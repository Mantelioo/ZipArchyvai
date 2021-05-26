using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Papidomos bibliotekos
using System.IO.Compression;
using System.IO;
using SevenZip; //NuGet paketas
using System.Threading;


namespace ZipArchyvai
{
    public partial class Form1 : Form
    {
        //ZIP kintamieji
        string arhivePath, source, destination;
        string extractSource, extractDestination;

        public Form1()
        {
            InitializeComponent();
        }
        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            LstContents.Items.Clear();

            var ofd = new OpenFileDialog()
            {
                Title = "Select archive",
                Filter = "Zip archive|*.zip",
                Multiselect = false,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
            };

            DialogResult result = ofd.ShowDialog();

            if (result == DialogResult.OK)
            {
                TxtPath.Text = ofd.FileName;
                arhivePath = ofd.FileName;
                ShowArchive(ofd.FileName); //pasiziurim archivo turini
            }
            else
            {
                LstContents.Items.Add("No archive selected");
                TxtPath.Text = string.Empty;
            }
        }
        private void ExtractZipToFolder_Click(object sender, EventArgs e)
        {
            //1 pasirenkam .zip archiva
            var ofd = new OpenFileDialog()
            {
                Title = "Select archive",
                Filter = "Zip archive|*.zip",
                Multiselect = false,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
            };

            DialogResult result = ofd.ShowDialog();

            if (result == DialogResult.OK) //reikai nurodyti i koki kataloga isarchivuot turini
            {
                extractSource = ofd.FileName; //source

                //2 Reikia pasirinkti folderi
                FolderBrowserDialog fbd = new FolderBrowserDialog()
                {
                    Description = "Select folder to extract archive",
                    ShowNewFolderButton = true,
                    RootFolder = Environment.SpecialFolder.Desktop,
                };

                DialogResult folderResult = fbd.ShowDialog(); //destination

                if (folderResult == DialogResult.OK)
                {
                    extractDestination = fbd.SelectedPath;
                    ZipFile.ExtractToDirectory(extractSource, extractDestination);
                }
            }
            else
            {
                LstContents.Items.Add("No archive selected");
                TxtPath.Text = string.Empty;
            }

        }
        private void Create7z_Click(object sender, EventArgs e) // is katalogo susikuriam archyva
        {
            LstContents.Items.Clear();

            //1 Reikia pasirinkti folderi
            FolderBrowserDialog fbd = new FolderBrowserDialog()
            {
                Description = "Select folder for archiving",
                ShowNewFolderButton = false,
                RootFolder = Environment.SpecialFolder.Desktop,
            };

            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK)
            {
                source = fbd.SelectedPath; //pasirenkama kataloga

                // 2 Reikia parinkti vieta archyvui saugoti
                SaveFileDialog sfd = new SaveFileDialog()
                {
                    Title = "Select where to save archive",
                    Filter = "Zip file|*.zip"
                };

                DialogResult safeFileResult = sfd.ShowDialog();
                if (safeFileResult == DialogResult.OK)
                {
                    //Cia naudosim 7zip
                    destination = sfd.FileName;
                    SevenZipCompressor.SetLibraryPath(Application.StartupPath + @"\7z.dll");
                    SevenZipCompressor sevenZcomppr = new SevenZipCompressor();
                    sevenZcomppr.CompressDirectory(source, destination);
                }
                else
                {
                    LstContents.Items.Add("No location selected");
                    TxtPath.Text = string.Empty;
                }
            }
            else
            {
                LstContents.Items.Add("No folder selected");
                TxtPath.Text = string.Empty;
            }
        }
        private void Extract7z_Click(object sender, EventArgs e)
        {
            //1 pasirenkam .zip archiva
            var ofd = new OpenFileDialog()
            {
                Title = "Select archive",
                Filter = "Zip archive|*.zip",
                Multiselect = false,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
            };

            DialogResult result = ofd.ShowDialog();

            if (result == DialogResult.OK) //reikai nurodyti i koki kataloga isarchivuot turini
            {
                extractSource = ofd.FileName; //source

                //2 Reikia pasirinkti folderi
                FolderBrowserDialog fbd = new FolderBrowserDialog()
                {
                    Description = "Select folder to extract archive",
                    ShowNewFolderButton = true,
                    RootFolder = Environment.SpecialFolder.Desktop,
                };

                DialogResult folderResult = fbd.ShowDialog(); //destination

                if (folderResult == DialogResult.OK)
                {
                    extractDestination = fbd.SelectedPath;
                    
                    SevenZipExtractor.SetLibraryPath(Application.StartupPath + @"\7z.dll");
                    SevenZipExtractor sevenZ = new SevenZipExtractor(extractSource);

                    //SevenZ veikia kaip bacground workeris
                    sevenZ.Extracting += SevenZ_Extracting;
                    sevenZ.ExtractionFinished += SevenZ_ExtractionFinished;
                    sevenZ.FileExists += SevenZ_FileExists;

                    sevenZ.ExtractArchive(extractDestination); //kur sukelti archivo failiukus
                }
            }
            else
            {
                LstContents.Items.Add("No archive selected");
                TxtPath.Text = string.Empty;
            }
        }
        private void SevenZ_FileExists(object sender, FileOverwriteEventArgs e)
        {
         
        }
        private void SevenZ_ExtractionFinished(object sender, EventArgs e)
        {
            MessageBox.Show("Finished");
            progressBar1.Value = 0;
        }
        private void SevenZ_Extracting(object sender, ProgressEventArgs e)
        {
            progressBar1.Value = e.PercentDone; //kiek procentu atlikta
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Labai fainas kodas");
        }

        private void ShowArchive(string path)//Funkcija kuri gauna .zip archivo turini.
        {
            try
            {
                ZipArchive zip = ZipFile.OpenRead(path); // jei cia nulus
                foreach (var item in zip.Entries)
                {
                    LstContents.Items.Add(item.FullName);
                }
            }
            catch (Exception ex) // cia parodys error
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnZipFromFolder_Click(object sender, EventArgs e)
        {
            LstContents.Items.Clear();

            //1 Reikia pasirinkti folderi
            FolderBrowserDialog fbd = new FolderBrowserDialog()
            {
                Description = "Select folder for archiving",
                ShowNewFolderButton = false,
                RootFolder = Environment.SpecialFolder.Desktop,
            };

            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK)
            {
                source = fbd.SelectedPath; //pasirenkama kataloga

                // 2 Reikia parinkti vieta archyvui saugoti
                SaveFileDialog sfd = new SaveFileDialog()
                {
                    Title = "Select where to save archive",
                    Filter = "Zip file|*.zip"
                };

               DialogResult safeFileResult = sfd.ShowDialog();
                if (safeFileResult == DialogResult.OK)
                {
                    destination = sfd.FileName; //Kur saugosim archyva

                    //Archyvo generavimas gali uztrukti. Naudojam thread
                    Thread th = new Thread(StartZip);
                    th.Start();
                }
                else
                {
                    LstContents.Items.Add("No location selected");
                    TxtPath.Text = string.Empty;
                }
            }
            else
            {
                LstContents.Items.Add("No folder selected");
                TxtPath.Text = string.Empty;
            }

        }
        private void StartZip()
        {
            //Parenkami archyvavimo parametrai
            ZipFile.CreateFromDirectory(source, destination, System.IO.Compression.CompressionLevel.Optimal, false);
            MessageBox.Show("Completed");
        }
    }
}
