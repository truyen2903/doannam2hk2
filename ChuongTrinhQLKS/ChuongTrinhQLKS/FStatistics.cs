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
    
    public partial class FStatistics : Form
    {
        HotelManagement db;
        public FStatistics()
        {
            InitializeComponent();
        }

        private async void btnView_Click(object sender, EventArgs e)
        {
            //db = linqConnect.GetDatabase();
            //int month = int.Parse( cbMonth.Text);
            //int Year = (int)numericYear.Value;
            //var listCheckin = await(from checkin in db.RECEIVEROOMs
            //                        join bookroom in db.BOOKROOMs on checkin.IDBookRoom equals bookroom.ID
            //                        join room in db.ROOMs on checkin.IDRoom equals room.ID
            //                        join typeroom in db.ROOMTYPEs on bookroom.IDRoomType equals typeroom.ID
            //                        where !(from bill in db.BILLs where bill.IDStatusBill == 1 select bill.IDReceiveRoom).Contains(checkin.ID)
            //                        where checkin.
            //                        select new {                                                                         
            //                            RoomTypeID = typeroom.ID,
             
            //                            dateCheckin = bookroom.DateCheckIn,
            //                            datecheckout = bookroom.DateCheckOut,
            //                        }).ToListAsync();


        }
    }
}
