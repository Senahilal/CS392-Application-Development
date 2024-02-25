namespace Prob7._10
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
            slot1 = new PictureBox();
            slot2 = new PictureBox();
            slot3 = new PictureBox();
            label1 = new Label();
            userInput = new TextBox();
            spinButton = new Button();
            exitButton = new Button();
            alert = new Label();
            ((System.ComponentModel.ISupportInitialize)slot1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)slot2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)slot3).BeginInit();
            SuspendLayout();
            // 
            // slot1
            // 
            slot1.BorderStyle = BorderStyle.Fixed3D;
            slot1.Location = new Point(12, 12);
            slot1.Name = "slot1";
            slot1.Size = new Size(127, 129);
            slot1.TabIndex = 0;
            slot1.TabStop = false;
            // 
            // slot2
            // 
            slot2.BorderStyle = BorderStyle.Fixed3D;
            slot2.Location = new Point(145, 12);
            slot2.Name = "slot2";
            slot2.Size = new Size(127, 129);
            slot2.TabIndex = 1;
            slot2.TabStop = false;
            // 
            // slot3
            // 
            slot3.BorderStyle = BorderStyle.Fixed3D;
            slot3.Location = new Point(278, 12);
            slot3.Name = "slot3";
            slot3.Size = new Size(127, 129);
            slot3.TabIndex = 2;
            slot3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 185);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 3;
            label1.Text = "Amount Inserted: $";
            // 
            // userInput
            // 
            userInput.Location = new Point(204, 182);
            userInput.Name = "userInput";
            userInput.Size = new Size(100, 23);
            userInput.TabIndex = 4;
            // 
            // spinButton
            // 
            spinButton.Location = new Point(123, 228);
            spinButton.Name = "spinButton";
            spinButton.Size = new Size(75, 23);
            spinButton.TabIndex = 5;
            spinButton.Text = "Spin";
            spinButton.UseVisualStyleBackColor = true;
            spinButton.Click += spinButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(214, 228);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 6;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // alert
            // 
            alert.AutoSize = true;
            alert.Location = new Point(167, 154);
            alert.Name = "alert";
            alert.Size = new Size(80, 15);
            alert.TabIndex = 7;
            alert.Text = "Alerts go here";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 260);
            Controls.Add(alert);
            Controls.Add(exitButton);
            Controls.Add(spinButton);
            Controls.Add(userInput);
            Controls.Add(label1);
            Controls.Add(slot3);
            Controls.Add(slot2);
            Controls.Add(slot1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)slot1).EndInit();
            ((System.ComponentModel.ISupportInitialize)slot2).EndInit();
            ((System.ComponentModel.ISupportInitialize)slot3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox slot1;
        private PictureBox slot2;
        private PictureBox slot3;
        private Label label1;
        private TextBox userInput;
        private Button spinButton;
        private Button exitButton;
        private Label alert;
    }
}
