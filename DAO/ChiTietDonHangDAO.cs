using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;
namespace DAO
{
    public class ChiTietDonHangDAO
    {
        public DataTable laytoanbo()
        {
            return DataAccessHelper.LayBang("exec HienThiCTDH");
        }
        public DataTable LayTheoDH(int ma)
        {
            return DataAccessHelper.LayBang("select ChiTietDonHang.MaDH,SanPham.SoKhung,TenXe,DonGia,ChiTietDonHang.SL, (ChiTietDonHang.SL*DonGia) as ThanhTien from DonHang,SanPham, ChiTietDonHang where DonHang.MaDH=ChiTietDonHang.MaDH and SanPham.SoKhung=ChiTietDonHang.SoKhung and ChiTietDonHang.MaDH=" + ma + "");
        }
        public void them(ChiTietDonHang ctdh)
        {
            DataAccessHelper.Open();
            DataAccessHelper.ExecuteNonQuery("insert into ChiTietDonHang values (" + ctdh.MaDH + ",'" + ctdh.SoKhung + "'," + ctdh.SL + ")");
            DataAccessHelper.Close();
        }
        public void sua(ChiTietDonHang ctdh)
        {
            DataAccessHelper.Open();
            DataAccessHelper.ExecuteNonQuery("exec SuaCTDH " + ctdh.MaDH + "," + ctdh.SoKhung + " ," + ctdh.SL + "");
            DataAccessHelper.Close();

        }
        public void xoa(int maDH)
        {
            DataAccessHelper.Open();
            DataAccessHelper.ExecuteNonQuery("exec XoaCTDH1 " + maDH + "");
            DataAccessHelper.Close();
        }

    }
}
