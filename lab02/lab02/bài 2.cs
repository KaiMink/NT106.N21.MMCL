using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace lab02
{
    public partial class bài_2 : Form
    {
        public bài_2()
        {
            InitializeComponent();
        }

        private void buttonread_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.SafeFileName.ToString(), FileMode.Open);
            StreamReader rd = new StreamReader(fs);
            
            textfilename.Text = ofd.SafeFileName.ToString();
            texturl.Text = fs.Name.ToString();
            

            FileInfo fi = new FileInfo(texturl.Text);
            textSize.Text = fi.Length.ToString();

            string input = "";
            int lineCount = 0,  charcount = 0;

            string line;
            while ((line = rd.ReadLine()) != null)
            {
                input = input + line + "\n";
                lineCount++;
            }
            string[] words = input.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            charcount = input.Length;


            textline.Text = lineCount.ToString();
            richTextBox1.Text = input;
            textword.Text = words.Length.ToString();
            textchar.Text = charcount.ToString();
            rd.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bai3 f = new bai3();
            f.Show();
            this.Hide();
        }
    }
}
