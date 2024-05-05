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
    public partial class Faddrom : Form
    {
        HotelManagement dblinq;
        public Faddrom()
        {
            InitializeComponent();
        }
        private async void Loadtyperoom()
        {
            dblinq = linqConnect.GetDatabase();
            var queryloadtyperoom = await (from loadtyperoom in dblinq.ROOMTYPEs
                                           select loadtyperoom).ToListAsync();
            cbType.DataSource = queryloadtyperoom;
            cbType.DisplayMember = "Name";
            cbType.ValueMember = "ID";
            cbType.SelectedIndexChanged += cbType_SelectedIndexChanged;

        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectTyperoom = (ROOMTYPE)cbType.SelectedItem;
            txtPrice.Text = selectTyperoom.Price.ToString();
            txtLimitperson.Text = selectTyperoom.LimitPerson.ToString();
        }

        private void Faddrom_Load(object sender, EventArgs e)
        {
            Loadtyperoom();
        }
        private async void Addroom()
        {
            dblinq = linqConnect.GetDatabase();
            var newRoom = new ROOM
            {
                Name = txtName.Text,
                IDStatusRoom = 1,
                IDRoomType = int.Parse(cbType.SelectedValue.ToString()),
            };
            dblinq.ROOMs.Add(newRoom);
            try
            {
                await dblinq.SaveChangesAsync();
                MessageBox.Show("Add Set Success.", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Text = string.Empty;
                Loadtyperoom();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error adding: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Addroom();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
