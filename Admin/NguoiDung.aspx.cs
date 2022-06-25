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
    public partial class NguoiDung : System.Web.UI.Page
    {
        TaiKhoan tk = new TaiKhoan();
        TaiKhoanBLL tkBLL = new TaiKhoanBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((bool)Session["TrangThaiDangNhap"] == false)
                Response.Redirect("/Admin/Admin.aspx");
        }

        protected void btnXacnhan_Click(object sender, EventArgs e)
        {
            tk.TenTK = txtTendangnhap.Text;
            tk.MK = txtMatkhau.Text;
            tk.HoTen = txtHoten.Text;
            tk.DiaChi = txtDiachi.Text;
            tk.GT = rblGioitinh.SelectedValue;
            tk.NS = DateTime.Parse(txtNS.Text);
            tk.SDT = txtDienthoai.Text;
            tkBLL.them(tk);
            Response.Redirect(Request.UrlReferrer.ToString());
        }
    }
}