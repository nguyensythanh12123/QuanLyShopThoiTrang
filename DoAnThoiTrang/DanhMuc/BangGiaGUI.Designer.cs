namespace DoAnThoiTrang.DanhMuc
{
    partial class BangGiaGUI
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
            this.panelCongCu = new System.Windows.Forms.Panel();
            this.mnuDong = new FontAwesome.Sharp.IconButton();
            this.mnuxoa = new FontAwesome.Sharp.IconButton();
            this.mnusua = new FontAwesome.Sharp.IconButton();
            this.mnuluu = new FontAwesome.Sharp.IconButton();
            this.mnuthem = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtgianhap = new Guna.UI.WinForms.GunaTextBox();
            this.txtgiaban = new Guna.UI.WinForms.GunaTextBox();
            this.txtNgayCN = new Guna.UI.WinForms.GunaTextBox();
            this.cbbsp = new Guna.UI.WinForms.GunaComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbsp = new System.Windows.Forms.Label();
            this.dgvBangGia = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCongCu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangGia)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCongCu
            // 
            this.panelCongCu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelCongCu.Controls.Add(this.mnuDong);
            this.panelCongCu.Controls.Add(this.mnuxoa);
            this.panelCongCu.Controls.Add(this.mnusua);
            this.panelCongCu.Controls.Add(this.mnuluu);
            this.panelCongCu.Controls.Add(this.mnuthem);
            this.panelCongCu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCongCu.Location = new System.Drawing.Point(0, 867);
            this.panelCongCu.Name = "panelCongCu";
            this.panelCongCu.Size = new System.Drawing.Size(1503, 86);
            this.panelCongCu.TabIndex = 3;
            // 
            // mnuDong
            // 
            this.mnuDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.mnuDong.Dock = System.Windows.Forms.DockStyle.Left;
            this.mnuDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mnuDong.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuDong.ForeColor = System.Drawing.Color.Gainsboro;
            this.mnuDong.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.mnuDong.IconColor = System.Drawing.Color.Gainsboro;
            this.mnuDong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mnuDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuDong.Location = new System.Drawing.Point(1000, 0);
            this.mnuDong.Name = "mnuDong";
            this.mnuDong.Size = new System.Drawing.Size(250, 86);
            this.mnuDong.TabIndex = 4;
            this.mnuDong.Text = "EXIT";
            this.mnuDong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mnuDong.UseVisualStyleBackColor = false;
            this.mnuDong.Click += new System.EventHandler(this.mnuDong_Click);
            // 
            // mnuxoa
            // 
            this.mnuxoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.mnuxoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.mnuxoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mnuxoa.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuxoa.ForeColor = System.Drawing.Color.Gainsboro;
            this.mnuxoa.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.mnuxoa.IconColor = System.Drawing.Color.Gainsboro;
            this.mnuxoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mnuxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuxoa.Location = new System.Drawing.Point(750, 0);
            this.mnuxoa.Name = "mnuxoa";
            this.mnuxoa.Size = new System.Drawing.Size(250, 86);
            this.mnuxoa.TabIndex = 3;
            this.mnuxoa.Text = "REMOVE";
            this.mnuxoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mnuxoa.UseVisualStyleBackColor = false;
            this.mnuxoa.Click += new System.EventHandler(this.mnuxoa_Click);
            // 
            // mnusua
            // 
            this.mnusua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.mnusua.Dock = System.Windows.Forms.DockStyle.Left;
            this.mnusua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mnusua.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnusua.ForeColor = System.Drawing.Color.Gainsboro;
            this.mnusua.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.mnusua.IconColor = System.Drawing.Color.Gainsboro;
            this.mnusua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mnusua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnusua.Location = new System.Drawing.Point(500, 0);
            this.mnusua.Name = "mnusua";
            this.mnusua.Size = new System.Drawing.Size(250, 86);
            this.mnusua.TabIndex = 2;
            this.mnusua.Text = "EDIT";
            this.mnusua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mnusua.UseVisualStyleBackColor = false;
            this.mnusua.Click += new System.EventHandler(this.mnusua_Click);
            // 
            // mnuluu
            // 
            this.mnuluu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.mnuluu.Dock = System.Windows.Forms.DockStyle.Left;
            this.mnuluu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mnuluu.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuluu.ForeColor = System.Drawing.Color.Gainsboro;
            this.mnuluu.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.mnuluu.IconColor = System.Drawing.Color.Gainsboro;
            this.mnuluu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mnuluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuluu.Location = new System.Drawing.Point(250, 0);
            this.mnuluu.Name = "mnuluu";
            this.mnuluu.Size = new System.Drawing.Size(250, 86);
            this.mnuluu.TabIndex = 1;
            this.mnuluu.Text = "SAVE";
            this.mnuluu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mnuluu.UseVisualStyleBackColor = false;
            this.mnuluu.Click += new System.EventHandler(this.mnuluu_Click);
            // 
            // mnuthem
            // 
            this.mnuthem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.mnuthem.Dock = System.Windows.Forms.DockStyle.Left;
            this.mnuthem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mnuthem.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuthem.ForeColor = System.Drawing.Color.Gainsboro;
            this.mnuthem.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.mnuthem.IconColor = System.Drawing.Color.Gainsboro;
            this.mnuthem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mnuthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuthem.Location = new System.Drawing.Point(0, 0);
            this.mnuthem.Name = "mnuthem";
            this.mnuthem.Size = new System.Drawing.Size(250, 86);
            this.mnuthem.TabIndex = 0;
            this.mnuthem.Text = "ADD";
            this.mnuthem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mnuthem.UseVisualStyleBackColor = false;
            this.mnuthem.Click += new System.EventHandler(this.mnuthem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1503, 275);
            this.panel1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtgianhap);
            this.groupBox1.Controls.Add(this.txtgiaban);
            this.groupBox1.Controls.Add(this.txtNgayCN);
            this.groupBox1.Controls.Add(this.cbbsp);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbsp);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1503, 275);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng Giá";
            // 
            // txtgianhap
            // 
            this.txtgianhap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtgianhap.BaseColor = System.Drawing.Color.White;
            this.txtgianhap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.txtgianhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtgianhap.FocusedBaseColor = System.Drawing.Color.White;
            this.txtgianhap.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.txtgianhap.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtgianhap.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgianhap.Location = new System.Drawing.Point(1204, 139);
            this.txtgianhap.Name = "txtgianhap";
            this.txtgianhap.PasswordChar = '\0';
            this.txtgianhap.SelectedText = "";
            this.txtgianhap.Size = new System.Drawing.Size(233, 40);
            this.txtgianhap.TabIndex = 15;
            // 
            // txtgiaban
            // 
            this.txtgiaban.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtgiaban.BaseColor = System.Drawing.Color.White;
            this.txtgiaban.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.txtgiaban.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtgiaban.FocusedBaseColor = System.Drawing.Color.White;
            this.txtgiaban.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.txtgiaban.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtgiaban.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgiaban.Location = new System.Drawing.Point(842, 139);
            this.txtgiaban.Name = "txtgiaban";
            this.txtgiaban.PasswordChar = '\0';
            this.txtgiaban.SelectedText = "";
            this.txtgiaban.Size = new System.Drawing.Size(233, 40);
            this.txtgiaban.TabIndex = 14;
            // 
            // txtNgayCN
            // 
            this.txtNgayCN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNgayCN.BaseColor = System.Drawing.Color.White;
            this.txtNgayCN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.txtNgayCN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNgayCN.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNgayCN.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.txtNgayCN.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNgayCN.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayCN.Location = new System.Drawing.Point(480, 139);
            this.txtNgayCN.Name = "txtNgayCN";
            this.txtNgayCN.PasswordChar = '\0';
            this.txtNgayCN.SelectedText = "";
            this.txtNgayCN.Size = new System.Drawing.Size(233, 40);
            this.txtNgayCN.TabIndex = 13;
            // 
            // cbbsp
            // 
            this.cbbsp.BackColor = System.Drawing.Color.Transparent;
            this.cbbsp.BaseColor = System.Drawing.Color.White;
            this.cbbsp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.cbbsp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbsp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbsp.FocusedColor = System.Drawing.Color.Empty;
            this.cbbsp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbsp.ForeColor = System.Drawing.Color.Black;
            this.cbbsp.FormattingEnabled = true;
            this.cbbsp.Location = new System.Drawing.Point(113, 144);
            this.cbbsp.Name = "cbbsp";
            this.cbbsp.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.cbbsp.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbsp.Size = new System.Drawing.Size(233, 35);
            this.cbbsp.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1204, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giá Nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(842, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá Bán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(480, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Nhập Giá";
            // 
            // lbsp
            // 
            this.lbsp.AutoSize = true;
            this.lbsp.Location = new System.Drawing.Point(113, 100);
            this.lbsp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbsp.Name = "lbsp";
            this.lbsp.Size = new System.Drawing.Size(137, 28);
            this.lbsp.TabIndex = 0;
            this.lbsp.Text = "Mã Sản Phẩm";
            // 
            // dgvBangGia
            // 
            this.dgvBangGia.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvBangGia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBangGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBangGia.BackgroundColor = System.Drawing.Color.White;
            this.dgvBangGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBangGia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBangGia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBangGia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBangGia.ColumnHeadersHeight = 40;
            this.dgvBangGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBangGia.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBangGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBangGia.EnableHeadersVisualStyles = false;
            this.dgvBangGia.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBangGia.Location = new System.Drawing.Point(0, 275);
            this.dgvBangGia.Name = "dgvBangGia";
            this.dgvBangGia.ReadOnly = true;
            this.dgvBangGia.RowHeadersVisible = false;
            this.dgvBangGia.RowHeadersWidth = 51;
            this.dgvBangGia.RowTemplate.Height = 40;
            this.dgvBangGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBangGia.Size = new System.Drawing.Size(1503, 592);
            this.dgvBangGia.TabIndex = 5;
            this.dgvBangGia.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvBangGia.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBangGia.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBangGia.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBangGia.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBangGia.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBangGia.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvBangGia.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBangGia.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.dgvBangGia.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBangGia.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.dgvBangGia.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBangGia.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBangGia.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvBangGia.ThemeStyle.ReadOnly = true;
            this.dgvBangGia.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBangGia.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBangGia.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvBangGia.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBangGia.ThemeStyle.RowsStyle.Height = 40;
            this.dgvBangGia.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBangGia.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBangGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBangGia_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "msp";
            this.Column1.HeaderText = "Mã Sản Phẩm";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tsp";
            this.Column2.HeaderText = "Tên Sản Phẩm";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ncn";
            this.Column3.HeaderText = "Ngày Cập Nhật";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "gb";
            this.Column4.HeaderText = "Giá Bán";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "gn";
            this.Column5.HeaderText = "Giá Nhập";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // BangGiaGUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1503, 953);
            this.Controls.Add(this.dgvBangGia);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelCongCu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BangGiaGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BangGiaGUI";
            this.Load += new System.EventHandler(this.BangGiaGUI_Load);
            this.panelCongCu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCongCu;
        private FontAwesome.Sharp.IconButton mnuDong;
        private FontAwesome.Sharp.IconButton mnuxoa;
        private FontAwesome.Sharp.IconButton mnusua;
        private FontAwesome.Sharp.IconButton mnuluu;
        private FontAwesome.Sharp.IconButton mnuthem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbsp;
        private Guna.UI.WinForms.GunaComboBox cbbsp;
        private Guna.UI.WinForms.GunaDataGridView dgvBangGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private Guna.UI.WinForms.GunaTextBox txtgianhap;
        private Guna.UI.WinForms.GunaTextBox txtgiaban;
        private Guna.UI.WinForms.GunaTextBox txtNgayCN;
    }
}