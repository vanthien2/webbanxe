using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;


namespace MinKi.Admin
{
    public partial class ChiTietBan : System.Web.UI.Page
    {
        ChiTietDonHangBLL ct = new ChiTietDonHangBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            //if ((bool)Session["TrangThaiDangNhap"] == false)
            //    Response.Redirect("/Admin/Admin.aspx");
            LayTheoDH();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
        }
        public void LayTheoDH()
        {
            int ma = int.Parse(Request.QueryString.Get("MaDH"));
            GridView1.DataSource = ct.layTheoDH(ma);
            GridView1.DataBind();
        }

      
    }
}