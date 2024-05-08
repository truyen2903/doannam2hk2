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
    public partial class Fcheckout : Form
    {
        HotelManagement db;
        public Fcheckout()
        {
            InitializeComponent();
            LoadTypeService();
        }
        //private void LoadlistRoomBook()
        //{
        //    db = linqConnect.GetDatabase();
        //    void 
        //}
        private async void LoadTypeService()
        {
            db = linqConnect.GetDatabase();
            var ListType = await (from type in db.SERVICETYPEs
                           select type).ToListAsync();
            CbTypeSer.DataSource = ListType;
            CbTypeSer.DisplayMember = "Name";
            CbTypeSer.ValueMember = "ID";
            CbTypeSer.SelectedValueChanged += CbTypeSer_SelectedIndexChanged;      
        }

        private void CbTypeSer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
