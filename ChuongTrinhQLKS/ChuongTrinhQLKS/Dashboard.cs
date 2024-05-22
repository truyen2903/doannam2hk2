using System;
using System.Windows.Forms;
using static ChuongTrinhQLKS.Program;

namespace ChuongTrinhQLKS
{
    public partial class Dashboard : Form
    {
        string username = GlobalVariables.LoggedInUsername;
        public Dashboard()
        {
            InitializeComponent();
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
            Hide();
            Fprofile profile = new Fprofile();
            profile.ShowDialog();
            Show();
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

        private void BtnCheckin_Click(object sender, EventArgs e)
        {
            Hide();
            Fcheck_in fcheckin = new Fcheck_in();
            fcheckin.ShowDialog();
            Show();
        }

        private void btncheckout_Click(object sender, EventArgs e)
        {
            Hide();
            Fcheckout fcheckout = new Fcheckout();
            fcheckout.ShowDialog();
            Show();
        }

        private void btnEmployeemanagement_Click(object sender, EventArgs e)
        {
            Hide();
            Femploy femploy = new Femploy();
            femploy.ShowDialog();
            Show();
        }
    }
}
