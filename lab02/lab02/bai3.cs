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
using System.Collections;
namespace lab02
{
    public partial class bai3 : Form
    {
        public bai3()
        {
            InitializeComponent();
        }

        private void buttRead_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("input3.txt", FileMode.Open);
            StreamReader rd = new StreamReader(fs);
            string input = rd.ReadToEnd();
            richTextBox1.Text = input;
            rd.Close();
        }
        private static bool HasHigherPrecedence(char op1, char op2)
        {
            if (op2 == '(' || op2 == ')')
                return false;
            if ((op1 == '*' || op1 == '/') && (op2 == '+' || op2 == '-'))
                return false;
            return true;
        }
        private static double ApplyOP(char op, double b, double a)
        {
            switch (op)
            {
                case '+': return a + b;
                case '-': return a - b;
                case '*': return a * b;
                case '/': return a / b;

            }

            return 0;
        }
        private static double CalculateExpression(string expression) 
        {
            char[] tokens = expression.ToCharArray();
            // Khởi tạo stack để lưu trữ các phép tính và số hạng
            Stack<double> values = new Stack<double>();
            Stack<char> ops = new Stack<char>();

            for(int i = 0; i < tokens.Length; i++)
            {
                if (tokens[i] == ' ')
                    continue;
                if (tokens[i] >= '0' && tokens[i] <= '9')
                {
                    StringBuilder sbuf = new StringBuilder();

                    while (i < tokens.Length && tokens[i] >= '0' && tokens[i] <= '9')
                    {
                        sbuf.Append(tokens[i++]);
                    }

                    values.Push(double.Parse(sbuf.ToString()));
                    i--;
                }
                else if (tokens[i] == '(')
                    ops.Push(tokens[i]);
                else if (tokens[i] == ')')
                {
                    while(ops.Peek() != '(')
                    {
                        values.Push(ApplyOP(ops.Pop(), values.Pop(), values.Pop()));
                    }
                    ops.Pop();
                }
                else if (tokens[i] == '+' || tokens[i] == '-' || tokens[i] == '*' || tokens[i] == '/')
                {
                    while(ops.Count > 0 && HasHigherPrecedence(tokens[i], ops.Peek()))
                    {
                        values.Push(ApplyOP(ops.Pop(), values.Pop(), values.Pop()));
                    }
                    ops.Push(tokens[i]);
                }

            }
            while(ops.Count > 0)
            {
                values.Push(ApplyOP(ops.Pop(), values.Pop(), values.Pop()));
            }

            return values.Pop();
        }

        private void buttoCal_Click(object sender, EventArgs e)
        {
            string input = richTextBox1.Text;
            richTextBox1.Clear();
            //split dòng
            string[] lines = input.Split(new string[] {"\n"}, StringSplitOptions.None);
            string x = "";
            foreach(string line in lines)
            {   
                x=line;
                x += " = " + Convert.ToString(CalculateExpression(line));
                richTextBox1.Text += x+ "\n";
            }
        }

        private void buttWrite_Click_1(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("output3.txt", FileMode.OpenOrCreate);
            StreamWriter wf = new StreamWriter(fs);
            string output;
            output = richTextBox1.Text;
            output = output.ToUpper();
            wf.WriteLine(output);
            wf.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bai4 f = new bai4();
            f.Show();
            this.Hide();
        }
    }
}
