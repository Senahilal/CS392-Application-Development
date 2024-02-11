namespace WindowsFormsApp1
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
            this.txtBefore = new System.Windows.Forms.TextBox();
            this.txtAfter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbFrom = new System.Windows.Forms.ListBox();
            this.lbTo = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a distance to convert:";
            // 
            // txtBefore
            // 
            this.txtBefore.Location = new System.Drawing.Point(443, 75);
            this.txtBefore.Name = "txtBefore";
            this.txtBefore.Size = new System.Drawing.Size(100, 31);
            this.txtBefore.TabIndex = 1;
            this.txtBefore.TextChanged += new System.EventHandler(this.txtBefore_TextChanged);
            // 
            // txtAfter
            // 
            this.txtAfter.Location = new System.Drawing.Point(443, 331);
            this.txtAfter.Name = "txtAfter";
            this.txtAfter.Size = new System.Drawing.Size(100, 31);
            this.txtAfter.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Result:";
            // 
            // lbFrom
            // 
            this.lbFrom.FormattingEnabled = true;
            this.lbFrom.ItemHeight = 24;
            this.lbFrom.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.lbFrom.Location = new System.Drawing.Point(106, 153);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(120, 76);
            this.lbFrom.TabIndex = 4;
            this.lbFrom.SelectedIndexChanged += new System.EventHandler(this.lbFrom_SelectedIndexChanged);
            // 
            // lbTo
            // 
            this.lbTo.FormattingEnabled = true;
            this.lbTo.ItemHeight = 24;
            this.lbTo.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.lbTo.Location = new System.Drawing.Point(381, 153);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(120, 76);
            this.lbTo.TabIndex = 5;
            this.lbTo.SelectedIndexChanged += new System.EventHandler(this.lbTo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "To";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(560, 153);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(155, 63);
            this.btn.TabIndex = 8;
            this.btn.Text = "Calculate";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTo);
            this.Controls.Add(this.lbFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAfter);
            this.Controls.Add(this.txtBefore);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBefore;
        private System.Windows.Forms.TextBox txtAfter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbFrom;
        private System.Windows.Forms.ListBox lbTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn;
    }
}

