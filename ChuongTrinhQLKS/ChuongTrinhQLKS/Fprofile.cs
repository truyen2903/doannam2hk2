using ChuongTrinhQLKS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ChuongTrinhQLKS.Program;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ChuongTrinhQLKS
{
    public partial class Fprofile : Form
    {
        HotelManagement infor;
        string Username = GlobalVariables.LoggedInUsername;
        public string GetLabelText(Label label)
        {
            return label.Text;
        }
        public Fprofile()
        {
            InitializeComponent();
        }
        private void Fprofile_Load(object sender, EventArgs e)
        {
            txtUsername.ReadOnly = true;
            txtTypeuser.ReadOnly = true;
            Loadinfor();
        }
        private async void Loadinfor()
        {
            infor = linqConnect.GetDatabase();
            var inforquery = await (from i in infor.STAFFs
                             join typer in infor.STAFFTYPEs on i.IDStaffType equals typer.ID
                             where i.UserName.ToString() == Username.ToString()
                                    select new
                             {
                                 Idcard = i.IDCard,
                                 displayName = i.DisplayName,
                                 birthday = i.DateOfBirth,
                                 address = i.Address,
                                 phonenumber = i.PhoneNumber,
                                 sex = i.Sex,
                                 startday = i.StartDay,
                                 userName = i.UserName,
                                 typecustom = typer.Name,
                             }).FirstOrDefaultAsync();
            if(inforquery != null)
            {
                lblUserName.Text = inforquery.userName;
                txtUsername.Text = inforquery.userName;
                lblDisplayName.Text = inforquery.displayName;
                txtDisplayname.Text = inforquery.displayName;
                txtAddress.Text = inforquery.address;
                txtIdcard.Text = inforquery.Idcard;
                txtPhone.Text = inforquery.phonenumber.ToString();
                DateTimeBirth.Value = DateTime.Parse( inforquery.birthday.ToString());
                DateTimeStartday.Value = DateTime.Parse(inforquery.startday.ToString());
                cbSex.Text = inforquery.sex;
                txtTypeuser.Text = inforquery.typecustom;
            }
            else
            {
                MessageBox.Show("Retrieval failed", "Notification",MessageBoxButtons.RetryCancel,MessageBoxIcon.Question);
            }
        }

        private async void BtnSaveaccount_Click(object sender, EventArgs e)
        {
            infor = linqConnect.GetDatabase();
            var saveacc = await (from i in infor.STAFFs
                                 where i.UserName == Username
                                 select i).FirstOrDefaultAsync();

            if (saveacc != null)
            {
                saveacc.DisplayName = txtDisplayname.Text;
                bool changesMade = false;
                if (txtDisplayname.Text != saveacc.DisplayName)
                {
                    changesMade = true;
                }

                if (changesMade)
                {
                    try
                    {
                        await infor.SaveChangesAsync();
                        MessageBox.Show("Account changes saved successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving account changes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No changes made to the account.");
                }
            }
            else
            {
                MessageBox.Show("Account not found.");
            }
        }

        private async void BtnSavepass_Click(object sender, EventArgs e)
        {
            infor = linqConnect.GetDatabase();
            var savepass = await(from i in infor.STAFFs
                                where i.UserName == Username
                                select i).FirstOrDefaultAsync();
            if(txtPassword.Text == savepass.PassWord)
            { 
            if (savepass != null)
            {
                savepass.PassWord = txtNewpassword.Text;
                bool changesMade = false;
                if (txtNewpassword.Text == txtConfirmpassword.Text)
                {
                    changesMade = true;
                }

                if (changesMade)
                {
                    try
                    {
                        await infor.SaveChangesAsync();
                        MessageBox.Show("Account changes saved successfully.");
                        Loadinfor();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving account changes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please re-enter your confirm password.");
                }
            }
            else
            {
                MessageBox.Show("Account not found.");
            }
        }
            else
            {
                MessageBox.Show("Please re-enter your password.");
            }    
        }

        private async void BtnSaveinfor_Click(object sender, EventArgs e)
        {
            infor = linqConnect.GetDatabase();
            var saveinfor = await (from i in infor.STAFFs
                                 where i.UserName == Username
                                 select i).FirstOrDefaultAsync();
            if (saveinfor != null)
            {
                saveinfor.IDCard = txtIdcard.Text;
                saveinfor.PhoneNumber = int.Parse( txtPhone.Text);
                saveinfor.Address = txtAddress.Text;
                saveinfor.Sex = cbSex.SelectedItem.ToString();
                saveinfor.DateOfBirth = DateTimeBirth.Value;
                saveinfor.StartDay = DateTimeStartday.Value;
                try
                {
                    await infor.SaveChangesAsync();
                    MessageBox.Show("Infor changes saved successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving infor changes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
