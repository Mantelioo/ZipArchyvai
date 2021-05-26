namespace ZipArchyvai
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPath = new System.Windows.Forms.TextBox();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LstContents = new System.Windows.Forms.ListBox();
            this.BtnZipFromFolder = new System.Windows.Forms.Button();
            this.ExtractZipToFolder = new System.Windows.Forms.Button();
            this.Extract7z = new System.Windows.Forms.Button();
            this.Create7z = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Archive";
            // 
            // TxtPath
            // 
            this.TxtPath.Location = new System.Drawing.Point(133, 11);
            this.TxtPath.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPath.Name = "TxtPath";
            this.TxtPath.ReadOnly = true;
            this.TxtPath.Size = new System.Drawing.Size(325, 22);
            this.TxtPath.TabIndex = 11;
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Location = new System.Drawing.Point(481, 11);
            this.BtnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(100, 33);
            this.BtnBrowse.TabIndex = 12;
            this.BtnBrowse.Text = "...";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Archive contents";
            // 
            // LstContents
            // 
            this.LstContents.FormattingEnabled = true;
            this.LstContents.ItemHeight = 16;
            this.LstContents.Location = new System.Drawing.Point(24, 81);
            this.LstContents.Margin = new System.Windows.Forms.Padding(4);
            this.LstContents.Name = "LstContents";
            this.LstContents.Size = new System.Drawing.Size(675, 484);
            this.LstContents.TabIndex = 14;
            // 
            // BtnZipFromFolder
            // 
            this.BtnZipFromFolder.Location = new System.Drawing.Point(24, 579);
            this.BtnZipFromFolder.Margin = new System.Windows.Forms.Padding(4);
            this.BtnZipFromFolder.Name = "BtnZipFromFolder";
            this.BtnZipFromFolder.Size = new System.Drawing.Size(140, 44);
            this.BtnZipFromFolder.TabIndex = 15;
            this.BtnZipFromFolder.Text = "Create zip from folder";
            this.BtnZipFromFolder.UseVisualStyleBackColor = true;
            this.BtnZipFromFolder.Click += new System.EventHandler(this.BtnZipFromFolder_Click);
            // 
            // ExtractZipToFolder
            // 
            this.ExtractZipToFolder.Location = new System.Drawing.Point(172, 579);
            this.ExtractZipToFolder.Margin = new System.Windows.Forms.Padding(4);
            this.ExtractZipToFolder.Name = "ExtractZipToFolder";
            this.ExtractZipToFolder.Size = new System.Drawing.Size(140, 44);
            this.ExtractZipToFolder.TabIndex = 16;
            this.ExtractZipToFolder.Text = "Extract zip to folder";
            this.ExtractZipToFolder.UseVisualStyleBackColor = true;
            this.ExtractZipToFolder.Click += new System.EventHandler(this.ExtractZipToFolder_Click);
            // 
            // Extract7z
            // 
            this.Extract7z.Location = new System.Drawing.Point(560, 579);
            this.Extract7z.Margin = new System.Windows.Forms.Padding(4);
            this.Extract7z.Name = "Extract7z";
            this.Extract7z.Size = new System.Drawing.Size(140, 44);
            this.Extract7z.TabIndex = 17;
            this.Extract7z.Text = "Extract zip to folder 7zip";
            this.Extract7z.UseVisualStyleBackColor = true;
            this.Extract7z.Click += new System.EventHandler(this.Extract7z_Click);
            // 
            // Create7z
            // 
            this.Create7z.Location = new System.Drawing.Point(412, 579);
            this.Create7z.Margin = new System.Windows.Forms.Padding(4);
            this.Create7z.Name = "Create7z";
            this.Create7z.Size = new System.Drawing.Size(140, 44);
            this.Create7z.TabIndex = 18;
            this.Create7z.Text = "Create zip from folder";
            this.Create7z.UseVisualStyleBackColor = true;
            this.Create7z.Click += new System.EventHandler(this.Create7z_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(24, 630);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(676, 46);
            this.progressBar1.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 728);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(616, 81);
            this.button1.TabIndex = 20;
            this.button1.Text = "Demoi mygtukas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 855);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Create7z);
            this.Controls.Add(this.Extract7z);
            this.Controls.Add(this.ExtractZipToFolder);
            this.Controls.Add(this.BtnZipFromFolder);
            this.Controls.Add(this.LstContents);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnBrowse);
            this.Controls.Add(this.TxtPath);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPath;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LstContents;
        private System.Windows.Forms.Button BtnZipFromFolder;
        private System.Windows.Forms.Button ExtractZipToFolder;
        private System.Windows.Forms.Button Extract7z;
        private System.Windows.Forms.Button Create7z;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
    }
}

