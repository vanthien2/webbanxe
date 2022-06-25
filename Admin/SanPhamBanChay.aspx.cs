using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;


namespace MinKi.Admin
{
    public partial class SanPhamBanChay : System.Web.UI.Page
    {
        SanPhamBLL sp = new SanPhamBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = sp.BanChay();
           GridView1.DataBind();
        }

        protected void btnThongke_Click(object sender, EventArgs e)
        {
            if(rdoTK.Items[0].Selected)
            {
                GridView1.DataSource = sp.BanChayThang(int.Parse(drThang.SelectedValue),int.Parse(drmTrongNam.SelectedValue));
                GridView1.DataBind();
            }
            if (rdoTK.Items[1].Selected)
            {
                GridView1.DataSource = sp.BanChayNam(int.Parse(drNam.SelectedValue));
                GridView1.DataBind();
            }
        }
    }
}