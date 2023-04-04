using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.IO;
namespace lab02
{
    public partial class bai5 : Form
    {
        public bai5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string inputFile = @"D:\NĂM HAI\LTM\TH\21521123-HuynhDinhKhaiMinh\lab02\lab02\bin\Debug\input5.txt";
            string zipFile = @"D:\NĂM HAI\LTM\TH\21521123-HuynhDinhKhaiMinh\lab02\lab02\bin\Debug\output5.zip";
            using (FileStream inputStream = File.OpenRead(inputFile))
            {
                using (FileStream zipStream = File.Create(zipFile))
                {
                    using (var archive = new ZipArchive(zipStream, ZipArchiveMode.Create))
                    {
                        var entry = archive.CreateEntry(Path.GetFileName(inputFile), CompressionLevel.Optimal);
                        using (var entryStream = entry.Open())
                        {
                            inputStream.CopyTo(entryStream);
                        }
                    }
                }
            }

            // Giải nén tập tin
            string outputDirectory = @"D:\NĂM HAI\LTM\TH\21521123-HuynhDinhKhaiMinh\lab02\lab02\bin\Debug\output5.txt";
            string unzipFile = @"D:\NĂM HAI\LTM\TH\21521123-HuynhDinhKhaiMinh\lab02\lab02\bin\Debug\output5.zip";
            using (FileStream zipStream = File.OpenRead(unzipFile))
            {
                using (var archive = new ZipArchive(zipStream, ZipArchiveMode.Read))
                {
                    foreach (var entry in archive.Entries)
                    {
                        string outputFilePath = Path.Combine(Application.StartupPath, "output5.txt");
                        if (File.Exists(outputFilePath))
                        {
                            File.Delete(outputFilePath);
                        }
                        using (var entryStream = entry.Open())
                        {
                            using (var outputStream = File.Create(outputFilePath))
                            {
                                entryStream.CopyTo(outputStream);
                            }
                        }
                    }
                }
            }
            MessageBox.Show("Đã zip và unzip");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BAI6 f = new BAI6();
            f.Show();
            this.Hide();
        }
    }
}
