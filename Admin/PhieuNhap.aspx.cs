using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAO;
using DTO;
using BLL;

namespace MinKi.Admin
{
    public partial class PhieuNhap : System.Web.UI.Page
    {
        PhieuNhapBLL pnBLL = new PhieuNhapBLL();
        PN pn = new PN();

        protected void Page_Load(object sender, EventArgs e)
        {   
            if((bool)Session["TrangThaiDangNhap"]==false)
                Response.Redirect("/Admin/Admin.aspx");
            else
            {
                if (!IsPostBack)
                {
                    Load();
                }
              
            }
        }
       public void Load()
        {
            gvPN.DataSource = pnBLL.laytoanbo();
            gvPN.DataBind();
        }

       protected void btnThem_Click(object sender, EventArgs e)
       {

   
           pn.MaTK =Session["UserName"].ToString();
           pn.Ngay = DateTime.Parse(DateTime.Now.ToString("dd/MM/yy"));
           pnBLL.them(pn);
           Response.Redirect(Request.UrlReferrer.ToString());
          
       }

       protected void gvPN_RowDeleting(object sender, GridViewDeleteEventArgs e)
       {
           try
           {
               int ma = int.Parse(e.Values["MaPN"].ToString());
               pnBLL.xoa(ma);
               Response.Redirect(Request.UrlReferrer.ToString());
           }
           catch
           {
               Response.Write("<script>alert('Không thể xóa!')</script>");

           }
       }

       protected void gvPN_RowEditing(object sender, GridViewEditEventArgs e)
       {
           gvPN.EditIndex = e.NewEditIndex;
           Load();
       }

       //protected void gvPN_RowUpdating(object sender, GridViewUpdateEventArgs e)
       //{
         
      
       //    pn.MaPN = int.Parse(e.NewValues["MaPN"].ToString());
     
       //    pnBLL.sua(pn);
       //    Response.Redirect(Request.UrlReferrer.ToString());
       //}

       protected void gvPN_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
       {
           gvPN.EditIndex = -1;
           Load();
       }

       protected void gvPN_PageIndexChanging(object sender, GridViewPageEventArgs e)
       {
           gvPN.PageIndex = e.NewPageIndex;
           Load();
       }

       protected void btnTim_Click(object sender, EventArgs e)
       {
           if (drTK.Text == "Tìm Theo Mã")
           {
               gvPN.DataSource = pnBLL.TimMa(int.Parse((txtTim.Text)));
               gvPN.DataBind();
           }

           if (drTK.Text == "Tìm Theo Người Lập")
           {
               gvPN.DataSource = pnBLL.TimNV(txtTim.Text);
               gvPN.DataBind();
           }
     
           if (drTK.Text == "Tìm Theo Ngày")
           {
               gvPN.DataSource = pnBLL.TimNgay(DateTime.Parse(txtTim.Text));
               gvPN.DataBind();
              
           }
           int sobanghi = gvPN.Rows.Count;
           Label12.Text = "Có " + sobanghi.ToString() + " " + "kết quả được tìm thấy.";
       }

       protected void gvPN_SelectedIndexChanged(object sender, EventArgs e)
       {

       }
    }
}