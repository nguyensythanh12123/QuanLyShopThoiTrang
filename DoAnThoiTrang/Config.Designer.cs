namespace DoAnThoiTrang
{
    partial class Config
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbserver = new Guna.UI.WinForms.GunaComboBox();
            this.cbbdatabase = new Guna.UI.WinForms.GunaComboBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(47, 264);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Database";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(47, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Server name";
            // 
            // cbbserver
            // 
            this.cbbserver.BackColor = System.Drawing.Color.Transparent;
            this.cbbserver.BaseColor = System.Drawing.Color.White;
            this.cbbserver.BorderColor = System.Drawing.Color.SeaGreen;
            this.cbbserver.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbserver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbserver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbserver.FocusedColor = System.Drawing.Color.Empty;
            this.cbbserver.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbserver.ForeColor = System.Drawing.Color.Black;
            this.cbbserver.FormattingEnabled = true;
            this.cbbserver.Location = new System.Drawing.Point(229, 78);
            this.cbbserver.Name = "cbbserver";
            this.cbbserver.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.cbbserver.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbserver.Size = new System.Drawing.Size(325, 32);
            this.cbbserver.TabIndex = 20;
            this.cbbserver.DropDown += new System.EventHandler(this.cbbserver_DropDown);
            // 
            // cbbdatabase
            // 
            this.cbbdatabase.BackColor = System.Drawing.Color.Transparent;
            this.cbbdatabase.BaseColor = System.Drawing.Color.White;
            this.cbbdatabase.BorderColor = System.Drawing.Color.SeaGreen;
            this.cbbdatabase.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbdatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbdatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbdatabase.FocusedColor = System.Drawing.Color.Empty;
            this.cbbdatabase.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbdatabase.ForeColor = System.Drawing.Color.Black;
            this.cbbdatabase.FormattingEnabled = true;
            this.cbbdatabase.Location = new System.Drawing.Point(229, 260);
            this.cbbdatabase.Name = "cbbdatabase";
            this.cbbdatabase.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.cbbdatabase.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbdatabase.Size = new System.Drawing.Size(325, 32);
            this.cbbdatabase.TabIndex = 21;
            this.cbbdatabase.DropDown += new System.EventHandler(this.cbbdatabase_DropDown);
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusername.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtusername.Location = new System.Drawing.Point(229, 135);
            this.txtusername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtusername.Multiline = true;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(325, 30);
            this.txtusername.TabIndex = 22;
            this.txtusername.Text = "Username";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(229, 172);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(319, 1);
            this.panel4.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(229, 236);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 1);
            this.panel1.TabIndex = 23;
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpassword.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtpassword.Location = new System.Drawing.Point(229, 196);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpassword.Multiline = true;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(325, 30);
            this.txtpassword.TabIndex = 24;
            this.txtpassword.Text = "Password";
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(252)))), ((int)(((byte)(234)))));
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnsave.Location = new System.Drawing.Point(229, 312);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(140, 55);
            this.btnsave.TabIndex = 27;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(252)))), ((int)(((byte)(234)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnExit.Location = new System.Drawing.Point(414, 312);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 55);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(621, 404);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.cbbdatabase);
            this.Controls.Add(this.cbbserver);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConfig";
            this.Load += new System.EventHandler(this.Config_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaComboBox cbbserver;
        private Guna.UI.WinForms.GunaComboBox cbbdatabase;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnExit;
    }
}