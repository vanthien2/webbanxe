using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class TaiKhoan
    {

        private string _tenTK;

        public string TenTK
        {
            get { return _tenTK; }
            set { _tenTK = value; }
        }
        private string _mK;

        public string MK
        {
            get { return _mK; }
            set { _mK = value; }
        }
        private string _hoTen;

        public string HoTen
        {
            get { return _hoTen; }
            set { _hoTen = value; }
        }
        private string _diaChi;

        public string DiaChi
        {
            get { return _diaChi; }
            set { _diaChi = value; }
        }
        private string _gT;

        public string GT
        {
            get { return _gT; }
            set { _gT = value; }
        }
        private DateTime _nS;

        public DateTime NS
        {
            get { return _nS; }
            set { _nS = value; }
        }
        private string _sDT;

        public string SDT
        {
            get { return _sDT; }
            set { _sDT = value; }
        }

        public TaiKhoan()
        {

        }
        public TaiKhoan(string tenTK, string mK, string ten, string dc,string gt, DateTime ns, string sdt)
        {
            this._tenTK = tenTK;
            this._mK = mK;
            this._hoTen = ten;
            this._diaChi = dc;
            this._gT = gt;
            this._nS = ns;
            this._sDT = sdt;
        }
    }
}
