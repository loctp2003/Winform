using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Permissions;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public class GiaoVienDao
    {
        Dao dao = new Dao();
        public DataTable LayDanhSachGiaoVien()
        {
            string sqlStr = string.Format("SELECT *FROM GiaoVien");
            return dao.LayDanhSach(sqlStr);
        }
        public void Them(GiaoVien hs)
        {
            bool check = dao.CheckTrue(hs.MaGV, hs.Ten, hs.QueQuan, hs.CMND, hs.Email, hs.Sdt);
            if (check)
            {
                string sqlStr1 = string.Format("INSERT INTO GiaoVien(MaGV, Ten, QueQuan, NgaySinh, CMND, Email, SDT) Values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')"
                , hs.MaGV, hs.Ten, hs.QueQuan, hs.NgaySinh, hs.CMND, hs.Email, hs.Sdt);
                dao.ThucThi(sqlStr1);
            }
        }
        public void Xoa(GiaoVien hs)
        {

            string sqlStr = string.Format("DELETE FROM GiaoVien Where MaGV = '{0}'", hs.MaGV);
            dao.ThucThi(sqlStr);
        }
        public void Sua(GiaoVien hs)
        {
            bool check = dao.CheckTrue(hs.MaGV, hs.Ten, hs.QueQuan, hs.CMND, hs.Email, hs.Sdt);
            if (check)
            {
                string sqlStr = string.Format("UPDATE GiaoVien Set Ten = '{0}', QueQuan = '{1}', NgaySinh = '{2}', CMND = '{3}', Email = '{4}', SDT = '{5}' where MaGV = '{6}'",
                hs.Ten, hs.QueQuan, hs.NgaySinh, hs.CMND, hs.Email, hs.Sdt, hs.MaGV);
                dao.ThucThi(sqlStr);
            }
        }
    }
}
