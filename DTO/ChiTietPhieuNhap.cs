using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhieuNhap
    {
        private int _maPN;

        public int MaPN
        {
            get { return _maPN; }
            set { _maPN = value; }
        }


        private string _maXe;

        public string MaXe
        {
            get { return _maXe; }
            set { _maXe = value; }
        }

   
        private int _sL;

        public int SL
        {
            get { return _sL; }
            set { _sL = value; }
        }
        private float _gia;

        public float Gia
        {
            get { return _gia; }
            set { _gia = value; }
        }
        public ChiTietPhieuNhap()
        { }
        public ChiTietPhieuNhap(int maPN, string maXe, int sL, float gia)
        {
            this._maPN = maPN;
            this._maXe = maXe;
            this._sL = sL;
            this._gia = gia;
        }
    }
}
