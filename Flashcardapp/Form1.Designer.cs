namespace Flashcardapp
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
            this.num_top = new System.Windows.Forms.Label();
            this.num_bottom = new System.Windows.Forms.Label();
            this.num_operator = new System.Windows.Forms.Label();
            this.user_input = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.progress_bar = new System.Windows.Forms.ProgressBar();
            this.add_sub = new System.Windows.Forms.ComboBox();
            this.toast = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // num_top
            // 
            this.num_top.AutoSize = true;
            this.num_top.BackColor = System.Drawing.SystemColors.ControlLight;
            this.num_top.Font = new System.Drawing.Font("Microsoft Sans Serif", 75F);
            this.num_top.Location = new System.Drawing.Point(329, 120);
            this.num_top.Name = "num_top";
            this.num_top.Size = new System.Drawing.Size(206, 226);
            this.num_top.TabIndex = 0;
            this.num_top.Text = "0";
            // 
            // num_bottom
            // 
            this.num_bottom.AutoSize = true;
            this.num_bottom.BackColor = System.Drawing.SystemColors.ControlLight;
            this.num_bottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 75F);
            this.num_bottom.Location = new System.Drawing.Point(329, 387);
            this.num_bottom.Name = "num_bottom";
            this.num_bottom.Size = new System.Drawing.Size(206, 226);
            this.num_bottom.TabIndex = 1;
            this.num_bottom.Text = "0";
            // 
            // num_operator
            // 
            this.num_operator.AutoSize = true;
            this.num_operator.BackColor = System.Drawing.SystemColors.ControlLight;
            this.num_operator.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.num_operator.Location = new System.Drawing.Point(155, 310);
            this.num_operator.Name = "num_operator";
            this.num_operator.Size = new System.Drawing.Size(143, 153);
            this.num_operator.TabIndex = 2;
            this.num_operator.Text = "+";
            // 
            // user_input
            // 
            this.user_input.Location = new System.Drawing.Point(322, 693);
            this.user_input.Name = "user_input";
            this.user_input.Size = new System.Drawing.Size(243, 31);
            this.user_input.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(349, 650);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Your Answer:";
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(367, 744);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(145, 102);
            this.submit.TabIndex = 5;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // progress_bar
            // 
            this.progress_bar.Location = new System.Drawing.Point(-7, 12);
            this.progress_bar.Name = "progress_bar";
            this.progress_bar.Size = new System.Drawing.Size(863, 47);
            this.progress_bar.TabIndex = 6;
            // 
            // add_sub
            // 
            this.add_sub.FormattingEnabled = true;
            this.add_sub.Items.AddRange(new object[] {
            "Addition",
            "Subtraction"});
            this.add_sub.Location = new System.Drawing.Point(596, 916);
            this.add_sub.Name = "add_sub";
            this.add_sub.Size = new System.Drawing.Size(243, 33);
            this.add_sub.TabIndex = 7;
            this.add_sub.SelectedIndexChanged += new System.EventHandler(this.add_sub_dropdown_change);
            // 
            // toast
            // 
            this.toast.AutoSize = true;
            this.toast.Location = new System.Drawing.Point(12, 916);
            this.toast.Name = "toast";
            this.toast.Size = new System.Drawing.Size(82, 25);
            this.toast.TabIndex = 8;
            this.toast.Text = "Correct";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(648, 879);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Problem type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 1044);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toast);
            this.Controls.Add(this.add_sub);
            this.Controls.Add(this.progress_bar);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.user_input);
            this.Controls.Add(this.num_top);
            this.Controls.Add(this.num_operator);
            this.Controls.Add(this.num_bottom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label num_top;
        private System.Windows.Forms.Label num_bottom;
        private System.Windows.Forms.Label num_operator;
        private System.Windows.Forms.TextBox user_input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.ProgressBar progress_bar;
        private System.Windows.Forms.ComboBox add_sub;
        private System.Windows.Forms.Label toast;
        private System.Windows.Forms.Label label1;
    }
}

