namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.gvHocSinh = new System.Windows.Forms.DataGridView();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblQueQuan = new System.Windows.Forms.Label();
            this.lblCMND = new System.Windows.Forms.Label();
            this.gtNgaySinh = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btnGiaoVien = new System.Windows.Forms.Button();
            this.lblMaHs = new System.Windows.Forms.Label();
            this.txtMaHS = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvHocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(97, 374);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 29);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(288, 374);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 29);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(471, 374);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 29);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sua";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // gvHocSinh
            // 
            this.gvHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvHocSinh.Location = new System.Drawing.Point(418, 12);
            this.gvHocSinh.Name = "gvHocSinh";
            this.gvHocSinh.RowHeadersWidth = 51;
            this.gvHocSinh.RowTemplate.Height = 29;
            this.gvHocSinh.Size = new System.Drawing.Size(585, 356);
            this.gvHocSinh.TabIndex = 3;
            this.gvHocSinh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvHocSinh_CellContentClick);
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(33, 56);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(75, 20);
            this.lblHoTen.TabIndex = 4;
            this.lblHoTen.Text = "Ho va Ten";
            // 
            // lblQueQuan
            // 
            this.lblQueQuan.AutoSize = true;
            this.lblQueQuan.Location = new System.Drawing.Point(33, 105);
            this.lblQueQuan.Name = "lblQueQuan";
            this.lblQueQuan.Size = new System.Drawing.Size(75, 20);
            this.lblQueQuan.TabIndex = 5;
            this.lblQueQuan.Text = "Que Quan";
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Location = new System.Drawing.Point(33, 207);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(53, 20);
            this.lblCMND.TabIndex = 6;
            this.lblCMND.Text = "CMND";
            // 
            // gtNgaySinh
            // 
            this.gtNgaySinh.AutoSize = true;
            this.gtNgaySinh.Location = new System.Drawing.Point(33, 154);
            this.gtNgaySinh.Name = "gtNgaySinh";
            this.gtNgaySinh.Size = new System.Drawing.Size(76, 20);
            this.gtNgaySinh.TabIndex = 7;
            this.gtNgaySinh.Text = "Ngay Sinh";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(160, 53);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(250, 27);
            this.txtTen.TabIndex = 8;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(160, 204);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(250, 27);
            this.txtCMND.TabIndex = 9;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(160, 102);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(250, 27);
            this.txtQueQuan.TabIndex = 10;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(160, 149);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(250, 27);
            this.dtpNgaySinh.TabIndex = 11;
            // 
            // btnGiaoVien
            // 
            this.btnGiaoVien.Location = new System.Drawing.Point(744, 374);
            this.btnGiaoVien.Name = "btnGiaoVien";
            this.btnGiaoVien.Size = new System.Drawing.Size(94, 29);
            this.btnGiaoVien.TabIndex = 12;
            this.btnGiaoVien.Text = "GiaoVien";
            this.btnGiaoVien.UseVisualStyleBackColor = true;
            this.btnGiaoVien.Click += new System.EventHandler(this.btnGiaoVien_Click);
            // 
            // lblMaHs
            // 
            this.lblMaHs.AutoSize = true;
            this.lblMaHs.Location = new System.Drawing.Point(33, 12);
            this.lblMaHs.Name = "lblMaHs";
            this.lblMaHs.Size = new System.Drawing.Size(88, 20);
            this.lblMaHs.TabIndex = 13;
            this.lblMaHs.Text = "Ma hoc sinh";
            // 
            // txtMaHS
            // 
            this.txtMaHS.Location = new System.Drawing.Point(160, 9);
            this.txtMaHS.Name = "txtMaHS";
            this.txtMaHS.Size = new System.Drawing.Size(250, 27);
            this.txtMaHS.TabIndex = 14;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(33, 257);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 20);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "Email";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(33, 304);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(97, 20);
            this.lblSDT.TabIndex = 16;
            this.lblSDT.Text = "So dien thoai";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(160, 254);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 27);
            this.txtEmail.TabIndex = 17;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(160, 301);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(250, 27);
            this.txtSDT.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 450);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtMaHS);
            this.Controls.Add(this.lblMaHs);
            this.Controls.Add(this.btnGiaoVien);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtQueQuan);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.gtNgaySinh);
            this.Controls.Add(this.lblCMND);
            this.Controls.Add(this.lblQueQuan);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.gvHocSinh);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Name = "Form1";
            this.Text = "HocSinh";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvHocSinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private DataGridView gvHocSinh;
        private Label lblHoTen;
        private Label lblQueQuan;
        private Label lblCMND;
        private Label gtNgaySinh;
        private TextBox txtTen;
        private TextBox txtCMND;
        private TextBox txtQueQuan;
        private DateTimePicker dtpNgaySinh;
        private Button btnGiaoVien;
        private Label lblMaHs;
        private TextBox txtMaHS;
        private Label lblEmail;
        private Label lblSDT;
        private TextBox txtEmail;
        private TextBox txtSDT;
    }
}