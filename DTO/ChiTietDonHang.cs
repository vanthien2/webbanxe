using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietDonHang
    {
        private string _maDH;

        public string MaDH
        {
            get { return _maDH; }
            set { _maDH = value; }
        }
        private string _SoKhung;

        public string SoKhung
        {
            get { return _SoKhung; }
            set { _SoKhung = value; }
        }
        private int _sL;

        public int SL
        {
            get { return _sL; }
            set { _sL = value; }
        }
   
    
        public ChiTietDonHang()
        { }

        public ChiTietDonHang(string maDH, string SoKhung, int sL)
        {
            this._maDH = maDH;
            this._SoKhung = SoKhung;
            this._sL=sL;
    
        }
    }
}
