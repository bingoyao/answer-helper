namespace AnswerHelper
{
    partial class LibManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.generateBtn = new System.Windows.Forms.Button();
            this.urlEditor = new System.Windows.Forms.TextBox();
            this.geberateFromFileBtn = new System.Windows.Forms.Button();
            this.selectImportFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.extractEditor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.hostText = new System.Windows.Forms.TextBox();
            this.portText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.databaseNameText = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(644, 271);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(93, 23);
            this.generateBtn.TabIndex = 0;
            this.generateBtn.Text = "在线收集";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateFromNetBtn_Click);
            // 
            // urlEditor
            // 
            this.urlEditor.Location = new System.Drawing.Point(52, 271);
            this.urlEditor.Name = "urlEditor";
            this.urlEditor.Size = new System.Drawing.Size(269, 21);
            this.urlEditor.TabIndex = 1;
            // 
            // geberateFromFileBtn
            // 
            this.geberateFromFileBtn.Location = new System.Drawing.Point(329, 307);
            this.geberateFromFileBtn.Name = "geberateFromFileBtn";
            this.geberateFromFileBtn.Size = new System.Drawing.Size(93, 23);
            this.geberateFromFileBtn.TabIndex = 2;
            this.geberateFromFileBtn.Text = "文件导入";
            this.geberateFromFileBtn.UseVisualStyleBackColor = true;
            this.geberateFromFileBtn.Click += new System.EventHandler(this.geberateFromFileBtn_Click);
            // 
            // extractEditor
            // 
            this.extractEditor.Location = new System.Drawing.Point(434, 271);
            this.extractEditor.Name = "extractEditor";
            this.extractEditor.Size = new System.Drawing.Size(204, 21);
            this.extractEditor.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "地址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "解析表达式：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(701, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "在线收集说明：地址为网页的url，解析表达式为合法的XPath表达式，用于从页面提取信息，使得提取后的每一行对应到一个题目。";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(413, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "文件导入说明：文件必须是纯文本文件，每一行对应一个题目（包含答案）。";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(8, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "数据导入：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(5, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "数据源管理：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "主机地址：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 12);
            this.label8.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(409, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = "端口：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 13;
            this.label10.Text = "数据库名：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 14;
            this.label11.Text = "用户名：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(409, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 15;
            this.label12.Text = "密码：";
            // 
            // hostText
            // 
            this.hostText.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AnswerHelper.Properties.Settings.Default, "Host", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.hostText.Location = new System.Drawing.Point(103, 25);
            this.hostText.Name = "hostText";
            this.hostText.Size = new System.Drawing.Size(218, 21);
            this.hostText.TabIndex = 16;
            this.hostText.Text = global::AnswerHelper.Properties.Settings.Default.Host;
            // 
            // portText
            // 
            this.portText.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AnswerHelper.Properties.Settings.Default, "Port", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.portText.Location = new System.Drawing.Point(456, 25);
            this.portText.Name = "portText";
            this.portText.Size = new System.Drawing.Size(218, 21);
            this.portText.TabIndex = 17;
            this.portText.Text = global::AnswerHelper.Properties.Settings.Default.Port;
            // 
            // passwordText
            // 
            this.passwordText.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AnswerHelper.Properties.Settings.Default, "Password", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.passwordText.Location = new System.Drawing.Point(456, 63);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(218, 21);
            this.passwordText.TabIndex = 18;
            this.passwordText.Text = global::AnswerHelper.Properties.Settings.Default.Password;
            // 
            // usernameText
            // 
            this.usernameText.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AnswerHelper.Properties.Settings.Default, "Username", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.usernameText.Location = new System.Drawing.Point(103, 63);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(218, 21);
            this.usernameText.TabIndex = 19;
            this.usernameText.Text = global::AnswerHelper.Properties.Settings.Default.Username;
            // 
            // databaseNameText
            // 
            this.databaseNameText.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AnswerHelper.Properties.Settings.Default, "DatabaseName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.databaseNameText.Location = new System.Drawing.Point(103, 100);
            this.databaseNameText.Name = "databaseNameText";
            this.databaseNameText.Size = new System.Drawing.Size(218, 21);
            this.databaseNameText.TabIndex = 20;
            this.databaseNameText.Text = global::AnswerHelper.Properties.Settings.Default.DatabaseName;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(8, 135);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 12);
            this.label13.TabIndex = 22;
            this.label13.Text = "百度AI客户端管理：";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AnswerHelper.Properties.Settings.Default, "BAIDU_SECRET_KEY", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox1.Location = new System.Drawing.Point(166, 225);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 21);
            this.textBox1.TabIndex = 28;
            this.textBox1.Text = global::AnswerHelper.Properties.Settings.Default.BAIDU_SECRET_KEY;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AnswerHelper.Properties.Settings.Default, "BAIDU_API_KEY", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox2.Location = new System.Drawing.Point(166, 188);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(218, 21);
            this.textBox2.TabIndex = 27;
            this.textBox2.Text = global::AnswerHelper.Properties.Settings.Default.BAIDU_API_KEY;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AnswerHelper.Properties.Settings.Default, "BAIDU_APP_ID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox3.Location = new System.Drawing.Point(166, 150);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(218, 21);
            this.textBox3.TabIndex = 26;
            this.textBox3.Text = global::AnswerHelper.Properties.Settings.Default.BAIDU_APP_ID;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(35, 191);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 12);
            this.label14.TabIndex = 25;
            this.label14.Text = "接口密钥（API_KEY）：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(35, 228);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(125, 12);
            this.label15.TabIndex = 24;
            this.label15.Text = "私钥（SECRET_KEY）：";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(35, 153);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(113, 12);
            this.label16.TabIndex = 23;
            this.label16.Text = "应用ID（APP_ID）：";
            // 
            // LibManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 461);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.databaseNameText);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.portText);
            this.Controls.Add(this.hostText);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.extractEditor);
            this.Controls.Add(this.geberateFromFileBtn);
            this.Controls.Add(this.urlEditor);
            this.Controls.Add(this.generateBtn);
            this.Name = "LibManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "题库管理";
            this.Load += new System.EventHandler(this.LibManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.TextBox urlEditor;
        private System.Windows.Forms.Button geberateFromFileBtn;
        private System.Windows.Forms.OpenFileDialog selectImportFileDialog;
        private System.Windows.Forms.TextBox extractEditor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox hostText;
        private System.Windows.Forms.TextBox portText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.TextBox databaseNameText;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}