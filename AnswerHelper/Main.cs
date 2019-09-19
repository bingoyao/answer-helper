using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using AnswerHelper.Properties;

namespace AnswerHelper
{
    public partial class Main : Form
    {
        /// <summary>
        /// 百度AI文字识别客户端
        /// </summary>
        Baidu.Aip.Ocr.Ocr client = null;
        /// <summary>
        /// 本地题库连接
        /// </summary>
        NpgsqlConnection connection = null;
        /// <summary>
        /// 题库管理面板
        /// </summary>
        LibManagement managePanel = new LibManagement();
        /// <summary>
        /// 自动截图的截图位置和大小
        /// </summary>
        public Rectangle CatchRectangle;
        /// <summary>
        /// 保存浏览器搜索结果的url
        /// </summary>
        List<string> netResultUrls = new List<string>();
        int currentPageNum = 0;
        /// <summary>
        /// 用户屏蔽的主机名
        /// </summary>
        private HashSet<string> maskedHosts = new HashSet<string>();

        /// <summary>
        /// 初始化百度AI客户端
        /// </summary>
        public void initAIClient()
        {
            
            client = new Baidu.Aip.Ocr.Ocr(Settings.Default.BAIDU_API_KEY, Settings.Default.BAIDU_SECRET_KEY);
            client.Timeout = 10000;
        }

