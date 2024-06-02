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
    public partial class fbookroom : Form
    {
        HotelManagement dblinq;
        int idcus;
        int idrommtype;
        public fbookroom()
        {
            InitializeComponent();
        }
        private async void LoadTypeRoom ()
        {
            try
            {
                dblinq = linqConnect.GetDatabase();
                var query = from typeroom in dblinq.ROOMTYPEs
                            select typeroom;
                var Roomtypelist = await query.ToListAsync();
                cbRoomtype.DataSource = Roomtypelist;
                cbRoomtype.DisplayMember = "Name";
                cbRoomtype.ValueMember = "ID";

                cbRoomtype.SelectedIndexChanged += CbRoomtype_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        
        private void Fbookroom_Load(object sender, EventArgs e)
        {
            LoadTypeRoom();
            LoadDate();
            LoadDays();
            LoadInforBookroomdays();
        }

        private void CbRoomtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedRoomtype = (ROOMTYPE)cbRoomtype.SelectedItem;
            txtIDtypeRoom.Text = selectedRoomtype.ID.ToString();   
            txtMaxpeople.Text=selectedRoomtype.LimitPerson.ToString();
            txtNUmberRoom.Text=selectedRoomtype.Name.ToString();   
            txtPrice.Text=selectedRoomtype.Price.ToString();
        }

        private void Datecheckout_ValueChanged(object sender, EventArgs e)
        {
            if (Datecheckout.Value < DateTime.Now)
                LoadDate();
            if (Datecheckout.Value <= Datecheckin.Value)
                LoadDate();
            LoadDays();
        }
        private void LoadDate()
        {
            DateBirthday.Value = new DateTime(1998, 4, 6);
            Datecheckin.Value = DateTime.Now;
            Datecheckout .Value = DateTime.Now.AddDays(1);
        }
        private void LoadDays()
        {
            txtDays.Text = (Datecheckout.Value.Date - Datecheckin.Value.Date).Days.ToString();
        }

        private void Datecheckin_ValueChanged(object sender, EventArgs e)
        {
            if (Datecheckin.Value < DateTime.Now)
                LoadDate();
            if (Datecheckout.Value <= Datecheckin.Value)
                LoadDate();
            LoadDays();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            txtPhonenumber.Text = string.Empty;
            txtNationality.Text = string.Empty;
            txtFullName.Text = string.Empty;
            txtFindID.Text = string.Empty;
            txtIDCard.Text = string.Empty;
            LoadDate();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            GetInforCustumer();
            GetCustumerType();
        }
        private async void GetInforCustumer()
        {
            if (txtFindID.Text == string.Empty)
            {
                MessageBox.Show("Please enter ID card", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFindID.Focus();
                return;
            }
            dblinq  = linqConnect.GetDatabase();
            var querycustom = from Customed in dblinq.CUSTOMERs
                              where Customed.IDCard.ToString() == txtFindID.Text
                              select Customed;
            var custumer  = await querycustom.FirstOrDefaultAsync();
            if (custumer == null)
            {
                MessageBox.Show("Please re-enter ID card", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFindID.Text = string.Empty;
                txtFindID.Focus();
                return;
            }
            else
            {
                txtIDCard.Text = custumer.IDCard.ToString();
                txtAddress.Text = custumer.Address.ToString(); 
                txtFullName.Text = custumer.Name.ToString();
                txtNationality.Text = custumer.Nationality.ToString(); 
                txtPhonenumber.Text = custumer.PhoneNumber.ToString();
                cbCustomtype.Text = custumer.ID.ToString();
                cbSex.Text = custumer.Sex.ToString();
                DateBirthday.Value = DateTime.Parse(custumer.DateOfBirth.ToString());
                idcus = custumer.ID;
            }

        }
        private async void GetCustumerType()
        {
            
            dblinq = linqConnect.GetDatabase();
            var querytype = await(from typecustumer in dblinq.CUSTOMERTYPEs
                            select typecustumer).ToListAsync();      
            cbCustomtype.DataSource = querytype;
            cbCustomtype.DisplayMember = "Name";
            cbCustomtype.ValueMember = "ID";

        }  
        private async void AddBookroom()
        {
            
            idrommtype = (int)cbRoomtype.SelectedValue;
            dblinq = linqConnect.GetDatabase();
            var newBookrooom = new BOOKROOM
            {
                IDCustomer = idcus,
                IDRoomType = idrommtype,
                DateBookRoom = DateTime.Now,
                DateCheckIn = Datecheckin.Value,
                DateCheckOut = Datecheckout.Value
            };
            dblinq.BOOKROOMs.Add(newBookrooom);
            try
            {
                await dblinq.SaveChangesAsync();
                MessageBox.Show("Add Set Success.", "announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPhonenumber.Text = string.Empty;
                txtNationality.Text = string.Empty;
                txtFullName.Text = string.Empty;
                txtFindID.Text = string.Empty;
                txtIDCard.Text = string.Empty;
                LoadDate();
        }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error adding a booking: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void BtnBookRoom_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to add a new booking?", "Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if(txtAddress.Text==null ||txtFullName.Text ==null || txtIDtypeRoom.Text ==null || txtIDCard.Text ==null)
                {
                    MessageBox.Show("Please enter full information","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    BtnCancel_Click(sender, e);
                }
                else
                {
                    AddBookroom();
                    LoadInforBookroomdays();   
                    BtnCancel_Click(sender, e);
                }
            }
            else
            {
                BtnCancel_Click(sender, e);
            }
        }
        private async void LoadInforBookroomdays()
        {
           dblinq = linqConnect.GetDatabase();
            var querybookroomdays =await (from bookroomdays in dblinq.BOOKROOMs
                                    join customer in dblinq.CUSTOMERs on bookroomdays.IDCustomer equals customer.ID
                                    join type in dblinq.ROOMTYPEs on bookroomdays.IDRoomType equals type.ID
                                    where DbFunctions.TruncateTime(bookroomdays.DateBookRoom) == DbFunctions.TruncateTime(DateTime.Now)
                                    select new
                                    {
                                        IdBookroom = bookroomdays.ID,
                                        Fullname = customer.Name,  
                                        CMND = customer.IDCard,
                                        typeroom = type.Name,
                                        Datecheckin = bookroomdays.DateCheckIn,
                                        Datecheckout = bookroomdays.DateCheckOut
                                    }).ToListAsync();
            dataGridViewBookRoom.DataSource = querybookroomdays;
        }

        private void btnexport_Click(object sender, EventArgs e)
        {
            ExportFile exportFile = new ExportFile();
            DataTable dataTable = exportFile.GetDataTableFromDataGridView(dataGridViewBookRoom);
            exportFile.ExportToExcel(dataTable, "Sheet1", "ListBookRoom");
            MessageBox.Show("The Excel file has been created successfully!");
        }
    }
    
}
