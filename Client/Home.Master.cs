using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;

namespace MinKi.Client
{
    public partial class Home : System.Web.UI.MasterPage
    {
        SanPhamBLL sp = new SanPhamBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            Cart giohang = (Cart)Session["GIOHANG"];
            if (giohang == null)
            {
                giohang = new Cart();
                Session["GIOHANG"] = giohang;

            }
            
            lblsonguoitruycap.Text = "Số lượt truy cập:" + Application["soluottruycap"].ToString();
            lbSoNguoiOnline.Text = "Số người online:" + Application["songuoionline"].ToString();
        }

        protected void btnTim_Click(object sender, EventArgs e)
        {
            string gia = DrGia.Text;
          
            Response.Redirect("KetQuaTimKiem.aspx?gia=" + gia + "");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("GioHang.aspx");
        }

        protected void btnTimKiem_Click(object sender, EventArgs e)
        {
            string key = txtTuKhoa.Text;
            Response.Redirect("TimTen.aspx?key=" + key + "");
        }

       


      

    }
}