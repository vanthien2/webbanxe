using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace MinKi.Admin
{
    public partial class Admin : System.Web.UI.Page
    {
        TaiKhoanBLL tk = new TaiKhoanBLL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDN_Click(object sender, EventArgs e)
        {

            if (txtTenDN.Text == "")
            {
                Response.Write("<script>alert('Tên tài khoản không được để trống')</script>");
                txtTenDN.Focus();
            }
            else
            {
                if (txtMK.Text == "")
                {
                    Response.Write("<script>alert('Mật khẩu không được để trống.')</script>");
                    txtTenDN.Focus();
                }
                else
                {
                    if (tk.ktrma(txtTenDN.Text, txtMK.Text) == false)
                    {
                        Session["UserName"] = txtTenDN.Text;
                        Session["TrangThaiDangNhap"] = true;
                        Response.Redirect("SP.aspx");
                    }
                    else
                        Response.Write("<script>alert('Sai thông tin tài khoản hoặc mật khẩu! Kiểm tra lại.')</script>");
                    txtMK.Text = "";
                }
            }
        }
    }
}