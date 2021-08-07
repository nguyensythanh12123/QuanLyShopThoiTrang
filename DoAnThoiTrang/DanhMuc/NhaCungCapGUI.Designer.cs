namespace DoAnThoiTrang.DanhMuc
{
    partial class NhaCungCapGUI
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
            this.panelCongCu = new System.Windows.Forms.Panel();
            this.mnuDong = new FontAwesome.Sharp.IconButton();
            this.mnuxoa = new FontAwesome.Sharp.IconButton();
            this.mnusua = new FontAwesome.Sharp.IconButton();
            this.mnuluu = new FontAwesome.Sharp.IconButton();
            this.mnuthem = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtsdt = new Guna.UI.WinForms.GunaTextBox();
            this.txtdiachi = new Guna.UI.WinForms.GunaTextBox();
            this.txtTenncc = new Guna.UI.WinForms.GunaTextBox();
            this.txtNhaCC = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvncc = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCongCu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvncc)).BeginInit();
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
            this.panelCongCu.Location = new System.Drawing.Point(0, 820);
            this.panelCongCu.Name = "panelCongCu";
            this.panelCongCu.Size = new System.Drawing.Size(1535, 86);
            this.panelCongCu.TabIndex = 2;
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
            this.panel1.Size = new System.Drawing.Size(1535, 275);
            this.panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtsdt);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.txtTenncc);
            this.groupBox1.Controls.Add(this.txtNhaCC);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1535, 275);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhà Cung Cấp";
            // 
            // txtsdt
            // 
            this.txtsdt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtsdt.BaseColor = System.Drawing.Color.White;
            this.txtsdt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.txtsdt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsdt.FocusedBaseColor = System.Drawing.Color.White;
            this.txtsdt.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.txtsdt.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtsdt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsdt.Location = new System.Drawing.Point(1177, 138);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.PasswordChar = '\0';
            this.txtsdt.SelectedText = "";
            this.txtsdt.Size = new System.Drawing.Size(300, 40);
            this.txtsdt.TabIndex = 17;
            this.txtsdt.Leave += new System.EventHandler(this.txtsdt_Leave);
            // 
            // txtdiachi
            // 
            this.txtdiachi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtdiachi.BaseColor = System.Drawing.Color.White;
            this.txtdiachi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.txtdiachi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdiachi.FocusedBaseColor = System.Drawing.Color.White;
            this.txtdiachi.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.txtdiachi.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtdiachi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiachi.Location = new System.Drawing.Point(827, 138);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.PasswordChar = '\0';
            this.txtdiachi.SelectedText = "";
            this.txtdiachi.Size = new System.Drawing.Size(300, 40);
            this.txtdiachi.TabIndex = 16;
            // 
            // txtTenncc
            // 
            this.txtTenncc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTenncc.BaseColor = System.Drawing.Color.White;
            this.txtTenncc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.txtTenncc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenncc.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTenncc.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.txtTenncc.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTenncc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenncc.Location = new System.Drawing.Point(477, 138);
            this.txtTenncc.Name = "txtTenncc";
            this.txtTenncc.PasswordChar = '\0';
            this.txtTenncc.SelectedText = "";
            this.txtTenncc.Size = new System.Drawing.Size(300, 40);
            this.txtTenncc.TabIndex = 15;
            // 
            // txtNhaCC
            // 
            this.txtNhaCC.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNhaCC.BaseColor = System.Drawing.Color.White;
            this.txtNhaCC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.txtNhaCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNhaCC.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNhaCC.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.txtNhaCC.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNhaCC.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhaCC.Location = new System.Drawing.Point(127, 138);
            this.txtNhaCC.Name = "txtNhaCC";
            this.txtNhaCC.PasswordChar = '\0';
            this.txtNhaCC.SelectedText = "";
            this.txtNhaCC.Size = new System.Drawing.Size(300, 40);
            this.txtNhaCC.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1177, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "SĐT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(827, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa Chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(477, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Nhà CC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhà CC";
            // 
            // dgvncc
            // 
            this.dgvncc.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvncc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvncc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvncc.BackgroundColor = System.Drawing.Color.White;
            this.dgvncc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvncc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvncc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvncc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvncc.ColumnHeadersHeight = 40;
            this.dgvncc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvncc.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvncc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvncc.EnableHeadersVisualStyles = false;
            this.dgvncc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvncc.Location = new System.Drawing.Point(0, 275);
            this.dgvncc.Name = "dgvncc";
            this.dgvncc.ReadOnly = true;
            this.dgvncc.RowHeadersVisible = false;
            this.dgvncc.RowHeadersWidth = 51;
            this.dgvncc.RowTemplate.Height = 40;
            this.dgvncc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvncc.Size = new System.Drawing.Size(1535, 545);
            this.dgvncc.TabIndex = 4;
            this.dgvncc.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvncc.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvncc.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvncc.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvncc.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvncc.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvncc.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvncc.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvncc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.dgvncc.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvncc.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvncc.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvncc.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvncc.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvncc.ThemeStyle.ReadOnly = true;
            this.dgvncc.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvncc.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvncc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvncc.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvncc.ThemeStyle.RowsStyle.Height = 40;
            this.dgvncc.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvncc.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvncc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvncc_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MANCC";
            this.Column1.HeaderText = "Mã Nhà Cung Cấp";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENNCC";
            this.Column2.HeaderText = "Tên Nhà Cung Cấp";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DIACHI";
            this.Column3.HeaderText = "Địa Chỉ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SDT";
            this.Column4.HeaderText = "Số Điện Thoại";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // NhaCungCapGUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1535, 906);
            this.Controls.Add(this.dgvncc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelCongCu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NhaCungCapGUI";
            this.Text = "NhaCungCapGUI";
            this.Load += new System.EventHandler(this.NhaCungCapGUI_Load);
            this.panelCongCu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvncc)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaDataGridView dgvncc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Guna.UI.WinForms.GunaTextBox txtsdt;
        private Guna.UI.WinForms.GunaTextBox txtdiachi;
        private Guna.UI.WinForms.GunaTextBox txtTenncc;
        private Guna.UI.WinForms.GunaTextBox txtNhaCC;
    }
}