using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class GiaoVien
    {

        private string maGV;
        private string ten;
        private string queQuan;
        private DateTime ngaySinh;
        private string cmnd;
        private string email;
        private string sdt;
        public GiaoVien(string maGV, string ten, string queQuan, DateTime ngaySinh, string cmnd, string email, string sdt)
        {
            this.maGV = maGV;
            this.ten = ten;
            this.queQuan = queQuan;
            this.ngaySinh = ngaySinh;
            this.cmnd = cmnd;
            this.email = email;
            this.sdt = sdt;
        }
        public string MaGV { get { return maGV; } set { maGV = value; } }
        public string Ten { get { return ten; } set { ten = value; } }
        public string QueQuan { get { return queQuan; } set { queQuan = value; } }
        public string CMND { get { return cmnd; } set { cmnd = value; } }
        public DateTime NgaySinh { get { return ngaySinh; } set { ngaySinh = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Sdt { get { return sdt; } set { sdt = value; } }
    }
}
