using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class HocSinhDao
    {
        Dao dao = new Dao();

        public DataTable LayDanhSachHocSinh()
        {
            string sqlStr = string.Format("SELECT *FROM HocSinh");
            return dao.LayDanhSach(sqlStr);
        }
        public void Them(HocSinh hs)
        {
            bool check = dao.CheckTrue(hs.MaHS, hs.Ten, hs.QueQuan, hs.CMND, hs.Email, hs.Sdt);
            if (check)
            {
                string sqlStr1 = string.Format("INSERT INTO HocSinh(MaHS, Ten, QueQuan, NgaySinh, CMND, Email, SDT) Values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')"
                , hs.MaHS, hs.Ten, hs.QueQuan, hs.NgaySinh, hs.CMND, hs.Email, hs.Sdt);
                dao.ThucThi(sqlStr1);
            }
        }
        public void Xoa(HocSinh hs)
        {

            string sqlStr = string.Format("DELETE FROM HocSinh Where MaHS = '{0}'", hs.MaHS);
            dao.ThucThi(sqlStr);
        }
        public void Sua(HocSinh hs)
        {
            bool check = dao.CheckTrue(hs.MaHS, hs.Ten, hs.QueQuan, hs.CMND, hs.Email, hs.Sdt);
            if (check)
            {
                string sqlStr = string.Format("UPDATE HocSinh Set Ten = '{0}', QueQuan = '{1}', NgaySinh = '{2}', CMND = '{3}', Email = '{4}', SDT = '{5}' where MaHS = '{6}'",
                hs.Ten, hs.QueQuan, hs.NgaySinh, hs.CMND, hs.Email, hs.Sdt, hs.MaHS);
                dao.ThucThi(sqlStr);
            }
        }
    }
}
