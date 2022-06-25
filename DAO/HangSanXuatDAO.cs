using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Web;
using System.Data;

namespace DAO
{
    public class HangSanXuatDAO
    {
        public DataTable laytoanbo()
        {
            return DataAccessHelper.LayBang("select * from DongXe");
        }
        public DataTable TimMa(int ma)
        {
            return DataAccessHelper.LayBang("select * from DongXe where MaDX="+ma+"");
        }
        public DataTable TimTen(string ten)
        {
            return DataAccessHelper.LayBang("select * from DongXe where TenDX like N'%" + ten + "%'");
        }
         public void them(HangSanXuat hsx)
        {
            DataAccessHelper.Open();
            DataAccessHelper.ExecuteNonQuery("insert into DongXe values(N'"+hsx.TenHSX+"')");
            DataAccessHelper.Close();
        }
        public void sua(HangSanXuat hsx)
        {
            DataAccessHelper.Open();
            DataAccessHelper.ExecuteNonQuery("update DongXe set TenDX=N'" + hsx.TenHSX + "' where MaDX='" + hsx.MaHSX + "'");
            DataAccessHelper.Close();
           
        }
        public void xoa(int ma)
        {
            DataAccessHelper.Open();
            DataAccessHelper.ExecuteNonQuery("Delete from DongXe where MaDX= '" + ma + "'");
            DataAccessHelper.Close();
        }

    }
}