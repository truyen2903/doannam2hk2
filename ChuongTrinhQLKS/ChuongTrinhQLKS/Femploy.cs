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

namespace ChuongTrinhQLKS
{
    public partial class Femploy : Form
    {
        string Username = GlobalVariables.LoggedInUsername;
        public Femploy()
        {
            InitializeComponent();
            loadType();
            LoadListEmploy();   
        }
        #region load
        private async void LoadListEmploy()
        {
            dgvEmploy.Rows.Clear();
            using (HotelManagement db = new HotelManagement())
            {
                var ListEmploy = await (from employ in db.STAFFs
                                        join type in db.STAFFTYPEs on employ.IDStaffType equals type.ID
                                        select new
                                        {
                                            User = employ.UserName,
                                            DisplayName = employ.DisplayName,
                                            nametype = type.Name,
                                            IDCard = employ.IDCard,
                                            PhoneNumber = employ.PhoneNumber,
                                            Address = employ.Address,
                                            Sex = employ.Sex,
                                            DateOfBirth = employ.DateOfBirth,
                                            IDStaffType = employ.IDStaffType,
                                            StartDate = employ.StartDay
                                        }).ToListAsync();
                foreach (var item in ListEmploy)
                {
                    var index = dgvEmploy.Rows.Add();
                    dgvEmploy.Rows[index].Cells["colUserName"].Value = item.User;
                    dgvEmploy.Rows[index].Cells["colname"].Value = item.DisplayName;
                    dgvEmploy.Rows[index].Cells["colNameStaffType"].Value = item.nametype;
                    dgvEmploy.Rows[index].Cells["colIDCard"].Value = item.IDCard;
                    dgvEmploy.Rows[index].Cells["colPhone"].Value = item.PhoneNumber;
                    dgvEmploy.Rows[index].Cells["colAddress"].Value = item.Address;
                    dgvEmploy.Rows[index].Cells["colSex"].Value = item.Sex;
                    dgvEmploy.Rows[index].Cells["colDateOfBirth"].Value = item.DateOfBirth;
                    dgvEmploy.Rows[index].Cells["colStartDate"].Value = item.StartDate;
                };
            }
        }

        private void Femploy_Load(object sender, EventArgs e)
        {

        }

