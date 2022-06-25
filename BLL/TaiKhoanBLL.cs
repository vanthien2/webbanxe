using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;
namespace BLL
{
  public  class TaiKhoanBLL
    {
        TaiKhoanDAO tkDAO = new TaiKhoanDAO();
        public DataTable laytoanbo()
        {
            return tkDAO.laytoanbo();
        }
        public void them(TaiKhoan tk)
        {
            tkDAO.them(tk);
        }

        public void sua(TaiKhoan tk)
        {
            tkDAO.sua(tk);
        }

        public void xoa(int ma)
        {
            tkDAO.xoa(ma);
        }
        public bool ktrma(string ten,string ma)
        {
            return tkDAO.ktrama(ten,ma);
        }
    }
}
