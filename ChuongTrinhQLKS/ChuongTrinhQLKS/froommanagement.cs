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
    public partial class froommanagement : Form
    {
        HotelManagement dblinq;

        public froommanagement()
        {
            InitializeComponent();
        }

        private void Froommanagement_Load(object sender, EventArgs e)
        {
            LoadRoom();
            Loadcondition();
            Loadtyperoom();
            LoadlistRoom();
        }
        private async void SearchIDRoom()
        {
            dblinq = linqConnect.GetDatabase();
            var querySearchlist = await (from room in dblinq.ROOMs
                                         where room.ID.ToString() == txtFindID.Text
                                         select room.ID).FirstOrDefaultAsync();
            if(querySearchlist != 0)
            {
                cbIDRoom.SelectedValue = querySearchlist;
            } 
            else
            {
                MessageBox.Show("Pre-enter ID Room", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    

                                         
        }
        private async void Loadcondition()
        {
            dblinq = linqConnect.GetDatabase();
            var queryloadcondition = await (from loadcondition in dblinq.STATUSROOMs
                                            select loadcondition).ToListAsync();
            cbCondition.DataSource = queryloadcondition;
            cbCondition.DisplayMember = "Name";
            cbCondition.ValueMember = "ID";
            
        }


        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SearchIDRoom();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async void UpdateRoom()
        {
            int roomid = int.Parse(cbIDRoom.Text);
            dblinq = linqConnect.GetDatabase();
            var querySearchlist = await (from room in dblinq.ROOMs
                                         where room.ID == roomid
                                         select room).FirstOrDefaultAsync();


            if (querySearchlist != null)
            {
                querySearchlist.ID = int.Parse(cbIDRoom.Text);
                querySearchlist.Name = txtNameRoom.Text;
                querySearchlist.IDRoomType =int.Parse(cbTyperoom.SelectedValue.ToString());
                querySearchlist.IDStatusRoom = int.Parse(cbCondition.SelectedValue.ToString());
                try
                {
                    await dblinq.SaveChangesAsync();
                    MessageBox.Show("Room updated successfully.");
                    LoadRoom();
                    Loadcondition();
                    Loadtyperoom();
                    LoadlistRoom();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating room: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Room not found.");
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
          UpdateRoom();
        }
        private async void LoadRoom()
        {
            dblinq = linqConnect.GetDatabase();
            var Loadroom =await (from i in dblinq.ROOMs
                           select i).ToListAsync();
            cbIDRoom.DataSource = Loadroom;
            cbIDRoom.DisplayMember = "ID";
            cbIDRoom.ValueMember = "ID";
            cbIDRoom.SelectedIndexChanged += CbIDRoom_SelectedIndexChanged;
        }

        private void CbIDRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectRoom = (ROOM)cbIDRoom.SelectedItem;
            txtNameRoom.Text = selectRoom.Name.ToString();
            cbTyperoom.SelectedIndex = selectRoom.IDRoomType - 1;
            cbCondition.SelectedIndex = selectRoom.IDStatusRoom - 1;
            txtLimitsPerson.ReadOnly = true;
            txtPriceRoom.ReadOnly = true;
        }
        private async void Loadtyperoom()
        {
            dblinq = linqConnect.GetDatabase();
            var queryloadtyperoom = await (from loadtyperoom in dblinq.ROOMTYPEs
                                           select loadtyperoom).ToListAsync();
            cbTyperoom.DataSource = queryloadtyperoom;
            cbTyperoom.DisplayMember = "Name";
            cbTyperoom.ValueMember = "ID";
            cbTyperoom.SelectedIndexChanged += CbTyperoom_SelectedIndexChanged;

        }

        private void CbTyperoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectTyperoom = (ROOMTYPE)cbTyperoom.SelectedItem;
            txtPriceRoom.Text = selectTyperoom.Price.ToString();
            txtLimitsPerson.Text = selectTyperoom.LimitPerson.ToString();
        }
        private async void LoadlistRoom()
        {
            dblinq = linqConnect.GetDatabase();

            var queryListRoom = await (from room in dblinq.ROOMs
                                join roomtype in dblinq.ROOMTYPEs on room.IDRoomType equals roomtype.ID
                                join status in dblinq.STATUSROOMs on room.IDStatusRoom equals status.ID
                                select new
                                {
                                    IDRoom = room.ID,
                                    name = room.Name,
                                    nametype = roomtype.Name,
                                    price = roomtype.Price,
                                    limitperson = roomtype.LimitPerson,
                                    status = status.Name,
                                }).ToListAsync();
            dataGridViewRoom.DataSource = queryListRoom;
            dataGridViewRoom.SelectionChanged += DataGridViewRoom_SelectionChanged;
        }

        private void DataGridViewRoom_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewRoom.SelectedRows.Count > 0)
            {
                DataGridViewRow selectrow = dataGridViewRoom.SelectedRows[0];
                cbIDRoom.Text = selectrow.Cells["colIDRoom"].Value.ToString();
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Hide();
            fRoomtype fRoomtype = new fRoomtype();
            fRoomtype.ShowDialog(); 
            Show();
        }
    }
}
