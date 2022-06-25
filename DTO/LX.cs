using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class LX
    {
        private int _maLoai;

        public int MaLoai
        {
            get { return _maLoai; }
            set { _maLoai = value; }
        }


        private string _tenLoai;

        public string TenLoai
        {
            get { return _tenLoai; }
            set { _tenLoai = value; }
        }
       public LX()
        { }
       public LX(int ma, string ten)
       {
           this._maLoai = ma;
           this._tenLoai = ten;
       }
    }
}
