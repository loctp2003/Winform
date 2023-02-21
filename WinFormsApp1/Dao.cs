using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Dao
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public DataTable LayDanhSach(string sqlStr)
        {
            DataTable dtds = new DataTable();
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                adapter.Fill(dtds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtds;
        }
        public bool CheckTrue(string ma, string ten, string quequan, string cmnd, string email,string sdt)
        {
            if (ma == "" || ten == "" || quequan == "" || cmnd == "" || email == "" || sdt == "")
            {
                MessageBox.Show("Không được để trống thông tin");
                return false;
            }
            if (!Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                MessageBox.Show("Email không hợp lệ");
                return false;
            }
            //SDT co 10 so
            if (!Regex.IsMatch(sdt, @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$"))
            {
                MessageBox.Show("SDT không hợp lệ");
                return false;
            }
            return true;
        }
        public void ThucThi(string sqlstr)
        {
            try
            {
                conn.Open();
                string sqlStr1 = string.Format(sqlstr);
                SqlCommand cmd = new SqlCommand(sqlStr1, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất bại" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
        public void GVToTextBox(DataGridView gv, string sql,TextBox txtMa,TextBox txtTen, TextBox txtQueQuan, DateTimePicker dtpNgaySinh, TextBox txtCMND, TextBox txtEmail, TextBox txtSDT)
        {
            if (gv.CurrentRow != null)
            {
                txtMa.Text = gv.CurrentRow.Cells[sql].Value.ToString();
                txtTen.Text = gv.CurrentRow.Cells["Ten"].Value.ToString();
                txtQueQuan.Text = gv.CurrentRow.Cells["QueQuan"].Value.ToString();
                txtCMND.Text = gv.CurrentRow.Cells["CMND"].Value.ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(gv.CurrentRow.Cells["NgaySinh"].Value);
                txtEmail.Text = gv.CurrentRow.Cells["Email"].Value.ToString();
                txtSDT.Text = gv.CurrentRow.Cells["SDT"].Value.ToString();
            }
        }
    }
}
