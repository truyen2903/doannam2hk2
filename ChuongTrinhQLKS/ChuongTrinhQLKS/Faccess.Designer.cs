namespace ChuongTrinhQLKS
{
    partial class Faccess
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Faccess));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGrant = new Guna.UI2.WinForms.Guna2Button();
            this.BtnClose = new Guna.UI2.WinForms.Guna2Button();
            this.cbType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupService = new System.Windows.Forms.GroupBox();
            this.dataGridViewAccessNow = new System.Windows.Forms.DataGridView();
            this.colAccessNow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdNow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewAccessRest = new System.Windows.Forms.DataGridView();
            this.colNameRest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdRest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddall = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditall = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox3.SuspendLayout();
            this.groupService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccessNow)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccessRest)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SeaGreen;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 37);
            this.label6.TabIndex = 64;
            this.label6.Text = "Access Rights";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGrant);
            this.groupBox3.Controls.Add(this.BtnClose);
            this.groupBox3.Controls.Add(this.cbType);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox3.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox3.Location = new System.Drawing.Point(12, 49);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(587, 105);
            this.groupBox3.TabIndex = 68;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Type Employ";
            // 
            // btnGrant
            // 
            this.btnGrant.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnGrant.BorderRadius = 15;
            this.btnGrant.BorderThickness = 1;
            this.btnGrant.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGrant.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGrant.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGrant.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGrant.FillColor = System.Drawing.Color.White;
            this.btnGrant.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGrant.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnGrant.HoverState.FillColor = System.Drawing.Color.SeaGreen;
            this.btnGrant.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnGrant.Location = new System.Drawing.Point(406, 24);
            this.btnGrant.Name = "btnGrant";
            this.btnGrant.Size = new System.Drawing.Size(175, 29);
            this.btnGrant.TabIndex = 30;
            this.btnGrant.Text = "Grant access";
            this.btnGrant.Click += new System.EventHandler(this.btnGrant_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BorderColor = System.Drawing.Color.SeaGreen;
            this.BtnClose.BorderRadius = 15;
            this.BtnClose.BorderThickness = 1;
            this.BtnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnClose.FillColor = System.Drawing.Color.White;
            this.BtnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnClose.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnClose.HoverState.FillColor = System.Drawing.Color.SeaGreen;
            this.BtnClose.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(406, 59);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(175, 29);
            this.BtnClose.TabIndex = 30;
            this.BtnClose.Text = "Close";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // cbType
            // 
            this.cbType.BackColor = System.Drawing.Color.Transparent;
            this.cbType.BorderColor = System.Drawing.Color.SeaGreen;
            this.cbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbType.ForeColor = System.Drawing.Color.SeaGreen;
            this.cbType.ItemHeight = 30;
            this.cbType.Location = new System.Drawing.Point(19, 52);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(175, 36);
            this.cbType.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SeaGreen;
            this.label5.Location = new System.Drawing.Point(15, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Name type:";
            // 
            // groupService
            // 
            this.groupService.Controls.Add(this.dataGridViewAccessNow);
            this.groupService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupService.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupService.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupService.Location = new System.Drawing.Point(12, 160);
            this.groupService.Name = "groupService";
            this.groupService.Size = new System.Drawing.Size(250, 337);
            this.groupService.TabIndex = 69;
            this.groupService.TabStop = false;
            this.groupService.Text = "Current rights";
            // 
            // dataGridViewAccessNow
            // 
            this.dataGridViewAccessNow.AllowUserToAddRows = false;
            this.dataGridViewAccessNow.AllowUserToDeleteRows = false;
            this.dataGridViewAccessNow.AllowUserToResizeRows = false;
            this.dataGridViewAccessNow.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAccessNow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAccessNow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewAccessNow.ColumnHeadersHeight = 29;
            this.dataGridViewAccessNow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewAccessNow.ColumnHeadersVisible = false;
            this.dataGridViewAccessNow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAccessNow,
            this.colIdNow});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAccessNow.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewAccessNow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAccessNow.GridColor = System.Drawing.Color.White;
            this.dataGridViewAccessNow.Location = new System.Drawing.Point(3, 25);
            this.dataGridViewAccessNow.Name = "dataGridViewAccessNow";
            this.dataGridViewAccessNow.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAccessNow.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewAccessNow.RowHeadersVisible = false;
            this.dataGridViewAccessNow.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewAccessNow.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dataGridViewAccessNow.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewAccessNow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAccessNow.Size = new System.Drawing.Size(244, 309);
            this.dataGridViewAccessNow.TabIndex = 29;
            // 
            // colAccessNow
            // 
            this.colAccessNow.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAccessNow.DataPropertyName = "name";
            this.colAccessNow.HeaderText = "Column1";
            this.colAccessNow.Name = "colAccessNow";
            this.colAccessNow.ReadOnly = true;
            // 
            // colIdNow
            // 
            this.colIdNow.DataPropertyName = "id";
            this.colIdNow.HeaderText = "Column2";
            this.colIdNow.Name = "colIdNow";
            this.colIdNow.ReadOnly = true;
            this.colIdNow.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewAccessRest);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Location = new System.Drawing.Point(349, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 337);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Remaining rights";
            // 
            // dataGridViewAccessRest
            // 
            this.dataGridViewAccessRest.AllowUserToAddRows = false;
            this.dataGridViewAccessRest.AllowUserToDeleteRows = false;
            this.dataGridViewAccessRest.AllowUserToResizeRows = false;
            this.dataGridViewAccessRest.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewAccessRest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAccessRest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAccessRest.ColumnHeadersHeight = 29;
            this.dataGridViewAccessRest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewAccessRest.ColumnHeadersVisible = false;
            this.dataGridViewAccessRest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNameRest,
            this.colIdRest});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAccessRest.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAccessRest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAccessRest.GridColor = System.Drawing.Color.White;
            this.dataGridViewAccessRest.Location = new System.Drawing.Point(3, 25);
            this.dataGridViewAccessRest.Name = "dataGridViewAccessRest";
            this.dataGridViewAccessRest.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAccessRest.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAccessRest.RowHeadersVisible = false;
            this.dataGridViewAccessRest.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewAccessRest.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dataGridViewAccessRest.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewAccessRest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAccessRest.Size = new System.Drawing.Size(244, 309);
            this.dataGridViewAccessRest.TabIndex = 30;
            // 
            // colNameRest
            // 
            this.colNameRest.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNameRest.DataPropertyName = "Name";
            this.colNameRest.HeaderText = "Column1";
            this.colNameRest.Name = "colNameRest";
            this.colNameRest.ReadOnly = true;
            // 
            // colIdRest
            // 
            this.colIdRest.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colIdRest.DataPropertyName = "Id";
            this.colIdRest.HeaderText = "Column1";
            this.colIdRest.Name = "colIdRest";
            this.colIdRest.ReadOnly = true;
            this.colIdRest.Visible = false;
            // 
            // btnAddall
            // 
            this.btnAddall.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnAddall.BorderThickness = 1;
            this.btnAddall.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddall.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddall.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddall.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddall.FillColor = System.Drawing.Color.Transparent;
            this.btnAddall.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddall.ForeColor = System.Drawing.Color.White;
            this.btnAddall.Image = ((System.Drawing.Image)(resources.GetObject("btnAddall.Image")));
            this.btnAddall.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddall.Location = new System.Drawing.Point(283, 197);
            this.btnAddall.Name = "btnAddall";
            this.btnAddall.Size = new System.Drawing.Size(40, 40);
            this.btnAddall.TabIndex = 71;
            this.btnAddall.Click += new System.EventHandler(this.btnAddall_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.BorderThickness = 1;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.Transparent;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(283, 270);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 40);
            this.btnAdd.TabIndex = 71;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnEdit.BorderThickness = 1;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.FillColor = System.Drawing.Color.Transparent;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(283, 376);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(40, 40);
            this.btnEdit.TabIndex = 71;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnEditall
            // 
            this.btnEditall.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnEditall.BorderThickness = 1;
            this.btnEditall.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditall.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditall.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditall.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditall.FillColor = System.Drawing.Color.Transparent;
            this.btnEditall.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditall.ForeColor = System.Drawing.Color.White;
            this.btnEditall.Image = ((System.Drawing.Image)(resources.GetObject("btnEditall.Image")));
            this.btnEditall.Location = new System.Drawing.Point(283, 438);
            this.btnEditall.Name = "btnEditall";
            this.btnEditall.Size = new System.Drawing.Size(40, 40);
            this.btnEditall.TabIndex = 71;
            this.btnEditall.Click += new System.EventHandler(this.btnEditall_Click);
            // 
            // Faccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(617, 506);
            this.Controls.Add(this.btnEditall);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnAddall);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupService);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Faccess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faccess";
            this.Load += new System.EventHandler(this.Faccess_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupService.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccessNow)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccessRest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.GroupBox groupService;
        private System.Windows.Forms.DataGridView dataGridViewAccessNow;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccessNow;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdNow;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewAccessRest;
        private Guna.UI2.WinForms.Guna2ComboBox cbType;
        private Guna.UI2.WinForms.Guna2Button btnEditall;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnAddall;
        private Guna.UI2.WinForms.Guna2Button BtnClose;
        private Guna.UI2.WinForms.Guna2Button btnGrant;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNameRest;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdRest;
    }
}