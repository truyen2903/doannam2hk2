using ChuongTrinhQLKS.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using static ChuongTrinhQLKS.Program;

namespace ChuongTrinhQLKS
{
   
    public partial class Fcheckout : Form
    {
        string username = GlobalVariables.LoggedInUsername;
        HotelManagement db;
        int? idbill = null;
        public Fcheckout()
        {
            InitializeComponent();
            LoadTypeService();
            LoadlistRoomBook();
            LoadSurcharge();
        }
        private async void LoadlistRoomBook()
        {
            db = linqConnect.GetDatabase();
            var listCheckin = await (from checkin in db.RECEIVEROOMs
                                     join bookroom in db.BOOKROOMs on checkin.IDBookRoom equals bookroom.ID
                                     join room in db.ROOMs on checkin.IDRoom equals room.ID
                                     join typeroom in db.ROOMTYPEs on bookroom.IDRoomType equals typeroom.ID
                                     where !(from bill in db.BILLs where bill.IDStatusBill == 2 select bill.IDReceiveRoom).Contains(checkin.ID)
                                     select new
                                     {
                                         IDReceive= checkin.ID,
                                         NameRoom = room.Name,
                                         RoomTypeID = typeroom.ID,
                                         Price = typeroom.Price,
                                         dateCheckin = bookroom.DateCheckIn,
                                         datecheckout = bookroom.DateCheckOut,
                                     }).ToListAsync();
            flowLayoutRooms.Controls.Clear();
            foreach (var item in listCheckin)
            {
                Button roomButton = new Button
                {
                    Text = item.NameRoom.ToString(),
                    Size = new Size(70, 70),
                    Tag = item,
                };
                if (item.RoomTypeID == 1) 
                {
                    roomButton.BackColor = Color.Violet;
                }
                else if (item.RoomTypeID == 2)
                {
                    roomButton.BackColor = Color.BurlyWood;
                }
                roomButton.Click += RoomButton_Click;
                flowLayoutRooms.Controls.Add(roomButton);
            }
        }
        private async void RoomButton_Click(object sender, EventArgs e)
        {
            var surcharge = 0;
            var totalMoney = 0;
            db = linqConnect.GetDatabase();
            var paramer = await (from j in db.PARAMETERs
                                 select j.Value).FirstOrDefaultAsync();
            Button clickedButton = (Button)sender;
            listViewBillRoom.Items.Clear();
            var roomInfo = (dynamic)clickedButton.Tag;
            surcharge = CalculateSurcharge(roomInfo, paramer);
            totalMoney = CalculateTotalMoney(roomInfo, surcharge);
            AddRoomToListView(roomInfo, surcharge, totalMoney,clickedButton);
            UpdateButtonColors(clickedButton);
            await CreateBillIfNotExists(roomInfo);
        }

        private int CalculateSurcharge(dynamic roomInfo, double paramer)
        {
            if (roomInfo.RoomTypeID == 1)
            {
                return (int)(roomInfo.Price * paramer);
            }
            return 0;
        }

        private int CalculateTotalMoney(dynamic roomInfo, int surcharge)
        {
            return surcharge + roomInfo.Price;
        }

        private void AddRoomToListView(dynamic roomInfo, int surcharge, int totalMoney, Button clickedButton)
        {
            ListViewItem item = new ListViewItem(new string[]
            {
                roomInfo.NameRoom.ToString(),
                roomInfo.Price.ToString("c0", new CultureInfo("vi-VN")),
                roomInfo.dateCheckin.ToString("dd/MM/yyyy"),
                roomInfo.datecheckout.ToString("dd/MM/yyyy"),
                roomInfo.Price.ToString("c0", new CultureInfo("vi-VN")),
                surcharge.ToString("c0", new CultureInfo("vi-VN")),
                totalMoney.ToString("c0", new CultureInfo("vi-VN"))
            });

                listViewBillRoom.Items.Add(item);
                clickedButton.BackColor = Color.SeaGreen;
        }

        private void UpdateButtonColors(Button clickedButton)
        {
            foreach (Control control in flowLayoutRooms.Controls)
            {
                if (control is Button button && button != clickedButton)
                {
                    var tag = (dynamic)button.Tag;
                    if (tag.RoomTypeID == 1)
                    {
                        button.BackColor = System.Drawing.Color.Violet;
                    }
                    else if (tag.RoomTypeID == 2)
                    {
                        button.BackColor = System.Drawing.Color.BurlyWood;
                    }
                }
            }
        }

