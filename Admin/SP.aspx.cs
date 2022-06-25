using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using DAO;
using BLL;
using System.Data;
using System.Data.SqlClient;

using System.IO;


namespace MinKi.Admin
{
    public partial class SP : System.Web.UI.Page
    {
        SanPham sp = new SanPham();
        SanPhamBLL spBLL = new SanPhamBLL();
        LoaiXeBLL lx = new LoaiXeBLL();
        HangSanXuatBLL hsx = new HangSanXuatBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((bool)Session["TrangThaiDangNhap"] == false)
                Response.Redirect("/Admin/Admin.aspx");
            else
            {

                if (!IsPostBack)
                {
                  
                    LoadSP();
                  
                }
            }
        }
        private void LoadSP()
        {
            gvSP.DataSource = spBLL.laytoanbo();
            gvSP.DataBind();
            DropDownList drDX = (DropDownList)gvSP.FooterRow.FindControl("drHangSX");

            drDX.DataSource = hsx.laytoanbo();
            drDX.DataTextField = "TenDX";
            drDX.DataValueField = "MaDX";
            drDX.DataBind();
            DropDownList drLoai = (DropDownList)gvSP.FooterRow.FindControl("drLoai");

            drLoai.DataSource = lx.laytoanbo();
            drLoai.DataTextField = "TenLoai";
            drLoai.DataValueField = "Maloai";
            drLoai.DataBind();
            
        }
      
        
        protected void gvSP_RowDataBound(object sender, GridViewRowEventArgs e)
        {
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            string fileName = "";
            FileUpload fUpLoad = (FileUpload)gvSP.FooterRow.FindControl("fUpLoad");
            if (Page.IsValid && fUpLoad.HasFile)
            {
                fileName = "~/Images/" + fUpLoad.FileName;
                string filePath = MapPath(fileName);
                fUpLoad.SaveAs(filePath);
            }
            TextBox txtSoKhung = (TextBox)gvSP.FooterRow.FindControl("txtSoKhung");
            TextBox txtTen = (TextBox)gvSP.FooterRow.FindControl("txtTen");
            DropDownList drLoai = (DropDownList)gvSP.FooterRow.FindControl("drLoai");
            DropDownList drHSX = (DropDownList)gvSP.FooterRow.FindControl("drHangSX");
            TextBox txtgia = (TextBox)gvSP.FooterRow.FindControl("txtGia");
            TextBox txtMauXe = (TextBox)gvSP.FooterRow.FindControl("txtMauXe");
            TextBox txtMota = (TextBox)gvSP.FooterRow.FindControl("txtMoTa");
            if (drHSX.SelectedValue.ToString() == "" || drLoai.SelectedValue.ToString() == "" || txtTen.Text == "" || txtMota.Text == "" || txtMauXe.Text == "" || txtgia.Text == "" || !fUpLoad.HasFile == true)
            {
             Label anh = (Label)gvSP.FooterRow.FindControl("lbAnh");
             Label lbhsx = (Label)gvSP.FooterRow.FindControl("lbHSX");
             Label loai = (Label)gvSP.FooterRow.FindControl("lbLoai");
             Label ten = (Label)gvSP.FooterRow.FindControl("lbTen");
             Label gia = (Label)gvSP.FooterRow.FindControl("lbGia");
             Label mau = (Label)gvSP.FooterRow.FindControl("lbMau");
             Label mota = (Label)gvSP.FooterRow.FindControl("lbMoTa");
             Label sokhung = (Label)gvSP.FooterRow.FindControl("lbSoKhung");
             //if (Regex.IsMatch(dt.Text, @"^[0-9]+$"))
             //{
             //    if (dt.Text.Length >= 10 && dt.Text.Length <= 11)
             //        e4.Text = "";
             //    else
             //        e4.Text = "Số điện thoại phải từ 10 - 11 số";
             //}
             //else
             //    e4.Text = "Chỉ được nhập số!";
             if (txtSoKhung.Text == "")
             {
                 sokhung.Text = "Bạn chưa nhập tên xe";
             }
       
                else
           {
               lbhsx.Text = "";
           }
           if (drLoai.SelectedValue.ToString() == "1")
           {
              
               loai.Text = "Chưa chọn loại xe";
           }
                else
           { loai.Text = ""; }

           if (txtTen.Text == "")
           {
               ten.Text = "Bạn chưa nhập tên xe";
           }
           else
           {
               ten.Text = "";
           }
           if (txtMauXe.Text == "")
           {
               mau.Text = "Màu xe???";
           }
           else
           {
               mau.Text = "";
           }
           if (txtMota.Text == "")
           {
               mota.Text = "Chưa có mô tả";
           }
           else
           {
               mota.Text = "";
           }
           if (txtgia.Text == "")
           {
               gia.Text = "Giá xe???";
           }
           else
           {
               gia .Text = "";
           }
           if (!fUpLoad.HasFile==true)
                {
                    anh.Text = "Chưa có ảnh";
                }
                else { anh.Text = ""; }
           }
            else
            {
                if (spBLL.kiemtrama(txtSoKhung.Text) == true)
                {
                    sp.MaXe = txtSoKhung.Text;
                    sp.MaLoai = int.Parse(drLoai.Text);
                    sp.MaHSX = int.Parse(drHSX.Text);
                    sp.TenXe = txtTen.Text;
                    sp.DonGia = double.Parse(txtgia.Text);
                    sp.SL = 0;
                    sp.MauXe = txtMauXe.Text;
                    sp.Anh = fUpLoad.FileName;
                    sp.MoTa = txtMota.Text;

                    spBLL.them(sp);
                    Response.Redirect(Request.UrlReferrer.ToString());
                }
                else
                {
                        Response.Write("<script>alert('Số Khung đã tồn tại!')</script>");
                }
                {

                }
            }
        }

