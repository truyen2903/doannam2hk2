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

namespace ChuongTrinhQLKS
{
    public partial class Femploy : Form
    {
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
            txtbirthday.Text = dgvEmploy.Rows[e.RowIndex].Cells["colDateOfBirth"].FormattedValue.ToString();
            txtstardate.Text = dgvEmploy.Rows[e.RowIndex].Cells["colStartDate"].FormattedValue.ToString();

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
                update.DateOfBirth = DateTime.Parse(txtbirthday.Text);
                update.Sex = txtsex.Text;
                update.StartDay = DateTime.Parse(txtstardate.Text);
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
            using (HotelManagement db = new HotelManagement())
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
                    txtaddress.Text = ListEmploy.Address;
                    txtbirthday.Text = ListEmploy.DateOfBirth.ToString("F");
                    txtIDcard.Text = ListEmploy.IDCard;
                    txtdisplay.Text = ListEmploy.DisplayName;
                    txtPhone.Text = ListEmploy.PhoneNumber.ToString();
                    txtsex.Text = ListEmploy.Sex;
                    txtstardate.Text = ListEmploy.StartDate.ToString("F");
                    txtusername.Text = ListEmploy.User;
                    cbtype.Text = ListEmploy.nametype;
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
                        txtaddress.Text = ListEmploys.Address;
                        txtbirthday.Text = ListEmploys.DateOfBirth.ToString("F");
                        txtIDcard.Text = ListEmploys.IDCard;
                        txtdisplay.Text = ListEmploys.DisplayName;
                        txtPhone.Text = ListEmploys.PhoneNumber.ToString();
                        txtsex.Text = ListEmploys.Sex;
                        txtstardate.Text = ListEmploys.StartDate.ToString("F");
                        txtusername.Text = ListEmploys.User;
                        cbtype.Text = ListEmploys.nametype;

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
                            txtaddress.Text = ListEmployss.Address;
                            txtbirthday.Text = ListEmployss.DateOfBirth.ToString("F");
                            txtIDcard.Text = ListEmployss.IDCard;
                            txtdisplay.Text = ListEmployss.DisplayName;
                            txtPhone.Text = ListEmployss.PhoneNumber.ToString();
                            txtsex.Text = ListEmployss.Sex;
                            txtstardate.Text = ListEmployss.StartDate.ToString("F");
                            txtusername.Text = ListEmployss.User;
                            cbtype.Text = ListEmployss.nametype;
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy nhân viên");
                        }
                    }
                }
            }
        }
        #endregion
        #region click
        private void btnSearch_Click(object sender, EventArgs e)
        {
            search();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            update();
        }

        private void btnresetpassword_Click(object sender, EventArgs e)
        {
           var fool =  MessageBox.Show("bạn có muốn đặt lại mật khẩu về \"123456\"?", "Notification",MessageBoxButtons.OKCancel,MessageBoxIcon.Asterisk);
            if (fool == DialogResult.OK)
            {
                resetpassword();
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
