using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ChuongTrinhQLKS.Models;

namespace ChuongTrinhQLKS
{
    public partial class Fdashboard : Form
    {
        private Guna2GradientButton currentBtn;
        private Guna2GradientPanel leftBorderBtn;
        private string Username;
        private Form currentChildForm;

        public Fdashboard()
        {
            InitializeComponent();
            leftBorderBtn = new Guna2GradientPanel();
            leftBorderBtn.Size = new Size(7, 45);
            PanelLeft.Controls.Add(leftBorderBtn);
            Username = Program.GlobalVariables.LoggedInUsername;
            if (!string.IsNullOrEmpty(Username))
            {
                BtnLogin.Text = Username;
            }
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(154, 205, 50);
            public static Color color8 = Color.FromArgb(0, 250, 154);
            public static Color color9 = Color.FromArgb(250, 235, 215);
            public static Color color10 = Color.FromArgb(176, 196, 222);
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelChild.Controls.Add(childForm);
            PanelChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (Guna2GradientButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(204, 232, 255);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = HorizontalAlignment.Left;
                currentBtn.ImageAlign = HorizontalAlignment.Left;
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            BtnTag.Text = "Home";
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.White;
                currentBtn.ForeColor = Color.FromArgb(105, 105, 105);
                currentBtn.TextAlign = HorizontalAlignment.Left;
                currentBtn.ImageAlign = HorizontalAlignment.Left;
            }
        }

        private void BtnBook_Click(object sender, EventArgs e)
        {
            if (BtnLogin.Text == "Login")
            {
                MessageBox.Show("Please log in", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (Check.CheckAccess("fbookroom", Username))
                {
                    ActivateButton(sender, RGBColors.color1);
                    OpenChildForm(new fbookroom());
                }
                else
                {
                    MessageBox.Show("You do not have permission to access this feature", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void BtnCheckin_Click(object sender, EventArgs e)
        {
            if (BtnLogin.Text == "Login")
            {
                MessageBox.Show("Please log in", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (Check.CheckAccess("Fcheck_in", Username))
                {
                    ActivateButton(sender, RGBColors.color2);
                    OpenChildForm(new Fcheck_in());
                }
                else
                {
                    MessageBox.Show("You do not have permission to access this feature", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void BtnCheckout_Click(object sender, EventArgs e)
        {
            if (BtnLogin.Text == "Login")
            {
                MessageBox.Show("Please log in", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (Check.CheckAccess("Fcheckout", Username))
                {
                    ActivateButton(sender, RGBColors.color3);
                    OpenChildForm(new Fcheckout());
                }
                else
                {
                    MessageBox.Show("You do not have permission to access this feature", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void BtnRoom_Click(object sender, EventArgs e)
        {
            if (BtnLogin.Text == "Login")
            {
                MessageBox.Show("Please log in", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (Check.CheckAccess("froommanagement", Username))
                {
                    ActivateButton(sender, RGBColors.color4);
                    OpenChildForm(new froommanagement());
                }
                else
                {
                    MessageBox.Show("You do not have permission to access this feature", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void BtnEmploy_Click(object sender, EventArgs e)
        {
            if (BtnLogin.Text == "Login")
            {
                MessageBox.Show("Please log in", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (Check.CheckAccess("Femploy", Username))
                {
                    ActivateButton(sender, RGBColors.color5);
                    OpenChildForm(new Femploy());
                }
                else
                {
                    MessageBox.Show("You do not have permission to access this feature", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void BtnCustomer_Click(object sender, EventArgs e)
        {
            if (BtnLogin.Text == "Login")
            {
                MessageBox.Show("Please log in", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (Check.CheckAccess("Fcustomer", Username))
                {
                    ActivateButton(sender, RGBColors.color6);
                    OpenChildForm(new Fcustomer());
                }
                else
                {
                    MessageBox.Show("You do not have permission to access this feature", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void BtnInvoid_Click(object sender, EventArgs e)
        {
            if (BtnLogin.Text == "Login")
            {
                MessageBox.Show("Please log in", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (Check.CheckAccess("Finvoid", Username))
                {
                    ActivateButton(sender, RGBColors.color7);
                    OpenChildForm(new Finvoid());
                }
                else
                {
                    MessageBox.Show("You do not have permission to access this feature", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void BtnService_Click(object sender, EventArgs e)
        {
            if (BtnLogin.Text == "Login")
            {
                MessageBox.Show("Please log in", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (Check.CheckAccess("Fsevice", Username))
                {
                    ActivateButton(sender, RGBColors.color8);
                    OpenChildForm(new Fsevice());
                }
                else
                {
                    MessageBox.Show("You do not have permission to access this feature", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void BtnStatistics_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color9);
        }

        private void BtnAccess_Click(object sender, EventArgs e)
        {
            if (BtnLogin.Text == "Login")
            {
                MessageBox.Show("Please log in", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (Check.CheckAccess("Faccess", Username))
                {
                    ActivateButton(sender, RGBColors.color10);
                    OpenChildForm(new Faccess());
                }
                else
                {
                    MessageBox.Show("You do not have permission to access this feature", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            LBDate.Text = DateTime.Now.ToLongDateString();
            LBTimer.Text = DateTime.Now.ToLongTimeString();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (BtnLogin.Text == "Login")
            {
                Hide();
                flogin flogin = new flogin();
                flogin.ShowDialog();
                this.Close();
            }
            else
            {
                OpenChildForm(new Fprofile());
            }
        }

        private void BtnTag_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
