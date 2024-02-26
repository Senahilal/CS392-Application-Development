namespace _09_Rock_Paper_Scissors
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
            groupBox1 = new GroupBox();
            RadioButton3 = new RadioButton();
            RadioButton2 = new RadioButton();
            RadioButton1 = new RadioButton();
            Button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            computerChoiceLabel = new Label();
            playerChoiceLabel = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RadioButton3);
            groupBox1.Controls.Add(RadioButton2);
            groupBox1.Controls.Add(RadioButton1);
            groupBox1.Location = new Point(12, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(466, 112);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Make Your Choice";
            // 
            // RadioButton3
            // 
            RadioButton3.AutoSize = true;
            RadioButton3.Location = new Point(27, 79);
            RadioButton3.Name = "RadioButton3";
            RadioButton3.Size = new Size(66, 19);
            RadioButton3.TabIndex = 2;
            RadioButton3.TabStop = true;
            RadioButton3.Text = "Scissors";
            RadioButton3.UseVisualStyleBackColor = true;
            // 
            // RadioButton2
            // 
            RadioButton2.AutoSize = true;
            RadioButton2.Location = new Point(27, 54);
            RadioButton2.Name = "RadioButton2";
            RadioButton2.Size = new Size(55, 19);
            RadioButton2.TabIndex = 1;
            RadioButton2.TabStop = true;
            RadioButton2.Text = "Paper";
            RadioButton2.UseVisualStyleBackColor = true;
            // 
            // RadioButton1
            // 
            RadioButton1.AutoSize = true;
            RadioButton1.Location = new Point(27, 29);
            RadioButton1.Name = "RadioButton1";
            RadioButton1.Size = new Size(51, 19);
            RadioButton1.TabIndex = 0;
            RadioButton1.TabStop = true;
            RadioButton1.Text = "Rock";
            RadioButton1.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            Button1.Location = new Point(223, 332);
            Button1.Name = "Button1";
            Button1.Size = new Size(75, 23);
            Button1.TabIndex = 3;
            Button1.Text = "Play";
            Button1.UseVisualStyleBackColor = true;
            Button1.Click += playButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 207);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 4;
            label1.Text = "You chose:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 234);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 5;
            label2.Text = "Computer chose:";
            // 
            // computerChoiceLabel
            // 
            computerChoiceLabel.BorderStyle = BorderStyle.FixedSingle;
            computerChoiceLabel.Location = new Point(198, 232);
            computerChoiceLabel.Name = "computerChoiceLabel";
            computerChoiceLabel.Size = new Size(100, 23);
            computerChoiceLabel.TabIndex = 6;
            computerChoiceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // playerChoiceLabel
            // 
            playerChoiceLabel.BorderStyle = BorderStyle.FixedSingle;
            playerChoiceLabel.Location = new Point(198, 203);
            playerChoiceLabel.Name = "playerChoiceLabel";
            playerChoiceLabel.Size = new Size(100, 23);
            playerChoiceLabel.TabIndex = 7;
            playerChoiceLabel.TextAlign = ContentAlignment.MiddleCenter;
            playerChoiceLabel.Click += playerChoiceLabel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 452);
            Controls.Add(playerChoiceLabel);
            Controls.Add(computerChoiceLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Button1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Rock Paper Scissors";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton RadioButton3;
        private RadioButton RadioButton2;
        private RadioButton RadioButton1;
        private Button Button1;
        private Label label1;
        private Label label2;
        private Label computerChoiceLabel;
        private Label playerChoiceLabel;
    }
}