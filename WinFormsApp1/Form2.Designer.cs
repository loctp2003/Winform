namespace WinFormsApp1
{
    partial class Form2
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
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.lblMaGV = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.gtNgaySinh = new System.Windows.Forms.Label();
            this.lblCMND = new System.Windows.Forms.Label();
            this.lblQueQuan = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.gvGiaoVien = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvGiaoVien)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(146, 320);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(250, 27);
            this.txtSDT.TabIndex = 37;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(146, 273);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 27);
            this.txtEmail.TabIndex = 36;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(19, 323);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(97, 20);
            this.lblSDT.TabIndex = 35;
            this.lblSDT.Text = "So dien thoai";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(19, 276);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 20);
            this.lblEmail.TabIndex = 34;
            this.lblEmail.Text = "Email";
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(146, 28);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(250, 27);
            this.txtMaGV.TabIndex = 33;
            // 
            // lblMaGV
            // 
            this.lblMaGV.AutoSize = true;
            this.lblMaGV.Location = new System.Drawing.Point(19, 31);
            this.lblMaGV.Name = "lblMaGV";
            this.lblMaGV.Size = new System.Drawing.Size(95, 20);
            this.lblMaGV.TabIndex = 32;
            this.lblMaGV.Text = "Ma giao vien";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(146, 168);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(250, 27);
            this.dtpNgaySinh.TabIndex = 30;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(146, 121);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(250, 27);
            this.txtQueQuan.TabIndex = 29;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(146, 223);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(250, 27);
            this.txtCMND.TabIndex = 28;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(146, 72);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(250, 27);
            this.txtTen.TabIndex = 27;
            // 
            // gtNgaySinh
            // 
            this.gtNgaySinh.AutoSize = true;
            this.gtNgaySinh.Location = new System.Drawing.Point(19, 173);
            this.gtNgaySinh.Name = "gtNgaySinh";
            this.gtNgaySinh.Size = new System.Drawing.Size(76, 20);
            this.gtNgaySinh.TabIndex = 26;
            this.gtNgaySinh.Text = "Ngay Sinh";
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Location = new System.Drawing.Point(19, 226);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(53, 20);
            this.lblCMND.TabIndex = 25;
            this.lblCMND.Text = "CMND";
            // 
            // lblQueQuan
            // 
            this.lblQueQuan.AutoSize = true;
            this.lblQueQuan.Location = new System.Drawing.Point(19, 124);
            this.lblQueQuan.Name = "lblQueQuan";
            this.lblQueQuan.Size = new System.Drawing.Size(75, 20);
            this.lblQueQuan.TabIndex = 24;
            this.lblQueQuan.Text = "Que Quan";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(19, 75);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(75, 20);
            this.lblHoTen.TabIndex = 23;
            this.lblHoTen.Text = "Ho va Ten";
            // 
            // gvGiaoVien
            // 
            this.gvGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGiaoVien.Location = new System.Drawing.Point(402, 12);
            this.gvGiaoVien.Name = "gvGiaoVien";
            this.gvGiaoVien.RowHeadersWidth = 51;
            this.gvGiaoVien.RowTemplate.Height = 29;
            this.gvGiaoVien.Size = new System.Drawing.Size(585, 356);
            this.gvGiaoVien.TabIndex = 22;
            this.gvGiaoVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvGiaoVien_CellContentClick);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(457, 393);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 29);
            this.btnSua.TabIndex = 21;
            this.btnSua.Text = "Sua";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(274, 393);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 29);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(83, 393);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 29);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 450);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtMaGV);
            this.Controls.Add(this.lblMaGV);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtQueQuan);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.gtNgaySinh);
            this.Controls.Add(this.lblCMND);
            this.Controls.Add(this.lblQueQuan);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.gvGiaoVien);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Name = "Form2";
            this.Text = "GiaoVien";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvGiaoVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtSDT;
        private TextBox txtEmail;
        private Label lblSDT;
        private Label lblEmail;
        private TextBox txtMaGV;
        private Label lblMaGV;
        private DateTimePicker dtpNgaySinh;
        private TextBox txtQueQuan;
        private TextBox txtCMND;
        private TextBox txtTen;
        private Label gtNgaySinh;
        private Label lblCMND;
        private Label lblQueQuan;
        private Label lblHoTen;
        private DataGridView gvGiaoVien;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
    }
}