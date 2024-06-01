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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ChuongTrinhQLKS
{
    public partial class fRoomtype : Form
    {
        HotelManagement dblinq;
        public fRoomtype()
        {
            InitializeComponent();
        }

        private async void LoadTypeRoom()
        {
            dblinq = linqConnect.GetDatabase();
            var queryloadtype = await (from typeroom in dblinq.ROOMTYPEs
                                select typeroom).ToListAsync();
            cbIDRoom.DataSource = queryloadtype;
            cbIDRoom.DisplayMember = "ID";
            cbIDRoom.ValueMember = "ID";
            cbIDRoom.SelectedIndexChanged += CbIDRoom_SelectedIndexChanged;
        }
        private async void LoadData()
        {
            dblinq = linqConnect.GetDatabase();
            var queryloadtype = await(from typeroom in dblinq.ROOMTYPEs
                                      select new
                                      {
                                          idroom = typeroom.ID,
#pragma warning disable IDE0037
                                          Name = typeroom.Name,
                                          Price = typeroom.Price,
                                          Limitperson = typeroom.LimitPerson,
                                      }).ToListAsync();
            dataGridViewRoom.DataSource = queryloadtype;
        }
        
        private void CbIDRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idroomlist = (ROOMTYPE)cbIDRoom.SelectedItem;
            txtPrice.Text = idroomlist.Price.ToString();
            txtNametype.Text =  idroomlist.Name.ToString();
            txtLimitPerson.Text = idroomlist.LimitPerson.ToString();
            txtLimitPerson.ReadOnly = true;
        }
        private async void Updatetype()
        {
            int typeid = int.Parse(cbIDRoom.Text);
            dblinq = linqConnect.GetDatabase();
            var queryloadtype = await (from typeroom in dblinq.ROOMTYPEs
                                       where typeroom.ID == typeid
                                       select typeroom).FirstOrDefaultAsync();
            if (queryloadtype != null)
            {
                queryloadtype.ID = int.Parse(cbIDRoom.Text);
                queryloadtype.Name = txtNametype.Text;
                queryloadtype.LimitPerson = int.Parse( txtLimitPerson.Text);
                queryloadtype.Price = int.Parse( txtPrice.Text);

                try
                {
                    await dblinq.SaveChangesAsync();
                    MessageBox.Show("SUCCESSFUL UPDATE", "Announcement",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTypeRoom();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erorr"+ ex, "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void FRoomtype_Load(object sender, EventArgs e)
        {
            LoadTypeRoom();
            LoadData();
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Updatetype();
            LoadData();
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async void Search()
        {
            LoadTypeRoom();
            int id = int.Parse(txtFind.Text);
            dblinq = linqConnect.GetDatabase();
            var queryloadtype = await (from typeroom in dblinq.ROOMTYPEs
                                       where typeroom.ID ==  id
                                       select typeroom.ID).FirstOrDefaultAsync();
            if (queryloadtype != 0)
            {
                cbIDRoom.SelectedValue = queryloadtype;
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        
    }
}
