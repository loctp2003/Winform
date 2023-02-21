using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        HocSinhDao hsDao = new HocSinhDao();
        Dao dao = new Dao();
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadForm()
        {
            this.gvHocSinh.DataSource = hsDao.LayDanhSachHocSinh();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh(txtMaHS.Text ,txtTen.Text, txtQueQuan.Text, dtpNgaySinh.Value, txtCMND.Text, txtEmail.Text, txtSDT.Text);
            hsDao.Them(hs);
            LoadForm();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh(txtMaHS.Text, txtTen.Text, txtQueQuan.Text, dtpNgaySinh.Value, txtCMND.Text, txtEmail.Text, txtSDT.Text);
            hsDao.Xoa(hs);
            LoadForm();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh(txtMaHS.Text, txtTen.Text, txtQueQuan.Text, dtpNgaySinh.Value, txtCMND.Text, txtEmail.Text, txtSDT.Text);
            hsDao.Sua(hs);
            LoadForm();
        }
        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void gvHocSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dao.GVToTextBox(gvHocSinh, "MaHS", txtMaHS, txtTen, txtQueQuan, dtpNgaySinh, txtCMND, txtEmail, txtSDT);
        }
    }
}
