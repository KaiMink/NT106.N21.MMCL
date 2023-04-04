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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTo2_Click(object sender, EventArgs e)
        {
            bài_2 f = new bài_2();
            f.Show();
            this.Hide();
        }

        private void buttonread_Click(object sender, EventArgs e)
        {   //nếu muốn mở dialog
            /*OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();*/
            FileStream fs = new FileStream("input1.txt", FileMode.Open);
            StreamReader rd = new StreamReader(fs);
            string input = rd.ReadToEnd();
            richTextBox1.Text = input;
            rd.Close();
        }

        private void buttonwrite_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("output1.txt", FileMode.OpenOrCreate);
            StreamWriter wf = new StreamWriter(fs);
            string output;
            output = richTextBox1.Text;
            output = output.ToUpper();
            wf.WriteLine(output);
            wf.Close();
        }
    }
}
