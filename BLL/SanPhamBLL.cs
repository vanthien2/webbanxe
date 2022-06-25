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
    public class SanPhamBLL
    {
        SanPhamDAO spDAO = new SanPhamDAO();
        public DataTable laytoanbo()
        {
            return spDAO.laytoanbo();
        }
        public DataTable SpBanChay()
        {
            return spDAO.SPBanChay();
        }
        public DataTable BanChayThang(int thang,int nam)
        {
            return spDAO.BanChayThang(thang,nam);
        }
        public DataTable BanChay()
        {
            return spDAO.BanChay();
        }
        public DataTable BanChayNam(int nam)
        {
            return spDAO.BanChayNam(nam);
        }
        public DataTable TKSP()
        {
            return spDAO.TKSP();
        }
        public DataTable laytheoloai(int ma)
        {
            return spDAO.hienthitheoloai(ma);
        }
        public DataTable TimMa(int ma)
        {
            return spDAO.Timma(ma);
        }
        public DataTable Key(string key)
        {
            return spDAO.Key(key);
        }
        public DataTable TimTen(string ten)
        {
            return spDAO.TimTen(ten);
        }
        public DataTable TimLX(string lx)
        {
            return spDAO.TimLX(lx);
        }
        public DataTable TimHSX(string hsx)
        {
            return spDAO.TimDX(hsx);
        }
        public DataTable chitiet(string ma)
        {
            return spDAO.chitiet(ma);
        }
        public DataTable Tu10Den20()
        {
            return spDAO.Tu10Den20();
        }
        public DataTable Tu20Den30()
        {
            return spDAO.Tu20Den30();
        }
        public DataTable Tu30Den40()
        {
            return spDAO.Tu30Den40();
        }
        public DataTable Tu40Fen50()
        {
            return spDAO.Tu40Den50();
        }
        public DataTable Tu50Den60()
        {
            return spDAO.Tu50Den60();
        }
        public DataTable Tu60Den70()
        {
            return spDAO.Tu60Den70();
        }
        public DataTable Tu70Den80()
        {
            return spDAO.Tu70Den80();
        }
        public DataTable Tu80Den90()
        {
            return spDAO.Tu80Den90();
        }
        public DataTable Tren90()
        {
            return spDAO.Tren90();
        }
        public void them(SanPham sp)
        {
            spDAO.them(sp);
        }

        public void sua(SanPham sp)
        {
            spDAO.sua(sp);
        }

        public void xoa(string ma)
        {
            spDAO.xoa(ma);
        }
        public bool kiemtrama(string maxe)
        {
            return spDAO.ktrama( maxe);
        }
    }
}
