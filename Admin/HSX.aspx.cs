using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DTO;
using System.Data;

namespace MinKi.Admin
{
    public partial class HSX : System.Web.UI.Page
    {
        HangSanXuat hsx = new HangSanXuat();
        HangSanXuatBLL hsxBLL = new HangSanXuatBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            //if ((bool)Session["TrangThaiDangNhap"] == false)
            //    Response.Redirect("/Admin/Admin.aspx");
            //else
            {
                if (!IsPostBack)
                    Load();
            }
        }
        public void Load()
        {
            gvHSX.DataSource = hsxBLL.laytoanbo();
            gvHSX.DataBind();
        }
        protected void btnThem_Click(object sender, EventArgs e)
        {
        TextBox txtTen =(TextBox)gvHSX.FooterRow.FindControl("txtTen");
        if (txtTen.Text != "")
        {
            hsx.TenHSX = txtTen.Text;
            hsxBLL.them(hsx);
            Response.Redirect(Request.UrlReferrer.ToString());
        }
        else
        Response.Write("<script>alert('Tên dòng xe không được để trống!')</script>");

        }

        protected void gvHSX_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                int ma = int.Parse(e.Values["MaDX"].ToString());
                hsxBLL.xoa(ma);
                Response.Redirect(Request.UrlReferrer.ToString());
            }
            catch
            {
                Response.Write("<script>alert('Không thể xóa!')</script>");

            }
        }

        protected void gvHSX_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvHSX.EditIndex = e.NewEditIndex;
            Load();
        }

        protected void gvHSX_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvHSX.EditIndex = -1;
            Load();
        }

        protected void gvHSX_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            hsx.TenHSX = e.NewValues["TenDX"].ToString();
            hsx.MaHSX = int.Parse(e.NewValues["MaDX"].ToString());
            hsxBLL.sua(hsx);
            Response.Redirect(Request.UrlReferrer.ToString());
        }

        protected void gvHSX_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvHSX.PageIndex = e.NewPageIndex;
            Load();
        }

        protected void btnTim_Click(object sender, EventArgs e)
        {
            if (drTK.Text == "Tìm Theo Mã")
            {
                gvHSX.DataSource = hsxBLL.TimMa(int.Parse((txtTim.Text)));
                gvHSX.DataBind();
            }

            if (drTK.Text == "Tìm Theo Tên")
            {
                gvHSX.DataSource = hsxBLL.TimTen(txtTim.Text);
                gvHSX.DataBind();
            }
            int sobanghi = gvHSX.Rows.Count;
            lbSP.Text = "Có " + sobanghi.ToString() + " " + "kết quả được tìm thấy.";
        }
   
    }
}