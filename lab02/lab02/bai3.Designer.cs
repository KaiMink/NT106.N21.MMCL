
namespace lab02
{
    partial class bai3
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
            this.buttRead = new System.Windows.Forms.Button();
            this.buttWrite = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttoCal = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttRead
            // 
            this.buttRead.Location = new System.Drawing.Point(75, 83);
            this.buttRead.Name = "buttRead";
            this.buttRead.Size = new System.Drawing.Size(80, 52);
            this.buttRead.TabIndex = 0;
            this.buttRead.Text = "Đọc File";
            this.buttRead.UseVisualStyleBackColor = true;
            this.buttRead.Click += new System.EventHandler(this.buttRead_Click);
            // 
            // buttWrite
            // 
            this.buttWrite.Location = new System.Drawing.Point(75, 262);
            this.buttWrite.Name = "buttWrite";
            this.buttWrite.Size = new System.Drawing.Size(80, 49);
            this.buttWrite.TabIndex = 1;
            this.buttWrite.Text = "Xuất File";
            this.buttWrite.UseVisualStyleBackColor = true;
            this.buttWrite.Click += new System.EventHandler(this.buttWrite_Click_1);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(185, 10);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(603, 414);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // buttoCal
            // 
            this.buttoCal.Location = new System.Drawing.Point(75, 174);
            this.buttoCal.Name = "buttoCal";
            this.buttoCal.Size = new System.Drawing.Size(80, 52);
            this.buttoCal.TabIndex = 3;
            this.buttoCal.Text = "Tính File";
            this.buttoCal.UseVisualStyleBackColor = true;
            this.buttoCal.Click += new System.EventHandler(this.buttoCal_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 82);
            this.button1.TabIndex = 4;
            this.button1.Text = "Bài 4";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttoCal);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttWrite);
            this.Controls.Add(this.buttRead);
            this.Name = "bai3";
            this.Text = "bai3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttRead;
        private System.Windows.Forms.Button buttWrite;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttoCal;
        private System.Windows.Forms.Button button1;
    }
}