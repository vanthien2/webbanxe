using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MinKi
{
    public class CartItem
    {
        private string sokhung;

        public string Sokhung
        {
            get { return sokhung; }
            set { sokhung = value; }
        }

    
        
        private string tenxe;

        public string Tenxe
        {
            get { return tenxe; }
            set { tenxe = value; }
        }
        private double dongia;

        public double Dongia
        {
            get { return dongia; }
            set { dongia = value; }
        }
        private int soluong;

        public int Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }

    
       
        private string anh;

        public string Anh
        {
            get { return anh; }
            set { anh = value; }
        }
        
        public double thanhtien
        {
            get { return soluong*dongia; }
        }
    }
        public  class Cart
        {
            List<CartItem> item;

            public Cart()
            {
                if (item == null)
                    item = new List<CartItem>();
            }
            public List<CartItem> Item
            {
                get { return item; }
            }
            
            public void insert(CartItem c)
            {
                Item.Add(c);
            }
            public void Delete(int Rowindex)
            {
                item.RemoveAt(Rowindex);
            }
            public void Update(int RowIdex, int sl)
            {
                item[RowIdex].Soluong = sl;
            }
            public double ThanhTien()
            {
                double tien = 0;
                foreach (CartItem i in item)
                {
                    tien += i.thanhtien;
                }
                return tien;
            }

        }
    }
