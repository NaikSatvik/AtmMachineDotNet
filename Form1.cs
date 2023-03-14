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
    public partial class loginForm : Form
    {
        // global variables
        public string id = "anon";
        public int pass = 1234;

        public loginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (String.Compare(this.loginID.Text,id) == 0 && int.Parse(this.pin.Text) == pass)
            {
                this.loginID.Clear();
                this.pin.Clear();
                this.loginMsgBox.Text = "";
                atm atm = new atm();
                atm.ShowDialog();
            } else
            {
                this.loginMsgBox.Text = "Login ID or Password is incorrect.";
            }
        }
    }
}
