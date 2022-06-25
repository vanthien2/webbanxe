using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using BLL;
using DTO;
using DAO;

namespace MinKi.Client
{
    public partial class DatHang : System.Web.UI.Page
    {
        Cart c = new Cart();
        DonHangBLL dhBLL = new DonHangBLL();
        DonHang dh = new DonHang();
        ChiTietDonHang ctdh = new ChiTietDonHang();
        ChiTietDonHangBLL ctdhBLL = new ChiTietDonHangBLL();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                //  tbGioHang = (DataTable)Session["GIOHANG"];
                load();
            }
        }
        public void load()
        {
            Cart giohang = (Cart)Session["GIOHANG"];
            if (giohang != null)
            {
                GridView1.DataSource = giohang.Item;
                GridView1.DataBind();
            }
        }
        protected void btthem_Click(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            Cart giohang = (Cart)Session["GIOHANG"];
            Session["GIOHANG"] = giohang;
            GridView1.DataSource = giohang.Item;
            GridView1.DataBind();
            Response.Redirect("GioHang.aspx");
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Cart giohang = (Cart)Session["GIOHANG"];
            int index = int.Parse(e.RowIndex.ToString());
            giohang.Delete(index);
            Session["GIOHANG"] = giohang;
            GridView1.DataSource = giohang.Item;
            GridView1.DataBind();
            Response.Redirect("giohang.aspx");

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            load();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            Cart giohang = (Cart)Session["GIOHANG"];
            int index = int.Parse(e.RowIndex.ToString());
            TextBox soluong = GridView1.Rows[e.RowIndex].Cells[3].Controls[0] as TextBox;
            int sl = int.Parse(soluong.Text);
            if (sl != 0)
            {
                giohang.Update(index, sl);
                Session["GIOHANG"] = giohang;
                GridView1.DataSource = giohang.Item;
                GridView1.DataBind();
                Response.Redirect("giohang.aspx");
            }
            else
            {
                giohang.Delete(index);
                Session["GIOHANG"] = giohang;
                GridView1.DataSource = giohang.Item;
                GridView1.DataBind();
                Response.Redirect("giohang.aspx");
            }
        }
        DataTable tbGioHang = new DataTable();
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (txtkhachhang.Text == "" || txtdiachi.Text == "" || txtnguoinhan.Text == "" || txtsdt.Text == "")
            {
                if (txtkhachhang.Text == "")
                    Response.Write("<script>alert('Tên người đặt hàng không được để trống!')</script>");
                if (txtdiachi.Text == "")
                    Response.Write("<script>alert('Địa chỉ không được để trống!')</script>");
                if (txtnguoinhan.Text == "")
                    Response.Write("<script>alert('Người nhận không để trống!')</script>");
                if (txtsdt.Text == "")
                    Response.Write("<script>alert('Số điện thoại không được để trống!')</script>");
            }
            else
            {
                dh.TenKH = txtkhachhang.Text;
                dh.SDT = txtsdt.Text;
                dh.TenTK = "Null";
                dh.NgayDH = DateTime.Parse(DateTime.Now.ToString("dd/MM/yy"));
                dh.TenNN = txtnguoinhan.Text;
                dh.DC = txtdiachi.Text;
                dh.TT = "Chưa Duyệt";


                dhBLL.them(dh);
                int ma = dhBLL.LayMa();
                Cart giohang = (Cart)Session["GioHang"];
                if (giohang != null)
                {
                    foreach (CartItem c in giohang.Item)
                    {
                        ctdh.MaDH = ma.ToString();
                        ctdh.SoKhung = c.Sokhung.ToString();
                        ctdh.SL = int.Parse(c.Soluong.ToString());
                        ctdhBLL.them(ctdh);
                    }
                    //foreach (GridViewRow gr in GridView1.Rows)
                    //{
                    //    int Sokhung= int.Parse(gr.Cells[0].ToString());
                    //    int sl = int.Parse(gr.Cells[1].ToString());
                    //    ctdh.MaDH = ma.ToString();
                    //    ctdh.Sokhung=Sokhung.ToString();
                    //    ctdh.SL=sl;
                    //    ctdhBLL.them(ctdh);
                    //}
                    //List<CartItem> mylist = new List<CartItem>();
                    //foreach (CartItem i in mylist)
                    //{

                    //}
                    Session["GioHang"] = null;
                    Response.Redirect("ThanhCong.aspx");
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect(" /Client/home.aspx");
        }
    }
}