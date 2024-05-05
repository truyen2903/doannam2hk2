namespace ChuongTrinhQLKS
{
    partial class froommanagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelName = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtFindID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupRoom = new System.Windows.Forms.GroupBox();
            this.cbIDRoom = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbTyperoom = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbCondition = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtLimitsPerson = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNameRoom = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPriceRoom = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAddRoom = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewRoom = new System.Windows.Forms.DataGridView();
            this.colIDRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNameRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLimitPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.groupBox3.SuspendLayout();
            this.groupRoom.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelName.Location = new System.Drawing.Point(9, 6);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(252, 37);
            this.labelName.TabIndex = 51;
            this.labelName.Text = "Room Management";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.txtFindID);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox3.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox3.Location = new System.Drawing.Point(5, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(444, 94);
            this.groupBox3.TabIndex = 52;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnSearch.BorderRadius = 12;
            this.btnSearch.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnSearch.BorderThickness = 1;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.White;
            this.btnSearch.FocusedColor = System.Drawing.Color.SeaGreen;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSearch.Location = new System.Drawing.Point(262, 44);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(164, 29);
            this.btnSearch.TabIndex = 30;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtFindID
            // 
            this.txtFindID.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtFindID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFindID.DefaultText = "";
            this.txtFindID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFindID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFindID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFindID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFindID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFindID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFindID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFindID.Location = new System.Drawing.Point(26, 44);
            this.txtFindID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtFindID.Name = "txtFindID";
            this.txtFindID.PasswordChar = '\0';
            this.txtFindID.PlaceholderText = "";
            this.txtFindID.SelectedText = "";
            this.txtFindID.Size = new System.Drawing.Size(175, 29);
            this.txtFindID.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SeaGreen;
            this.label5.Location = new System.Drawing.Point(22, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "ID Room:";
            // 
            // groupRoom
            // 
            this.groupRoom.Controls.Add(this.cbIDRoom);
            this.groupRoom.Controls.Add(this.cbTyperoom);
            this.groupRoom.Controls.Add(this.cbCondition);
            this.groupRoom.Controls.Add(this.txtLimitsPerson);
            this.groupRoom.Controls.Add(this.txtNameRoom);
            this.groupRoom.Controls.Add(this.txtPriceRoom);
            this.groupRoom.Controls.Add(this.label2);
            this.groupRoom.Controls.Add(this.label16);
            this.groupRoom.Controls.Add(this.label20);
            this.groupRoom.Controls.Add(this.label13);
            this.groupRoom.Controls.Add(this.label15);
            this.groupRoom.Controls.Add(this.label1);
            this.groupRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupRoom.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupRoom.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupRoom.Location = new System.Drawing.Point(5, 149);
            this.groupRoom.Name = "groupRoom";
            this.groupRoom.Size = new System.Drawing.Size(444, 199);
            this.groupRoom.TabIndex = 53;
            this.groupRoom.TabStop = false;
            this.groupRoom.Text = "Room Information:";
            // 
            // cbIDRoom
            // 
            this.cbIDRoom.BackColor = System.Drawing.Color.Transparent;
            this.cbIDRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbIDRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIDRoom.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbIDRoom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbIDRoom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbIDRoom.ForeColor = System.Drawing.Color.SeaGreen;
            this.cbIDRoom.ItemHeight = 30;
            this.cbIDRoom.Location = new System.Drawing.Point(26, 46);
            this.cbIDRoom.Margin = new System.Windows.Forms.Padding(2);
            this.cbIDRoom.Name = "cbIDRoom";
            this.cbIDRoom.Size = new System.Drawing.Size(176, 36);
            this.cbIDRoom.TabIndex = 53;
            this.cbIDRoom.SelectedIndexChanged += new System.EventHandler(this.CbIDRoom_SelectedIndexChanged);
            // 
            // cbTyperoom
            // 
            this.cbTyperoom.BackColor = System.Drawing.Color.Transparent;
            this.cbTyperoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTyperoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTyperoom.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTyperoom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTyperoom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTyperoom.ForeColor = System.Drawing.Color.SeaGreen;
            this.cbTyperoom.ItemHeight = 30;
            this.cbTyperoom.Location = new System.Drawing.Point(250, 44);
            this.cbTyperoom.Margin = new System.Windows.Forms.Padding(2);
            this.cbTyperoom.Name = "cbTyperoom";
            this.cbTyperoom.Size = new System.Drawing.Size(176, 36);
            this.cbTyperoom.TabIndex = 52;
            this.cbTyperoom.SelectedIndexChanged += new System.EventHandler(this.CbTyperoom_SelectedIndexChanged);
            // 
            // cbCondition
            // 
            this.cbCondition.BackColor = System.Drawing.Color.Transparent;
            this.cbCondition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCondition.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCondition.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCondition.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCondition.ForeColor = System.Drawing.Color.SeaGreen;
            this.cbCondition.ItemHeight = 30;
            this.cbCondition.Location = new System.Drawing.Point(26, 157);
            this.cbCondition.Margin = new System.Windows.Forms.Padding(2);
            this.cbCondition.Name = "cbCondition";
            this.cbCondition.Size = new System.Drawing.Size(176, 36);
            this.cbCondition.TabIndex = 51;
            // 
            // txtLimitsPerson
            // 
            this.txtLimitsPerson.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtLimitsPerson.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLimitsPerson.DefaultText = "";
            this.txtLimitsPerson.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLimitsPerson.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLimitsPerson.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLimitsPerson.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLimitsPerson.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLimitsPerson.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLimitsPerson.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLimitsPerson.Location = new System.Drawing.Point(250, 157);
            this.txtLimitsPerson.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtLimitsPerson.Name = "txtLimitsPerson";
            this.txtLimitsPerson.PasswordChar = '\0';
            this.txtLimitsPerson.PlaceholderText = "";
            this.txtLimitsPerson.SelectedText = "";
            this.txtLimitsPerson.Size = new System.Drawing.Size(175, 29);
            this.txtLimitsPerson.TabIndex = 50;
            // 
            // txtNameRoom
            // 
            this.txtNameRoom.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtNameRoom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameRoom.DefaultText = "";
            this.txtNameRoom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNameRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNameRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameRoom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameRoom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameRoom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNameRoom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameRoom.Location = new System.Drawing.Point(26, 101);
            this.txtNameRoom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNameRoom.Name = "txtNameRoom";
            this.txtNameRoom.PasswordChar = '\0';
            this.txtNameRoom.PlaceholderText = "";
            this.txtNameRoom.SelectedText = "";
            this.txtNameRoom.Size = new System.Drawing.Size(175, 29);
            this.txtNameRoom.TabIndex = 48;
            // 
            // txtPriceRoom
            // 
            this.txtPriceRoom.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtPriceRoom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPriceRoom.DefaultText = "";
            this.txtPriceRoom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPriceRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPriceRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPriceRoom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPriceRoom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPriceRoom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPriceRoom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPriceRoom.Location = new System.Drawing.Point(250, 101);
            this.txtPriceRoom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtPriceRoom.Name = "txtPriceRoom";
            this.txtPriceRoom.PasswordChar = '\0';
            this.txtPriceRoom.PlaceholderText = "";
            this.txtPriceRoom.SelectedText = "";
            this.txtPriceRoom.Size = new System.Drawing.Size(175, 29);
            this.txtPriceRoom.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(247, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Max number of people:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.SeaGreen;
            this.label16.Location = new System.Drawing.Point(22, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 20);
            this.label16.TabIndex = 22;
            this.label16.Text = "ID Room:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.SeaGreen;
            this.label20.Location = new System.Drawing.Point(247, 21);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(87, 20);
            this.label20.TabIndex = 41;
            this.label20.Text = "Type Room:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.SeaGreen;
            this.label13.Location = new System.Drawing.Point(22, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "Condition:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.SeaGreen;
            this.label15.Location = new System.Drawing.Point(22, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 20);
            this.label15.TabIndex = 24;
            this.label15.Text = "Name Room:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(247, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Price Room:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAddRoom);
            this.groupBox4.Controls.Add(this.btnUpdate);
            this.groupBox4.Controls.Add(this.btnClose);
            this.groupBox4.Controls.Add(this.btnEdit);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox4.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox4.Location = new System.Drawing.Point(5, 350);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(444, 138);
            this.groupBox4.TabIndex = 59;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Funcion";
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackColor = System.Drawing.Color.White;
            this.btnAddRoom.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnAddRoom.BorderRadius = 12;
            this.btnAddRoom.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnAddRoom.BorderThickness = 1;
            this.btnAddRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddRoom.FillColor = System.Drawing.Color.White;
            this.btnAddRoom.FocusedColor = System.Drawing.Color.SeaGreen;
            this.btnAddRoom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddRoom.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAddRoom.Location = new System.Drawing.Point(22, 35);
            this.btnAddRoom.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(164, 29);
            this.btnAddRoom.TabIndex = 34;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnUpdate.BorderRadius = 12;
            this.btnUpdate.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnUpdate.BorderThickness = 1;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.White;
            this.btnUpdate.FocusedColor = System.Drawing.Color.SeaGreen;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnUpdate.Location = new System.Drawing.Point(22, 89);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(164, 29);
            this.btnUpdate.TabIndex = 33;
            this.btnUpdate.Text = "Update Room";
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnClose.BorderRadius = 12;
            this.btnClose.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnClose.BorderThickness = 1;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.White;
            this.btnClose.FocusedColor = System.Drawing.Color.SeaGreen;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnClose.Location = new System.Drawing.Point(247, 89);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(164, 29);
            this.btnClose.TabIndex = 32;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnEdit.BorderRadius = 12;
            this.btnEdit.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnEdit.BorderThickness = 1;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.White;
            this.btnEdit.FocusedColor = System.Drawing.Color.SeaGreen;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnEdit.Location = new System.Drawing.Point(247, 35);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(164, 29);
            this.btnEdit.TabIndex = 31;
            this.btnEdit.Text = "Edit Type Room";
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewRoom);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Location = new System.Drawing.Point(455, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 435);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List Room";
            // 
            // dataGridViewRoom
            // 
            this.dataGridViewRoom.AllowUserToAddRows = false;
            this.dataGridViewRoom.AllowUserToDeleteRows = false;
            this.dataGridViewRoom.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.SeaGreen;
            this.dataGridViewRoom.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRoom.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRoom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRoom.ColumnHeadersHeight = 29;
            this.dataGridViewRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDRoom,
            this.colName,
            this.colNameRoomType,
            this.colPrice,
            this.colLimitPerson,
            this.colStatus,
            this.colIdRoomType,
            this.colIdStatus});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRoom.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRoom.GridColor = System.Drawing.Color.White;
            this.dataGridViewRoom.Location = new System.Drawing.Point(3, 25);
            this.dataGridViewRoom.Name = "dataGridViewRoom";
            this.dataGridViewRoom.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRoom.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewRoom.RowHeadersVisible = false;
            this.dataGridViewRoom.RowHeadersWidth = 51;
            this.dataGridViewRoom.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewRoom.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewRoom.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewRoom.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewRoom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRoom.Size = new System.Drawing.Size(646, 407);
            this.dataGridViewRoom.TabIndex = 28;
            this.dataGridViewRoom.SelectionChanged += new System.EventHandler(this.DataGridViewRoom_SelectionChanged);
            // 
            // colIDRoom
            // 
            this.colIDRoom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colIDRoom.DataPropertyName = "IDRoom";
            this.colIDRoom.FillWeight = 90F;
            this.colIDRoom.HeaderText = "ID Room";
            this.colIDRoom.MinimumWidth = 6;
            this.colIDRoom.Name = "colIDRoom";
            this.colIDRoom.ReadOnly = true;
            this.colIDRoom.Width = 96;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colName.DataPropertyName = "name";
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 77;
            // 
            // colNameRoomType
            // 
            this.colNameRoomType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colNameRoomType.DataPropertyName = "nametype";
            this.colNameRoomType.HeaderText = "RoomType";
            this.colNameRoomType.MinimumWidth = 6;
            this.colNameRoomType.Name = "colNameRoomType";
            this.colNameRoomType.ReadOnly = true;
            this.colNameRoomType.Width = 109;
            // 
            // colPrice
            // 
            this.colPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPrice.DataPropertyName = "price";
            this.colPrice.HeaderText = "Price";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Width = 69;
            // 
            // colLimitPerson
            // 
            this.colLimitPerson.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colLimitPerson.DataPropertyName = "limitperson";
            this.colLimitPerson.HeaderText = "Limit Person";
            this.colLimitPerson.MinimumWidth = 6;
            this.colLimitPerson.Name = "colLimitPerson";
            this.colLimitPerson.ReadOnly = true;
            this.colLimitPerson.Width = 121;
            // 
            // colStatus
            // 
            this.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStatus.DataPropertyName = "status";
            this.colStatus.HeaderText = "Status Room";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // colIdRoomType
            // 
            this.colIdRoomType.DataPropertyName = "idRoomType";
            this.colIdRoomType.HeaderText = "";
            this.colIdRoomType.MinimumWidth = 6;
            this.colIdRoomType.Name = "colIdRoomType";
            this.colIdRoomType.ReadOnly = true;
            this.colIdRoomType.Visible = false;
            this.colIdRoomType.Width = 125;
            // 
            // colIdStatus
            // 
            this.colIdStatus.DataPropertyName = "idStatusRoom";
            this.colIdStatus.HeaderText = "";
            this.colIdStatus.MinimumWidth = 6;
            this.colIdStatus.Name = "colIdStatus";
            this.colIdStatus.ReadOnly = true;
            this.colIdStatus.Visible = false;
            this.colIdStatus.Width = 125;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(5, 43);
            this.guna2Separator1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1102, 14);
            this.guna2Separator1.TabIndex = 31;
            // 
            // froommanagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1111, 496);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupRoom);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "froommanagement";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Froommanagement_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupRoom.ResumeLayout(false);
            this.groupRoom.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtFindID;
        private Guna.UI2.WinForms.Guna2TextBox txtLimitsPerson;
        private Guna.UI2.WinForms.Guna2TextBox txtNameRoom;
        private Guna.UI2.WinForms.Guna2TextBox txtPriceRoom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewRoom;
        private Guna.UI2.WinForms.Guna2Button btnAddRoom;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2ComboBox cbCondition;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2ComboBox cbTyperoom;
        private Guna.UI2.WinForms.Guna2ComboBox cbIDRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNameRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLimitPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdStatus;
    }
}