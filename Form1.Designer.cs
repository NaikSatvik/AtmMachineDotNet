﻿
namespace AtmMachine
{
    partial class loginForm
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
            this.loginID = new System.Windows.Forms.RichTextBox();
            this.pin = new System.Windows.Forms.RichTextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginMsgBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginID
            // 
            this.loginID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginID.Location = new System.Drawing.Point(53, 117);
            this.loginID.Name = "loginID";
            this.loginID.Size = new System.Drawing.Size(184, 36);
            this.loginID.TabIndex = 0;
            this.loginID.Text = "";
            // 
            // pin
            // 
            this.pin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pin.Location = new System.Drawing.Point(53, 217);
            this.pin.Name = "pin";
            this.pin.Size = new System.Drawing.Size(184, 36);
            this.pin.TabIndex = 2;
            this.pin.Text = "";
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.loginBtn.Location = new System.Drawing.Point(97, 278);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "LOGIN";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "PIN";
            // 
            // loginMsgBox
            // 
            this.loginMsgBox.AutoSize = true;
            this.loginMsgBox.Location = new System.Drawing.Point(123, 54);
            this.loginMsgBox.Name = "loginMsgBox";
            this.loginMsgBox.Size = new System.Drawing.Size(0, 13);
            this.loginMsgBox.TabIndex = 6;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 419);
            this.Controls.Add(this.loginMsgBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.pin);
            this.Controls.Add(this.loginID);
            this.Name = "loginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox loginID;
        private System.Windows.Forms.RichTextBox pin;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label loginMsgBox;
    }
}

