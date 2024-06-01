using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChuongTrinhQLKS.Models;
using Guna.UI2.WinForms.Enums;

namespace ChuongTrinhQLKS
{
    public partial class Faddcustomer : Form
    {
        HotelManagement db;
        public Faddcustomer()
        {
            InitializeComponent();
            LoadCustomerType();
        }
        #region Methods
        private async void AddCustomer()
        {
            using (db = linqConnect.GetDatabase())
            {
                var customer = new CUSTOMER
                {
                    Name = txtName.Text,
                    Address = txtAddress.Text,
                    PhoneNumber = int.Parse(txtPhone.Text),
                    IDCard = txtIDcard.Text,
                    Nationality = txtNationnality.Text,
                    IDCustomerType = (int)CbType.SelectedValue
                };
                db.CUSTOMERs.Add(customer);
                try
                {
                    await db.SaveChangesAsync();
                    MessageBox.Show("Add customer successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }

            }
        }
        private void LoadCustomerType()
        {
            using (db = linqConnect.GetDatabase())
            {
                CbType.DataSource = db.CUSTOMERTYPEs.ToList();
                CbType.DisplayMember = "Name";
                CbType.ValueMember = "ID";
            }
        }
        private void ResetForm()
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtIDcard.Text = "";
            txtNationnality.Text = "";
        }
        #endregion
        #region click event
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtAddress.Text == "" || txtPhone.Text == "" || txtIDcard.Text == "" || txtNationnality.Text == "")
            {
                MessageBox.Show("Please fill all fields");
            }
            else
            {
                AddCustomer();
                ResetForm();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


    }
}