        private async Task CreateBillIfNotExists(dynamic roomInfo)
        {
            int id = Convert.ToInt32(roomInfo.IDReceive);
            var checkBill = await (from i in db.BILLs
                                   where i.IDReceiveRoom == id
                                   select i).FirstOrDefaultAsync();

            if (checkBill == null)
            {
                var newBill = new BILL
                {
                    IDReceiveRoom = roomInfo.IDReceive,
                    StaffSetUp = username,
                    DateOfCreate = DateTime.Now,
                    RoomPrice = roomInfo.Price,
                    ServicePrice = 0,
                    Surcharge = 0,
                    TotalPrice = 0,
                    Discount = 0,
                    IDStatusBill = 1,
                };
                db.BILLs.Add(newBill);
                try
                {
                    await db.SaveChangesAsync();
                    idbill = newBill.ID;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error add " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                idbill = checkBill.ID;
            }    
        }
        private async void AddService()
        {
            if (idbill != null)
            {
                db = linqConnect.GetDatabase();
                int IDBill = int.Parse(idbill.ToString());
                int cout = int.Parse(numericUpDownCount.Value.ToString());
                int IDService = int.Parse(CbService.SelectedValue.ToString());
                int price = int.Parse(TxtPrice.Text.ToString());
                var check = await (from i in db.BILLDETAILS
                            where i.IDBill == IDBill
                            where i.IDService == IDService
                            select i).FirstOrDefaultAsync();
                if (check == null) 
                { 
                    var BILLDETAIL = new BILLDETAIL
                    {
                        IDBill = IDBill,
                        IDService = IDService,
                        Count = cout,
                        TotalPrice =  cout * price
                    };
                    db.BILLDETAILS.Add(BILLDETAIL);
                    try
                    {
                        await db.SaveChangesAsync();
                        LoadListService();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("There was an error adding " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    check.Count += cout;
                    check.TotalPrice += cout * price;
                    try
                    {
                        await db.SaveChangesAsync();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("There was an error while editing" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a room to add services", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void LoadListService()
        {
            int IDBill = int.Parse(idbill.ToString());
            db = linqConnect.GetDatabase();
            var ListService = await (from i in db.BILLDETAILS
                                     join j in db.SERVICEs on i.IDService equals j.ID
                                     where i.IDBill == IDBill
                                     select new
                                     {
                                         Name = j.Name,
                                         Count = i.Count,
                                         Price = j.Price
                                     }).ToListAsync();
            int totalBill = 0;

            foreach (var list in ListService)
            {
                int cout = 1;
                int serviceTotal = list.Count * list.Price; 
                totalBill += serviceTotal;
                ListViewItem item = new ListViewItem(new string[]
                {
                    cout.ToString(),
                    list.Name,
                    list.Price.ToString(),
                    list.Count.ToString(),
                    serviceTotal.ToString()
                });
                listViewUseService.Items.Add(item);
                ListViewItem totalItem = new ListViewItem(new string[]
                {
                     "", 
                     "",
                     "",
                    "Total:",
                    totalBill.ToString() 
                });
      
                listViewBillRoom.Items.Add(totalItem);
                cout++;
            }
        }
        private async void LoadSurcharge()
        {
            int count = 1;
            db = linqConnect.GetDatabase();
            var listSurcharge = await (from i in db.PARAMETERs
                                select i).ToListAsync();
            foreach ( var item in listSurcharge )
            {
                ListViewItem i = new ListViewItem(new string[]
                {
                    count.ToString(),
                    item.Name,
                    item.Value.ToString(),
                    item.Describe,
                });
                listView.Items.Add(i);
                count++;
            }
        }
        
        private async void LoadTypeService()
        {
            db = linqConnect.GetDatabase();
            var ListType = await (from type in db.SERVICETYPEs
                           select type).ToListAsync();
            CbTypeSer.DataSource = ListType;
            CbTypeSer.DisplayMember = "Name";
            CbTypeSer.ValueMember = "ID";
            CbTypeSer.SelectedValueChanged += CbTypeSer_SelectedIndexChanged;  
            LoadService();
        }
        private async void LoadService()
        {
            int id = 1;
            if (CbTypeSer.SelectedValue != null)
            {
                if (int.TryParse(CbTypeSer.SelectedValue.ToString(), out int parsedId))
                {
                    id = parsedId;
                }
            }
            db = linqConnect.GetDatabase();
            var listService = await (from service in db.SERVICEs
                              where service.IDServiceType == id
                              select service).ToListAsync();
            CbService.DataSource = listService;
            CbService.DisplayMember = "Name";
            CbService.ValueMember = "ID";
            CbService.SelectedValueChanged += CbService_SelectedIndexChanged;

        }
        
        private void CbTypeSer_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadService();
        }

        private void CbService_SelectedIndexChanged(object sender, EventArgs e)
        {
            var service = (SERVICE)CbService.SelectedItem;
            TxtPrice.Text = service.Price.ToString();
            TxtPrice.ReadOnly = true;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddService();
        }
    }
}
