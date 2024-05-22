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

namespace ChuongTrinhQLKS
{
    public partial class Faddemploy : Form
    {
        HotelManagement dblinq;
        public Faddemploy()
        {
            InitializeComponent();
            LoadType();
        }
        #region load
        private async void LoadType()
        {
            dblinq = linqConnect.GetDatabase();
            var type = await (from t in dblinq.STAFFTYPEs select t).ToListAsync();
            cbType.DataSource = type;
            cbType.DisplayMember = "Name";
            cbType.ValueMember = "ID";
        }
        #endregion
        #region add
        private async void addemploy()
        {
            dblinq = linqConnect.GetDatabase();
            var newstaff = new STAFF()
            {
                UserName = txtUsername.Text,
                DisplayName = txtname.Text,
                PassWord = "123456",
                IDStaffType = int.Parse(cbType.SelectedValue.ToString()),
                PhoneNumber = int.Parse(txtNumberPhone.Text),
                Address = txtAddress.Text,
                IDCard = txtIDCard.Text,
                DateOfBirth = DateTimeBirthday.Value,
                StartDay = DateTimeStart.Value,
                Sex= txtSex.Text
            };
            dblinq.STAFFs.Add(newstaff);
            try
            {
                await dblinq.SaveChangesAsync();
                MessageBox.Show("Add success");
            }
            catch(Exception ex)
            {
                MessageBox.Show("There was an error while adding" + ex,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        #endregion
        #region click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "" || txtname.Text == "" || txtNumberPhone.Text == "" || txtAddress.Text == "" || txtIDCard.Text == "" || txtSex.Text == "")
            {
                MessageBox.Show("Please fill in all the information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            addemploy();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


    }
}
