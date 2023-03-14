
namespace AtmMachine
{
    partial class atm
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
            this.welcomeMsg = new System.Windows.Forms.Label();
            this.withdrawRedirect = new System.Windows.Forms.LinkLabel();
            this.depositRedirect = new System.Windows.Forms.LinkLabel();
            this.label = new System.Windows.Forms.Label();
            this.balance = new System.Windows.Forms.Label();
            this.withdrawPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.withdrawAmt = new System.Windows.Forms.RichTextBox();
            this.withPin = new System.Windows.Forms.RichTextBox();
            this.withdrawBtn = new System.Windows.Forms.Button();
            this.ackMsgBox = new System.Windows.Forms.Label();
            this.depositPanel = new System.Windows.Forms.Panel();
            this.depositBtn = new System.Windows.Forms.Button();
            this.depoPin = new System.Windows.Forms.RichTextBox();
            this.depositAmt = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.withdrawPanel.SuspendLayout();
            this.depositPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeMsg
            // 
            this.welcomeMsg.AutoSize = true;
            this.welcomeMsg.Location = new System.Drawing.Point(30, 31);
            this.welcomeMsg.Name = "welcomeMsg";
            this.welcomeMsg.Size = new System.Drawing.Size(10, 13);
            this.welcomeMsg.TabIndex = 0;
            this.welcomeMsg.Text = " ";
            // 
            // withdrawRedirect
            // 
            this.withdrawRedirect.AutoSize = true;
            this.withdrawRedirect.Location = new System.Drawing.Point(37, 90);
            this.withdrawRedirect.Name = "withdrawRedirect";
            this.withdrawRedirect.Size = new System.Drawing.Size(52, 13);
            this.withdrawRedirect.TabIndex = 1;
            this.withdrawRedirect.TabStop = true;
            this.withdrawRedirect.Text = "Withdraw";
            this.withdrawRedirect.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.withdrawRedirect_LinkClicked);
            // 
            // depositRedirect
            // 
            this.depositRedirect.AutoSize = true;
            this.depositRedirect.Location = new System.Drawing.Point(188, 90);
            this.depositRedirect.Name = "depositRedirect";
            this.depositRedirect.Size = new System.Drawing.Size(43, 13);
            this.depositRedirect.TabIndex = 2;
            this.depositRedirect.TabStop = true;
            this.depositRedirect.Text = "Deposit";
            this.depositRedirect.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.depositRedirect_LinkClicked);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(30, 56);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(46, 13);
            this.label.TabIndex = 3;
            this.label.Text = "Balance";
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.Location = new System.Drawing.Point(83, 56);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(0, 13);
            this.balance.TabIndex = 4;
            // 
            // withdrawPanel
            // 
            this.withdrawPanel.Controls.Add(this.withdrawBtn);
            this.withdrawPanel.Controls.Add(this.withPin);
            this.withdrawPanel.Controls.Add(this.withdrawAmt);
            this.withdrawPanel.Controls.Add(this.label2);
            this.withdrawPanel.Controls.Add(this.label1);
            this.withdrawPanel.Location = new System.Drawing.Point(12, 121);
            this.withdrawPanel.Name = "withdrawPanel";
            this.withdrawPanel.Size = new System.Drawing.Size(127, 286);
            this.withdrawPanel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PIN";
            // 
            // withdrawAmt
            // 
            this.withdrawAmt.Location = new System.Drawing.Point(23, 47);
            this.withdrawAmt.Name = "withdrawAmt";
            this.withdrawAmt.Size = new System.Drawing.Size(77, 22);
            this.withdrawAmt.TabIndex = 2;
            this.withdrawAmt.Text = "";
            // 
            // withPin
            // 
            this.withPin.Location = new System.Drawing.Point(23, 111);
            this.withPin.Name = "withPin";
            this.withPin.Size = new System.Drawing.Size(77, 22);
            this.withPin.TabIndex = 3;
            this.withPin.Text = "";
            // 
            // withdrawBtn
            // 
            this.withdrawBtn.Location = new System.Drawing.Point(21, 163);
            this.withdrawBtn.Name = "withdrawBtn";
            this.withdrawBtn.Size = new System.Drawing.Size(86, 23);
            this.withdrawBtn.TabIndex = 4;
            this.withdrawBtn.Text = "WITHDRAW";
            this.withdrawBtn.UseVisualStyleBackColor = true;
            this.withdrawBtn.Click += new System.EventHandler(this.withdrawBtn_Click);
            // 
            // ackMsgBox
            // 
            this.ackMsgBox.AutoSize = true;
            this.ackMsgBox.Location = new System.Drawing.Point(95, 9);
            this.ackMsgBox.Name = "ackMsgBox";
            this.ackMsgBox.Size = new System.Drawing.Size(0, 13);
            this.ackMsgBox.TabIndex = 6;
            // 
            // depositPanel
            // 
            this.depositPanel.Controls.Add(this.depositBtn);
            this.depositPanel.Controls.Add(this.depoPin);
            this.depositPanel.Controls.Add(this.depositAmt);
            this.depositPanel.Controls.Add(this.label3);
            this.depositPanel.Controls.Add(this.label4);
            this.depositPanel.Location = new System.Drawing.Point(160, 121);
            this.depositPanel.Name = "depositPanel";
            this.depositPanel.Size = new System.Drawing.Size(127, 286);
            this.depositPanel.TabIndex = 6;
            // 
            // depositBtn
            // 
            this.depositBtn.Location = new System.Drawing.Point(21, 163);
            this.depositBtn.Name = "depositBtn";
            this.depositBtn.Size = new System.Drawing.Size(86, 23);
            this.depositBtn.TabIndex = 4;
            this.depositBtn.Text = "DEPOSIT";
            this.depositBtn.UseVisualStyleBackColor = true;
            this.depositBtn.Click += new System.EventHandler(this.depositBtn_Click);
            // 
            // depoPin
            // 
            this.depoPin.Location = new System.Drawing.Point(23, 111);
            this.depoPin.Name = "depoPin";
            this.depoPin.Size = new System.Drawing.Size(77, 22);
            this.depoPin.TabIndex = 3;
            this.depoPin.Text = "";
            // 
            // depositAmt
            // 
            this.depositAmt.Location = new System.Drawing.Point(23, 47);
            this.depositAmt.Name = "depositAmt";
            this.depositAmt.Size = new System.Drawing.Size(77, 22);
            this.depositAmt.TabIndex = 2;
            this.depositAmt.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "PIN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Amount";
            // 
            // atm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 419);
            this.Controls.Add(this.depositPanel);
            this.Controls.Add(this.ackMsgBox);
            this.Controls.Add(this.withdrawPanel);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.label);
            this.Controls.Add(this.depositRedirect);
            this.Controls.Add(this.withdrawRedirect);
            this.Controls.Add(this.welcomeMsg);
            this.Name = "atm";
            this.Text = "ATM";
            this.withdrawPanel.ResumeLayout(false);
            this.withdrawPanel.PerformLayout();
            this.depositPanel.ResumeLayout(false);
            this.depositPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeMsg;
        private System.Windows.Forms.LinkLabel withdrawRedirect;
        private System.Windows.Forms.LinkLabel depositRedirect;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.Panel withdrawPanel;
        private System.Windows.Forms.Button withdrawBtn;
        private System.Windows.Forms.RichTextBox withPin;
        private System.Windows.Forms.RichTextBox withdrawAmt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ackMsgBox;
        private System.Windows.Forms.Panel depositPanel;
        private System.Windows.Forms.Button depositBtn;
        private System.Windows.Forms.RichTextBox depoPin;
        private System.Windows.Forms.RichTextBox depositAmt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}