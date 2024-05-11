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
    public partial class Fprintbill : Form
    {
        HotelManagement db;
        public Fprintbill(int idbill)
        {
            InitializeComponent();
            int IDbill = idbill;
            LoadInfor(IDbill);
            LoadListService(IDbill);
        }
        private async void LoadInfor(int IDbill)
        {
            db = linqConnect.GetDatabase();
            var ListInfor = await (from bill in db.BILLs
                            join receiver in db.RECEIVEROOMs on bill.IDReceiveRoom equals receiver.ID
                            join room in db.ROOMs on receiver.IDRoom equals room.ID
                            join roomtype in db.ROOMTYPEs on room.IDRoomType equals roomtype.ID
                            join bookroom in db.BOOKROOMs on receiver.IDBookRoom equals bookroom.ID
                            join customer in db.CUSTOMERs on bookroom.IDCustomer equals customer.ID
                            join customertype in db.CUSTOMERTYPEs on customer.IDCustomerType equals customertype.ID
                            where bill.ID == IDbill
                            where bill.IDStatusBill == 2
                            select new
                            {
                                IDbill = bill.ID,
                                StaffSetUp = bill.StaffSetUp,
                                DateCreate = bill.DateOfCreate,
                                CustomerName = customer.Name,
                                CMND = customer.IDCard,
                                CustomerType = customertype.Name,
                                Address = customer.Address,
                                Nationality = customer.Nationality,
                                NameRoom = room.Name,
                                RoomType = roomtype.Name,
                                Price = roomtype.Price,
                                DateCheckin = bookroom.DateCheckIn,
                                DateCheckout = bookroom.DateCheckOut,
                                NumberPeople = roomtype.LimitPerson,
                                Surcharge = bill.Surcharge,
                                TotalPrice = bill.TotalPrice,
                                Discount = bill.Discount,
                                ServicePrice = bill.ServicePrice
                            }).FirstOrDefaultAsync();
            if(ListInfor != null)
            {
                lblIDBill.Text = ListInfor.IDbill.ToString();
                lblStaffSetUp.Text = ListInfor.StaffSetUp.ToString();
                lblDateCreate.Text = ListInfor.DateCreate.ToString();
                lblCustomerName.Text = ListInfor.CustomerName.ToString();
                lblIDCard.Text = ListInfor.CMND.ToString();
                lblCustomerTypeName.Text = ListInfor.CustomerType.ToString();
                lblAddress.Text = ListInfor.Address.ToString();
                lblNationality.Text = ListInfor.Nationality.ToString();
                lblRoomName.Text = ListInfor.NameRoom.ToString();
                lblRoomTypeName.Text = ListInfor.RoomType.ToString();
                lblRoomPrice_.Text = ListInfor.Price.ToString();
                lblDateCheckIn.Text = ListInfor.DateCheckin.ToString();
                TimeSpan daysDifference = ListInfor.DateCheckout - ListInfor.DateCheckin;
                int days = (int)Math.Ceiling(daysDifference.TotalDays);
                lblDays.Text = days.ToString();
                lblPeoples.Text = ListInfor.NumberPeople.ToString();
                lblRoomPrice.Text = ListInfor.Price.ToString();
                lblSurcharge.Text = ListInfor.Surcharge.ToString();
                lblServicePrice.Text = ListInfor.ServicePrice.ToString();
                lblTotalPrice.Text = ListInfor.TotalPrice.ToString();
                lblDiscount.Text = ListInfor.Discount.ToString();
                int Discount = ListInfor.Discount;
                int TotalPrice = ListInfor.TotalPrice;
                int FinalPrice = TotalPrice - (Discount * TotalPrice) / 10;
                lblFinalPrice.Text = FinalPrice.ToString();
            }
            else
            {
                MessageBox.Show("There was an error " , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private async void LoadListService(int IDbill)
        {
            
            db = linqConnect.GetDatabase();
            var ListService = await (from i in db.BILLDETAILS
                                     join j in db.SERVICEs on i.IDService equals j.ID
                                     where i.IDBill == IDbill
                                     select new
                                     {
                                         Name = j.Name,
                                         Count = i.Count,
                                         Price = j.Price
                                     }).ToListAsync();
            int totalBill = 0;
            listViewUseService.Items.Clear();
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
                cout++;
            }
            ListViewItem totalItem = new ListViewItem(new string[]
               {
                     "",
                     "",
                     "",
                    "Total:",
                    totalBill.ToString()

        });
            listViewUseService.Items.Add(totalItem);

        }

        private void Btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
