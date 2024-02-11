namespace Roman
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtN = new TextBox();
            txtR = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 61);
            label1.Name = "label1";
            label1.Size = new Size(106, 32);
            label1.TabIndex = 0;
            label1.Text = "Numeral";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 214);
            label2.Name = "label2";
            label2.Size = new Size(188, 32);
            label2.TabIndex = 1;
            label2.Text = "Roman Numeral";
            // 
            // txtN
            // 
            txtN.Location = new Point(124, 133);
            txtN.Name = "txtN";
            txtN.Size = new Size(200, 39);
            txtN.TabIndex = 2;
            txtN.TextChanged += txtN_TextChanged;
            // 
            // txtR
            // 
            txtR.Location = new Point(124, 281);
            txtR.Name = "txtR";
            txtR.Size = new Size(200, 39);
            txtR.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtR);
            Controls.Add(txtN);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtN;
        private TextBox txtR;
    }
}
