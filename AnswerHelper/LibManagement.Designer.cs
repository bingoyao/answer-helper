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
            this.SuspendLayout();
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(12, 12);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(93, 23);
            this.generateBtn.TabIndex = 0;
            this.generateBtn.Text = "从该页面收集";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateFromNetBtn_Click);
            // 
            // urlEditor
            // 
            this.urlEditor.Location = new System.Drawing.Point(121, 14);
            this.urlEditor.Name = "urlEditor";
            this.urlEditor.Size = new System.Drawing.Size(382, 21);
            this.urlEditor.TabIndex = 1;
            // 
            // geberateFromFileBtn
            // 
            this.geberateFromFileBtn.Location = new System.Drawing.Point(12, 51);
            this.geberateFromFileBtn.Name = "geberateFromFileBtn";
            this.geberateFromFileBtn.Size = new System.Drawing.Size(75, 23);
            this.geberateFromFileBtn.TabIndex = 2;
            this.geberateFromFileBtn.Text = "从文件导入";
            this.geberateFromFileBtn.UseVisualStyleBackColor = true;
            this.geberateFromFileBtn.Click += new System.EventHandler(this.geberateFromFileBtn_Click);
            // 
            // LibManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 461);
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
    }
}