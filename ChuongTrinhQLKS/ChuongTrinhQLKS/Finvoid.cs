using ChuongTrinhQLKS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using System.Data;
namespace ChuongTrinhQLKS
{
    public partial class Finvoid : Form
    {
        HotelManagement db;

        public Finvoid()
        {
            InitializeComponent();
            loadID();
            loadListBill();
        }

        #region methods

        private async void loadID()
        {
            try
            {
                db = linqConnect.GetDatabase();
                var ID = await (from i in db.BILLs
                                select i).ToListAsync();
                cbId.DataSource = ID;
                cbId.DisplayMember = "ID";
                cbId.ValueMember = "ID";
                cbId.SelectedValue = 15;
                cbId.SelectedIndexChanged += cbId_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading IDs: {ex.Message}");
            }
        }

        private async void loadListBill()
        {
            try
            {
                dataGridViewBill.Rows.Clear();
                db = linqConnect.GetDatabase();
                var list = await (from i in db.BILLs
                                  join j in db.RECEIVEROOMs on i.IDReceiveRoom equals j.ID
                                  join k in db.ROOMs on j.IDRoom equals k.ID
                                  join l in db.BOOKROOMs on j.IDBookRoom equals l.ID
                                  join m in db.CUSTOMERs on l.IDCustomer equals m.ID
                                  join n in db.STATUSBILLs on i.IDStatusBill equals n.ID
                                  select new
                                  {
                                      ID = i.ID,
                                      DateCreate = i.DateOfCreate,
                                      Status = n.Name,
                                      Staff = i.StaffSetUp,
                                      Price = i.RoomPrice,
                                      Discount = i.Discount,
                                      Total = i.TotalPrice,
                                      NameCustomer = m.Name,
                                      NameRoom = k.Name,
                                  }).ToListAsync();

                foreach (var item in list)
                {
                    var index = dataGridViewBill.Rows.Add();
                    dataGridViewBill.Rows[index].Cells["colID"].Value = item.ID;
                    dataGridViewBill.Rows[index].Cells["colIdReciveRoom"].Value = item.NameRoom;
                    dataGridViewBill.Rows[index].Cells["colCustomerName"].Value = item.NameCustomer;
                    dataGridViewBill.Rows[index].Cells["coldDateOfCreate"].Value = item.DateCreate;
                    dataGridViewBill.Rows[index].Cells["colStatus"].Value = item.Status;
                    dataGridViewBill.Rows[index].Cells["colPrice"].Value = item.Price;
                    dataGridViewBill.Rows[index].Cells["Coldiscount"].Value = item.Discount;
                    dataGridViewBill.Rows[index].Cells["ColToltal"].Value = item.Total;
                    dataGridViewBill.Rows[index].Cells["colStaffsetUp"].Value = item.Staff;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading bill list: {ex.Message}");
            }
        }

        private void dataGridViewBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewBill.Rows.Count)
            {
                DataGridViewRow row = dataGridViewBill.Rows[e.RowIndex];

                cbId.Text = row.Cells["colID"].Value.ToString();
                txtNameRoom.Text = row.Cells["colIdReciveRoom"].Value.ToString();
                txtDate.Text = row.Cells["coldDateOfCreate"].Value.ToString();
                txtStatus.Text = row.Cells["colStatus"].Value.ToString();
                txtPrice.Text = row.Cells["colPrice"].Value.ToString();
                txtDiscount.Text = row.Cells["Coldiscount"].Value.ToString();
                txtToltal.Text = row.Cells["ColToltal"].Value.ToString();
                txtStaff.Text = row.Cells["colStaffsetUp"].Value.ToString();
            }
        }

