namespace DoAnThoiTrang
{
    partial class NhapHangGUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTim = new FontAwesome.Sharp.IconButton();
            this.txtMaPN = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.trvDonDatHang = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbbNhanVien = new Guna.UI.WinForms.GunaComboBox();
            this.btnLoc = new FontAwesome.Sharp.IconButton();
            this.cbbNcc = new Guna.UI.WinForms.GunaComboBox();
            this.txtNgayNhap = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelCongCu = new System.Windows.Forms.Panel();
            this.btnThoat = new FontAwesome.Sharp.IconButton();
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnLuu = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvNhapHang = new Guna.UI.WinForms.GunaDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTienChu = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTongTien = new Guna.UI.WinForms.GunaTextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelCongCu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 344);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.trvDonDatHang);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1924, 344);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Đặt Hàng Nhà Cung Cấp";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.btnTim);
            this.groupBox3.Controls.Add(this.txtMaPN);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(1326, 44);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(586, 281);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm Kiếm";
            this.groupBox3.Visible = false;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTim.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnTim.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTim.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.Location = new System.Drawing.Point(269, 154);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(199, 61);
            this.btnTim.TabIndex = 21;
            this.btnTim.Text = "Tìm ";
            this.btnTim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtMaPN
            // 
            this.txtMaPN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMaPN.BaseColor = System.Drawing.Color.White;
            this.txtMaPN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.txtMaPN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaPN.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMaPN.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.txtMaPN.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMaPN.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPN.Location = new System.Drawing.Point(219, 90);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.PasswordChar = '\0';
            this.txtMaPN.SelectedText = "";
            this.txtMaPN.Size = new System.Drawing.Size(319, 41);
            this.txtMaPN.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã Phiếu Nhập";
            // 
            // trvDonDatHang
            // 
            this.trvDonDatHang.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trvDonDatHang.Location = new System.Drawing.Point(646, 44);
            this.trvDonDatHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trvDonDatHang.Name = "trvDonDatHang";
            this.trvDonDatHang.Size = new System.Drawing.Size(674, 281);
            this.trvDonDatHang.TabIndex = 4;
            this.trvDonDatHang.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvDonDatHang_AfterSelect);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.51955F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.48045F));
            this.tableLayoutPanel2.Controls.Add(this.cbbNhanVien, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnLoc, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.cbbNcc, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtNgayNhap, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(54, 44);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(564, 281);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // cbbNhanVien
            // 
            this.cbbNhanVien.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbbNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.cbbNhanVien.BaseColor = System.Drawing.Color.White;
            this.cbbNhanVien.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.cbbNhanVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNhanVien.FocusedColor = System.Drawing.Color.Empty;
            this.cbbNhanVien.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNhanVien.ForeColor = System.Drawing.Color.Black;
            this.cbbNhanVien.FormattingEnabled = true;
            this.cbbNhanVien.Location = new System.Drawing.Point(192, 155);
            this.cbbNhanVien.Name = "cbbNhanVien";
            this.cbbNhanVien.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.cbbNhanVien.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbNhanVien.Size = new System.Drawing.Size(349, 39);
            this.cbbNhanVien.TabIndex = 14;
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoc.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLoc.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.btnLoc.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLoc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoc.Location = new System.Drawing.Point(192, 213);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(184, 60);
            this.btnLoc.TabIndex = 5;
            this.btnLoc.Text = "LỌC";
            this.btnLoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // cbbNcc
            // 
            this.cbbNcc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbbNcc.BackColor = System.Drawing.Color.Transparent;
            this.cbbNcc.BaseColor = System.Drawing.Color.White;
            this.cbbNcc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.cbbNcc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbNcc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNcc.FocusedColor = System.Drawing.Color.Empty;
            this.cbbNcc.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNcc.ForeColor = System.Drawing.Color.Black;
            this.cbbNcc.FormattingEnabled = true;
            this.cbbNcc.Location = new System.Drawing.Point(192, 15);
            this.cbbNcc.Name = "cbbNcc";
            this.cbbNcc.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.cbbNcc.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbNcc.Size = new System.Drawing.Size(349, 39);
            this.cbbNcc.TabIndex = 13;
            // 
            // txtNgayNhap
            // 
            this.txtNgayNhap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNgayNhap.BaseColor = System.Drawing.Color.White;
            this.txtNgayNhap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.txtNgayNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNgayNhap.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNgayNhap.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.txtNgayNhap.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNgayNhap.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayNhap.Location = new System.Drawing.Point(192, 85);
            this.txtNgayNhap.Name = "txtNgayNhap";
            this.txtNgayNhap.PasswordChar = '\0';
            this.txtNgayNhap.SelectedText = "";
            this.txtNgayNhap.Size = new System.Drawing.Size(349, 40);
            this.txtNgayNhap.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhà Cung Cấp";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 28);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nhân viên";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày Nhập";
            // 
            // panelCongCu
            // 
            this.panelCongCu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelCongCu.Controls.Add(this.btnThoat);
            this.panelCongCu.Controls.Add(this.btnTimKiem);
            this.panelCongCu.Controls.Add(this.btnXoa);
            this.panelCongCu.Controls.Add(this.btnSua);
            this.panelCongCu.Controls.Add(this.btnLuu);
            this.panelCongCu.Controls.Add(this.btnThem);
            this.panelCongCu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCongCu.Location = new System.Drawing.Point(0, 946);
            this.panelCongCu.Name = "panelCongCu";
            this.panelCongCu.Size = new System.Drawing.Size(1924, 109);
            this.panelCongCu.TabIndex = 3;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnThoat.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnThoat.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnThoat.IconColor = System.Drawing.Color.Gainsboro;
            this.btnThoat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(1430, 0);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(286, 109);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnTimKiem.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTimKiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnTimKiem.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(1144, 0);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(286, 109);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "TÌM KIẾM";
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnXoa.IconColor = System.Drawing.Color.Gainsboro;
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(858, 0);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(286, 109);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSua.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnSua.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(572, 0);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(286, 109);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "SỬA";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnLuu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLuu.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnLuu.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLuu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(286, 0);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(286, 109);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnThem.IconColor = System.Drawing.Color.Gainsboro;
            this.btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(0, 0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(286, 109);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "THÊM";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvNhapHang);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 344);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1924, 502);
            this.panel2.TabIndex = 4;
            // 
            // dgvNhapHang
            // 
            this.dgvNhapHang.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvNhapHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNhapHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhapHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhapHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNhapHang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNhapHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhapHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvNhapHang.ColumnHeadersHeight = 40;
            this.dgvNhapHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Column6});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhapHang.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvNhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhapHang.EnableHeadersVisualStyles = false;
            this.dgvNhapHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNhapHang.Location = new System.Drawing.Point(0, 0);
            this.dgvNhapHang.Name = "dgvNhapHang";
            this.dgvNhapHang.RowHeadersVisible = false;
            this.dgvNhapHang.RowTemplate.Height = 40;
            this.dgvNhapHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhapHang.Size = new System.Drawing.Size(1924, 502);
            this.dgvNhapHang.TabIndex = 25;
            this.dgvNhapHang.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvNhapHang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNhapHang.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvNhapHang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvNhapHang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvNhapHang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvNhapHang.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvNhapHang.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNhapHang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.dgvNhapHang.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvNhapHang.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNhapHang.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvNhapHang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvNhapHang.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvNhapHang.ThemeStyle.ReadOnly = false;
            this.dgvNhapHang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNhapHang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNhapHang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNhapHang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.dgvNhapHang.ThemeStyle.RowsStyle.Height = 40;
            this.dgvNhapHang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNhapHang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "msp";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Sản Phẩm";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "tsp";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Sản Phẩm ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "sld";
            this.dataGridViewTextBoxColumn3.HeaderText = "Số Lượng";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "gn";
            this.dataGridViewTextBoxColumn4.HeaderText = "Giá Nhập";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "tt";
            this.dataGridViewTextBoxColumn5.HeaderText = "Thành Tiền";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "gc";
            this.Column6.HeaderText = "Ghi Chú";
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.Controls.Add(this.txtTienChu, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTongTien, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(899, 846);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1025, 100);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // txtTienChu
            // 
            this.txtTienChu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTienChu.BaseColor = System.Drawing.Color.White;
            this.txtTienChu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.txtTienChu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTienChu.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTienChu.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.txtTienChu.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTienChu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienChu.Location = new System.Drawing.Point(643, 27);
            this.txtTienChu.Name = "txtTienChu";
            this.txtTienChu.PasswordChar = '\0';
            this.txtTienChu.SelectedText = "";
            this.txtTienChu.Size = new System.Drawing.Size(378, 45);
            this.txtTienChu.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "TỔNG TIỀN";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTongTien.BaseColor = System.Drawing.Color.White;
            this.txtTongTien.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.txtTongTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTongTien.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTongTien.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.txtTongTien.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTongTien.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(259, 27);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.PasswordChar = '\0';
            this.txtTongTien.SelectedText = "";
            this.txtTongTien.Size = new System.Drawing.Size(377, 45);
            this.txtTongTien.TabIndex = 19;
            this.txtTongTien.TextChanged += new System.EventHandler(this.txtTongTien_TextChanged);
            // 
            // NhapHangGUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelCongCu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NhapHangGUI";
            this.Text = "NhapHangGUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.NhapHangGUI_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panelCongCu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView trvDonDatHang;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnLoc;
        private System.Windows.Forms.Panel panelCongCu;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnLuu;
        private FontAwesome.Sharp.IconButton btnThem;
        private Guna.UI.WinForms.GunaTextBox txtNgayNhap;
        private Guna.UI.WinForms.GunaComboBox cbbNhanVien;
        private Guna.UI.WinForms.GunaComboBox cbbNcc;
        private FontAwesome.Sharp.IconButton btnThoat;
        private System.Windows.Forms.GroupBox groupBox3;
        private FontAwesome.Sharp.IconButton btnTim;
        private Guna.UI.WinForms.GunaTextBox txtMaPN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaDataGridView dgvNhapHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI.WinForms.GunaTextBox txtTienChu;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox txtTongTien;
    }
}