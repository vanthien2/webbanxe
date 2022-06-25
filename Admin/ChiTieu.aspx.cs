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
    public partial class ChiTieu : System.Web.UI.Page
    {
        PhieuNhapBLL pn = new PhieuNhapBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvPN.PageIndex = e.NewPageIndex;
        }
        void TinhTong()
        {
            double tongtiennhap = 0;
            foreach (GridViewRow gr in gvPN.Rows)
            {
                tongtiennhap += double.Parse(gr.Cells[3].Text);
            }
            Label1.Text = tongtiennhap.ToString("###,###") + "  " + "VNĐ";
        }
        protected void btnThongke_Click(object sender, EventArgs e)
        {
            if(rdoTK.Items[0].Selected)
            {
                DateTime ngay = DateTime.Parse(txtNgay.Text);
                gvPN.DataSource = pn.ThongKeNgay(DateTime.Parse(ngay.ToString("dd/MM/yy")));
                gvPN.DataBind();
                TinhTong();
            }
            if (rdoTK.Items[1].Selected)
            {
                DateTime ngaybd = DateTime.Parse(txtTungay.Text);
                DateTime ngaykt = DateTime.Parse(txtDenngay.Text);
                gvPN.DataSource = pn.ThongKeKhoangNgay(DateTime.Parse(ngaybd.ToString("dd/MM/yy")),DateTime.Parse(ngaykt.ToString("dd/MM/yy")));
                gvPN.DataBind();
                TinhTong();
            }
            if (rdoTK.Items[2].Selected)
            {
                gvPN.DataSource = pn.ThongKeNam(int.Parse(drNam.SelectedValue));
                gvPN.DataBind();
                TinhTong();
            }
        }

      
    }
}