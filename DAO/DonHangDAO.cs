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
    public class DonHangDAO
    {
        DonHang dh = new DonHang();
        public DataTable laytoanbo()
        {
            return DataAccessHelper.LayBang("select DonHang.MaDH,TaiKhoan.TenTK,TenKH,DonHang.SDT,NgayDH,TenNN,DonHang.DC,TT, sum(ChiTietDonHang.SL*SanPham.DonGia) as TongTien from (DonHang left join ChiTietDonHang on ChiTietDonHang.MaDH=DonHang.MaDH) left join SanPham on ChiTietDonHang.Sokhung=SanPham.Sokhung left join TaiKhoan on DonHang.TenTK=TaiKhoan.TenTK group by DonHang.MaDH,TaiKhoan.TenTK,TenKH,DonHang.SDT,NgayDH,TenNN,DonHang.DC,TT order by MaDH desc");
        }
        public DataTable DaDuyet()
        {
            return DataAccessHelper.LayBang("select DonHang.MaDH,TaiKhoan.TenTK,TenKH,DonHang.SDT,NgayDH,TenNN,DonHang.DC,TT, sum(ChiTietDonHang.SL*SanPham.DonGia) as TongTien from (DonHang left join ChiTietDonHang on ChiTietDonHang.MaDH=DonHang.MaDH) left join SanPham on ChiTietDonHang.Sokhung=SanPham.Sokhung left join TaiKhoan on DonHang.TenTK=TaiKhoan.TenTK  group by DonHang.MaDH,TaiKhoan.TenTK,TenKH,DonHang.SDT,NgayDH,TenNN,DonHang.DC,TT having TT=N'Đã Duyệt' order by MaDH desc");
        }
        public DataTable ChuaDuyet()
        {
            return DataAccessHelper.LayBang("select DonHang.MaDH,TaiKhoan.TenTK,TenKH,DonHang.SDT,NgayDH,TenNN,DonHang.DC,TT, sum(ChiTietDonHang.SL*SanPham.DonGia) as TongTien from (DonHang left join ChiTietDonHang on ChiTietDonHang.MaDH=DonHang.MaDH) left join SanPham on ChiTietDonHang.Sokhung=SanPham.Sokhung left join TaiKhoan on DonHang.TenTK=TaiKhoan.TenTK  group by DonHang.MaDH,TaiKhoan.TenTK,TenKH,DonHang.SDT,NgayDH,TenNN,DonHang.DC,TT having TT=N'Chưa Duyệt' order by MaDH desc");
        }
        public int layMa()
        {
            return DataAccessHelper.GetValueInt("select top 1 MaDH from DonHang order by MaDH desc");
        }
        public DataTable DoanhThuNgay(DateTime ngay)
        {
            return DataAccessHelper.LayBang("set dateformat dmy select DonHang.MaDH,TaiKhoan.TenTK,TenKH,DonHang.SDT,NgayDH,TenNN,DonHang.DC,TT, sum(ChiTietDonHang.SL*SanPham.DonGia) as TongTien from DonHang ,ChiTietDonHang,SanPham,TaiKhoan where DonHang.TenTK=TaiKhoan.TenTK and DonHang.MaDH=ChiTietDonHang.MaDH and SanPham.Sokhung=ChiTietDonHang.Sokhung and NgayDH='"+ngay+"' group by  DonHang.MaDH,TaiKhoan.TenTK,TenKH,DonHang.SDT,NgayDH,TenNN,DonHang.DC,TT");
        }
        public DataTable TimNgay(DateTime timngay)
        {
            return DataAccessHelper.LayBang("set dateformat dmy select DonHang.MaDH,TaiKhoan.TenTK,TenKH,DonHang.SDT,NgayDH,TenNN,DonHang.DC,TT, sum(ChiTietDonHang.SL*SanPham.DonGia) as TongTien from DonHang ,ChiTietDonHang,SanPham,TaiKhoan where DonHang.TenTK=TaiKhoan.TenTK and DonHang.MaDH=ChiTietDonHang.MaDH and SanPham.Sokhung=ChiTietDonHang.Sokhung and NgayDH='"+timngay+"' group by  DonHang.MaDH,TaiKhoan.TenTK,TenKH,DonHang.SDT,NgayDH,TenNN,DonHang.DC,TT");
        }
        public DataTable TimMa(int madh)
        {
            return DataAccessHelper.LayBang("set dateformat dmy select DonHang.MaDH,TaiKhoan.TenTK,TenKH,DonHang.SDT,NgayDH,TenNN,DonHang.DC,TT, sum(ChiTietDonHang.SL*SanPham.DonGia) as TongTien from DonHang ,ChiTietDonHang,SanPham,TaiKhoan where DonHang.TenTK=TaiKhoan.TenTK and DonHang.MaDH=ChiTietDonHang.MaDH and SanPham.Sokhung=ChiTietDonHang.Sokhung and MaDH='" + madh + "' group by  DonHang.MaDH,TaiKhoan.TenTK,TenKH,DonHang.SDT,NgayDH,TenNN,DonHang.DC,TT");
        }
        public DataTable TimTenKH(string tenKH)
        {
            return DataAccessHelper.LayBang("set dateformat dmy select DonHang.MaDH,TaiKhoan.TenTK,TenKH,DonHang.SDT,NgayDH,TenNN,DonHang.DC,TT, sum(ChiTietDonHang.SL*SanPham.DonGia) as TongTien from DonHang ,ChiTietDonHang,SanPham,TaiKhoan where DonHang.TenTK=TaiKhoan.TenTK and DonHang.MaDH=ChiTietDonHang.MaDH and SanPham.Sokhung=ChiTietDonHang.Sokhung and TenKH like'%" + tenKH + "%' group by  DonHang.MaDH,TaiKhoan.TenTK,TenKH,DonHang.SDT,NgayDH,TenNN,DonHang.DC,TT");
        }
        public DataTable DoanhThuKhoangNgay(DateTime ngaybd, DateTime ngaykt)
        {
            return DataAccessHelper.LayBang("set dateformat dmy select DonHang.MaDH,TaiKhoan.TenTK,TenKH,DonHang.SDT,NgayDH,TenNN,DonHang.DC,TT, sum(ChiTietDonHang.SL*SanPham.DonGia) as TongTien from DonHang ,ChiTietDonHang,SanPham,TaiKhoan where DonHang.TenTK=TaiKhoan.TenTK and DonHang.MaDH=ChiTietDonHang.MaDH and SanPham.Sokhung=ChiTietDonHang.Sokhung and NgayDH>='"+ngaybd+"' and NgayDH>='"+ngaykt+"' group by  DonHang.MaDH,TaiKhoan.TenTK,TenKH,DonHang.SDT,NgayDH,TenNN,DonHang.DC,TT");
        }
        public DataTable DoanhThuNam(int nam)
        {
            return DataAccessHelper.LayBang("set dateformat dmy select DonHang.MaDH,TaiKhoan.TenTK,TenKH,DonHang.SDT,NgayDH,TenNN,DonHang.DC,TT, sum(ChiTietDonHang.SL*SanPham.DonGia) as TongTien from DonHang ,ChiTietDonHang,SanPham,TaiKhoan where DonHang.TenTK=TaiKhoan.TenTK and DonHang.MaDH=ChiTietDonHang.MaDH and SanPham.Sokhung=ChiTietDonHang.Sokhung and YEAR(NgayDH)="+nam+" group by  DonHang.MaDH,TaiKhoan.TenTK,TenKH,DonHang.SDT,NgayDH,TenNN,DonHang.DC,TT");
        }
        public void them(DonHang dh)
        {
            DataAccessHelper.ExecuteNonQuery("set dateformat dmy insert into DonHang values ('" + dh.TenTK + "',N'" + dh.TenKH + "','" + dh.SDT + "','" + dh.NgayDH.ToShortDateString() + "',N'" + dh.TenNN + "',N'" + dh.DC + "',N'" + dh.TT + "')");
        }
        public void sua(DonHang dh)
        {
            DataAccessHelper.Open();
            DataAccessHelper.ExecuteNonQuery("update DonHang set TenTK='" + dh.TenTK + "',TT=N'" + dh.TT + "'where madh=" + dh.MaDH + "");
            DataAccessHelper.Close();

        }
        public void xoa(int ma)
        {
            DataAccessHelper.Open();
            DataAccessHelper.ExecuteNonQuery(" delete from DonHang where MaDH=" + ma + "");
            DataAccessHelper.Close();
        }

    }
}
