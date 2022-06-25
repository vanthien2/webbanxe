using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using BLL;
using System.Data;

namespace MinKi.Admin
{
    public partial class BanHang : System.Web.UI.Page
    {
        ChiTietDonHangBLL ctdh = new ChiTietDonHangBLL();
    DonHangBLL dhBLL = new DonHangBLL();
        DonHang dh = new DonHang();
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
            gvDonHang.DataSource = dhBLL.laytoanbo();
            gvDonHang.DataBind();
        }

        protected void gvDonHang_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvDonHang.PageIndex = e.NewPageIndex;
            Load();
        }

        protected void gvDonHang_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
               string tt = e.Values["TT"].ToString();
                int ma = int.Parse(e.Values["MaDH"].ToString());
               if (tt.ToString() == "Chưa Duyệt")
               {
                    ctdh.xoa(ma);
                    dhBLL.xoa(ma);
                    Load();
              }
                else
              Response.Write("<script>alert('Không thể xóa!')</script>");
            }
            catch
            {
                Response.Write("<script>alert('Không thể xóa!')</script>");

            }
        }

        protected void gvDonHang_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvDonHang.EditIndex = e.NewEditIndex;
            Load();
        }

        protected void gvDonHang_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string tt = ((DropDownList)gvDonHang.Rows[e.RowIndex].FindControl("drTT")).SelectedValue;

            dh.MaDH = int.Parse(e.NewValues["MaDH"].ToString());
            dh.TenTK = Session["UserName"].ToString();
            dh.TT = tt;
            dhBLL.sua(dh);
            Response.Redirect(Request.UrlReferrer.ToString());
        }

        protected void gvDonHang_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvDonHang.EditIndex = -1;
            Load();
        }

        protected void btnTim_Click(object sender, EventArgs e)
        {
            if (drTK.Text == "Tìm Theo Mã")
            {
                gvDonHang.DataSource = dhBLL.TimMa(int.Parse((txtTim.Text)));
                gvDonHang.DataBind();
            }

            if (drTK.Text == "Tìm Theo Tên Khách Hàng")
            {
                gvDonHang.DataSource = dhBLL.TimTenkh(txtTim.Text);
                gvDonHang.DataBind();
            }

            if (drTK.Text == "Tìm Theo Ngày Đặt Hàng")
            {
                gvDonHang.DataSource = dhBLL.TimNgay(DateTime.Parse(txtTim.Text));
                gvDonHang.DataBind();

            }
        }

        protected void btnLoc_Click(object sender, EventArgs e)
        {
            if (DrLoc.Text == "Đã Duyệt")
            {
                gvDonHang.DataSource = dhBLL.DaDuyet();
                gvDonHang.DataBind();
            }
           
            if (DrLoc.Text == "Chưa Duyệt")
            {
                gvDonHang.DataSource = dhBLL.ChuaDuyet();
                gvDonHang.DataBind();
            }
        }
    }
}