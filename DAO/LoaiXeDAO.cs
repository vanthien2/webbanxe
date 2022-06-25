using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAO
{
   public class LoaiXeDAO
    {
        public DataTable laytoanbo()
        {
            return DataAccessHelper.LayBang("select * from LoaiXe");
        }
        public void them(LX lx)
        {
            DataAccessHelper.Open();
            DataAccessHelper.ExecuteNonQuery("insert into LoaiXe values(N'" + lx.TenLoai + "')");
            DataAccessHelper.Close();
        }
        public void sua(LX lx)
        {
            DataAccessHelper.Open();
            DataAccessHelper.ExecuteNonQuery("update LoaiXe set TenLoai=N'" + lx.TenLoai + "' where MaLoai='"+lx.MaLoai+"'");
            DataAccessHelper.Close();

        }
        public void xoa(int ma)
        {
            DataAccessHelper.Open();
            DataAccessHelper.ExecuteNonQuery("Delete from LoaiXe where MaLoai='" + ma + "'");
            DataAccessHelper.Close();
        }
    }
}
