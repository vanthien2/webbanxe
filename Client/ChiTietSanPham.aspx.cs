using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using BLL;
using System.Data;
using System.Data.SqlClient;
using DAO;
namespace MinKi.Client
{
    public partial class ChiTietSanPham : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=Website;Integrated Security=True");
        DataAccessHelper da = new DataAccessHelper();
        SqlDataAdapter Da;
        DataTable dt;
        CartItem ca = new CartItem();
        Cart that = new Cart();
        SanPhamBLL sp = new SanPhamBLL();
        SanPham xe = new SanPham();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Load();
            }
        }
        public void Load()
        {
            string ma = Request.QueryString["SoKhung"];
            dlCTSP.DataSource = sp.chitiet(ma);
            dlCTSP.DataBind();
        }


        protected void btnthem_Command(object sender, CommandEventArgs e)
        {
            string Sokhung = e.CommandArgument.ToString();
            string sql = "select * from Sanpham where Sokhung='" + Sokhung + "'";
            conn.Open();
            Da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            Da.Fill(dt);
            conn.Close();
            DataTable sp = dt;
            DataRow dr = dt.Rows[0];
            CartItem item = new CartItem();
            item.Sokhung = Sokhung;
            item.Tenxe = dr["Tenxe"].ToString();
            item.Dongia = float.Parse(dr["Dongia"].ToString());
            item.Soluong = 1;
            item.Anh = dr["Anh"].ToString();

            Cart giohang = (Cart)Session["GioHang"];
            if (giohang != null)
            {
                foreach (CartItem c in giohang.Item)
                {
                    if (c.Sokhung.ToString() == Sokhung)
                    {
                        c.Soluong = c.Soluong + 1;
                        goto GIOHANG;
                    }
                }
                giohang.insert(item);
            GIOHANG:
                Session["GIOHANG"] = giohang;
                Response.Write("<script>alert('Đã thêm vào giỏ hàng')</script>");

            }
            Response.Redirect("giohang.aspx");
        }
    }
}
    