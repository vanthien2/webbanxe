using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAO
{
   public class TaiKhoanDAO
    {
            public DataTable laytoanbo()
            {
                return DataAccessHelper.LayBang("select * from TaiKhoan ");
            }
            public void them(TaiKhoan tk)
            {
                DataAccessHelper.Open();
                DataAccessHelper.ExecuteNonQuery("insert into TaiKhoan values (N'" + tk.TenTK + "','" + tk.MK + "',N'" + tk.HoTen + "',N'" + tk.DiaChi + "',N'" + tk.GT + "','" + tk.NS + "','" + tk.SDT + "')");
                DataAccessHelper.Close();
            }
            public void sua(TaiKhoan tk)
            {
                DataAccessHelper.Open();
                DataAccessHelper.ExecuteNonQuery("update TaiKhoan set N'" + tk.TenTK + "','" + tk.MK + "',N'" + tk.HoTen + "',N'" + tk.DiaChi + "',N'" + tk.GT + "','" + tk.NS + "','" + tk.SDT + "'");
                DataAccessHelper.Close();

            }
            public void xoa(int ma)
            {
                DataAccessHelper.Open();
                DataAccessHelper.ExecuteNonQuery("Delete from TaiKhoan where tenTk= '" + ma + "'");
                DataAccessHelper.Close();
            }
            public bool ktrama(string ten,string ma)
            {
                int ktra = DataAccessHelper.GetValueInt("select count(tentk) from TaiKhoan where TenTK=N'" + ten + "'and MK=N'"+ma+"'");
                if (ktra == 0)
                    return true;
                else
                    return false;
            }
      
        }
    }
