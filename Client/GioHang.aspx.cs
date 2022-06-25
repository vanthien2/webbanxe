using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using System.Data;

namespace MinKi.Client
{
    public partial class GioHang : System.Web.UI.Page
    {
           Cart ca=new Cart();


        protected void Page_Load(object sender, EventArgs e)
        {
                        if(!IsPostBack)
             load();
          
            int sc = GridView1.Rows.Count;
            double tongtien = 0;
            for (int i = 0; i < sc; i++)
                tongtien += double.Parse(GridView1.Rows[i].Cells[4].Text.ToString());
            lblTongTien.Text = tongtien.ToString();
            
            
        }
        
        public void load()
        {
            Cart giohang = (Cart)Session["GIOHANG"];
            if (giohang != null)
            {
                GridView1.DataSource = giohang.Item;
                GridView1.DataBind();
            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("DatHang.aspx");
        }

        protected void GridView1_RowDeleting1(object sender, GridViewDeleteEventArgs e)
        {
         Cart giohang = (Cart)Session["GIOHANG"];
            int index = int.Parse(e.RowIndex.ToString());
            giohang.Delete(index);
            Session["GIOHANG"] = giohang;
            GridView1.DataSource = giohang.Item;
            GridView1.DataBind();
            Response.Redirect("giohang.aspx");
        }

        protected void GridView1_RowCancelingEdit1(object sender, GridViewCancelEditEventArgs e)
        {
            Cart giohang = (Cart)Session["GIOHANG"];
            Session["GIOHANG"] = giohang;
            GridView1.DataSource = giohang.Item;
            GridView1.DataBind();
            Response.Redirect("giohang.aspx");

        }

        protected void GridView1_RowEditing1(object sender, GridViewEditEventArgs e)
        {

            GridView1.EditIndex = e.NewEditIndex;
            load();        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {


            Cart giohang = (Cart)Session["GIOHANG"];
            int index = int.Parse(e.RowIndex.ToString());
            TextBox soluong = GridView1.Rows[e.RowIndex].Cells[3].Controls[0] as TextBox;
            int sl = int.Parse(soluong.Text);
            if (sl != 0)
            {
                giohang.Update(index, sl);
                Session["GIOHANG"] = giohang;
                GridView1.DataSource = giohang.Item;
                GridView1.DataBind();
                Response.Redirect("giohang.aspx");
            }
            else
            {
                giohang.Delete(index);
                Session["GIOHANG"] = giohang;
                GridView1.DataSource = giohang.Item;
                GridView1.DataBind();
                Response.Redirect("giohang.aspx");
            }
   


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }       
    }
}
