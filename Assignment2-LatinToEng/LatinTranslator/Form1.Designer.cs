namespace LatinTranslator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEng2 = new System.Windows.Forms.TextBox();
            this.txtEng3 = new System.Windows.Forms.TextBox();
            this.labelLatin1 = new System.Windows.Forms.Label();
            this.labelLatin2 = new System.Windows.Forms.Label();
            this.labelLatin3 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "English";
            this.label1.UseMnemonic = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "English";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtEng2
            // 
            this.txtEng2.Location = new System.Drawing.Point(349, 214);
            this.txtEng2.Name = "txtEng2";
            this.txtEng2.Size = new System.Drawing.Size(100, 22);
            this.txtEng2.TabIndex = 6;
            this.txtEng2.TextChanged += new System.EventHandler(this.txtEng2_TextChanged);
            // 
            // txtEng3
            // 
            this.txtEng3.Location = new System.Drawing.Point(349, 269);
            this.txtEng3.Name = "txtEng3";
            this.txtEng3.Size = new System.Drawing.Size(100, 22);
            this.txtEng3.TabIndex = 7;
            this.txtEng3.TextChanged += new System.EventHandler(this.txtEng3_TextChanged);
            // 
            // labelLatin1
            // 
            this.labelLatin1.AutoSize = true;
            this.labelLatin1.Location = new System.Drawing.Point(188, 167);
            this.labelLatin1.Name = "labelLatin1";
            this.labelLatin1.Size = new System.Drawing.Size(44, 16);
            this.labelLatin1.TabIndex = 8;
            this.labelLatin1.Text = "autem";
            this.labelLatin1.Click += new System.EventHandler(this.labelLatin1_Click);
            // 
            // labelLatin2
            // 
            this.labelLatin2.AutoSize = true;
            this.labelLatin2.Location = new System.Drawing.Point(180, 220);
            this.labelLatin2.Name = "labelLatin2";
            this.labelLatin2.Size = new System.Drawing.Size(66, 16);
            this.labelLatin2.TabIndex = 9;
            this.labelLatin2.Text = "descendit";
            this.labelLatin2.Click += new System.EventHandler(this.labelLatin2_Click);
            // 
            // labelLatin3
            // 
            this.labelLatin3.AutoSize = true;
            this.labelLatin3.Location = new System.Drawing.Point(184, 272);
            this.labelLatin3.Name = "labelLatin3";
            this.labelLatin3.Size = new System.Drawing.Size(55, 16);
            this.labelLatin3.TabIndex = 10;
            this.labelLatin3.Text = "medium";
            this.labelLatin3.Click += new System.EventHandler(this.labelLatin3_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(535, 160);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(104, 23);
            this.btn1.TabIndex = 11;
            this.btn1.Text = "Translate";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(535, 213);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(104, 23);
            this.btn2.TabIndex = 12;
            this.btn2.Text = "Translate";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(535, 267);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(104, 23);
            this.btn3.TabIndex = 13;
            this.btn3.Text = "Translate";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(349, 164);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.labelLatin3);
            this.Controls.Add(this.labelLatin2);
            this.Controls.Add(this.labelLatin1);
            this.Controls.Add(this.txtEng3);
            this.Controls.Add(this.txtEng2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEng2;
        private System.Windows.Forms.TextBox txtEng3;
        private System.Windows.Forms.Label labelLatin1;
        private System.Windows.Forms.Label labelLatin2;
        private System.Windows.Forms.Label labelLatin3;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

