namespace Prob3._14
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblTicketA = new System.Windows.Forms.Label();
            this.lblTicketB = new System.Windows.Forms.Label();
            this.lblTicketC = new System.Windows.Forms.Label();
            this.lblTicketsSold = new System.Windows.Forms.Label();
            this.lblRev = new System.Windows.Forms.Label();
            this.lblRevA = new System.Windows.Forms.Label();
            this.lblRevB = new System.Windows.Forms.Label();
            this.lblRevC = new System.Windows.Forms.Label();
            this.lblRevTotal = new System.Windows.Forms.Label();
            this.txtTA = new System.Windows.Forms.TextBox();
            this.txtTB = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.txtRA = new System.Windows.Forms.TextBox();
            this.txtRB = new System.Windows.Forms.TextBox();
            this.txtRC = new System.Windows.Forms.TextBox();
            this.txtRT = new System.Windows.Forms.TextBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEx = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.Location = new System.Drawing.Point(43, 121);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(196, 32);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Enter the number of tickets sold for each class of seats. ";
            this.lbl1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTicketA
            // 
            this.lblTicketA.AutoSize = true;
            this.lblTicketA.Location = new System.Drawing.Point(43, 174);
            this.lblTicketA.Name = "lblTicketA";
            this.lblTicketA.Size = new System.Drawing.Size(56, 16);
            this.lblTicketA.TabIndex = 1;
            this.lblTicketA.Text = "Class A:";
            // 
            // lblTicketB
            // 
            this.lblTicketB.AutoSize = true;
            this.lblTicketB.Location = new System.Drawing.Point(43, 215);
            this.lblTicketB.Name = "lblTicketB";
            this.lblTicketB.Size = new System.Drawing.Size(56, 16);
            this.lblTicketB.TabIndex = 2;
            this.lblTicketB.Text = "Class B:";
            // 
            // lblTicketC
            // 
            this.lblTicketC.AutoSize = true;
            this.lblTicketC.Location = new System.Drawing.Point(43, 255);
            this.lblTicketC.Name = "lblTicketC";
            this.lblTicketC.Size = new System.Drawing.Size(56, 16);
            this.lblTicketC.TabIndex = 3;
            this.lblTicketC.Text = "Class C:";
            // 
            // lblTicketsSold
            // 
            this.lblTicketsSold.AutoSize = true;
            this.lblTicketsSold.Location = new System.Drawing.Point(46, 78);
            this.lblTicketsSold.Name = "lblTicketsSold";
            this.lblTicketsSold.Size = new System.Drawing.Size(82, 16);
            this.lblTicketsSold.TabIndex = 4;
            this.lblTicketsSold.Text = "Tickets Sold";
            // 
            // lblRev
            // 
            this.lblRev.AutoSize = true;
            this.lblRev.Location = new System.Drawing.Point(310, 78);
            this.lblRev.Name = "lblRev";
            this.lblRev.Size = new System.Drawing.Size(129, 16);
            this.lblRev.TabIndex = 5;
            this.lblRev.Text = "Revenue Generated";
            // 
            // lblRevA
            // 
            this.lblRevA.AutoSize = true;
            this.lblRevA.Location = new System.Drawing.Point(310, 137);
            this.lblRevA.Name = "lblRevA";
            this.lblRevA.Size = new System.Drawing.Size(56, 16);
            this.lblRevA.TabIndex = 6;
            this.lblRevA.Text = "Class A:";
            // 
            // lblRevB
            // 
            this.lblRevB.AutoSize = true;
            this.lblRevB.Location = new System.Drawing.Point(310, 174);
            this.lblRevB.Name = "lblRevB";
            this.lblRevB.Size = new System.Drawing.Size(56, 16);
            this.lblRevB.TabIndex = 7;
            this.lblRevB.Text = "Class B:";
            // 
            // lblRevC
            // 
            this.lblRevC.AutoSize = true;
            this.lblRevC.Location = new System.Drawing.Point(310, 212);
            this.lblRevC.Name = "lblRevC";
            this.lblRevC.Size = new System.Drawing.Size(56, 16);
            this.lblRevC.TabIndex = 8;
            this.lblRevC.Text = "Class C:";
            // 
            // lblRevTotal
            // 
            this.lblRevTotal.AutoSize = true;
            this.lblRevTotal.Location = new System.Drawing.Point(325, 255);
            this.lblRevTotal.Name = "lblRevTotal";
            this.lblRevTotal.Size = new System.Drawing.Size(41, 16);
            this.lblRevTotal.TabIndex = 9;
            this.lblRevTotal.Text = "Total:";
            // 
            // txtTA
            // 
            this.txtTA.Location = new System.Drawing.Point(114, 168);
            this.txtTA.Name = "txtTA";
            this.txtTA.Size = new System.Drawing.Size(100, 22);
            this.txtTA.TabIndex = 10;
            this.txtTA.TextChanged += new System.EventHandler(this.txtTA_TextChanged);
            this.txtTA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTA_KeyPress);
            // 
            // txtTB
            // 
            this.txtTB.Location = new System.Drawing.Point(114, 212);
            this.txtTB.Name = "txtTB";
            this.txtTB.Size = new System.Drawing.Size(100, 22);
            this.txtTB.TabIndex = 11;
            this.txtTB.TextChanged += new System.EventHandler(this.txtTB_TextChanged);
            this.txtTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTB_KeyPress);
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(114, 249);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(100, 22);
            this.txtTC.TabIndex = 12;
            this.txtTC.TextChanged += new System.EventHandler(this.txtTC_TextChanged);
            this.txtTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTC_KeyPress);
            // 
            // txtRA
            // 
            this.txtRA.Location = new System.Drawing.Point(372, 131);
            this.txtRA.Name = "txtRA";
            this.txtRA.Size = new System.Drawing.Size(100, 22);
            this.txtRA.TabIndex = 13;
            this.txtRA.TextChanged += new System.EventHandler(this.txtRA_TextChanged);
            // 
            // txtRB
            // 
            this.txtRB.Location = new System.Drawing.Point(372, 174);
            this.txtRB.Name = "txtRB";
            this.txtRB.Size = new System.Drawing.Size(100, 22);
            this.txtRB.TabIndex = 14;
            this.txtRB.TextChanged += new System.EventHandler(this.txtRB_TextChanged);
            // 
            // txtRC
            // 
            this.txtRC.Location = new System.Drawing.Point(372, 212);
            this.txtRC.Name = "txtRC";
            this.txtRC.Size = new System.Drawing.Size(100, 22);
            this.txtRC.TabIndex = 15;
            this.txtRC.TextChanged += new System.EventHandler(this.txtRC_TextChanged);
            // 
            // txtRT
            // 
            this.txtRT.Location = new System.Drawing.Point(372, 249);
            this.txtRT.Name = "txtRT";
            this.txtRT.Size = new System.Drawing.Size(100, 22);
            this.txtRT.TabIndex = 16;
            this.txtRT.TextChanged += new System.EventHandler(this.txtRT_TextChanged);
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(139, 329);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(75, 60);
            this.btnCal.TabIndex = 17;
            this.btnCal.Text = "Calculate Revenue";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(238, 329);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 60);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEx
            // 
            this.btnEx.Location = new System.Drawing.Point(328, 329);
            this.btnEx.Name = "btnEx";
            this.btnEx.Size = new System.Drawing.Size(75, 60);
            this.btnEx.TabIndex = 19;
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
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.txtRT);
            this.Controls.Add(this.txtRC);
            this.Controls.Add(this.txtRB);
            this.Controls.Add(this.txtRA);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.txtTB);
            this.Controls.Add(this.txtTA);
            this.Controls.Add(this.lblRevTotal);
            this.Controls.Add(this.lblRevC);
            this.Controls.Add(this.lblRevB);
            this.Controls.Add(this.lblRevA);
            this.Controls.Add(this.lblRev);
            this.Controls.Add(this.lblTicketsSold);
            this.Controls.Add(this.lblTicketC);
            this.Controls.Add(this.lblTicketB);
            this.Controls.Add(this.lblTicketA);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblTicketA;
        private System.Windows.Forms.Label lblTicketB;
        private System.Windows.Forms.Label lblTicketC;
        private System.Windows.Forms.Label lblTicketsSold;
        private System.Windows.Forms.Label lblRev;
        private System.Windows.Forms.Label lblRevA;
        private System.Windows.Forms.Label lblRevB;
        private System.Windows.Forms.Label lblRevC;
        private System.Windows.Forms.Label lblRevTotal;
        private System.Windows.Forms.TextBox txtTA;
        private System.Windows.Forms.TextBox txtTB;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.TextBox txtRA;
        private System.Windows.Forms.TextBox txtRB;
        private System.Windows.Forms.TextBox txtRC;
        private System.Windows.Forms.TextBox txtRT;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEx;
    }
}

