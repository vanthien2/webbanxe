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
    class PhieuNhapBLL
    {
        PhieuNhapDAO pnDAO = new PhieuNhapDAO();
        public DataTable laytoanbo()
        {
            return pnDAO.laytoanbo();
        }
        public DataTable ThongKeNgay(DateTime ngay)
        {
            return pnDAO.ThongKeNgay(ngay);
        }
        public DataTable ThongKeKhoangNgay(DateTime bd,DateTime kt)
        {
            return pnDAO.ThongKeKhoangNgay(bd,kt);
        }
        public DataTable ThongKeNam(int nam)
        {
            return pnDAO.ThongKeNam(nam);
        }
        public DataTable TimMa(int ma)
        {
            return pnDAO.TimMa(ma);
        }
     
        public DataTable TimNV(string nv)
        {
            return pnDAO.TimTenNV(nv);
            }
        public DataTable TimNgay(DateTime ngay)
        {
            return pnDAO.TimNgay(ngay);
        }
        public void them(PN pn)
        {
            pnDAO.them(pn);
        }
        //public void sua(PN pn)
        //{
        //    pnDAO.sua(pn);
        //}
        public void xoa(int ma)
        {
            pnDAO.xoa(ma);
        }
    }
}
