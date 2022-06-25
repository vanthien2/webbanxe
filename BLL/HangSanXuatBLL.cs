using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;

namespace BLL
{
   public class HangSanXuatBLL
    {
        HangSanXuatDAO hsxDAO = new HangSanXuatDAO();
        public DataTable laytoanbo()
        {
            return hsxDAO.laytoanbo();
        }
        public DataTable TimMa(int ma)
        {
            return hsxDAO.TimMa(ma);
        }
        public DataTable TimTen(string ten)
        {
            return hsxDAO.TimTen(ten);
        }
        public void them(HangSanXuat hsx)
        {
            hsxDAO.them(hsx);
        }

        public void sua(HangSanXuat hsx)
        {
            hsxDAO.sua(hsx);
        }

        public void xoa(int ma)
        {
            hsxDAO.xoa(ma);
        }
    }
}