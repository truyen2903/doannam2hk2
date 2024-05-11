using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using ChuongTrinhQLKS.Models;
using static ChuongTrinhQLKS.Program;

namespace ChuongTrinhQLKS
{
    public partial class flogin : Form
    {
        public flogin()
        {
            InitializeComponent();
            Panellogin.ShadowDecoration.Shadow = new Padding(10);
            Panellogin.ShadowDecoration.Enabled = true;
        }
        private void Btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Txtusername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtpassword.Focus();
            }
        }


        private void Btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;

            funcion dbfuncion = new funcion();

            if (dbfuncion.CheckLogin(username, password))
            {
                Hide();
                GlobalVariables.LoggedInUsername = username; 
                Dashboard dashboard = new Dashboard();
                dashboard.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong account or password!","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtusername.Text = string.Empty;
                txtusername.Focus();
                txtpassword.Text = string.Empty;
            }

        }

        private void Lbclick_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact your administrator to re-issue your account", "Announcement",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            txtusername.Text = string.Empty;
            txtusername.Focus();
            txtpassword.Text = string.Empty;
        }

        private void Flogin_Load(object sender, EventArgs e)
        {
            txtusername.Text = string.Empty;
            txtusername.Focus();
            txtpassword.Text = string.Empty;
        }
    }
}
