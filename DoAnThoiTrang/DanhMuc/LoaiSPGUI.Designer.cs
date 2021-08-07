namespace DoAnThoiTrang.DanhMuc
{
    partial class LoaiSPGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelCongCu = new System.Windows.Forms.Panel();
            this.mnuDong = new FontAwesome.Sharp.IconButton();
            this.mnuxoa = new FontAwesome.Sharp.IconButton();
            this.mnusua = new FontAwesome.Sharp.IconButton();
            this.mnuluu = new FontAwesome.Sharp.IconButton();
            this.mnuthem = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtten = new Guna.UI.WinForms.GunaTextBox();
            this.txtma = new Guna.UI.WinForms.GunaTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvloaisp = new Guna.UI.WinForms.GunaDataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCongCu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvloaisp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(838, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Loại";
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
            this.panelCongCu.TabIndex = 6;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtten);
            this.groupBox1.Controls.Add(this.txtma);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1535, 275);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại Sản Phẩm";
            // 
            // txtten
            // 
            this.txtten.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtten.BaseColor = System.Drawing.Color.White;
            this.txtten.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.txtten.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtten.FocusedBaseColor = System.Drawing.Color.White;
            this.txtten.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.txtten.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtten.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtten.Location = new System.Drawing.Point(838, 134);
            this.txtten.Name = "txtten";
            this.txtten.PasswordChar = '\0';
            this.txtten.SelectedText = "";
            this.txtten.Size = new System.Drawing.Size(300, 40);
            this.txtten.TabIndex = 16;
            // 
            // txtma
            // 
            this.txtma.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtma.BaseColor = System.Drawing.Color.White;
            this.txtma.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.txtma.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtma.FocusedBaseColor = System.Drawing.Color.White;
            this.txtma.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.txtma.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtma.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtma.Location = new System.Drawing.Point(428, 134);
            this.txtma.Name = "txtma";
            this.txtma.PasswordChar = '\0';
            this.txtma.SelectedText = "";
            this.txtma.Size = new System.Drawing.Size(300, 40);
            this.txtma.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvloaisp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 275);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1535, 545);
            this.panel1.TabIndex = 8;
            // 
            // dgvloaisp
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvloaisp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvloaisp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvloaisp.BackgroundColor = System.Drawing.Color.White;
            this.dgvloaisp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvloaisp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvloaisp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvloaisp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvloaisp.ColumnHeadersHeight = 40;
            this.dgvloaisp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvloaisp.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvloaisp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvloaisp.EnableHeadersVisualStyles = false;
            this.dgvloaisp.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvloaisp.Location = new System.Drawing.Point(0, 0);
            this.dgvloaisp.Name = "dgvloaisp";
            this.dgvloaisp.RowHeadersVisible = false;
            this.dgvloaisp.RowHeadersWidth = 51;
            this.dgvloaisp.RowTemplate.Height = 40;
            this.dgvloaisp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvloaisp.Size = new System.Drawing.Size(1535, 545);
            this.dgvloaisp.TabIndex = 0;
            this.dgvloaisp.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvloaisp.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvloaisp.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvloaisp.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvloaisp.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvloaisp.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvloaisp.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvloaisp.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvloaisp.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.dgvloaisp.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvloaisp.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvloaisp.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvloaisp.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvloaisp.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvloaisp.ThemeStyle.ReadOnly = false;
            this.dgvloaisp.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvloaisp.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvloaisp.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvloaisp.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvloaisp.ThemeStyle.RowsStyle.Height = 40;
            this.dgvloaisp.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvloaisp.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvloaisp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvloaisp_CellClick);
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MALOAI";
            this.Column3.HeaderText = "Mã Loại";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TENLOAI";
            this.Column4.HeaderText = "Tên Loại";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // LoaiSPGUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1535, 906);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelCongCu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoaiSPGUI";
            this.Text = "LoaiSP_GUI";
            this.Load += new System.EventHandler(this.LoaiSP_GUI_Load);
            this.panelCongCu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvloaisp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelCongCu;
        private FontAwesome.Sharp.IconButton mnuDong;
        private FontAwesome.Sharp.IconButton mnuxoa;
        private FontAwesome.Sharp.IconButton mnusua;
        private FontAwesome.Sharp.IconButton mnuluu;
        private FontAwesome.Sharp.IconButton mnuthem;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI.WinForms.GunaTextBox txtten;
        private Guna.UI.WinForms.GunaTextBox txtma;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaDataGridView dgvloaisp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}