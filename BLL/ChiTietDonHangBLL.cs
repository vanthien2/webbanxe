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
    class ChiTietDonHangBLL
    {
        ChiTietDonHangDAO ctdhDAO = new ChiTietDonHangDAO();
        public DataTable laytoanbo()
        {
            return ctdhDAO.laytoanbo();
        }
        public DataTable layTheoDH(int ma)
        {
            return ctdhDAO.LayTheoDH(ma);
        }
        public void them(ChiTietDonHang ctdh)
        {
            ctdhDAO.them(ctdh);
        }

        public void sua(ChiTietDonHang ctdh)
        {
            ctdhDAO.sua(ctdh);
        }

        public void xoa(int maDH)
        {
            ctdhDAO.xoa(maDH);
        }
    }
}
