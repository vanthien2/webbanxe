using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using BLL;
namespace MinKi.Admin
{
    public partial class LoaiXe : System.Web.UI.Page
    {
        LoaiXeBLL lxBLL = new LoaiXeBLL();
        LX lx = new LX();
        protected void Page_Load(object sender, EventArgs e)
        {
            //if ((bool)Session["TrangThaiDangNhap"] == false)
            //    Response.Redirect("/Admin/Admin.aspx");
            //else
            //{
            if(!IsPostBack)
            {
                Load();
            }
            //}
        }
        public void Load()
        {
           gvLX.DataSource = lxBLL.laytoanbo();
            gvLX.DataBind();
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            TextBox txtTen = (TextBox)gvLX.FooterRow.FindControl("txtTen");
            if (txtTen.Text != "")
            {
                lx.TenLoai = txtTen.Text;
                lxBLL.them(lx);
                Response.Redirect(Request.UrlReferrer.ToString());
            }
            else
            {
                Response.Write("<script>alert('Tên loại xe không được để rỗng!')</script>");
            }
        }

        protected void gvLX_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                int ma = int.Parse(e.Values["MaLoai"].ToString());
                lxBLL.xoa(ma);
                Response.Redirect(Request.UrlReferrer.ToString());
            }
            catch
            {
                Response.Write("<script>alert('Không thể xóa!')</script>");

            }
        }

        protected void gvLX_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvLX.EditIndex = e.NewEditIndex;
            Load();
        }

        protected void gvLX_RowUpdated(object sender, GridViewUpdatedEventArgs e)
        {

        }

        protected void gvLX_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            lx.TenLoai = e.NewValues["TenLoai"].ToString();
            lx.MaLoai = int.Parse(e.NewValues["MaLoai"].ToString());
            lxBLL.sua(lx);
            Response.Redirect(Request.UrlReferrer.ToString());
        }

        protected void gvLX_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvLX.EditIndex = -1;
            Load();
        }
    }
}