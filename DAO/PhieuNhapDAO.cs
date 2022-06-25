using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAO
{
   public class PhieuNhapDAO
    {
      
        public DataTable laytoanbo()
        {
            return DataAccessHelper.LayBang("set dateformat dmy select PhieuNhap.MaPN,TaiKhoan.TenTK,NgayTao, sum(ChiTietPhieuNhap.SL*ChiTietPhieuNhap.DonGia) as TongTien from (PhieuNhap left join ChiTietPhieuNhap on PhieuNhap.MaPN=ChiTietPhieuNhap.MaPN)left join TaiKhoan on TaiKhoan.TenTK=PhieuNhap.TenTK  group by PhieuNhap.MaPN,TaiKhoan.TenTK,NgayTao order by MaPN desc");
        }
        public DataTable ThongKeNgay(DateTime ngay)
        {
            return DataAccessHelper.LayBang("set dateformat dmy select PhieuNhap.MaPN,TaiKhoan.TenTK,NgayTao, sum(ChiTietPhieuNhap.SL*ChiTietPhieuNhap.DonGia) as TongTien from PhieuNhap,ChiTietPhieuNhap,TaiKhoan where  PhieuNhap.MaPN=ChiTietPhieuNhap.MaPN and PhieuNhap.TenTK=TaiKhoan.TenTK and NgayTao='" + ngay + "'group by PhieuNhap.MaPN,TaiKhoan.TenTK,NgayTao");
        }
        public DataTable ThongKeKhoangNgay(DateTime bd,DateTime kt)
        {
            return DataAccessHelper.LayBang("set dateformat dmy select PhieuNhap.MaPN,TaiKhoan.TenTK,NgayTao, sum(ChiTietPhieuNhap.SL*ChiTietPhieuNhap.DonGia) as TongTien from PhieuNhap,ChiTietPhieuNhap,TaiKhoan where  PhieuNhap.MaPN=ChiTietPhieuNhap.MaPN and PhieuNhap.TenTK=TaiKhoan.TenTK and NgayTao>='"+bd+"' and  NgayTao<='"+kt+"' group by PhieuNhap.MaPN,TaiKhoan.TenTK,NgayTao");
        }
        public DataTable ThongKeNam(int nam)
        {
            return DataAccessHelper.LayBang("set dateformat dmy select PhieuNhap.MaPN,TaiKhoan.TenTK,NgayTao, sum(ChiTietPhieuNhap.SL*ChiTietPhieuNhap.DonGia) as TongTien from PhieuNhap,ChiTietPhieuNhap,TaiKhoan where  PhieuNhap.MaPN=ChiTietPhieuNhap.MaPN and PhieuNhap.TenTK=TaiKhoan.TenTK and Year(NgayTao)="+nam+" group by PhieuNhap.MaPN,TaiKhoan.TenTK,NgayTao");

        }
       public DataTable TimMa(int ma)
        {
            return DataAccessHelper.LayBang("set dateformat dmy select PhieuNhap.MaPN,TaiKhoan.TenTK,NgayTao, sum(ChiTietPhieuNhap.SL*ChiTietPhieuNhap.DonGia) as TongTien from PhieuNhap,ChiTietPhieuNhap,TaiKhoan where  PhieuNhap.MaPN=ChiTietPhieuNhap.MaPN and PhieuNhap.TenTK=TaiKhoan.TenTK and PhieuNhap.MaPN=" + ma + " group by PhieuNhap.MaPN,TaiKhoan.TenTK,NgayTao");
        }
    
       public DataTable TimTenNV(string nv)
       {
           return DataAccessHelper.LayBang("set dateformat dmy select PhieuNhap.MaPN,TaiKhoan.TenTK,NgayTao, sum(ChiTietPhieuNhap.SL*ChiTietPhieuNhap.DonGia) as TongTien from PhieuNhap,ChiTietPhieuNhap,TaiKhoan where  PhieuNhap.MaPN=ChiTietPhieuNhap.MaPN and PhieuNhap.TenTK=TaiKhoan.TenTK and TaiKhoan.TenTK=" +nv + " group by PhieuNhap.MaPN,TaiKhoan.TenTK,NgayTao");
       }
       public DataTable TimNgay(DateTime ngay)
       {
           return DataAccessHelper.LayBang("set dateformat dmy select PhieuNhap.MaPN,TaiKhoan.TenTK,NgayTao, sum(ChiTietPhieuNhap.SL*ChiTietPhieuNhap.DonGia) as TongTien from(PhieuNhap left join ChiTietPhieuNhap on ChiTietPhieuNhap.MaPN=PhieuNhap.MaPN) left join TaiKhoan on TaiKhoan.TenTK=PhieuNhap.TenTK where NgayTao=Convert(datetime,'" + ngay + "',103) group by PhieuNhap.MaPN,TaiKhoan.TenTK,NgayTao ");
       }
        public void them(PN pn)
        {
            DataAccessHelper.Open();
            DataAccessHelper.ExecuteNonQuery("set dateformat dmy insert into PhieuNhap values (N'" + pn.MaTK + "','" + pn.Ngay.ToShortDateString() + "')");
            DataAccessHelper.Close();
        }
        //public void sua(PN pn)
        //{
        //    DataAccessHelper.Open();
        //    DataAccessHelper.ExecuteNonQuery("update PhieuNhap set MaNCC=" + pn.MaNCC + " where MaPN="+pn.MaPN+"");
        //    DataAccessHelper.Close();

        //}
        public void xoa(int ma)
        {
            DataAccessHelper.Open();
            DataAccessHelper.ExecuteNonQuery("Delete from PhieuNhap where MaPN= '" + ma + "'");
            DataAccessHelper.Close();
        }

    }
}
