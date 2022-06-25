using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class HangSanXuat
    {
        private int _maHSX;

        public int MaHSX
        {
            get { return _maHSX; }
            set { _maHSX = value; }
        }

     
        private string _tenHSX;

        public string TenHSX
        {
            get { return _tenHSX; }
            set { _tenHSX = value; }
        }
       public HangSanXuat()
        {

        }
       public HangSanXuat(int ma,string ten)
       {
           this._maHSX = ma;
           this._tenHSX = ten;
       }
    }
}

