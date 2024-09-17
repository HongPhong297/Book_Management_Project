using Repositories.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Management_PhongLe
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            btnLogin.Enabled = false;
        }

        private void btbCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void UpdateLoginButtonState()
        {
            btnLogin.Enabled = !string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(txtPassword.Text);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserAccountServices services = new UserAccountServices();
            UserAccount acc = services.CheckLogin(txtEmail.Text, txtPassword.Text);
            //if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPassword.Text))
            //{
            //    btnLogin.Enabled = false;
            //}
            
            if (acc == null)
            {
                MessageBox.Show("Login Fail, Please Check Your Email Or PassWord", "Wrong Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (acc.Role != 1)
            {
                MessageBox.Show("You Have No Permision To Access", "Wrong Privilege", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BookManagerMainUI f = new();
            f.Show();
            this.Hide();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            UpdateLoginButtonState();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            UpdateLoginButtonState();
        }
    }
}
