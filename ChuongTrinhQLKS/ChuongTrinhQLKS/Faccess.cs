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
    public partial class Faccess : Form
    {
        HotelManagement db;
        public Faccess()
        {
            InitializeComponent();
        }
        #region methods
        private async void loadType()
        {
            db = linqConnect.GetDatabase();
            var listType = await(from u in db.STAFFTYPEs
                           select u).ToListAsync();
            cbType.DataSource = listType;
            cbType.DisplayMember = "Name";
            cbType.ValueMember = "ID";
            cbType.SelectedIndex = 0;
        }
        private async void LoadAccessNow()
        {
            dataGridViewAccessNow.Rows.Clear();
            db = linqConnect.GetDatabase();
                var listAccessNow = await (from j in db.Jobs
                                           join i in db.Accesses on j.ID equals i.IDJob
                                           join u in db.STAFFTYPEs on i.IDStaffType equals u.ID
                                           where i.IDStaffType == (int)cbType.SelectedValue
                                           select new
                                           {
                                               Name = j.Name,
                                               ID = j.ID
                                           }).ToListAsync();
                foreach (var item in listAccessNow)
                {
                    var index = dataGridViewAccessNow.Rows.Add();
                    dataGridViewAccessNow.Rows[index].Cells["colAccessNow"].Value = item.Name;
                    dataGridViewAccessNow.Rows[index].Cells["colIdNow"].Value = item.ID;
                }
            
        }
        private async void LoadAccessRest()
        {
            dataGridViewAccessRest.Rows.Clear();
            db = linqConnect.GetDatabase();
            var listAccessNow = await (from j in db.Jobs
                                       join i in db.Accesses on j.ID equals i.IDJob
                                       join u in db.STAFFTYPEs on i.IDStaffType equals u.ID
                                       where i.IDStaffType == (int)cbType.SelectedValue
                                       select new
                                       {
                                           Name = j.Name,
                                           ID = j.ID
                                       }).ToListAsync();
            var allJobs = await db.Jobs.ToListAsync();
            var listAccessRest = allJobs.Where(job => !listAccessNow.Any(accessedJob => accessedJob.ID == job.ID));
            foreach (var item in listAccessRest)
            {
                var index = dataGridViewAccessRest.Rows.Add();
                dataGridViewAccessRest.Rows[index].Cells["colNameRest"].Value = item.Name;
                dataGridViewAccessRest.Rows[index].Cells["colIdRest"].Value = item.ID;
            }
        }

        #endregion

        private void Faccess_Load(object sender, EventArgs e)
        {
            loadType();
            
        }

        private void btnGrant_Click(object sender, EventArgs e)
        {
            LoadAccessNow();
            LoadAccessRest();
            
        }

        private async void btnAddall_Click(object sender, EventArgs e)
        {
            db = linqConnect.GetDatabase();
            int idtype = (int)cbType.SelectedValue;
            foreach (DataGridViewRow row in dataGridViewAccessRest.Rows)
            {
                int idjob = Convert.ToInt32(row.Cells["colIdRest"].Value);
                var access = new Access()
                {
                    IDJob = idjob,
                    IDStaffType = idtype,
                    describe = "Access"
                };
                db.Accesses.Add(access);
                try
                {
                   await db.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error adding: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            btnGrant_Click(sender, e);
        }

        private async void btnEditall_Click(object sender, EventArgs e)
        {
            db = linqConnect.GetDatabase();

            int idtype = (int)cbType.SelectedValue;
            foreach (DataGridViewRow row in dataGridViewAccessNow.Rows)
            {
                int idjob = Convert.ToInt32(row.Cells["colIdNow"].Value);
                db.Accesses.RemoveRange(db.Accesses.Where(a => a.IDJob == idjob && a.IDStaffType == idtype));
                try
                {
                    await db.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error editing: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            btnGrant_Click(sender, e);
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            db = linqConnect.GetDatabase();
            int idtype = (int)cbType.SelectedValue;
            int idjob = Convert.ToInt32(dataGridViewAccessRest.CurrentRow.Cells["colIdRest"].Value);
            var access = new Access()
            {
                IDJob = idjob,
                IDStaffType = idtype,
                describe = "Access"
            };
            db.Accesses.Add(access);
            try
            {
                await db.SaveChangesAsync();
                btnGrant_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error adding: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            db = linqConnect.GetDatabase();
            int idtype = (int)cbType.SelectedValue;
            int idjob = Convert.ToInt32(dataGridViewAccessNow.CurrentRow.Cells["colIdNow"].Value);
            db.Accesses.RemoveRange(db.Accesses.Where(a => a.IDJob == idjob && a.IDStaffType == idtype));
            try
            {
                await db.SaveChangesAsync();
                btnGrant_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error editing: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private async void btnDelete_Click(object sender, EventArgs e)
        //{
        //    db = linqConnect.GetDatabase();
        //    if (dataGridViewAccessNow.SelectedRows.Count > 0)
        //    {
        //        MessageBox.Show("You are selecting the permissions that are currently in use. Please select from the remaining permissions list to make changes.", "Amount", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        dataGridViewAccessNow.ClearSelection();
        //    }
        //    if (dataGridViewAccessRest.SelectedRows.Count > 0)
        //    {
        //        foreach (DataGridViewRow row in dataGridViewAccessRest.SelectedRows)
        //        {                    
        //            int idjob = Convert.ToInt32(row.Cells["colIdRest"].Value);
        //            db.Accesses.RemoveRange(db.Accesses.Where(a => a.IDJob == idjob));
        //        }
        //        try
        //        {
        //            await db.SaveChangesAsync();
        //            btnGrant_Click(sender, e);
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("There was an error deleting: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //}
    }
    }

