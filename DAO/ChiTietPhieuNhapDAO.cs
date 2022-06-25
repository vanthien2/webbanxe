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
    public class ChiTietPhieuNhapDAO
    {
        public DataTable laytoanbo(int ma)
        {
            return DataAccessHelper.LayBang("select ChiTietPhieuNhap.MaPN,SanPham.SoKhung,TenXe,ChiTietPhieuNhap.DonGia,ChiTietPhieuNhap.SL, (ChiTietPhieuNhap.SL*ChiTietPhieuNhap.DonGia) as ThanhTien from PhieuNhap,SanPham, ChiTietPhieuNhap where PhieuNhap.MaPN=ChiTietPhieuNhap.MaPN and SanPham.SoKhung=ChiTietPhieuNhap.SoKhung and PhieuNhap.MaPN= "+ma+"");
        }
        public DataTable CTPN()
        {
            return DataAccessHelper.LayBang("select ChiTietPhieuNhap.MaPN,SanPham.SoKhung,TenXe,ChiTietPhieuNhap.DonGia,ChiTietPhieuNhap.SL, (ChiTietPhieuNhap.SL*ChiTietPhieuNhap.DonGia) as ThanhTien from PhieuNhap,SanPham, ChiTietPhieuNhap where PhieuNhap.MaPN=ChiTietPhieuNhap.MaPN and SanPham.SoKhung=ChiTietPhieuNhap.SoKhung and PhieuNhap.MaPN=@MaPN");
        }
        public DataTable tinh(int ma)
        {
           return DataAccessHelper.LayBang("exec TinhTongTien "+ma+"");
        }
        public void them(ChiTietPhieuNhap ctpn)
        {
            DataAccessHelper.Open();
            DataAccessHelper.ExecuteNonQuery("exec ThemCTPN1 "+ctpn.MaPN+",'"+ctpn.MaXe+"'," + ctpn.SL + ","+ctpn.Gia+"");
            DataAccessHelper.Close();
        }
        public void sua(ChiTietPhieuNhap ctpn)
        {
            DataAccessHelper.Open();
            DataAccessHelper.ExecuteNonQuery("exec SuaCTPN1 "+ctpn.MaPN+",'"+ctpn.MaXe+"'," + ctpn.SL + "," + ctpn.Gia + "");
            DataAccessHelper.Close();

        }
        public void xoa(int maPN,string SoKhung)
        {
            DataAccessHelper.Open();
            DataAccessHelper.ExecuteNonQuery("exec XoaCTPN " + maPN + ",'"+SoKhung+"'");
            DataAccessHelper.Close();
        }
        public bool ktrama(int mapn, string SoKhung)
        {
            int ktra = DataAccessHelper.GetValueInt("select count(MaPN) from ChiTietPhieuNhap where MaPN="+mapn+" and SoKhung='"+SoKhung+"'");
            if (ktra == 0)
                return true;
            else
                return false;
        }
    }
}
