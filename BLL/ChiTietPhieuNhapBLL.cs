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
    class ChiTietPhieuNhapBLL
    {
        ChiTietPhieuNhapDAO ctpnDAO = new ChiTietPhieuNhapDAO();
        public DataTable laytoanbo(int ma)
        {
            return ctpnDAO.laytoanbo(ma);
        }
        public DataTable CTPN()
        {
            return ctpnDAO.CTPN();
        }
        public DataTable tinh(int ma)
        {
            return ctpnDAO.tinh(ma);
        }
        public void them(ChiTietPhieuNhap ctpn)
        {
            ctpnDAO.them(ctpn);
        }

        public void sua(ChiTietPhieuNhap ctpn)
        {
            ctpnDAO.sua(ctpn);
        }

        public void xoa(int maPN,string maXe)
        {
            ctpnDAO.xoa(maPN,maXe);
        }
        public bool kiemtrama(int mapn,string maxe)
        {
            return ctpnDAO.ktrama(mapn, maxe);
        }
    }
}
