using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data;

namespace MinKi.Admin
{
    public partial class DoanhThu : System.Web.UI.Page
        
    {
        DonHangBLL dh=new DonHangBLL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvDH.PageIndex=e.NewPageIndex;
        }
         void TinhTong()
        {
            double tongtiennhap = 0;
            foreach (GridViewRow gr in gvDH.Rows)
            {
                tongtiennhap += double.Parse(gr.Cells[7].Text);
            }
            Label1.Text = tongtiennhap.ToString("###,###") + "  " + "VNĐ";
        }
        protected void btnThongke_Click(object sender, EventArgs e)
        {
        
         if(rdoTK.Items[0].Selected)
            {
                DateTime ngay = DateTime.Parse(txtNgay.Text);
                gvDH.DataSource = dh.DoanhThuNgay(DateTime.Parse(ngay.ToString("dd/MM/yy")));
                gvDH.DataBind();
                TinhTong();
            }
            if (rdoTK.Items[1].Selected)
            {
                DateTime ngaybd = DateTime.Parse(txtTungay.Text);
                DateTime ngaykt = DateTime.Parse(txtDenngay.Text);
                gvDH.DataSource = dh.DoanhThuKhoangNgay(DateTime.Parse(ngaybd.ToString("dd/MM/yy")),DateTime.Parse(ngaykt.ToString("dd/MM/yy")));
                gvDH.DataBind();
                TinhTong();
            }
            if (rdoTK.Items[2].Selected)
            {
                gvDH.DataSource = dh.DoanhThuNam(int.Parse(drNam.SelectedValue));
                gvDH.DataBind();
                TinhTong();
            }
        }
    }
}