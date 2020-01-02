using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Ionic.Zip;

namespace V_fileCompression
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            V_compressionRatio.SelectedIndex = 0; // по умолчанию без сжатия
            V_encodingFileNames.SelectedIndex = 0; // кодировка имен файлов
            V_passwordToTheArchive.Text = "iGyTwLmO7p"; // пароль для архива
            V_templateFilenames.Text = "data.bin"; // шаблон имен файлов

            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_pathToFiles_Click(object sender, EventArgs e)
        {
            //Путь к файлам, которые нужно архивировать
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                //textBox1.Text = folderDlg.SelectedPath;
                V_pathToFiles.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
        }

        private void button_folderWithTheResults_Click(object sender, EventArgs e)
        {
            //Путь к папке, куда сохранять файлы архива
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                //textBox1.Text = folderDlg.SelectedPath;
                V_folderWithTheResults.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
        }

        private void button_startArh_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            button_startArh.Enabled = false;

            //MessageBox.Show(selectedIndexEncodingFileNames.ToString() + selectedIndexCompressionRatio.ToString());

            if (backgroundWorker1.IsBusy != true)
            {
                // Start the asynchronous operation.
                backgroundWorker1.RunWorkerAsync();
            }
	
		
 
		
 
		
	


        }

        public void SaveProgress(object sender, SaveProgressEventArgs e)
        {
            if (e.EventType == ZipProgressEventType.Saving_Started)
            {
                //MessageBox.Show("Begin Saving: " + e.ArchiveName);
                this.Invoke((MethodInvoker)delegate()
                {
                PR_toolStripStatus.Text = "Начало архивации: " + e.ArchiveName;
                });
            }
            else if (e.EventType == ZipProgressEventType.Saving_BeforeWriteEntry)
            {
                this.Invoke((MethodInvoker)delegate()
                {
                    labelCompressionStatus.Text = "Статистика: " + e.CurrentEntry.FileName + " (" + (e.EntriesSaved + 1) + "/" + e.EntriesTotal + ")";
                    labelFilename.Text = "Текущий файл: " + e.CurrentEntry.FileName;

                    progressBar2.Maximum = e.EntriesTotal;
                    progressBar2.Value = e.EntriesSaved + 1;
                });

                
                //labelFilename.Text = "Filename:" + e.CurrentEntry.LocalFileName;
                
            }
            else if (e.EventType == ZipProgressEventType.Saving_EntryBytesRead)
            {
                this.Invoke((MethodInvoker)delegate()
                {
                progressBar1.Value = (int)((e.BytesTransferred * 100) / e.TotalBytesToTransfer);
                });
            }
            else if (e.EventType == ZipProgressEventType.Saving_Completed)
            {
                //MessageBox.Show("Done: " + e.ArchiveName);
                this.Invoke((MethodInvoker)delegate()
                {
                PR_toolStripStatus.Text = "Архив создан: " + e.ArchiveName;
                });
            }
        }

        string CommentArchive, PasswordToTheArchive, PathToFiles, FolderWithTheResults, EncodingFileNames, TemplateFilenames, CompressionRatio, SizeVolumes = "";
        int selectedIndexCompressionRatio, selectedIndexEncodingFileNames;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
            this.Invoke((MethodInvoker)delegate()
                {
            CommentArchive = V_commentArchive.Text; //комментарий к архиву
            PasswordToTheArchive = V_passwordToTheArchive.Text; //пароль к архиву
            PathToFiles = V_pathToFiles.Text;
            FolderWithTheResults = V_folderWithTheResults.Text; //путь к папке с архивами

            selectedIndexEncodingFileNames = V_encodingFileNames.SelectedIndex;
            Object selectedItemEncodingFileNames = V_encodingFileNames.SelectedItem;
            EncodingFileNames = selectedItemEncodingFileNames.ToString(); //кодировка имен файлов

            TemplateFilenames = V_templateFilenames.Text; //шаблон имен файлов


            selectedIndexCompressionRatio = V_compressionRatio.SelectedIndex;
            Object selectedItemCompressionRatio = V_compressionRatio.SelectedItem;
            CompressionRatio = selectedItemCompressionRatio.ToString(); //степень сжатия фалов

            SizeVolumes = V_sizeVolumes.Text; //размер томов
                });

            string encodingf = "utf-8";
            switch(selectedIndexEncodingFileNames)
            {
                case 0:
                    encodingf = "utf-8";
                    break;
                default:
                    encodingf = "utf-8";
                    break;
            }


            using (ZipFile zip = new ZipFile(Encoding.GetEncoding(encodingf)))
            {
                zip.Password = PasswordToTheArchive;

                switch(selectedIndexCompressionRatio)
                {
                    case 0:
                        zip.CompressionLevel = Ionic.Zlib.CompressionLevel.None;;
                        break;
                    case 1:
                        zip.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression;
                        break;
                    case 2:
                        zip.CompressionLevel = Ionic.Zlib.CompressionLevel.BestSpeed;
                        break;
                    case 3:
                        zip.CompressionLevel = Ionic.Zlib.CompressionLevel.Default;
                        break;
                    case 4:
                        zip.CompressionLevel = Ionic.Zlib.CompressionLevel.Level0;
                        break;
                    case 5:
                        zip.CompressionLevel = Ionic.Zlib.CompressionLevel.Level1;
                        break;
                    case 6:
                        zip.CompressionLevel = Ionic.Zlib.CompressionLevel.Level2;
                        break;
                    case 7:
                        zip.CompressionLevel = Ionic.Zlib.CompressionLevel.Level3;
                        break;
                    case 8:
                        zip.CompressionLevel = Ionic.Zlib.CompressionLevel.Level4;
                        break;
                    case 9:
                        zip.CompressionLevel = Ionic.Zlib.CompressionLevel.Level5;
                        break;
                    case 10:
                        zip.CompressionLevel = Ionic.Zlib.CompressionLevel.Level6;
                        break;
                    case 11:
                        zip.CompressionLevel = Ionic.Zlib.CompressionLevel.Level7;
                        break;
                    case 12:
                        zip.CompressionLevel = Ionic.Zlib.CompressionLevel.Level8;
                        break;
                    case 13:
                        zip.CompressionLevel = Ionic.Zlib.CompressionLevel.Level9;
                        break;
                    default:
                        zip.CompressionLevel = Ionic.Zlib.CompressionLevel.Default;
                        break;
                }


                //zip.CompressionLevel = Ionic.Zlib.CompressionLevel.BestSpeed;
                zip.SaveProgress += SaveProgress;

                zip.StatusMessageTextWriter = System.Console.Out;
                zip.AddDirectory(@PathToFiles); 
                //zip.AddSelectedFiles("*.*", @"C:\birja", true);
                //zip.Comment = "This zip was created at " + System.DateTime.Now.ToString("G");
                //zip.Comment = CommentArchive;
                zip.MaxOutputSegmentSize = Convert.ToInt32(SizeVolumes) * 1024 * 1024;   // 2mb
                zip.Save(FolderWithTheResults + "\\" + TemplateFilenames);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            button_startArh.Enabled = true;
        }

    }
}
