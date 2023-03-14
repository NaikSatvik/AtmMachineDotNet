using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtmMachine
{
    public partial class atm : Form
    {
        public int bal = 20980;
        loginForm lgnFrm = new loginForm();

        public atm()
        {
            InitializeComponent();
            this.withdrawPanel.Hide();
            this.depositPanel.Hide();
            this.welcomeMsg.Text = "Welcome "+lgnFrm.id;
            this.balance.Text = bal.ToString();
        }

        private void withdrawRedirect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.withdrawPanel.Show();
            this.depositPanel.Hide();
        }

        private void depositRedirect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.depositPanel.Show();
            this.withdrawPanel.Hide();
        }

        private void withdrawBtn_Click(object sender, EventArgs e)
        {
            if (int.Parse(this.withdrawAmt.Text) > bal && int.Parse(this.withPin.Text) == lgnFrm.pass)
            {
                this.ackMsgBox.Text = "Your account dosen't have enough balance.";
            }
            else if (int.Parse(this.withdrawAmt.Text) < bal && int.Parse(this.withPin.Text) == lgnFrm.pass)
            {
                this.balance.Text = (int.Parse(this.balance.Text) - int.Parse(this.withdrawAmt.Text)).ToString();
                this.withdrawAmt.Clear();
                this.withPin.Clear();
                this.ackMsgBox.Text = "Amount debited successfully.";
            } else
            {
                this.ackMsgBox.Text = "Incorrect PIN entered. Try again.";
            }
        }

        private void depositBtn_Click(object sender, EventArgs e)
        {
            if (int.Parse(this.depoPin.Text) == lgnFrm.pass)
            {
                this.balance.Text = (int.Parse(this.balance.Text) + int.Parse(this.depositAmt.Text)).ToString();
                this.depositAmt.Clear();
                this.depoPin.Clear();
                this.ackMsgBox.Text = "Amount credited successfully.";
            }
            else
            {
                this.ackMsgBox.Text = "Incorrect PIN entered. Try again.";
            }
        }
    }
}
