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
    class DonHangBLL
    {
        DonHangDAO dhDAO = new DonHangDAO();
        public DataTable laytoanbo()
        {
            return dhDAO.laytoanbo();
        }
        public DataTable TimMa(int ma)
        {
            return dhDAO.TimMa(ma);
        }
        public DataTable TimNgay(DateTime ngay)
        {
            return dhDAO.TimNgay(ngay);
        }
        public DataTable TimTenkh(string tenkh)
        {
            return dhDAO.TimTenKH(tenkh);
        }
        public DataTable ChuaDuyet()
        {
            return dhDAO.ChuaDuyet();
        }
        public DataTable DaDuyet()
        {
            return dhDAO.DaDuyet();
        }
        public int LayMa()
        {
            return dhDAO.layMa();
        }
        public DataTable DoanhThuNgay(DateTime ngay)
        {
            return dhDAO.DoanhThuNgay(ngay);
        }
        public DataTable DoanhThuKhoangNgay(DateTime bd, DateTime kt)
        {
            return dhDAO.DoanhThuKhoangNgay(bd, kt);
        }
        public DataTable DoanhThuNam(int nam)
        {
            return dhDAO.DoanhThuNam(nam);
        }
        public void them(DonHang dh)
        {
            dhDAO.them(dh);
        }

        public void sua(DonHang dh)
        {
            dhDAO.sua(dh);
        }

        public void xoa(int ma)
        {
            dhDAO.xoa(ma);
        }
    }
}
