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
using ChuongTrinhQLKS.Models;

namespace ChuongTrinhQLKS
{
    public partial class Fservicetypemanagement : Form
    {
        HotelManagement db;
        public Fservicetypemanagement()
        {
            InitializeComponent();
            LoadListServiceType();
        }
        #region methods
        private async void LoadListServiceType()
        {
            dataGridViewServiceType.Rows.Clear();
            db = linqConnect.GetDatabase();
            var listServiceType = await(from i in db.SERVICETYPEs
                                  select i).ToListAsync();
                                  
            foreach (var item in listServiceType)
            {
                var index = dataGridViewServiceType.Rows.Add();
                dataGridViewServiceType.Rows[index].Cells["colID"].Value = item.ID;
                dataGridViewServiceType.Rows[index].Cells["colName"].Value = item.Name;
            }
        }
        #endregion

        #region events
        private void dataGridViewServiceType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewServiceType.Rows.Count)
            {
                DataGridViewRow row = dataGridViewServiceType.Rows[e.RowIndex];
                txtID.Text = row.Cells["colID"].Value.ToString();
                txtName.Text = row.Cells["colName"].Value.ToString();
            }
        }
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            db = linqConnect.GetDatabase();
            var listServiceType = await (from i in db.SERVICETYPEs
                                  where i.Name.Contains(txtSearch.Text)
                                  select i).FirstOrDefaultAsync();
            if (listServiceType != null)
            {
                txtID.Text = listServiceType.ID.ToString();
                txtName.Text = listServiceType.Name;
            }
            else
            {
                var listServiceTypes = await (from i in db.SERVICETYPEs
                                             where i.ID.ToString().Contains(txtSearch.Text)
                                             select i).FirstOrDefaultAsync();
                if (listServiceTypes != null)
                {
                    txtID.Text = listServiceTypes.ID.ToString();
                    txtName.Text = listServiceTypes.Name;
                }
                else
                {
                    MessageBox.Show("No data found!");
                }
            }
        }
        private async void btnEdit_Click(object sender, EventArgs e)
        {
            db = linqConnect.GetDatabase();
            var id = int.Parse(txtID.Text);
            var servicetype = await (from i in db.SERVICETYPEs
                              where i.ID == id
                              select i).FirstOrDefaultAsync();
            if(servicetype != null)
            {
                servicetype.Name = txtName.Text;
                try
                {
                    await db.SaveChangesAsync();
                    MessageBox.Show("Edit success!");
                    LoadListServiceType();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Errorr: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No data found!");
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Fservicetype f = new Fservicetype();
            f.ShowDialog();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


    }
}
