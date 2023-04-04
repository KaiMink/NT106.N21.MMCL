
namespace lab02
{
    partial class bài_2
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
            this.buttonread = new System.Windows.Forms.Button();
            this.in4group = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textchar = new System.Windows.Forms.TextBox();
            this.textword = new System.Windows.Forms.TextBox();
            this.textline = new System.Windows.Forms.TextBox();
            this.texturl = new System.Windows.Forms.TextBox();
            this.textSize = new System.Windows.Forms.TextBox();
            this.textfilename = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.in4group.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonread
            // 
            this.buttonread.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonread.Location = new System.Drawing.Point(6, 21);
            this.buttonread.Name = "buttonread";
            this.buttonread.Size = new System.Drawing.Size(441, 25);
            this.buttonread.TabIndex = 0;
            this.buttonread.Text = "Read From File";
            this.buttonread.UseVisualStyleBackColor = true;
            this.buttonread.Click += new System.EventHandler(this.buttonread_Click);
            // 
            // in4group
            // 
            this.in4group.Controls.Add(this.button1);
            this.in4group.Controls.Add(this.textchar);
            this.in4group.Controls.Add(this.textword);
            this.in4group.Controls.Add(this.textline);
            this.in4group.Controls.Add(this.texturl);
            this.in4group.Controls.Add(this.textSize);
            this.in4group.Controls.Add(this.textfilename);
            this.in4group.Controls.Add(this.label6);
            this.in4group.Controls.Add(this.label5);
            this.in4group.Controls.Add(this.label4);
            this.in4group.Controls.Add(this.label3);
            this.in4group.Controls.Add(this.label2);
            this.in4group.Controls.Add(this.label1);
            this.in4group.Controls.Add(this.buttonread);
            this.in4group.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.in4group.Location = new System.Drawing.Point(5, 6);
            this.in4group.Name = "in4group";
            this.in4group.Size = new System.Drawing.Size(453, 590);
            this.in4group.TabIndex = 1;
            this.in4group.TabStop = false;
            this.in4group.Text = "Thông tin";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LawnGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(7, 503);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(440, 81);
            this.button1.TabIndex = 13;
            this.button1.Text = "Bài 3";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textchar
            // 
            this.textchar.Location = new System.Drawing.Point(158, 463);
            this.textchar.Name = "textchar";
            this.textchar.Size = new System.Drawing.Size(289, 22);
            this.textchar.TabIndex = 12;
            // 
            // textword
            // 
            this.textword.Location = new System.Drawing.Point(158, 387);
            this.textword.Name = "textword";
            this.textword.Size = new System.Drawing.Size(289, 22);
            this.textword.TabIndex = 11;
            // 
            // textline
            // 
            this.textline.Location = new System.Drawing.Point(158, 307);
            this.textline.Name = "textline";
            this.textline.Size = new System.Drawing.Size(289, 22);
            this.textline.TabIndex = 10;
            // 
            // texturl
            // 
            this.texturl.Location = new System.Drawing.Point(158, 229);
            this.texturl.Name = "texturl";
            this.texturl.Size = new System.Drawing.Size(289, 22);
            this.texturl.TabIndex = 9;
            // 
            // textSize
            // 
            this.textSize.Location = new System.Drawing.Point(158, 153);
            this.textSize.Name = "textSize";
            this.textSize.Size = new System.Drawing.Size(289, 22);
            this.textSize.TabIndex = 8;
            // 
            // textfilename
            // 
            this.textfilename.Location = new System.Drawing.Point(158, 73);
            this.textfilename.Name = "textfilename";
            this.textfilename.Size = new System.Drawing.Size(289, 22);
            this.textfilename.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 463);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Character Count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Words Count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Line Count";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "File Name";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(476, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(838, 584);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // bài_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1326, 608);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.in4group);
            this.Name = "bài_2";
            this.Text = "bài_2";
            this.in4group.ResumeLayout(false);
            this.in4group.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonread;
        private System.Windows.Forms.GroupBox in4group;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textchar;
        private System.Windows.Forms.TextBox textword;
        private System.Windows.Forms.TextBox textline;
        private System.Windows.Forms.TextBox texturl;
        private System.Windows.Forms.TextBox textSize;
        private System.Windows.Forms.TextBox textfilename;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}