using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class SanPhamDAO
    {
        public DataTable laytoanbo()
        {
            return DataAccessHelper.LayBang("select SanPham.SoKhung,LoaiXe.TenLoai,DongXe.TenDX,TenXe,DonGia,SL,MauXe,Anh,MoTa from SanPham,LoaiXe,DongXe where SanPham.MaLoai=LoaiXe.MaLoai and SanPham.MaDX=DongXe.MaDX");
        }
        public DataTable BanChay()
        {
            return DataAccessHelper.LayBang("Select Top 10 SanPham.SoKhung,TenXe,LoaiXe.Tenloai,DongXe.TenDX,DonGia,Sanpham.SL, SUM(ChiTietDonHang.SL) as SLBan from SanPham, ChiTietDonHang,DonHang,DongXe,LoaiXe where SanPham.Sokhung = ChiTietDonHang.sokhung and DonHang.MaDH=ChiTietDonHang.MaDH and SanPham.MaDX=DongXe.MaDX and SanPham.MaLoai=LoaiXe.MaLoai group by  SanPham.SoKhung,TenXe,LoaiXe.Tenloai,DongXe.TenDX,TenXe,DonGia,Sanpham.SL order by SLBan desc");
        }
        public DataTable SPBanChay()
        {
            return DataAccessHelper.LayBang("Select Top 8 SanPham.Sokhung,TenXe,Anh,DonGia, SUM(ChiTietDonHang.SL) as SLBan from SanPham, ChiTietDonHang,DonHang,DongXe,LoaiXe where SanPham.SoKhung = ChiTietDonHang.SoKhung and DonHang.MaDH=ChiTietDonHang.MaDH and SanPham.MaDX=DongXe.MaDX and SanPham.MaLoai=LoaiXe.MaLoai group by  SanPham.SoKhung,TenXe,Anh,DonGia order by SLBan desc");
        }
        public DataTable BanChayThang(int thang,int nam)
        {
            return DataAccessHelper.LayBang("set dateformat dmy Select Top 10 SanPham.SoKhung,TenXe,LoaiXe.Tenloai,DongXe.TenDX,DonGia,Sanpham.SL, SUM(ChiTietDonHang.SL) as SLBan from SanPham, ChiTietDonHang,DonHang,DongXe,LoaiXe where SanPham.SoKhung = ChiTietDonHang.SoKhung and DonHang.MaDH=ChiTietDonHang.MaDH and SanPham.MaDX=DongXe.MaDX and SanPham.MaLoai=LoaiXe.MaLoai and MONTH(NgayDH)=" + thang + " and year(NgayDH)=" + nam + " group by  SanPham.SoKhung,TenXe,LoaiXe.Tenloai,DongXe.TenDX,TenXe,DonGia,Sanpham.SL order by SLBan desc");
        }
             public DataTable BanChayNam(int nam)
        {
            return DataAccessHelper.LayBang("Select Top 10 SanPham.SoKhung,TenXe,LoaiXe.Tenloai,DongXe.TenDX,DonGia,Sanpham.SL, SUM(ChiTietDonHang.SL) as SLBan from SanPham, ChiTietDonHang,DonHang,DongXe,LoaiXe where SanPham.SoKhung = ChiTietDonHang.SoKhung and DonHang.MaDH=ChiTietDonHang.MaDH and SanPham.MaDX=DongXe.MaDX and SanPham.MaLoai=LoaiXe.MaLoai and Year(NgayDH)=" + nam + " group by  SanPham.SoKhung,TenXe,LoaiXe.Tenloai,DongXe.TenDX,TenXe,DonGia,Sanpham.SL order by SLBan desc");
        }
        public DataTable hienthitheoloai(int ma)
        {
            return DataAccessHelper.LayBang("select SanPham.* from SanPham,DongXe where SanPham.MaDX=DongXe.MaDX and DongXe.MaDX='" + ma + "'");
        }

        public DataTable Timma(int ma)
        {
            return DataAccessHelper.LayBang("exec LayMaSP "+ma+"");
        }
        public DataTable TimTen(string ten)
        {
            return DataAccessHelper.LayBang("select SanPham.SoKhung,LoaiXe.TenLoai,DongXe.TenDX,TenXe,DonGia,SL,MauXe,Anh,MoTa from SanPham,LoaiXe,DongXe where SanPham.MaLoai=LoaiXe.MaLoai and SanPham.MaDX=DongXe.MaDX and SanPham.TenXe  like N'%" + ten + "%'");
        }
        public DataTable Key(string key)
        {
            return DataAccessHelper.LayBang("select SanPham.SoKhung,TenXe,DonGia,Anh from SanPham where TenXe like N'%"+key+"%'");
        }
        public DataTable TimLX(string loaixe)
        {
            return DataAccessHelper.LayBang("select SanPham.SoKhung,LoaiXe.TenLoai,DongXe.TenDX,TenXe,DonGia,SL,MauXe,Anh,MoTa from SanPham,LoaiXe,DongXe where SanPham.MaLoai=LoaiXe.MaLoai and SanPham.MaDX=DongXe.MaDX and LoaiXe.TenLoai  like N'%" + loaixe + "%'");
        }
        public DataTable TimDX(string dx)
        {
            return DataAccessHelper.LayBang("select SanPham.SoKhung,LoaiXe.TenLoai,DongXe.TenDX,TenXe,DonGia,SL,MauXe,Anh,MoTa from SanPham,LoaiXe,DongXe where SanPham.MaLoai=LoaiXe.MaLoai and SanPham.MaDX=DongXe.MaDX and DongXe.TenDX  like N'%" + dx + "%'");
        }
        public DataTable TKSP()
        {
            return DataAccessHelper.LayBang("select SanPham.SoKhung,LoaiXe.Tenloai,DongXe.TenDX,TenXe,DonGia,SL,MauXe,Anh,MoTa from SanPham, LoaiXe, DongXe where SanPham.MaDX=DongXe.MaDX and SanPham.MaLoai=LoaiXe.MaLoai and SL<=0 ");
        }

        public DataTable chitiet(string ma)
        {
            return DataAccessHelper.LayBang("select SanPham.SoKhung,LoaiXe.TenLoai,DongXe.TenDX,TenXe,DonGia,SL,MauXe,Anh,MoTa from SanPham,LoaiXe,DongXe where SanPham.MaLoai=LoaiXe.MaLoai and SanPham.MaDX=DongXe.MaDX and sokhung='" + ma + "'");
        }
        public DataTable Tu10Den20()
        {
            return DataAccessHelper.LayBang("exec Tu10Den20");
        }
        public DataTable Tu20Den30()
        {
            return DataAccessHelper.LayBang("exec Tu20Den30 ");
        }
        public DataTable Tu30Den40()
        {
            return DataAccessHelper.LayBang("exec Tu30Den40 ");
        }
        public DataTable Tu40Den50()
        {
            return DataAccessHelper.LayBang("exec Tu40Den50 ");
        }
        public DataTable Tu50Den60()
        {
            return DataAccessHelper.LayBang("exec Tu50Den60");
        }
        public DataTable Tu60Den70()
        {
            return DataAccessHelper.LayBang("exec Tu60Den70 ");
        }
        public DataTable Tu70Den80()
        {
            return DataAccessHelper.LayBang("exec Tu70Den80 ");
        }
        public DataTable Tu80Den90()
        {
            return DataAccessHelper.LayBang("exec Tu80Den90");
        }
        public DataTable Tren90()
        {
            return DataAccessHelper.LayBang("exec Tren90");
        }
        public void them(SanPham sp)
        {
            DataAccessHelper.Open();
            DataAccessHelper.ExecuteNonQuery("insert into SanPham values('"+sp.MaXe+"','" + sp.MaLoai+"','"+sp.MaHSX+"',N'"+sp.TenXe+"',"+sp.DonGia+","+sp.SL+",N'"+sp.MauXe+"',N'"+sp.Anh+"',N'"+sp.MoTa+"')");
            DataAccessHelper.Close();
        }
        public void sua(SanPham sp)
        {
            DataAccessHelper.Open();
            DataAccessHelper.ExecuteNonQuery("update SanPham set " + sp.MaXe + "," + sp.MaLoai + "," + sp.MaHSX + ",N'" + sp.TenXe + "'," + sp.DonGia + ",N'" + sp.MauXe + "',N'" + sp.MoTa + "'");
            DataAccessHelper.Close();

        }
        public void xoa(string ma)
        {
            DataAccessHelper.Open();
            DataAccessHelper.ExecuteNonQuery("Delete from SanPham where SoKhung='" + ma + "'");
            DataAccessHelper.Close();
        }
        public bool ktrama(string SoKhung)
        {
            int ktra = DataAccessHelper.GetValueInt("select count(SoKhung) from SanPham where SoKhung='" + SoKhung + "'");
            if (ktra == 0)
                return true;
            else
                return false;
        }
    }
}
