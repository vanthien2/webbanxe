using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DonHang
    {
        private int _maDH;
        
        public int MaDH
        {
            get { return _maDH; }
            set { _maDH = value; }
        }
        private string _tenTK;

        public string TenTK
        {
            get { return _tenTK; }
            set { _tenTK = value; }
        }

        private string _TenKH;
        public string TenKH
        {
         get { return _TenKH; }
         set { _TenKH = value; }
        }private DateTime _ngayDH;

        public DateTime NgayDH
        {
            get { return _ngayDH; }
            set { _ngayDH = value; }
        }
   private string _sDT;

public string SDT
{
  get { return _sDT; }
  set { _sDT = value; }
}
        private string _tenNN;

        public string TenNN
        {
            get { return _tenNN; }
            set { _tenNN = value; }
        }
        private string _dC;

        public string DC
        {
            get { return _dC; }
            set { _dC = value; }
        }
 
        private string _tT;

        public string TT
        {
            get { return _tT; }
            set { _tT = value; }
        }
        public DonHang()
        { }
        public DonHang(int maDH, string tenTK, string tenKH, string sdt,DateTime ngaydat,string tenNN, string dc, string tT)
        {
            this._maDH = maDH;
            this._tenTK = tenKH;
            this._TenKH = tenKH;
            this._sDT=sdt;
            this._ngayDH = ngaydat;
            this._tenNN = tenNN;
            this._dC = dc;
            this._tT = tT;
        }
   
    }
}
