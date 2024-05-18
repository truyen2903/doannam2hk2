using ChuongTrinhQLKS.Models;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace ChuongTrinhQLKS
{
    public partial class Fcheck_in : Form
    {
        HotelManagement dblinq;
        public Fcheck_in()
        {
            InitializeComponent();
        }
        private async void LoadTypeRoom()
        {
            dblinq = linqConnect.GetDatabase();
            var typeroom = await (from type in dblinq.ROOMTYPEs
                                  select type).ToListAsync();
            CbTyroom.DataSource = typeroom;
            CbTyroom.DisplayMember = "Name";
            CbTyroom.ValueMember = "ID";
            CbTyroom.SelectedIndex = 0;
            CbTyroom.SelectedIndexChanged += CbTyroom_SelectedIndexChanged;
            LoadRoom();
        }

        private async void LoadRoom()
        {
            int id = 1;
            if (CbTyroom.SelectedValue != null)
            {
                if (int.TryParse(CbTyroom.SelectedValue.ToString(), out int parsedId))
                {
                    id = parsedId;
                }
            }

            dblinq = linqConnect.GetDatabase();
            var roomList = await (from room in dblinq.ROOMs
                                  where room.IDRoomType == id
                                  where room.IDStatusRoom == 1 
                                  select room).ToListAsync();
            CbRoom.DataSource = roomList;
            CbRoom.DisplayMember = "Name";
            CbRoom.ValueMember = "ID";
            CbRoom.SelectedIndexChanged += CbRoom_SelectedIndexChanged;
        }

        private void Fcheck_in_Load(object sender, EventArgs e)
        {
            TxtRoomType.ReadOnly = true;
            TxtCheckinDay.ReadOnly = true;
            Txtcard.ReadOnly = true;
            TxtCheckoutDay.ReadOnly = true;
            TxtLimitsPerson.ReadOnly = true;
            TxtName.ReadOnly = true;
            TxtPrice.ReadOnly = true;
            TxtNameRoom.ReadOnly = true;
            LoadTypeRoom();
            LoadCheckinDay();
        }

        private void CbTyroom_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRoom();
            var type = (ROOMTYPE)CbTyroom.SelectedItem;
            TxtRoomType.Text = type.Name.ToString();
            TxtRoomType.ReadOnly = true;
        }

        private void CbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbRoom.SelectedItem != null)
            {
                var room = (ROOM)CbRoom.SelectedItem;
                TxtNameRoom.Text = room.Name.ToString();
                TxtNameRoom.ReadOnly = true;
            }
            else
            {
                TxtNameRoom.Text = string.Empty;
            } 
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            TxtName.Text = Txtcard.Text = TxtCheckinDay.Text = TxtCheckoutDay.Text = TxtLimitsPerson.Text = TxtPrice.Text  = string.Empty;
        }
        private async void SearchID()
        {
            int idbookroom = int.Parse(TxtFind.Text);
            dblinq = linqConnect.GetDatabase();
            var check = await (from i in dblinq.RECEIVEROOMs
                        where i.IDBookRoom == idbookroom
                        select i).FirstOrDefaultAsync();
            if (check == null) 
            { 
                var checkin = await (from bookroom in dblinq.BOOKROOMs
                                 join customer in dblinq.CUSTOMERs on bookroom.IDCustomer equals customer.ID
                                 join typeroom in dblinq.ROOMTYPEs on bookroom.IDRoomType equals typeroom.ID
                                 where bookroom.ID == idbookroom
                                 where bookroom.DateCheckIn == DbFunctions.TruncateTime(DateTime.Now)
                                 select new
                                 {
                                     Namecustumer = customer.Name,
                                     idCard = customer.IDCard,
                                     typeroom = typeroom.Name,
                                     limitsperson = typeroom.LimitPerson,
                                     price = typeroom.Price,
                                     datecheckin = bookroom.DateCheckIn,
                                     datecheckout = bookroom.DateCheckOut,
                                 }).FirstOrDefaultAsync();
                if (checkin != null)
                {
                TxtName.Text = checkin.Namecustumer;
                Txtcard.Text = checkin.idCard;
                TxtCheckinDay.Text= checkin.datecheckin.ToString();
                TxtCheckoutDay.Text= checkin.datecheckout.ToString();
                TxtLimitsPerson.Text = checkin.limitsperson.ToString();
                TxtPrice.Text = checkin.price.ToString();
                CbTyroom.Text = checkin.typeroom;
                }
                else
                {
                MessageBox.Show("Please re-enter ID Bookroom", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtFind.Text = string.Empty;
                TxtFind.Focus();
                }

            }
            else
            {
                MessageBox.Show("Please re-enter ID Bookroom", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtFind.Text = string.Empty;
                TxtFind.Focus();
            }    
        }
        private async void Checkin()
        {
            if(TxtName.Text != string.Empty && TxtFind.Text !=string.Empty && TxtNameRoom.Text != string.Empty) 
            { 
                int IDROOM = int.Parse(CbRoom.SelectedValue.ToString());
                dblinq = linqConnect.GetDatabase();
                var NewReceiveroom = new RECEIVEROOM
                {
                IDBookRoom = int.Parse(TxtFind.Text),
                IDRoom = IDROOM,
                };
                dblinq.RECEIVEROOMs.Add(NewReceiveroom);
                try
                {
                await dblinq.SaveChangesAsync();
                Restatus(IDROOM);
                MessageBox.Show("Add Set Success.", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch(Exception ex)
                {
                MessageBox.Show("There was an error adding: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter complete information", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }
        private async void Restatus(int idroom)
        {
            
                var Room = await (from room in dblinq.ROOMs
                                    where room.ID == idroom
                                    select room).FirstOrDefaultAsync();
                if (Room != null)
                {
                    Room.IDStatusRoom = 4; 
                }
            try
            {
                await dblinq.SaveChangesAsync();
                TxtFind.Text = Txtcard.Text = TxtCheckinDay.Text = TxtCheckoutDay.Text = TxtLimitsPerson.Text = TxtName.Text = TxtNameRoom.Text = TxtPrice.Text = string.Empty;
                LoadCheckinDay();
                LoadTypeRoom();
            }
            catch(Exception ex)
            {
                MessageBox.Show("There is an error when correcting the room status" + ex, "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void LoadCheckinDay()
        {
            dblinq = linqConnect.GetDatabase();
            var listCheckin = await (from checkin in dblinq.RECEIVEROOMs
                              join room in dblinq.ROOMs on checkin.IDRoom equals room.ID
                              join bookroom in dblinq.BOOKROOMs on checkin.IDBookRoom equals bookroom.ID
                              join customer in dblinq.CUSTOMERs on bookroom.IDCustomer equals customer.ID
                              where bookroom.DateCheckIn == DbFunctions.TruncateTime(DateTime.Now)
                              select new
                              {
                                  ID = checkin.ID,
                                  NameCustomer = customer.Name,
                                  IDcard = customer.IDCard,
                                  NameRoom = room.Name,
                                  Datecheckin = bookroom.DateCheckIn.ToString(),
                                  datecheckout = bookroom.DateCheckOut.ToString(),
                              }).ToListAsync();
            dataGridViewReceiveRoom.DataSource = listCheckin;
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SearchID();
        }

        private void BtnCheckin_Click(object sender, EventArgs e)
        {
            Checkin();
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