        /// <summary>
        /// 初始化题库数据库连接
        /// </summary>
        private void initQuestionLib()
        {
            string dbPath = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};",
                                            Settings.Default.Host,
                                            Settings.Default.Port,
                                            Settings.Default.Username,
                                            Settings.Default.Password,
                                            Settings.Default.DatabaseName
                                            );
            connection = new NpgsqlConnection(dbPath);
        }

        /// <summary>
        /// 初始化截屏区域
        /// </summary>
        public void initCatchRectangle()
        {

        }

        public Main()
        {
            InitializeComponent();
            initAIClient();
            initQuestionLib();
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        /// <summary>
        /// 将查询结果显示到表格
        /// </summary>
        /// <param name="results"></param>
        /// <param name="table"></param>
        private void putResultsToTable(List<Dictionary<String, String>> results,TableLayoutPanel table)
        {
            table.Controls.Clear();
            if (results == null || results.Count == 0 || table == null)
            {
                table.RowCount = 1;
                Label tip = new Label();
                tip.AutoSize = true;
                tip.Text = "未找到相关提示";
                tip.ForeColor = Color.Red;
                table.Controls.Add(tip, 0, 0);
                table.Refresh();
                return;
            }
            
            //设置表格默认样式
            // 表头 + 数据
            table.RowCount = results.Count + 1;
            table.Height = table.RowCount * 40;
            
            Label questionLabel = new Label();
            Label similarityLabel = new Label();
            Label enrollTimeLabel = new Label();
            questionLabel.Text = "题目描述";
            similarityLabel.Text = "题目相似度";
            enrollTimeLabel.Text = "加入时间";
            questionLabel.Anchor = AnchorStyles.Left;
            questionLabel.AutoSize = true;
            similarityLabel.Anchor = AnchorStyles.Left;
            similarityLabel.AutoSize = true;
            enrollTimeLabel.Anchor = AnchorStyles.Left;
            enrollTimeLabel.AutoSize = true;
            table.Controls.Add(questionLabel, 0, 0);
            table.Controls.Add(similarityLabel, 1, 0);
            table.Controls.Add(enrollTimeLabel, 2, 0);

            table.RowStyles.Clear();
            for(int i = 0; i < table.RowCount; i++)
            {
                table.RowStyles.Add(new RowStyle(System.Windows.Forms.SizeType.Absolute, 80));
            }

            for (int i=0;i<results.Count;i++)
            {
                Label question = new Label();
                question.Text = results[i]["question"];
                question.Anchor = AnchorStyles.Left;
                question.AutoSize = true;
                table.Controls.Add(question,0,i+1);
                Label similarity = new Label();
                similarity.Text = results[i]["similarity"];
                similarity.Anchor = AnchorStyles.Left;
                similarity.AutoSize = true;
                table.Controls.Add(similarity, 1, i + 1);
                Label enrollTime = new Label();
                enrollTime.Text = results[i]["enrollTime"];
                enrollTime.Anchor = AnchorStyles.Left;
                enrollTime.AutoSize = true;
                table.Controls.Add(enrollTime, 2, i + 1);
            }
            table.Refresh();
            showMessage("已完成，共找到" + results.Count + "条结果");
        }
        
        /// <summary>
        /// 检索题库中相似题目
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns></returns>
        private List<Dictionary<String,String>> queryLib(String keyword)
        {
            showMessage("正在从本地题库检索相似题目");
            List<Dictionary<String, String>> results = new List<Dictionary<String, String>>();
            try
            {
                connection.Open();
                NpgsqlCommand command = connection.CreateCommand();
                command.CommandText = String.Format("select question, similarity(question,'{0}') as sml,\"enrollTime\" from qiangguo where question % '{1}' order by sml DESC;", keyword, keyword);
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Dictionary<String, String> item = new Dictionary<String, String>();
                    item.Add("question", reader.GetString(0));
                    item.Add("similarity", reader.GetFloat(1).ToString());
                    item.Add("enrollTime", reader.GetTimeStamp(2).ToDateTime().ToString());
                    results.Add(item);
                }
            }
            catch (PostgresException ex)
            {
                Console.WriteLine(ex.MessageText);
            }
            finally
            {
                connection.Close();
            }
            
            return results;
        }
        
        /// <summary>
        /// 管理本地题库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void libManageBtn_Click(object sender, EventArgs e)
        {
            if (managePanel.IsDisposed)
            {
                managePanel = new LibManagement();
            }
            managePanel.initConnection(connection);
            managePanel.BringToFront();
            managePanel.Show();
        }

        /// <summary>
        /// 设置自动截屏的屏幕区域
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void setAreaBtn_Click(object sender, EventArgs e)
        {
            // 新建一个和屏幕大小相同的图片
            Bitmap CatchBmp = new Bitmap(Screen.AllScreens[0].Bounds.Width, Screen.AllScreens[0].Bounds.Height);

            // 创建一个画板，让我们可以在画板上画图
            // 这个画板也就是和屏幕大小一样大的图片
            // 我们可以通过Graphics这个类在这个空白图片上画图
            Graphics g = Graphics.FromImage(CatchBmp);

            // 把屏幕图片拷贝到我们创建的空白图片 CatchBmp中
            g.CopyFromScreen(new Point(0, 0), new Point(0, 0), new Size(Screen.AllScreens[0].Bounds.Width, Screen.AllScreens[0].Bounds.Height));

            // 创建截图窗体
            Cutter cutter = new Cutter();

            // 指示窗体的背景图片为屏幕图片
            cutter.BackgroundImage = CatchBmp;

            cutter.originBmp = CatchBmp;
            cutter.parent = this;
            cutter.Show();
        }

        /// <summary>
        /// 使用本地题库辅助答题
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void answerWithLibBtn_Click(object sender, EventArgs e)
        {
            clearRequest();
            tabControl1.SelectedIndex = 0;
            answerWithLib(extractImg(getImgFromClipboard()));

        }

        private bool answerWithLib(String query)
        {
            List<Dictionary<String, String>> queryResult = queryLib(query);
            if (queryResult.Count > 0)
            {
                putResultsToTable(queryResult, resultsTable);
                return true;
            }
            else
            {
                showMessage("本地题库无相关题目");
                return false;
            }
            
        }
        
        /// <summary>
        /// 通过搜索引擎搜索，提取结果页面url保存至netResultUrls
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        private bool answerWithNet(String query)
        {
            HtmlWeb web = new HtmlWeb();
            web.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/75.0.3770.100 Safari/537.36";
            
            HtmlAgilityPack.HtmlDocument doc = web.Load("https://www.baidu.com/s?wd=" + query);
            Console.WriteLine(doc == null);
            HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes("//div/h3/a");
            if (nodes == null)
            {
                showMessage("解析文档出错，可能是页面结构与Xpath解析路径不一致");
                return false;
            }
            netResultUrls.Clear();
            currentPageNum = 0;
            foreach(var node in nodes)
            {
                string url = node.Attributes["href"].Value;
                string host = new Uri(url).Host;
                Console.WriteLine("$$ " + host);
                foreach(var h in maskedHosts)
                {
                    Console.WriteLine("## " + h);
                }
                if (!maskedHosts.Contains(host))
                {
                    netResultUrls.Add(url);
                }
            }
            webBrowser1.Navigate(netResultUrls[currentPageNum]);
            tabControl1.SelectedIndex = 1;
            return true;
        }
        /// <summary>
        /// 使用网络辅助答题
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void answerWithNetBtn_Click(object sender, EventArgs e)
        {
            clearRequest();

            answerWithNet(extractImg(getImgFromClipboard()));
        }

        /// <summary>
        /// 自动搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void autoAnswerBtn_Click(object sender, EventArgs e)
        {
            clearRequest();

            String query = extractImg(getImgFromClipboard());
            tabControl1.SelectedIndex = 0;
            if (!answerWithLib(query))
            {
                showMessage("本地题库无结果，正在尝试使用网络搜索...");
                tabControl1.SelectedIndex = 1;
                answerWithNet(query);
            };
        }

        /// <summary>
        /// 从剪切板获得指定位置的截图
        /// </summary>
        /// <returns></returns>
        private Bitmap getImgFromClipboard()
        {
            showMessage("正在从剪切板获得图片");
            // 新建一个和屏幕大小相同的图片
            Bitmap ScreenBmp = new Bitmap(Screen.AllScreens[0].Bounds.Width, Screen.AllScreens[0].Bounds.Height);

            // 创建一个画板，让我们可以在画板上画图
            // 这个画板也就是和屏幕大小一样大的图片
            // 我们可以通过Graphics这个类在这个空白图片上画图
            Graphics g = Graphics.FromImage(ScreenBmp);

            // 把屏幕图片拷贝到我们创建的空白图片 CatchBmp中
            g.CopyFromScreen(new Point(0, 0), new Point(0, 0), new Size(Screen.AllScreens[0].Bounds.Width, Screen.AllScreens[0].Bounds.Height));

            // 新建一个与矩形一样大小的空白图片
            Bitmap CatchedBmp = new Bitmap(CatchRectangle.Width, CatchRectangle.Height);

            Graphics cg = Graphics.FromImage(CatchedBmp);

            // 把originBmp中指定部分按照指定大小画到空白图片上
            // CatchRectangle指定originBmp中指定部分
            // 第二个参数指定绘制到空白图片的位置和大小
            // 画完后CatchedBmp不再是空白图片了，而是具有与截取的图片一样的内容
            cg.DrawImage(ScreenBmp, new Rectangle(0, 0, CatchRectangle.Width, CatchRectangle.Height), CatchRectangle, GraphicsUnit.Pixel);

            g.Dispose();
            cg.Dispose();

            return CatchedBmp;
        }

        /// <summary>
        /// 使用百度AI识别图片文字
        /// </summary>
        /// <param name="img"></param>
        /// <returns></returns>
        private String extractImg(Bitmap img)
        {
            showMessage("正在提取图片中的文字");
            byte[] bytes = (byte[])TypeDescriptor.GetConverter(img).ConvertTo(img, typeof(byte[]));
            var options = new Dictionary<string, object>{
                {"language_type", "CHN_ENG"},
                {"detect_direction", "true"},
                {"detect_language", "true"},
                {"probability", "true"}
            };
            // 带参数调用通用文字识别, 图片参数为本地图片
            var result = client.GeneralBasic(bytes, options);
            Console.WriteLine("识别结果："+Environment.NewLine+result);

            int wordsCount = (int)result.SelectToken("words_result_num");
            var wordsResult = result.SelectToken("words_result").ToList();
            String text = "";
            wordsResult.ForEach(wordResult =>
            {
                String word = (String)wordResult.SelectToken("words");
                text += word;
            });
            //Console.WriteLine("文字提取结果：" + text);
            showMessage("成功提取到文字：" + text);
            return text;
        }

        private void nextResultPageBtn_Click(object sender, EventArgs e)
        {
            clearRequest();
            if (netResultUrls==null||currentPageNum>=netResultUrls.Count-1)
            {
                showMessage("没有结果了:(");
            }else
            {
                webBrowser1.Navigate(netResultUrls[++currentPageNum]);
            }
        }

        private void preResultPageBtn_Click(object sender, EventArgs e)
        {
            clearRequest();
            if (netResultUrls == null || currentPageNum <= 0)
            {
                showMessage("没有结果了:(");
            }
            else
            {
                webBrowser1.Navigate(netResultUrls[--currentPageNum]);
            }
        }

        private void showMessage(String msg)
        {
            statusContent.Text = msg;
        }

        private void maskCurrentUrlBtn_Click(object sender, EventArgs e)
        {
            
                maskUrl(webBrowser1.Url.Host);
                showMessage("已屏蔽" + webBrowser1.Url.Host+"的内容");
        }

        /// <summary>
        /// 屏蔽指定网站
        /// </summary>
        /// <param name="url"></param>
        private void maskUrl(String host)
        {
            maskedHosts.Add(host);
        }

        /// <summary>
        /// 退出程序前，保存必要的数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void clearRequest()
        {
            if (webBrowser1.IsBusy)
            {
                webBrowser1.Stop();
            }
        }
    }
}
