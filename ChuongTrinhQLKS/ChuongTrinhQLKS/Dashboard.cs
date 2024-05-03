using System;
using System.Windows.Forms;

namespace ChuongTrinhQLKS
{
    public partial class Dashboard : Form
    {
#pragma warning disable IDE0052
        private readonly string loggedInUser;
        public Dashboard(string username)
        {
            InitializeComponent();
            loggedInUser = username;
        }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void BtnNav_Click(object sender, EventArgs e)
        {
            if (PanelLeft.Width == 42)
            {
                PanelLeft.Width = 177;
                PanelRight.Width = 1282;
                this.Width = 1459;
            }
            else
            {
                PanelLeft.Width = 42;
                PanelRight.Width = 1282;
                this.Width = 1324;
            }
        }

        private void BtnInformation_Click(object sender, EventArgs e)
        {
            //Hide();
            //fProfile profile = new fProfile(loggedInUser);
            //profile.ShowDialog();
            //Show();
        }

        private void Btnaddrom_Click(object sender, EventArgs e)
        {
            Hide();
            fbookroom fbookroom = new fbookroom();
            fbookroom.ShowDialog();
            Show();
        }

        private void BtnRoommanagement_Click(object sender, EventArgs e)
        {
            Hide();
            froommanagement froommanagement = new froommanagement();
            froommanagement.ShowDialog();
            Show();
        }

        private void Btnlog_Click(object sender, EventArgs e)
        {
            Hide();
            flogin flogin = new flogin();   
            flogin.Show();
        }
    }
}
