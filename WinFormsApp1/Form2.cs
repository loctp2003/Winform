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
    public partial class Form2 : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        GiaoVienDao gvDao = new GiaoVienDao();
        Dao dao = new Dao();
        public Form2()
        {
            InitializeComponent();
        }
        private void LoadForm()
        {
            this.gvGiaoVien.DataSource = gvDao.LayDanhSachGiaoVien();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            GiaoVien giaovien = new GiaoVien(txtMaGV.Text, txtTen.Text, txtQueQuan.Text, dtpNgaySinh.Value, txtCMND.Text, txtEmail.Text, txtSDT.Text);
            gvDao.Them(giaovien);
            LoadForm();
        }

        private void gvGiaoVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dao.GVToTextBox(gvGiaoVien, "MaGV", txtMaGV, txtTen, txtQueQuan, dtpNgaySinh, txtCMND, txtEmail, txtSDT);
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            GiaoVien giaovien = new GiaoVien(txtMaGV.Text, txtTen.Text, txtQueQuan.Text, dtpNgaySinh.Value, txtCMND.Text, txtEmail.Text, txtSDT.Text);
            gvDao.Xoa(giaovien);
            LoadForm();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            GiaoVien giaovien = new GiaoVien(txtMaGV.Text, txtTen.Text, txtQueQuan.Text, dtpNgaySinh.Value, txtCMND.Text, txtEmail.Text, txtSDT.Text);
            gvDao.Sua(giaovien);
            LoadForm();
        }
    }
}
