using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class PN
    {
        private int _maPN;

        public int MaPN
        {
            get { return _maPN; }
            set { _maPN = value; }
        }
        private string _maTK;

        public string MaTK
        {
            get { return _maTK; }
            set { _maTK = value; }
        }

      
        private DateTime _ngay;

        public DateTime Ngay
        {
        get { return _ngay; }
        set { _ngay = value; }
        }
       public PN()
        { }
       public PN(int maPN, int maNCC, string maTK, DateTime ngay) 
       {
           this._maPN = maPN;
           this._maTK = maTK;
           this._ngay = ngay;
       }

    }
}
