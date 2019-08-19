using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Text.RegularExpressions;
using System.IO;

namespace AnswerHelper
{
    public partial class LibManagement : Form
    {
        private NpgsqlConnection connection = null;



        public LibManagement()
        {
            InitializeComponent();
        }

        private void LibManagement_Load(object sender, EventArgs e)
        {

        }
        public void initConnection(NpgsqlConnection conn)
        {
            connection = conn;
        }

        private void generateFromNetBtn_Click(object sender, EventArgs e)
        {
            String url = urlEditor.Text.Trim();
            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(url);

            Regex rgx = new Regex(@"^\d+\..+");

            var targetNodes = htmlDoc.DocumentNode.SelectNodes("//p");
            var targetSentences = targetNodes.SkipWhile(node =>
            {
                return !rgx.IsMatch(node.InnerHtml);
            }).Select(n => n.InnerHtml);
            foreach(var sen in targetSentences)
            {
                Console.WriteLine(sen);
            }

        }

        private void geberateFromFileBtn_Click(object sender, EventArgs e)
        {
            selectImportFileDialog.InitialDirectory = "c:\\";//注意这里写路径时要用c:\\而不是c:\
            selectImportFileDialog.RestoreDirectory = true;
            selectImportFileDialog.FilterIndex = 1;

            DialogResult result = selectImportFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fName = selectImportFileDialog.FileName;
                try
                {
                    connection.Open();
                    // 创建一个 StreamReader 的实例来读取文件 
                    // using 语句也能关闭 StreamReader
                    using (StreamReader sr = new StreamReader(fName))
                    using (var cmd = connection.CreateCommand())
                    using (var transaction = connection.BeginTransaction())
                    {
                        string line;                     
                        while ((line = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                            String sql = string.Format("insert into qiangguo (question, \"enrollTime\") values ('{0}', CURRENT_TIMESTAMP)", line.Trim());
                            cmd.CommandText = sql;
                            cmd.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                }
                catch (Exception ex)
                {
                    // 向用户显示出错消息
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