        private void cbId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbId.SelectedValue == null)
            {
                return;
            }

            if (!int.TryParse(cbId.SelectedValue.ToString(), out int selectedId))
            {
                MessageBox.Show("Please wait");
                return;
            }

            try
            {
                foreach (DataGridViewRow row in dataGridViewBill.Rows)
                {
                    if (row.Cells["colID"].Value != null && (int)row.Cells["colID"].Value == selectedId)
                    {
                        txtNameRoom.Text = row.Cells["colIdReciveRoom"].Value.ToString();
                        txtDate.Text = row.Cells["coldDateOfCreate"].Value.ToString();
                        txtStatus.Text = row.Cells["colStatus"].Value.ToString();
                        txtPrice.Text = row.Cells["colPrice"].Value.ToString();
                        txtDiscount.Text = row.Cells["Coldiscount"].Value.ToString();
                        txtToltal.Text = row.Cells["ColToltal"].Value.ToString();
                        txtStaff.Text = row.Cells["colStaffsetUp"].Value.ToString();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing selected ID: {ex.Message}");
            }
        }

        #endregion

        private void btndetails_Click(object sender, EventArgs e)
        {
            if (cbId.SelectedValue == null)
            {
                MessageBox.Show("Please select a bill ID");
                return;
            }
            int idbill = (int)cbId.SelectedValue;
            Fprintbill fprintbill = new Fprintbill(idbill);
            fprintbill.ShowDialog();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportFile exportFile = new ExportFile();
            DataTable dataTable = exportFile.GetDataTableFromDataGridView(dataGridViewBill);
            exportFile.ExportToExcel(dataTable, "Sheet1", "List Bill");
            MessageBox.Show("The Excel file has been created successfully!");
        }

        private async void BtnSearch_Click(object sender, EventArgs e)
        {
            if (txtSeach.Text == "")
            {
                MessageBox.Show("Please enter the search value");
                return;
            }
            if (cbSearch.Text == "ID")
            {
                db = linqConnect.GetDatabase();
                var list = await(from i in db.BILLs
                            join j in db.RECEIVEROOMs on i.IDReceiveRoom equals j.ID
                            join k in db.ROOMs on j.IDRoom equals k.ID
                            join l in db.BOOKROOMs on j.IDBookRoom equals l.ID
                            join m in db.CUSTOMERs on l.IDCustomer equals m.ID
                            join n in db.STATUSBILLs on i.IDStatusBill equals n.ID
                            where i.ID.ToString() ==txtSeach.Text
                            select new
                            {
                                ID = i.ID,
                                DateCreate = i.DateOfCreate,
                                Status = n.Name,
                                Staff = i.StaffSetUp,
                                Price = i.RoomPrice,
                                Discount = i.Discount,
                                Total = i.TotalPrice,
                                NameCustomer = m.Name,
                                NameRoom = k.Name,
                            }).FirstOrDefaultAsync();
                if (list != null)
                {
                    cbId.Text = list.ID.ToString();
                    txtDate.Text = list.DateCreate.ToString();
                    txtDiscount.Text = list.Discount.ToString();
                    txtNameRoom.Text = list.NameRoom;
                    txtPrice.Text = list.Price.ToString();
                    txtStaff.Text = list.Staff;
                    txtStatus.Text = list.Status;
                    txtToltal.Text = list.Total.ToString();
                }
                else
                {
                    MessageBox.Show("No data found");
                }   

            }
            else if(cbSearch.Text == "Customer Name")
            {
                db = linqConnect.GetDatabase();
                var list = await (from i in db.BILLs
                                  join j in db.RECEIVEROOMs on i.IDReceiveRoom equals j.ID
                                  join k in db.ROOMs on j.IDRoom equals k.ID
                                  join l in db.BOOKROOMs on j.IDBookRoom equals l.ID
                                  join m in db.CUSTOMERs on l.IDCustomer equals m.ID
                                  join n in db.STATUSBILLs on i.IDStatusBill equals n.ID
                                  where m.Name.ToString() == txtSeach.Text
                                  select new
                                  {
                                      ID = i.ID,
                                      DateCreate = i.DateOfCreate,
                                      Status = n.Name,
                                      Staff = i.StaffSetUp,
                                      Price = i.RoomPrice,
                                      Discount = i.Discount,
                                      Total = i.TotalPrice,
                                      NameCustomer = m.Name,
                                      NameRoom = k.Name,
                                  }).FirstOrDefaultAsync();
                if (list != null)
                {
                    cbId.Text = list.ID.ToString();
                    txtDate.Text = list.DateCreate.ToString();
                    txtDiscount.Text = list.Discount.ToString();
                    txtNameRoom.Text = list.NameRoom;
                    txtPrice.Text = list.Price.ToString();
                    txtStaff.Text = list.Staff;
                    txtStatus.Text = list.Status;
                    txtToltal.Text = list.Total.ToString();
                }
                else
                {
                    MessageBox.Show("No data found");
                }
            }
            else if(cbSearch.Text == "ID Card")
            {
                db = linqConnect.GetDatabase();
                var list = await (from i in db.BILLs
                                  join j in db.RECEIVEROOMs on i.IDReceiveRoom equals j.ID
                                  join k in db.ROOMs on j.IDRoom equals k.ID
                                  join l in db.BOOKROOMs on j.IDBookRoom equals l.ID
                                  join m in db.CUSTOMERs on l.IDCustomer equals m.ID
                                  join n in db.STATUSBILLs on i.IDStatusBill equals n.ID
                                  where m.IDCard.ToString() == txtSeach.Text
                                  select new
                                  {
                                      ID = i.ID,
                                      DateCreate = i.DateOfCreate,
                                      Status = n.Name,
                                      Staff = i.StaffSetUp,
                                      Price = i.RoomPrice,
                                      Discount = i.Discount,
                                      Total = i.TotalPrice,
                                      NameCustomer = m.Name,
                                      NameRoom = k.Name,
                                  }).FirstOrDefaultAsync();
                if (list != null)
                {
                    cbId.Text = list.ID.ToString();
                    txtDate.Text = list.DateCreate.ToString();
                    txtDiscount.Text = list.Discount.ToString();
                    txtNameRoom.Text = list.NameRoom;
                    txtPrice.Text = list.Price.ToString();
                    txtStaff.Text = list.Staff;
                    txtStatus.Text = list.Status;
                    txtToltal.Text = list.Total.ToString();
                }
                else
                {
                    MessageBox.Show("No data found");
                }
               
            }
            else
            {
                MessageBox.Show("Please select a search type");
            }
        }
    }
}
