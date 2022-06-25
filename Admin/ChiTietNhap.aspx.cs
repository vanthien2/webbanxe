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

namespace MinKi.Admin
{
    public partial class ChiTietNhap : System.Web.UI.Page
    {
        ChiTietPhieuNhap ct = new ChiTietPhieuNhap();
        ChiTietPhieuNhapBLL ctBLL = new ChiTietPhieuNhapBLL();
        SanPhamBLL sp = new SanPhamBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((bool)Session["TrangThaiDangNhap"] == false)
                Response.Redirect("/Admin/Admin.aspx");
            else
            {
           if(!IsPostBack)
           {
               Load();
           }
           }
        }
        public void Load()
        {
            int maHD = int.Parse(Request.QueryString.Get("MaPN"));
            lbMaPN.Text = maHD.ToString();
            drXe.DataSource = sp.laytoanbo();
            drXe.DataTextField = "TenXe";
            drXe.DataValueField = "SoKhung";
            drXe.DataBind();
            GridView1.DataSource = ctBLL.laytoanbo(maHD);
            //GridView1.DataSource = ctBLL.laytoanbo();
            GridView1.DataBind();
            tinh();
        }
        public void Load2()
        {

            int maHD = int.Parse(Request.QueryString.Get("MaPN"));
            lbMaPN.Text = maHD.ToString();
            GridView1.DataSource = ctBLL.laytoanbo(maHD);
            //GridView1.DataSource = ctBLL.laytoanbo();
            GridView1.DataBind();
       
        }

        void tinh()
        {
            lbSP.Text = GridView1.Rows.Count.ToString();
            double tongtiennhap = 0;
            foreach (GridViewRow gr in GridView1.Rows)
            {
                tongtiennhap += float.Parse(gr.Cells[5].Text);
            }
            lbTong.Text = tongtiennhap.ToString("###,###") + "  " + "VNĐ";
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            if (txtDG.Text == "")
                Response.Write("<script>alert('Đơn giá không được rỗng!')</script>");
            if (ctBLL.kiemtrama(int.Parse(lbMaPN.Text), drXe.SelectedValue.ToString()) == true)
            {
                ct.MaPN = int.Parse(lbMaPN.Text);
                ct.MaXe = drXe.Text;
                ct.SL = int.Parse(drSL.Text);
                ct.Gia = float.Parse(txtDG.Text);
                ctBLL.them(ct);
                Response.Redirect(Request.UrlReferrer.ToString());
            }
            else
            {
                Response.Write("<script>alert('Sản phẩm đã tồn tại! Vui lòng thêm sản phẩm khác!')</script>");
            }


        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            Load2();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int maPN = int.Parse(e.Values["MaPN"].ToString());
            string maXe = e.Values["SoKhung"].ToString();
            ctBLL.xoa(maPN, maXe);
            Response.Redirect(Request.UrlReferrer.ToString());
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            Load();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            Load();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            ct.SL = int.Parse(e.NewValues["SL"].ToString());
            ct.Gia = int.Parse(e.NewValues["DonGia"].ToString());
            ct.MaPN = int.Parse(e.NewValues["MaPN"].ToString());
            ct.MaXe = e.NewValues["SoKhung"].ToString();
            ctBLL.sua(ct);
            Response.Redirect(Request.UrlReferrer.ToString());
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

  

    }
}