namespace V_fileCompression
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
            this.V_commentArchive = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.V_passwordToTheArchive = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_pathToFiles = new System.Windows.Forms.Button();
            this.V_pathToFiles = new System.Windows.Forms.TextBox();
            this.button_folderWithTheResults = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.V_folderWithTheResults = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.V_compressionRatio = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.V_sizeVolumes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.V_templateFilenames = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.V_encodingFileNames = new System.Windows.Forms.ComboBox();
            this.button_startArh = new System.Windows.Forms.Button();
            this.labelCompressionStatus = new System.Windows.Forms.Label();
            this.labelFilename = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.PR_toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // V_commentArchive
            // 
            this.V_commentArchive.Enabled = false;
            this.V_commentArchive.Location = new System.Drawing.Point(134, 19);
            this.V_commentArchive.Name = "V_commentArchive";
            this.V_commentArchive.Size = new System.Drawing.Size(608, 20);
            this.V_commentArchive.TabIndex = 0;
            this.V_commentArchive.Text = "(Название+Р.Г.:Путь к exe файлу, относительно папки (test\\test.exe)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Комментарий архива:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль к архиву:";
            // 
            // V_passwordToTheArchive
            // 
            this.V_passwordToTheArchive.Location = new System.Drawing.Point(134, 42);
            this.V_passwordToTheArchive.Name = "V_passwordToTheArchive";
            this.V_passwordToTheArchive.Size = new System.Drawing.Size(608, 20);
            this.V_passwordToTheArchive.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Папка с файлами:";
            // 
            // button_pathToFiles
            // 
            this.button_pathToFiles.Location = new System.Drawing.Point(134, 66);
            this.button_pathToFiles.Name = "button_pathToFiles";
            this.button_pathToFiles.Size = new System.Drawing.Size(75, 23);
            this.button_pathToFiles.TabIndex = 5;
            this.button_pathToFiles.Text = "...";
            this.button_pathToFiles.UseVisualStyleBackColor = true;
            this.button_pathToFiles.Click += new System.EventHandler(this.button_pathToFiles_Click);
            // 
            // V_pathToFiles
            // 
            this.V_pathToFiles.Location = new System.Drawing.Point(215, 64);
            this.V_pathToFiles.Name = "V_pathToFiles";
            this.V_pathToFiles.Size = new System.Drawing.Size(527, 20);
            this.V_pathToFiles.TabIndex = 6;
            // 
            // button_folderWithTheResults
            // 
            this.button_folderWithTheResults.Location = new System.Drawing.Point(134, 95);
            this.button_folderWithTheResults.Name = "button_folderWithTheResults";
            this.button_folderWithTheResults.Size = new System.Drawing.Size(75, 23);
            this.button_folderWithTheResults.TabIndex = 7;
            this.button_folderWithTheResults.Text = "...";
            this.button_folderWithTheResults.UseVisualStyleBackColor = true;
            this.button_folderWithTheResults.Click += new System.EventHandler(this.button_folderWithTheResults_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Папка с результатом:";
            // 
            // V_folderWithTheResults
            // 
            this.V_folderWithTheResults.Location = new System.Drawing.Point(215, 93);
            this.V_folderWithTheResults.Name = "V_folderWithTheResults";
            this.V_folderWithTheResults.Size = new System.Drawing.Size(527, 20);
            this.V_folderWithTheResults.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Степень сжатия:";
            // 
            // V_compressionRatio
            // 
            this.V_compressionRatio.FormattingEnabled = true;
            this.V_compressionRatio.Items.AddRange(new object[] {
            "None",
            "Best Compression",
            "Best Speed",
            "Default",
            "Level 0",
            "Level 1",
            "Level 2",
            "Level 3",
            "Level 4",
            "Level 5",
            "Level 6",
            "Level 7",
            "Level 8",
            "Level 9"});
            this.V_compressionRatio.Location = new System.Drawing.Point(110, 174);
            this.V_compressionRatio.Name = "V_compressionRatio";
            this.V_compressionRatio.Size = new System.Drawing.Size(121, 21);
            this.V_compressionRatio.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Размер томов:";
            // 
            // V_sizeVolumes
            // 
            this.V_sizeVolumes.Location = new System.Drawing.Point(110, 200);
            this.V_sizeVolumes.Name = "V_sizeVolumes";
            this.V_sizeVolumes.Size = new System.Drawing.Size(121, 20);
            this.V_sizeVolumes.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(238, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "mb";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Шаблон имен файлов:";
            // 
            // V_templateFilenames
            // 
            this.V_templateFilenames.Location = new System.Drawing.Point(136, 150);
            this.V_templateFilenames.Name = "V_templateFilenames";
            this.V_templateFilenames.Size = new System.Drawing.Size(606, 20);
            this.V_templateFilenames.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Кодировка имен файлов:";
            // 
            // V_encodingFileNames
            // 
            this.V_encodingFileNames.FormattingEnabled = true;
            this.V_encodingFileNames.Items.AddRange(new object[] {
            "utf-8"});
            this.V_encodingFileNames.Location = new System.Drawing.Point(151, 124);
            this.V_encodingFileNames.Name = "V_encodingFileNames";
            this.V_encodingFileNames.Size = new System.Drawing.Size(121, 21);
            this.V_encodingFileNames.TabIndex = 20;
            // 
            // button_startArh
            // 
            this.button_startArh.Location = new System.Drawing.Point(12, 409);
            this.button_startArh.Name = "button_startArh";
            this.button_startArh.Size = new System.Drawing.Size(203, 40);
            this.button_startArh.TabIndex = 21;
            this.button_startArh.Text = "Архивировать";
            this.button_startArh.UseVisualStyleBackColor = true;
            this.button_startArh.Click += new System.EventHandler(this.button_startArh_Click);
            // 
            // labelCompressionStatus
            // 
            this.labelCompressionStatus.AutoSize = true;
            this.labelCompressionStatus.Location = new System.Drawing.Point(10, 47);
            this.labelCompressionStatus.Name = "labelCompressionStatus";
            this.labelCompressionStatus.Size = new System.Drawing.Size(68, 13);
            this.labelCompressionStatus.TabIndex = 22;
            this.labelCompressionStatus.Text = "Статистика:";
            // 
            // labelFilename
            // 
            this.labelFilename.AutoSize = true;
            this.labelFilename.Location = new System.Drawing.Point(10, 25);
            this.labelFilename.Name = "labelFilename";
            this.labelFilename.Size = new System.Drawing.Size(84, 13);
            this.labelFilename.TabIndex = 23;
            this.labelFilename.Text = "Текущий файл:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 73);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(729, 23);
            this.progressBar1.TabIndex = 24;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(13, 102);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(729, 23);
            this.progressBar2.TabIndex = 25;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PR_toolStripStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 460);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 26;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // PR_toolStripStatus
            // 
            this.PR_toolStripStatus.Name = "PR_toolStripStatus";
            this.PR_toolStripStatus.Size = new System.Drawing.Size(16, 17);
            this.PR_toolStripStatus.Text = "...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.V_commentArchive);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.V_passwordToTheArchive);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button_pathToFiles);
            this.groupBox1.Controls.Add(this.V_pathToFiles);
            this.groupBox1.Controls.Add(this.V_encodingFileNames);
            this.groupBox1.Controls.Add(this.button_folderWithTheResults);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.V_templateFilenames);
            this.groupBox1.Controls.Add(this.V_folderWithTheResults);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.V_compressionRatio);
            this.groupBox1.Controls.Add(this.V_sizeVolumes);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 233);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.fileToolStripMenuItem.Text = "About";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelFilename);
            this.groupBox2.Controls.Add(this.labelCompressionStatus);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.progressBar2);
            this.groupBox2.Location = new System.Drawing.Point(12, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(758, 137);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Статистика";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 482);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button_startArh);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "File Compression";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox V_commentArchive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox V_passwordToTheArchive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_pathToFiles;
        private System.Windows.Forms.TextBox V_pathToFiles;
        private System.Windows.Forms.Button button_folderWithTheResults;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox V_folderWithTheResults;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox V_compressionRatio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox V_sizeVolumes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox V_templateFilenames;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox V_encodingFileNames;
        private System.Windows.Forms.Button button_startArh;
        private System.Windows.Forms.Label labelCompressionStatus;
        private System.Windows.Forms.Label labelFilename;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel PR_toolStripStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

