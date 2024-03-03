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
            this.calculate_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.gender_input = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.height_input = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.weight_input = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bmi_output = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.height_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weight_input)).BeginInit();
            this.SuspendLayout();
            // 
            // calculate_button
            // 
            this.calculate_button.Location = new System.Drawing.Point(42, 146);
            this.calculate_button.Margin = new System.Windows.Forms.Padding(2);
            this.calculate_button.Name = "calculate_button";
            this.calculate_button.Size = new System.Drawing.Size(74, 23);
            this.calculate_button.TabIndex = 8;
            this.calculate_button.Text = "Calculate";
            this.calculate_button.UseVisualStyleBackColor = true;
            this.calculate_button.Click += new System.EventHandler(this.cacluate_click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 220);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 16;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(74, 194);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(117, 23);
            this.save_button.TabIndex = 17;
            this.save_button.Text = "Save to DB";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_click);
            // 
            // gender_input
            // 
            this.gender_input.FormattingEnabled = true;
            this.gender_input.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender_input.Location = new System.Drawing.Point(114, 102);
            this.gender_input.Margin = new System.Windows.Forms.Padding(2);
            this.gender_input.Name = "gender_input";
            this.gender_input.Size = new System.Drawing.Size(77, 21);
            this.gender_input.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Gender:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Height:";
            // 
            // height_input
            // 
            this.height_input.Location = new System.Drawing.Point(114, 69);
            this.height_input.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.height_input.Name = "height_input";
            this.height_input.Size = new System.Drawing.Size(77, 20);
            this.height_input.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Weight:";
            // 
            // weight_input
            // 
            this.weight_input.Location = new System.Drawing.Point(114, 37);
            this.weight_input.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.weight_input.Name = "weight_input";
            this.weight_input.Size = new System.Drawing.Size(77, 20);
            this.weight_input.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Pounds";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Inches";
            // 
            // bmi_output
            // 
            this.bmi_output.Location = new System.Drawing.Point(139, 149);
            this.bmi_output.Name = "bmi_output";
            this.bmi_output.ReadOnly = true;
            this.bmi_output.Size = new System.Drawing.Size(100, 20);
            this.bmi_output.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(154, 133);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Enhanced BMI:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 262);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bmi_output);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.weight_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.height_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gender_input);
            this.Controls.Add(this.calculate_button);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.height_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weight_input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button calculate_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.ComboBox gender_input;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown height_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown weight_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bmi_output;
        private System.Windows.Forms.Label label7;
    }
}

