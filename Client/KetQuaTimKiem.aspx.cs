using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;
using System.Data.SqlClient;
using DAO;

namespace MinKi.Client
{
    public partial class KetQuaTimKiem : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=Website;Integrated Security=True");
        DataAccessHelper da = new DataAccessHelper();
        SqlDataAdapter Da;
        DataTable dt;
        CartItem ca = new CartItem();
        Cart that = new Cart();
        SanPhamBLL sp = new SanPhamBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string gia = Request.QueryString["gia"].ToString();
                //int loai = int.Parse(Request.QueryString["LoaiXe"].ToString());
                //int hsx = int.Parse(Request.QueryString["DongXe"].ToString());


                if (gia.ToString() == "Từ 10 Đến 20 Triệu")
                {
                    dlKQ.DataSource = sp.Tu10Den20();
                    dlKQ.DataBind();
                }
                if (gia.ToString() == "Từ 20 Đến 30 Triệu")
                {
                    dlKQ.DataSource = sp.Tu20Den30();
                    dlKQ.DataBind();
                }
                if (gia.ToString() == "Từ 30 Đến 40 Triệu")
                {
                    dlKQ.DataSource = sp.Tu30Den40();
                    dlKQ.DataBind();
                }
                if (gia.ToString() == "Từ 40 Đến 50 Triệu")
                {
                    dlKQ.DataSource = sp.Tu40Fen50();
                    dlKQ.DataBind();
                }
                if (gia.ToString() == "Từ 50 Đến 60 Triệu")
                {
                    dlKQ.DataSource = sp.Tu50Den60();
                    dlKQ.DataBind();
                }
                if (gia.ToString() == "Từ 60 Đến 70 Triệu")
                {
                    dlKQ.DataSource = sp.Tu60Den70();
                    dlKQ.DataBind();
                    if (gia.ToString() == "Từ 70 Đến 80 Triệu")
                    {
                        dlKQ.DataSource = sp.Tu70Den80();
                        dlKQ.DataBind();
                    }

                    if (gia.ToString() == "Từ 80 Đến 90 Triệu")
                    {
                        dlKQ.DataSource = sp.Tu80Den90();
                        dlKQ.DataBind();
                    }
                    if (gia.ToString() == "Trên 90 Triệu")
                    {
                        dlKQ.DataSource = sp.Tren90();
                        dlKQ.DataBind();
                    }
                }

            }
        }
        protected void dlKQ_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnthem_Command1(object sender, CommandEventArgs e)
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