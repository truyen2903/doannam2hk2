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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static ChuongTrinhQLKS.Program;

namespace ChuongTrinhQLKS
{
    public partial class flogin : Form
    {
        public flogin()
        {
            InitializeComponent();
            Color shadowColor2 = Color.FromArgb(60, 0, 0, 0);
            Panellogin.ShadowDecoration.Color = shadowColor2;
            Panellogin.ShadowDecoration.Depth = 10; 
            Panellogin.ShadowDecoration.Shadow = new Padding(0, 10, 36, 0);
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
            using (HotelManagement db = new HotelManagement())
            {
                var user = db.STAFFs.FirstOrDefault(u => u.UserName == txtusername.Text && u.PassWord == txtpassword.Text);
                if (user != null)
                {
                    Hide();
                    GlobalVariables.LoggedInUsername = user.UserName;
                    Fdashboard fdashboard = new Fdashboard();
                    fdashboard.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpassword.Focus();
                    txtpassword.Text = string.Empty;
                }
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
