namespace DoAnThoiTrang
{
    partial class MessageBoxThanhCong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Test = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 148);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Test);
            this.panel3.Location = new System.Drawing.Point(118, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(419, 91);
            this.panel3.TabIndex = 4;
            // 
            // Test
            // 
            this.Test.AutoSize = true;
            this.Test.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Test.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Test.Location = new System.Drawing.Point(3, 20);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(39, 19);
            this.Test.TabIndex = 1;
            this.Test.Text = "Test";
            this.Test.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Location = new System.Drawing.Point(20, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(92, 91);
            this.panel2.TabIndex = 3;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Lime;
            this.iconPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.iconPictureBox1.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 91;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(92, 91);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Lime;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnOK.Location = new System.Drawing.Point(212, 166);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(122, 41);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // MessageBoxThanhCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 219);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageBoxThanhCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageBoxThanhCong";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Test;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Button btnOK;
    }
}