        private void dgvEmploy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex >= 0 && e.RowIndex < dgvEmploy.Rows.Count)
            { 
            txtusername.Text = dgvEmploy.Rows[e.RowIndex].Cells["colUserName"].FormattedValue.ToString();
            cbtype.Text = dgvEmploy.Rows[e.RowIndex].Cells["colNameStaffType"].FormattedValue.ToString();
            txtdisplay.Text = dgvEmploy.Rows[e.RowIndex].Cells["colname"].FormattedValue.ToString();
            txtIDcard.Text = dgvEmploy.Rows[e.RowIndex].Cells["colIDCard"].FormattedValue.ToString();
            txtPhone.Text = dgvEmploy.Rows[e.RowIndex].Cells["colPhone"].FormattedValue.ToString();
            txtaddress.Text = dgvEmploy.Rows[e.RowIndex].Cells["colAddress"].FormattedValue.ToString();
            txtsex.Text = dgvEmploy.Rows[e.RowIndex].Cells["colSex"].FormattedValue.ToString();
            DateTimeBirthday.Text = dgvEmploy.Rows[e.RowIndex].Cells["colDateOfBirth"].FormattedValue.ToString();
            DateTimeStart.Text = dgvEmploy.Rows[e.RowIndex].Cells["colStartDate"].FormattedValue.ToString();

            }
        }
        private async void loadType()
        {
            using (HotelManagement db = new HotelManagement())
            {
                var ListType = await (db.STAFFTYPEs).ToListAsync();
                cbtype.DataSource = ListType;
                cbtype.DisplayMember = "Name";
                cbtype.ValueMember = "ID";
            }
        }

        private async void update()
        {
            using (HotelManagement db = new HotelManagement())
            {
                var update = await db.STAFFs.Where(x => x.UserName == txtusername.Text).FirstOrDefaultAsync();

                update.DisplayName = txtdisplay.Text;
                update.IDCard = txtIDcard.Text;
                update.PhoneNumber = int.Parse(txtPhone.Text);
                update.Address = txtaddress.Text;
                update.DateOfBirth = DateTimeBirthday.Value;
                update.Sex = txtsex.Text;
                update.StartDay =DateTimeStart.Value;
                update.IDStaffType = int.Parse(cbtype.SelectedValue.ToString());
                update.UserName = txtusername.Text;
                try
                {
                    await db.SaveChangesAsync();
                    LoadListEmploy();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
        }
        private void resetpassword()
        {
            using (HotelManagement db = new HotelManagement())
            {
                var update = db.STAFFs.FirstOrDefault(x => x.UserName == txtusername.Text);
                if (update != null)
                {
                    update.PassWord = "123456";
                    db.SaveChanges();
                    MessageBox.Show("Reset password successfully!");
                }
            }
        }
        #endregion
        #region Search
        private async void search()
        {
            using (var db = linqConnect.GetDatabase())
            {
                var ListEmploy = await (from employ in db.STAFFs
                                        join type in db.STAFFTYPEs on employ.IDStaffType equals type.ID
                                        where employ.UserName == txtFind.Text
                                        select new
                                        {
                                            User = employ.UserName,
                                            DisplayName = employ.DisplayName,
                                            nametype = type.Name,
                                            IDCard = employ.IDCard,
                                            PhoneNumber = employ.PhoneNumber,
                                            Address = employ.Address,
                                            Sex = employ.Sex,
                                            DateOfBirth = employ.DateOfBirth,
                                            IDStaffType = employ.IDStaffType,
                                            StartDate = employ.StartDay
                                        }).FirstOrDefaultAsync();
                if (ListEmploy != null)
                {
                    AssignValues(ListEmploy);
                }
                else
                {
                    var ListEmploys = await (from employ in db.STAFFs
                                             join type in db.STAFFTYPEs on employ.IDStaffType equals type.ID
                                             where employ.DisplayName == txtFind.Text
                                             select new
                                             {
                                                 User = employ.UserName,
                                                 DisplayName = employ.DisplayName,
                                                 nametype = type.Name,
                                                 IDCard = employ.IDCard,
                                                 PhoneNumber = employ.PhoneNumber,
                                                 Address = employ.Address,
                                                 Sex = employ.Sex,
                                                 DateOfBirth = employ.DateOfBirth,
                                                 IDStaffType = employ.IDStaffType,
                                                 StartDate = employ.StartDay
                                             }).FirstOrDefaultAsync();
                    if (ListEmploys != null)
                    {
                        AssignValues(ListEmploys);
                    }
                    else
                    {
                        var ListEmployss = await (from employ in db.STAFFs
                                                  join type in db.STAFFTYPEs on employ.IDStaffType equals type.ID
                                                  where employ.IDCard == txtFind.Text
                                                  select new
                                                  {
                                                      User = employ.UserName,
                                                      DisplayName = employ.DisplayName,
                                                      nametype = type.Name,
                                                      IDCard = employ.IDCard,
                                                      PhoneNumber = employ.PhoneNumber,
                                                      Address = employ.Address,
                                                      Sex = employ.Sex,
                                                      DateOfBirth = employ.DateOfBirth,
                                                      IDStaffType = employ.IDStaffType,
                                                      StartDate = employ.StartDay
                                                  }).FirstOrDefaultAsync();
                        if (ListEmployss != null)
                        {
                            AssignValues(ListEmployss);
                        }
                        else
                        {
                            MessageBox.Show("No employees found");
                        }
                    }
                }
            }
        }

        private void AssignValues(dynamic employee)
        {
            txtaddress.Text = employee.Address;
            DateTimeBirthday.Value = DateTime.Parse(employee.DateOfBirth.ToString());
            txtIDcard.Text = employee.IDCard;
            txtdisplay.Text = employee.DisplayName;
            txtPhone.Text = employee.PhoneNumber.ToString();
            txtsex.Text = employee.Sex;
            DateTimeStart.Value = DateTime.Parse(employee.StartDate.ToString());
            txtusername.Text = employee.User;
            cbtype.Text = employee.nametype;
        }

        #endregion
        #region click
        private void btnSearch_Click(object sender, EventArgs e)
        {
            search();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "")
            {
                MessageBox.Show("Please select an employee to update!");
                return;
            }
            update();
            MessageBox.Show("Update Success");
        }

        private void btnresetpassword_Click(object sender, EventArgs e)
        {
           var fool =  MessageBox.Show("Do you want to reset your password to \"123456\"?", "Notification",MessageBoxButtons.OKCancel,MessageBoxIcon.Asterisk);
            if (fool == DialogResult.OK)
            {
                resetpassword();
            }
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Hide();
            Faddemploy faddemploy = new Faddemploy();
            faddemploy.ShowDialog();
            Show();
            LoadListEmploy();
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportFile exportFile = new ExportFile();
            DataTable dt = exportFile.GetDataTableFromDataGridView(dgvEmploy);
            exportFile.ExportToExcel(dt,"sheet1", "List Employ");
            MessageBox.Show("The Excel file has been created successfully!");
        }

        private void btnAccess_Click(object sender, EventArgs e)
        {
            if (Check.CheckAccess("Faccess", Username))
            {
                Hide();
                Faccess faccess = new Faccess();
                faccess.ShowDialog();
                Show();
            }
            else
            {
                MessageBox.Show("You do not have permission to access this feature!");
            }
        }
    }
}
