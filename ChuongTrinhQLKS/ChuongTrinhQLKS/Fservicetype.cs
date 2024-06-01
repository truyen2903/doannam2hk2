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

namespace ChuongTrinhQLKS
{
    public partial class Fservicetype : Form
    {
        HotelManagement db;
        public Fservicetype()
        {
            InitializeComponent();
        }
        #region events
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            db = linqConnect.GetDatabase();
            var servicetype = new SERVICETYPE
            {
                Name = txtname.Text
            };
            db.SERVICETYPEs.Add(servicetype);
            try
            {
                await db.SaveChangesAsync();
                MessageBox.Show("Add success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
        #endregion


    }
}
