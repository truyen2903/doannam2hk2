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
using static ChuongTrinhQLKS.Program;

namespace ChuongTrinhQLKS
{
    public partial class Fsevice : Form
    {
        HotelManagement db;
        string Username = GlobalVariables.LoggedInUsername;
        public Fsevice()
        {
            InitializeComponent();
            txtID.ReadOnly = true;
            LoadListService();
            LoadType();
        }
        #region methods
        private void LoadListService()
        {
            dataGridViewService.Rows.Clear();
            db = linqConnect.GetDatabase();
            var listService = from i in db.SERVICEs
                              join j in db.SERVICETYPEs on i.IDServiceType equals j.ID
                              select new
                              {
                                  Name = i.Name,
                                  Price = i.Price,
                                  Type = j.Name,
                                  ID = i.ID,
                                  IdType = j.ID
                              };
            foreach (var item in listService)
            {
                var index = dataGridViewService.Rows.Add();
                dataGridViewService.Rows[index].Cells["colID"].Value = item.ID;
                dataGridViewService.Rows[index].Cells["colName"].Value = item.Name;
                dataGridViewService.Rows[index].Cells["colPrice"].Value = item.Price;
                dataGridViewService.Rows[index].Cells["colNameType"].Value = item.Type;
                dataGridViewService.Rows[index].Cells["colIdServiceType"].Value = item.IdType;
            }
        }
        private async void LoadType()
        {
            db = linqConnect.GetDatabase();
            var listType = await (from i in db.SERVICETYPEs
                                  select i).ToListAsync();
            cbType.DataSource = listType;
            cbType.DisplayMember = "Name";
            cbType.ValueMember = "ID";
        }
        private void Clear()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            cbType.SelectedIndex = 0;
        }
        #endregion
        #region events
        private void dataGridViewService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewService.Rows.Count)
            {
                DataGridViewRow row = dataGridViewService.Rows[e.RowIndex];
                txtID.Text = row.Cells["colID"].Value.ToString();
                txtName.Text = row.Cells["colName"].Value.ToString();
                txtPrice.Text = row.Cells["colPrice"].Value.ToString();
                cbType.SelectedValue = row.Cells["colIdServiceType"].Value;
            }
        }
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            db = linqConnect.GetDatabase();
            var listService = await (from i in db.SERVICEs
                                     join j in db.SERVICETYPEs on i.IDServiceType equals j.ID
                                     where i.Name.Contains(txtSearch.Text)
                                     select new
                                     {
                                         Name = i.Name,
                                         Price = i.Price,
                                         ID = i.ID,
                                         IdType = j.ID
                                     }).FirstOrDefaultAsync();
            if (listService != null)
            {
                txtID.Text = listService.ID.ToString();
                txtName.Text = listService.Name;
                txtPrice.Text = listService.Price.ToString();
                cbType.SelectedValue = listService.IdType;
            }
            else
            {
                var listServices = await (from i in db.SERVICEs
                                          join j in db.SERVICETYPEs on i.IDServiceType equals j.ID
                                          where i.ID.ToString().Contains(txtSearch.Text)
                                          select new
                                          {
                                              Name = i.Name,
                                              Price = i.Price,
                                              ID = i.ID,
                                              IdType = j.ID
                                          }).FirstOrDefaultAsync();
                if (listServices != null)
                {
                    txtID.Text = listServices.ID.ToString();
                    txtName.Text = listServices.Name;
                    txtPrice.Text = listServices.Price.ToString();
                    cbType.SelectedValue = listServices.IdType;
                }
                else
                {
                    MessageBox.Show("Service not found");
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" && txtPrice.Text == "")
            {
                MessageBox.Show("Please enter full information");
                return;
            }
            db = linqConnect.GetDatabase();
            var service = new SERVICE()
            {
                ID = int.Parse(txtID.Text),
                Name = txtName.Text,
                Price = int.Parse(txtPrice.Text),
                IDServiceType = (int)cbType.SelectedValue
            };
            db.SERVICEs.Add(service);
            try
            {
                await db.SaveChangesAsync();
                MessageBox.Show("Add success");
                LoadListService();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add fail" + ex, "Errorr");
            }
        }
        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" && txtName.Text == "" && txtPrice.Text == "")
            {
                MessageBox.Show("Please select a service to update");
                return;
            }
            db = linqConnect.GetDatabase();
            var service = await (from i in db.SERVICEs
                                 where i.ID.ToString().Contains(txtID.Text)
                                 select i).FirstOrDefaultAsync();
            if (service != null)
            {
                service.Name = txtName.Text;
                service.Price = int.Parse(txtPrice.Text);
                service.IDServiceType = (int)cbType.SelectedValue;
                try
                {
                    await db.SaveChangesAsync();
                    MessageBox.Show("Update success");
                    LoadListService();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update fail" + ex, "Errorr");
                }
            }
            else
            {
                MessageBox.Show("Service not found");
            }      
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(Check.CheckAccess("Fservicetypemanagement", Username))
            {
                Fservicetypemanagement fservicetypemanagement = new Fservicetypemanagement();
                fservicetypemanagement.ShowDialog();
            }
            else
            {
                MessageBox.Show("You do not have permission to access this feature");
            }
            
        }
        #endregion





    }
}
