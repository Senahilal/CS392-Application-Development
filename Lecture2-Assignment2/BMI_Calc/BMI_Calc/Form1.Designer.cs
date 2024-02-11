namespace BMI_Calc
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.lbl_feet = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_height = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(129, 168);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(149, 31);
            this.txt1.TabIndex = 0;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(129, 338);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(149, 31);
            this.txt3.TabIndex = 1;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(369, 168);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(149, 31);
            this.txt2.TabIndex = 2;
            // 
            // lbl_feet
            // 
            this.lbl_feet.AutoSize = true;
            this.lbl_feet.Location = new System.Drawing.Point(124, 128);
            this.lbl_feet.Name = "lbl_feet";
            this.lbl_feet.Size = new System.Drawing.Size(55, 25);
            this.lbl_feet.TabIndex = 3;
            this.lbl_feet.Text = "Feet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Inch";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "2. Weight";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pounds";
            // 
            // lbl_height
            // 
            this.lbl_height.AutoSize = true;
            this.lbl_height.Location = new System.Drawing.Point(124, 83);
            this.lbl_height.Name = "lbl_height";
            this.lbl_height.Size = new System.Drawing.Size(98, 25);
            this.lbl_height.TabIndex = 7;
            this.lbl_height.Text = "1. Height";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(380, 421);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(149, 31);
            this.txt4.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(618, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 40);
            this.button2.TabIndex = 10;
            this.button2.Text = "English";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(740, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 40);
            this.button3.TabIndex = 11;
            this.button3.Text = "Metric";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 534);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_height);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_feet);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label lbl_feet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_height;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

