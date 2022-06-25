using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace MinKi.Admin
{
    public partial class SanPhamDaHet : System.Web.UI.Page
    {
        SanPhamBLL sp = new SanPhamBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((bool)Session["TrangThaiDangNhap"] == false)
                Response.Redirect("/Admin/Admin.aspx");
            else
            {
                if (!IsPostBack)
                    Load();
                int sobanghi = gvSP.Rows.Count;
                lbSP.Text = "Có " + sobanghi.ToString() + " " + "sản phẩm đã hết.";
            }
        }
        public void Load()
        {
            gvSP.DataSource = sp.TKSP();
            gvSP.DataBind();
        }

        protected void gvSP_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvSP.PageIndex = e.NewPageIndex;
            Load();
        }
    }
}