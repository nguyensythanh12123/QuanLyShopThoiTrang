namespace DoAnThoiTrang
{
    partial class DM_ManHinhGUI
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
            this.btnDong = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnLuu = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTenMH = new Guna.UI.WinForms.GunaTextBox();
            this.txtMaMH = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvmanhinh = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCongCu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmanhinh)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCongCu
            // 
            this.panelCongCu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelCongCu.Controls.Add(this.btnDong);
            this.panelCongCu.Controls.Add(this.btnXoa);
            this.panelCongCu.Controls.Add(this.btnSua);
            this.panelCongCu.Controls.Add(this.btnLuu);
            this.panelCongCu.Controls.Add(this.btnThem);
            this.panelCongCu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCongCu.Location = new System.Drawing.Point(0, 721);
            this.panelCongCu.Name = "panelCongCu";
            this.panelCongCu.Size = new System.Drawing.Size(1254, 86);
            this.panelCongCu.TabIndex = 3;
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnDong.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDong.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnDong.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(1000, 0);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(250, 86);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "EXIT";
            this.btnDong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
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
            this.btnXoa.Location = new System.Drawing.Point(750, 0);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(250, 86);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "REMOVE";
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
            this.btnSua.Location = new System.Drawing.Point(500, 0);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(250, 86);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "EDIT";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
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
            this.btnLuu.Location = new System.Drawing.Point(250, 0);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(250, 86);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "SAVE";
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
            this.btnThem.Size = new System.Drawing.Size(250, 86);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "ADD";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTenMH);
            this.groupBox1.Controls.Add(this.txtMaMH);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1254, 246);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH MỤC MÀN HÌNH";
            // 
            // txtTenMH
            // 
            this.txtTenMH.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTenMH.BaseColor = System.Drawing.Color.White;
            this.txtTenMH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.txtTenMH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenMH.Enabled = false;
            this.txtTenMH.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTenMH.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.txtTenMH.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTenMH.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMH.Location = new System.Drawing.Point(709, 141);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.PasswordChar = '\0';
            this.txtTenMH.SelectedText = "";
            this.txtTenMH.Size = new System.Drawing.Size(300, 40);
            this.txtTenMH.TabIndex = 18;
            // 
            // txtMaMH
            // 
            this.txtMaMH.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMaMH.BaseColor = System.Drawing.Color.White;
            this.txtMaMH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.txtMaMH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaMH.Enabled = false;
            this.txtMaMH.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMaMH.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.txtMaMH.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMaMH.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMH.Location = new System.Drawing.Point(332, 141);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.PasswordChar = '\0';
            this.txtMaMH.SelectedText = "";
            this.txtMaMH.Size = new System.Drawing.Size(300, 40);
            this.txtMaMH.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(709, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 28);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tên Màn Hình";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã Màn Hình";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvmanhinh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 246);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 475);
            this.panel1.TabIndex = 5;
            // 
            // dgvmanhinh
            // 
            this.dgvmanhinh.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvmanhinh.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvmanhinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvmanhinh.BackgroundColor = System.Drawing.Color.White;
            this.dgvmanhinh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvmanhinh.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvmanhinh.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvmanhinh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvmanhinh.ColumnHeadersHeight = 40;
            this.dgvmanhinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvmanhinh.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvmanhinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvmanhinh.EnableHeadersVisualStyles = false;
            this.dgvmanhinh.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvmanhinh.Location = new System.Drawing.Point(0, 0);
            this.dgvmanhinh.Name = "dgvmanhinh";
            this.dgvmanhinh.ReadOnly = true;
            this.dgvmanhinh.RowHeadersVisible = false;
            this.dgvmanhinh.RowTemplate.Height = 40;
            this.dgvmanhinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvmanhinh.Size = new System.Drawing.Size(1254, 475);
            this.dgvmanhinh.TabIndex = 0;
            this.dgvmanhinh.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvmanhinh.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvmanhinh.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvmanhinh.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvmanhinh.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvmanhinh.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvmanhinh.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvmanhinh.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvmanhinh.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.dgvmanhinh.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvmanhinh.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvmanhinh.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvmanhinh.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvmanhinh.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvmanhinh.ThemeStyle.ReadOnly = true;
            this.dgvmanhinh.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvmanhinh.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvmanhinh.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvmanhinh.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvmanhinh.ThemeStyle.RowsStyle.Height = 40;
            this.dgvmanhinh.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvmanhinh.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvmanhinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmanhinh_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MAMANHINH";
            this.Column1.HeaderText = "Mã Màn Hình";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENMANHINH";
            this.Column2.HeaderText = "Tên Màn Hình";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // DM_ManHinhGUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1254, 807);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelCongCu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DM_ManHinhGUI";
            this.Text = "DM_ManHinhGUI";
            this.Load += new System.EventHandler(this.DM_ManHinhGUI_Load);
            this.panelCongCu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmanhinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCongCu;
        private FontAwesome.Sharp.IconButton btnDong;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnLuu;
        private FontAwesome.Sharp.IconButton btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtTenMH;
        private Guna.UI.WinForms.GunaTextBox txtMaMH;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaDataGridView dgvmanhinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}