        protected void gvSP_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                string ma = e.Values["SoKhung"].ToString();
                spBLL.xoa(ma);
                Response.Redirect(Request.UrlReferrer.ToString());
            }
            catch
            {
                Response.Write("<script>alert('Không thể xóa!')</script>");

            }
        }

        protected void gvSP_RowEditing(object sender, GridViewEditEventArgs e)
        {

            gvSP.EditIndex = e.NewEditIndex;
            LoadSP();
        }

        protected void gvSP_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvSP.EditIndex = -1;
            LoadSP();
        }

        protected void gvSP_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int idLX = int.Parse(((DropDownList)gvSP.Rows[e.RowIndex].FindControl("drLoaiXe")).SelectedValue);
            DropDownList drLoai = (DropDownList)gvSP.FooterRow.FindControl("drLoaiXe");
            drLoai.DataSource = lx.laytoanbo();
            drLoai.DataTextField = "TenLoai";
            drLoai.DataValueField = "Maloai";
            drLoai.DataBind();
            int idHSX = int.Parse(((DropDownList)gvSP.Rows[e.RowIndex].FindControl("drHSX")).SelectedValue);
            sp.MaXe = e.NewValues["SoKhung"].ToString();
            sp.MaHSX = idHSX;
            sp.MaLoai = idLX;
            sp.TenXe = e.NewValues["TenXe"].ToString();
            sp.DonGia = int.Parse(e.NewValues["DonGia"].ToString());
            sp.MauXe = e.NewValues["MauXe"].ToString();
            sp.MoTa = e.NewValues["Mota"].ToString();


            spBLL.sua(sp);
            Response.Redirect(Request.UrlReferrer.ToString());
        }

        protected void gvSP_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvSP.PageIndex = e.NewPageIndex;
            LoadSP();
        }

        protected void gvSP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnTim_Click(object sender, EventArgs e)
        {

            if (drTK.Text == "Tìm Theo Mã")
            {
                gvSP.DataSource = spBLL.TimMa(int.Parse((txtTim.Text)));
                gvSP.DataBind();
            }

            if (drTK.Text == "Tìm Theo Tên")
            {
                gvSP.DataSource = spBLL.TimTen(txtTim.Text);
                gvSP.DataBind();
            }

            if (drTK.Text == "Tìm Theo Loại Xe")
            {
                gvSP.DataSource = spBLL.TimLX(txtTim.Text);
                gvSP.DataBind();
            }

            if (drTK.Text == "Tìm Theo Dòng Xe")
            {
                gvSP.DataSource = spBLL.TimHSX(txtTim.Text);
                gvSP.DataBind();
            }
            int sobanghi = gvSP.Rows.Count;
            Label12.Text = "Có " + sobanghi.ToString() +" "+ "kết quả được tìm thấy.";

        }
    }
}