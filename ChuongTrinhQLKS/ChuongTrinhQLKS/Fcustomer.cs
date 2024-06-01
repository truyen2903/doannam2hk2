using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChuongTrinhQLKS.Models;

namespace ChuongTrinhQLKS
{
    public partial class Fcustomer : Form
    {
        HotelManagement db;
        public Fcustomer()
        {
            InitializeComponent();
            LoadListCustomer();
            LoadType();
        }
        #region load
        private async void LoadType()
        {
           using( db = linqConnect.GetDatabase()) {
                var type = await (from t in db.CUSTOMERTYPEs
                           select t).ToListAsync();
                cbType.DataSource = type;
                cbType.DisplayMember = "Name";
                cbType.ValueMember = "ID";
            }
        }
        private async void LoadListCustomer()
        {
            dataGridViewCustomer.Rows.Clear();
            using (db = linqConnect.GetDatabase())
            {
                var list = await (from i in db.CUSTOMERs
                                  join j in db.CUSTOMERTYPEs on i.IDCustomerType equals j.ID
                                  select new
                                  {
                                    ID=i.ID,
                                    Name =i.Name,
                                    IDCard = i.IDCard,
                                    TypeName =j.Name,
                                    address=i.Address,
                                    phone = i.PhoneNumber,
                                    Nationality = i.Nationality,
                                    IDType = j.ID,
                                    Sex = i.Sex,
                                    Birthday = i.DateOfBirth,

                                  }).ToListAsync();
                foreach (var item in list)
                {
                    var index = dataGridViewCustomer.Rows.Add();
                    dataGridViewCustomer.Rows[index].Cells["colID"].Value = item.ID;
                    dataGridViewCustomer.Rows[index].Cells["colNameCustomer"].Value = item.Name;
                    dataGridViewCustomer.Rows[index].Cells["colIDCard"].Value = item.IDCard;
                    dataGridViewCustomer.Rows[index].Cells["colNameCustomerType"].Value = item.TypeName;
                    dataGridViewCustomer.Rows[index].Cells["colAddress"].Value = item.address;
                    dataGridViewCustomer.Rows[index].Cells["colPhone"].Value = item.phone;
                    dataGridViewCustomer.Rows[index].Cells["colNationality"].Value = item.Nationality;
                    dataGridViewCustomer.Rows[index].Cells["Collidtype"].Value = item.IDType;
                    dataGridViewCustomer.Rows[index].Cells["colSex"].Value = item.Sex;
                    dataGridViewCustomer.Rows[index].Cells["colDateOfBirth"].Value = item.Birthday;
                }
            }
        }

        #endregion
        #region method
        private void Clear()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtIdCard.Text = "";
            cbType.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtNation.Text = "";
            txtSex.Text = "";
            DateTimebirthday.Value = DateTime.Now;
        }
        private async void UpdateCustumer()
        {
            using (db = linqConnect.GetDatabase())
            {
                int id = int.Parse(txtID.Text);
                var customer = await (from i in db.CUSTOMERs
                                      where i.ID == id
                                      select i).FirstOrDefaultAsync();

                customer.ID = int.Parse(txtID.Text);
                customer.Name = txtName.Text;
                customer.IDCard = txtIdCard.Text;
                customer.IDCustomerType = (int)cbType.SelectedValue;
                customer.Address = txtAddress.Text;
                customer.PhoneNumber = int.Parse(txtPhone.Text);
                customer.Sex = txtSex.Text;
                customer.Nationality = txtNation.Text;
                customer.DateOfBirth = DateTimebirthday.Value;
                try
                {
                    await db.SaveChangesAsync();
                    MessageBox.Show("Update Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            Clear();
            LoadListCustomer();
        }
        #endregion
        #region click
        private void dataGridViewCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0&& e.RowIndex<dataGridViewCustomer.Rows.Count)
            {
                txtID.Text = dataGridViewCustomer.Rows[e.RowIndex].Cells["colID"].Value.ToString();
                txtName.Text = dataGridViewCustomer.Rows[e.RowIndex].Cells["colNameCustomer"].Value.ToString();
                txtIdCard.Text = dataGridViewCustomer.Rows[e.RowIndex].Cells["colIDCard"].Value.ToString();
                cbType.Text = dataGridViewCustomer.Rows[e.RowIndex].Cells["colNameCustomerType"].Value.ToString();
                txtAddress.Text = dataGridViewCustomer.Rows[e.RowIndex].Cells["colAddress"].Value.ToString();
                txtPhone.Text = dataGridViewCustomer.Rows[e.RowIndex].Cells["colPhone"].Value.ToString();
                txtNation.Text = dataGridViewCustomer.Rows[e.RowIndex].Cells["colNationality"].Value.ToString();
                txtSex.Text = dataGridViewCustomer.Rows[e.RowIndex].Cells["colSex"].Value.ToString();
                DateTimebirthday.Value = Convert.ToDateTime(dataGridViewCustomer.Rows[e.RowIndex].Cells["colDateOfBirth"].Value);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" && txtName.Text=="" && txtID.Text=="" )
            {
                MessageBox.Show("Please select a customer to update");
                return;
            }
            UpdateCustumer();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Faddcustomer faddcustomer = new Faddcustomer();
            faddcustomer.ShowDialog();
            LoadListCustomer();
        }

        #endregion


    }
}
