namespace AnswerHelper
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.answerWithLibBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statusContent = new System.Windows.Forms.Label();
            this.libManageBtn = new System.Windows.Forms.Button();
            this.setAreaBtn = new System.Windows.Forms.Button();
            this.ctrlPanel = new System.Windows.Forms.Panel();
            this.guideLabel = new System.Windows.Forms.Label();
            this.answerWithNetBtn = new System.Windows.Forms.Button();
            this.resultsTable = new System.Windows.Forms.TableLayoutPanel();
            this.guide = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.nextResultPageBtn = new System.Windows.Forms.Button();
            this.autoAnswerBtn = new System.Windows.Forms.Button();
            this.preResultPageBtn = new System.Windows.Forms.Button();
            this.maskCurrentUrlBtn = new System.Windows.Forms.Button();
            this.ctrlPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // answerWithLibBtn
            // 
            this.answerWithLibBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.answerWithLibBtn.FlatAppearance.BorderSize = 0;
            this.answerWithLibBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.answerWithLibBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerWithLibBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.answerWithLibBtn.ForeColor = System.Drawing.Color.White;
            this.answerWithLibBtn.Location = new System.Drawing.Point(159, 14);
            this.answerWithLibBtn.Name = "answerWithLibBtn";
            this.answerWithLibBtn.Size = new System.Drawing.Size(90, 25);
            this.answerWithLibBtn.TabIndex = 1;
            this.answerWithLibBtn.Text = "题库辅助答题";
            this.answerWithLibBtn.UseVisualStyleBackColor = false;
            this.answerWithLibBtn.Click += new System.EventHandler(this.answerWithLibBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(34, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "状态：";
            // 
            // statusContent
            // 
            this.statusContent.AutoSize = true;
            this.statusContent.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusContent.Location = new System.Drawing.Point(76, 73);
            this.statusContent.MaximumSize = new System.Drawing.Size(500, 50);
            this.statusContent.Name = "statusContent";
            this.statusContent.Size = new System.Drawing.Size(80, 17);
            this.statusContent.TabIndex = 2;
            this.statusContent.Text = "等待用户操作";
            // 
            // libManageBtn
            // 
            this.libManageBtn.AutoSize = true;
            this.libManageBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.libManageBtn.FlatAppearance.BorderSize = 0;
            this.libManageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.libManageBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.libManageBtn.ForeColor = System.Drawing.Color.White;
            this.libManageBtn.Location = new System.Drawing.Point(533, 16);
            this.libManageBtn.Name = "libManageBtn";
            this.libManageBtn.Size = new System.Drawing.Size(90, 27);
            this.libManageBtn.TabIndex = 4;
            this.libManageBtn.Text = "题库管理";
            this.libManageBtn.UseVisualStyleBackColor = false;
            this.libManageBtn.Click += new System.EventHandler(this.libManageBtn_Click);
            // 
            // setAreaBtn
            // 
            this.setAreaBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.setAreaBtn.FlatAppearance.BorderSize = 0;
            this.setAreaBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.setAreaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setAreaBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.setAreaBtn.ForeColor = System.Drawing.Color.White;
            this.setAreaBtn.Location = new System.Drawing.Point(37, 14);
            this.setAreaBtn.Name = "setAreaBtn";
            this.setAreaBtn.Size = new System.Drawing.Size(90, 25);
            this.setAreaBtn.TabIndex = 0;
            this.setAreaBtn.Text = "设置截图区域";
            this.setAreaBtn.UseVisualStyleBackColor = false;
            this.setAreaBtn.Click += new System.EventHandler(this.setAreaBtn_Click);
            // 
            // ctrlPanel
            // 
            this.ctrlPanel.BackColor = System.Drawing.Color.White;
            this.ctrlPanel.Controls.Add(this.maskCurrentUrlBtn);
            this.ctrlPanel.Controls.Add(this.autoAnswerBtn);
            this.ctrlPanel.Controls.Add(this.guideLabel);
            this.ctrlPanel.Controls.Add(this.answerWithNetBtn);
            this.ctrlPanel.Controls.Add(this.setAreaBtn);
            this.ctrlPanel.Controls.Add(this.libManageBtn);
            this.ctrlPanel.Controls.Add(this.statusContent);
            this.ctrlPanel.Controls.Add(this.answerWithLibBtn);
            this.ctrlPanel.Controls.Add(this.label1);
            this.ctrlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctrlPanel.Location = new System.Drawing.Point(0, 0);
            this.ctrlPanel.Name = "ctrlPanel";
            this.ctrlPanel.Size = new System.Drawing.Size(684, 112);
            this.ctrlPanel.TabIndex = 6;
            // 
            // guideLabel
            // 
            this.guideLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guideLabel.AutoSize = true;
            this.guideLabel.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.guideLabel.Location = new System.Drawing.Point(655, 16);
            this.guideLabel.Name = "guideLabel";
            this.guideLabel.Size = new System.Drawing.Size(17, 16);
            this.guideLabel.TabIndex = 7;
            this.guideLabel.Text = "?";
            this.guide.SetToolTip(this.guideLabel, resources.GetString("guideLabel.ToolTip"));
            // 
            // answerWithNetBtn
            // 
            this.answerWithNetBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.answerWithNetBtn.FlatAppearance.BorderSize = 0;
            this.answerWithNetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerWithNetBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.answerWithNetBtn.ForeColor = System.Drawing.Color.White;
            this.answerWithNetBtn.Location = new System.Drawing.Point(282, 14);
            this.answerWithNetBtn.Name = "answerWithNetBtn";
            this.answerWithNetBtn.Size = new System.Drawing.Size(100, 25);
            this.answerWithNetBtn.TabIndex = 2;
            this.answerWithNetBtn.Text = "浏览器辅助答题";
            this.answerWithNetBtn.UseVisualStyleBackColor = false;
            this.answerWithNetBtn.Click += new System.EventHandler(this.answerWithNetBtn_Click);
            // 
            // resultsTable
            // 
            this.resultsTable.AutoSize = true;
            this.resultsTable.BackColor = System.Drawing.Color.White;
            this.resultsTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.resultsTable.ColumnCount = 3;
            this.resultsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.resultsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.resultsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.resultsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsTable.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.resultsTable.Location = new System.Drawing.Point(3, 3);
            this.resultsTable.Name = "resultsTable";
            this.resultsTable.RowCount = 1;
            this.resultsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 511F));
            this.resultsTable.Size = new System.Drawing.Size(670, 473);
            this.resultsTable.TabIndex = 7;
            // 
            // guide
            // 
            this.guide.AutoPopDelay = 10000;
            this.guide.InitialDelay = 500;
            this.guide.IsBalloon = true;
            this.guide.ReshowDelay = 100;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(0, 112);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(684, 509);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.resultsTable);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(676, 479);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "题库检索结果";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.nextResultPageBtn);
            this.tabPage2.Controls.Add(this.preResultPageBtn);
            this.tabPage2.Controls.Add(this.webBrowser1);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(676, 479);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "浏览器检索结果";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(670, 473);
            this.webBrowser1.TabIndex = 0;
            // 
            // nextResultPageBtn
            // 
            this.nextResultPageBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nextResultPageBtn.FlatAppearance.BorderSize = 0;
            this.nextResultPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextResultPageBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nextResultPageBtn.ForeColor = System.Drawing.Color.Black;
            this.nextResultPageBtn.Location = new System.Drawing.Point(628, 157);
            this.nextResultPageBtn.Name = "nextResultPageBtn";
            this.nextResultPageBtn.Size = new System.Drawing.Size(45, 119);
            this.nextResultPageBtn.TabIndex = 0;
            this.nextResultPageBtn.Text = ">";
            this.nextResultPageBtn.UseVisualStyleBackColor = true;
            this.nextResultPageBtn.Click += new System.EventHandler(this.nextResultPageBtn_Click);
            // 
            // autoAnswerBtn
            // 
            this.autoAnswerBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.autoAnswerBtn.FlatAppearance.BorderSize = 0;
            this.autoAnswerBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.autoAnswerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autoAnswerBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.autoAnswerBtn.ForeColor = System.Drawing.Color.White;
            this.autoAnswerBtn.Location = new System.Drawing.Point(408, 16);
            this.autoAnswerBtn.Name = "autoAnswerBtn";
            this.autoAnswerBtn.Size = new System.Drawing.Size(90, 25);
            this.autoAnswerBtn.TabIndex = 3;
            this.autoAnswerBtn.Text = "自动搜索";
            this.autoAnswerBtn.UseVisualStyleBackColor = false;
            this.autoAnswerBtn.Click += new System.EventHandler(this.autoAnswerBtn_Click);
            // 
            // preResultPageBtn
            // 
            this.preResultPageBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.preResultPageBtn.BackColor = System.Drawing.Color.Transparent;
            this.preResultPageBtn.FlatAppearance.BorderSize = 0;
            this.preResultPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.preResultPageBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.preResultPageBtn.ForeColor = System.Drawing.Color.Black;
            this.preResultPageBtn.Location = new System.Drawing.Point(0, 157);
            this.preResultPageBtn.Name = "preResultPageBtn";
            this.preResultPageBtn.Size = new System.Drawing.Size(43, 119);
            this.preResultPageBtn.TabIndex = 1;
            this.preResultPageBtn.Text = "<";
            this.preResultPageBtn.UseVisualStyleBackColor = false;
            this.preResultPageBtn.Click += new System.EventHandler(this.preResultPageBtn_Click);
            // 
            // maskCurrentUrlBtn
            // 
            this.maskCurrentUrlBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.maskCurrentUrlBtn.BackColor = System.Drawing.Color.Tomato;
            this.maskCurrentUrlBtn.FlatAppearance.BorderSize = 0;
            this.maskCurrentUrlBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maskCurrentUrlBtn.ForeColor = System.Drawing.Color.White;
            this.maskCurrentUrlBtn.Location = new System.Drawing.Point(581, 71);
            this.maskCurrentUrlBtn.Name = "maskCurrentUrlBtn";
            this.maskCurrentUrlBtn.Size = new System.Drawing.Size(91, 23);
            this.maskCurrentUrlBtn.TabIndex = 8;
            this.maskCurrentUrlBtn.Text = "屏蔽当前网站";
            this.maskCurrentUrlBtn.UseVisualStyleBackColor = false;
            this.maskCurrentUrlBtn.Click += new System.EventHandler(this.maskCurrentUrlBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 621);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ctrlPanel);
            this.Name = "Main";
            this.Text = "答题助手";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.ctrlPanel.ResumeLayout(false);
            this.ctrlPanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button answerWithLibBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label statusContent;
        private System.Windows.Forms.Button libManageBtn;
        private System.Windows.Forms.Button setAreaBtn;
        private System.Windows.Forms.Panel ctrlPanel;
        private System.Windows.Forms.TableLayoutPanel resultsTable;
        private System.Windows.Forms.Button answerWithNetBtn;
        private System.Windows.Forms.Label guideLabel;
        private System.Windows.Forms.ToolTip guide;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button nextResultPageBtn;
        private System.Windows.Forms.Button autoAnswerBtn;
        private System.Windows.Forms.Button preResultPageBtn;
        private System.Windows.Forms.Button maskCurrentUrlBtn;
    }
}

