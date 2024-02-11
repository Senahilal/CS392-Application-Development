namespace Prob3._10
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.boxOrange = new System.Windows.Forms.PictureBox();
            this.boxApple = new System.Windows.Forms.PictureBox();
            this.boxbanana = new System.Windows.Forms.PictureBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEx = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxOrange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxApple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxbanana)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Prob3._10.Properties.Resources.PearPrice;
            this.pictureBox1.Location = new System.Drawing.Point(83, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 189);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // boxOrange
            // 
            this.boxOrange.Image = global::Prob3._10.Properties.Resources.OrangePrice;
            this.boxOrange.Location = new System.Drawing.Point(258, 33);
            this.boxOrange.Name = "boxOrange";
            this.boxOrange.Size = new System.Drawing.Size(169, 190);
            this.boxOrange.TabIndex = 1;
            this.boxOrange.TabStop = false;
            this.boxOrange.Click += new System.EventHandler(this.boxOrange_Click);
            // 
            // boxApple
            // 
            this.boxApple.Image = global::Prob3._10.Properties.Resources.ApplePrice;
            this.boxApple.Location = new System.Drawing.Point(81, 229);
            this.boxApple.Name = "boxApple";
            this.boxApple.Size = new System.Drawing.Size(171, 189);
            this.boxApple.TabIndex = 2;
            this.boxApple.TabStop = false;
            this.boxApple.Click += new System.EventHandler(this.boxApple_Click);
            // 
            // boxbanana
            // 
            this.boxbanana.Image = global::Prob3._10.Properties.Resources.BananaPrice;
            this.boxbanana.Location = new System.Drawing.Point(258, 229);
            this.boxbanana.Name = "boxbanana";
            this.boxbanana.Size = new System.Drawing.Size(169, 189);
            this.boxbanana.TabIndex = 3;
            this.boxbanana.TabStop = false;
            this.boxbanana.Click += new System.EventHandler(this.boxbanana_Click);
            // 
            // lbl1
            // 
            this.lbl1.Location = new System.Drawing.Point(485, 65);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(100, 42);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "Total";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(485, 110);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 22);
            this.txt1.TabIndex = 5;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            this.txt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(500, 292);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnEx
            // 
            this.btnEx.Location = new System.Drawing.Point(500, 321);
            this.btnEx.Name = "btnEx";
            this.btnEx.Size = new System.Drawing.Size(75, 23);
            this.btnEx.TabIndex = 7;
            this.btnEx.Text = "Exit";
            this.btnEx.UseVisualStyleBackColor = true;
            this.btnEx.Click += new System.EventHandler(this.btnEx_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEx);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.boxbanana);
            this.Controls.Add(this.boxApple);
            this.Controls.Add(this.boxOrange);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxOrange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxApple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxbanana)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox boxOrange;
        private System.Windows.Forms.PictureBox boxApple;
        private System.Windows.Forms.PictureBox boxbanana;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnEx;
    }
}

