using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class SanPham
    {
        private string _maXe;

        public string MaXe
        {
            get { return _maXe; }
            set { _maXe = value; }
        }
        private int _maLoai;

        public int MaLoai
        {
            get { return _maLoai; }
            set { _maLoai = value; }
        }

        private int _maHSX;

        public int MaHSX
        {
            get { return _maHSX; }
            set { _maHSX = value; }
        }

      
        private string _tenXe;

        public string TenXe
        {
            get { return _tenXe; }
            set { _tenXe = value; }
        }
        private double _donGia;

        public double DonGia
        {
            get { return _donGia; }
            set { _donGia = value; }
        }

       
        private int _sL;

        public int SL
        {
            get { return _sL; }
            set { _sL = value; }
        }
        private string _mauXe;

        public string MauXe
        {
            get { return _mauXe; }
            set { _mauXe = value; }
        }
       
        private string _anh;

        public string Anh
        {
            get { return _anh; }
            set { _anh = value; }
        }
        private string _moTa;

        public string MoTa
        {
            get { return _moTa; }
            set { _moTa = value; }
        }
 
      
       public SanPham()
        {

        }
       public SanPham(string maXe, int maLoai, int maHSX, string tenXe, double donGia, int sL, string mauXe, string anh, string moTa)
       {
           this._maXe = maXe;
           this._maLoai = maLoai;
           this._maHSX = maHSX;
           this._tenXe = tenXe;
           this._donGia = donGia;
           this._sL = sL;
           this._mauXe = mauXe;
           this._anh = anh;
           this._moTa = moTa;
          
        
       }
    }
}
