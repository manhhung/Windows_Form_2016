namespace QLBH_3._5._16
{
    partial class DangNhapHT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhapHT));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTaiKhoan_HT = new System.Windows.Forms.TextBox();
            this.txtMatKhau_HT = new System.Windows.Forms.TextBox();
            this.btnDangNhap_HT = new System.Windows.Forms.Button();
            this.btnThoat_HT = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật khẩu";
            // 
            // txtTaiKhoan_HT
            // 
            this.txtTaiKhoan_HT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan_HT.Location = new System.Drawing.Point(169, 109);
            this.txtTaiKhoan_HT.Name = "txtTaiKhoan_HT";
            this.txtTaiKhoan_HT.Size = new System.Drawing.Size(204, 20);
            this.txtTaiKhoan_HT.TabIndex = 0;
            // 
            // txtMatKhau_HT
            // 
            this.txtMatKhau_HT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau_HT.Location = new System.Drawing.Point(169, 156);
            this.txtMatKhau_HT.Name = "txtMatKhau_HT";
            this.txtMatKhau_HT.PasswordChar = '*';
            this.txtMatKhau_HT.Size = new System.Drawing.Size(204, 20);
            this.txtMatKhau_HT.TabIndex = 1;
            // 
            // btnDangNhap_HT
            // 
            this.btnDangNhap_HT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap_HT.Location = new System.Drawing.Point(87, 205);
            this.btnDangNhap_HT.Name = "btnDangNhap_HT";
            this.btnDangNhap_HT.Size = new System.Drawing.Size(105, 23);
            this.btnDangNhap_HT.TabIndex = 2;
            this.btnDangNhap_HT.Text = "Đăng nhập";
            this.btnDangNhap_HT.UseVisualStyleBackColor = true;
            this.btnDangNhap_HT.Click += new System.EventHandler(this.btnDangNhap_HT_Click);
            // 
            // btnThoat_HT
            // 
            this.btnThoat_HT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat_HT.Location = new System.Drawing.Point(249, 205);
            this.btnThoat_HT.Name = "btnThoat_HT";
            this.btnThoat_HT.Size = new System.Drawing.Size(105, 23);
            this.btnThoat_HT.TabIndex = 3;
            this.btnThoat_HT.Text = "Thoát";
            this.btnThoat_HT.UseVisualStyleBackColor = true;
            this.btnThoat_HT.Click += new System.EventHandler(this.btnThoat_HT_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::QLBH_3._5._16.Properties.Resources.e1b81d3f5c5f;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(438, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // DangNhapHT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 272);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnThoat_HT);
            this.Controls.Add(this.btnDangNhap_HT);
            this.Controls.Add(this.txtMatKhau_HT);
            this.Controls.Add(this.txtTaiKhoan_HT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DangNhapHT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP HỆ THỐNG";
            this.Load += new System.EventHandler(this.DangNhapHT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTaiKhoan_HT;
        private System.Windows.Forms.TextBox txtMatKhau_HT;
        private System.Windows.Forms.Button btnDangNhap_HT;
        private System.Windows.Forms.Button btnThoat_HT;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}