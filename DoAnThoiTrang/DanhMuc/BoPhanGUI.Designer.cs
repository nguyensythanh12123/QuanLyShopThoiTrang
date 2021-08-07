namespace DoAnThoiTrang.DanhMuc
{
    partial class BoPhanGUI
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
            this.panelCongCu = new System.Windows.Forms.Panel();
            this.mnuDong = new FontAwesome.Sharp.IconButton();
            this.mnuxoa = new FontAwesome.Sharp.IconButton();
            this.mnusua = new FontAwesome.Sharp.IconButton();
            this.mnuluu = new FontAwesome.Sharp.IconButton();
            this.mnuthem = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTenBP = new System.Windows.Forms.TextBox();
            this.txtMaBP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvBoPhan = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panelCongCu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoPhan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelCongCu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 820);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1535, 86);
            this.panel1.TabIndex = 0;
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
            this.panelCongCu.Location = new System.Drawing.Point(0, 0);
            this.panelCongCu.Name = "panelCongCu";
            this.panelCongCu.Size = new System.Drawing.Size(1535, 86);
            this.panelCongCu.TabIndex = 1;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1535, 275);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTenBP);
            this.groupBox1.Controls.Add(this.txtMaBP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1535, 275);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bộ Phận";
            // 
            // txtTenBP
            // 
            this.txtTenBP.Location = new System.Drawing.Point(883, 141);
            this.txtTenBP.Multiline = true;
            this.txtTenBP.Name = "txtTenBP";
            this.txtTenBP.Size = new System.Drawing.Size(300, 40);
            this.txtTenBP.TabIndex = 17;
            // 
            // txtMaBP
            // 
            this.txtMaBP.Location = new System.Drawing.Point(355, 141);
            this.txtMaBP.Multiline = true;
            this.txtMaBP.Name = "txtMaBP";
            this.txtMaBP.Size = new System.Drawing.Size(300, 40);
            this.txtMaBP.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã Bộ Phận";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(878, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên Bộ Phận";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvBoPhan);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 275);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1535, 545);
            this.panel3.TabIndex = 2;
            // 
            // dgvBoPhan
            // 
            this.dgvBoPhan.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvBoPhan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBoPhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBoPhan.BackgroundColor = System.Drawing.Color.White;
            this.dgvBoPhan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBoPhan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBoPhan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBoPhan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBoPhan.ColumnHeadersHeight = 40;
            this.dgvBoPhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBoPhan.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBoPhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBoPhan.EnableHeadersVisualStyles = false;
            this.dgvBoPhan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBoPhan.Location = new System.Drawing.Point(0, 0);
            this.dgvBoPhan.Name = "dgvBoPhan";
            this.dgvBoPhan.ReadOnly = true;
            this.dgvBoPhan.RowHeadersVisible = false;
            this.dgvBoPhan.RowHeadersWidth = 51;
            this.dgvBoPhan.RowTemplate.Height = 40;
            this.dgvBoPhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBoPhan.Size = new System.Drawing.Size(1535, 545);
            this.dgvBoPhan.TabIndex = 0;
            this.dgvBoPhan.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvBoPhan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBoPhan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBoPhan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBoPhan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBoPhan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBoPhan.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvBoPhan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBoPhan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.dgvBoPhan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBoPhan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.dgvBoPhan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBoPhan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBoPhan.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvBoPhan.ThemeStyle.ReadOnly = true;
            this.dgvBoPhan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBoPhan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBoPhan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvBoPhan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBoPhan.ThemeStyle.RowsStyle.Height = 40;
            this.dgvBoPhan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBoPhan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBoPhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBoPhan_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MABP";
            this.Column1.HeaderText = "Mã Bộ Phận";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENBP";
            this.Column2.HeaderText = "Tên Bộ Phận";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // BoPhanGUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1535, 906);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BoPhanGUI";
            this.Text = "BoPhan";
            this.Load += new System.EventHandler(this.BoPhanGUI_Load);
            this.panel1.ResumeLayout(false);
            this.panelCongCu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoPhan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelCongCu;
        private FontAwesome.Sharp.IconButton mnuDong;
        private FontAwesome.Sharp.IconButton mnuxoa;
        private FontAwesome.Sharp.IconButton mnusua;
        private FontAwesome.Sharp.IconButton mnuluu;
        private FontAwesome.Sharp.IconButton mnuthem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaDataGridView dgvBoPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TextBox txtTenBP;
        private System.Windows.Forms.TextBox txtMaBP;
    }
}