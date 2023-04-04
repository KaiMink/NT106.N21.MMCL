
namespace lab02
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
            this.buttonread = new System.Windows.Forms.Button();
            this.buttonwrite = new System.Windows.Forms.Button();
            this.buttonTo2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonread
            // 
            this.buttonread.Location = new System.Drawing.Point(74, 45);
            this.buttonread.Name = "buttonread";
            this.buttonread.Size = new System.Drawing.Size(104, 96);
            this.buttonread.TabIndex = 0;
            this.buttonread.Text = "Đọc file";
            this.buttonread.UseVisualStyleBackColor = true;
            this.buttonread.Click += new System.EventHandler(this.buttonread_Click);
            // 
            // buttonwrite
            // 
            this.buttonwrite.Location = new System.Drawing.Point(74, 193);
            this.buttonwrite.Name = "buttonwrite";
            this.buttonwrite.Size = new System.Drawing.Size(104, 82);
            this.buttonwrite.TabIndex = 1;
            this.buttonwrite.Text = "Ghi file";
            this.buttonwrite.UseVisualStyleBackColor = true;
            this.buttonwrite.Click += new System.EventHandler(this.buttonwrite_Click);
            // 
            // buttonTo2
            // 
            this.buttonTo2.Location = new System.Drawing.Point(74, 340);
            this.buttonTo2.Name = "buttonTo2";
            this.buttonTo2.Size = new System.Drawing.Size(104, 82);
            this.buttonTo2.TabIndex = 2;
            this.buttonTo2.Text = "Câu 2";
            this.buttonTo2.UseVisualStyleBackColor = true;
            this.buttonTo2.Click += new System.EventHandler(this.buttonTo2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(256, 45);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(532, 377);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonTo2);
            this.Controls.Add(this.buttonwrite);
            this.Controls.Add(this.buttonread);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonread;
        private System.Windows.Forms.Button buttonwrite;
        private System.Windows.Forms.Button buttonTo2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

