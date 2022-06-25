using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MinKi.Admin
{
    public partial class MasterPageAdmin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((bool)Session["TrangThaiDangNhap"] == true)
            {
                lbUS.InnerText = Session["UserName"].ToString();
            }
            else
            {
                lbUS.InnerText = "";
            }
           
        }
    }
}