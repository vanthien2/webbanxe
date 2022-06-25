<%@ Page Title="" Language="C#" MasterPageFile="~/Client/Home.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MinKi.Client.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="col-mid">
        <div class="box-head"> Sản Phẩm Mới</div>
    </div>
      
    <asp:DataList ID="DataList1" runat="server" DataKeyField="SoKhung" DataSourceID="SqlDataSource1" RepeatColumns="4">
        <ItemTemplate>
            <table class="auto-style2">
                 <tr>
                <td><asp:HyperLink ID="HyperLink3" style="font-size:15px;color:blue;text-align:center" runat="server" Font-Size="10pt" 
                    ForeColor="#333333" Text='<%# Eval("TenXe") %>'
                    NavigateUrl='<%# "ChitietSanPham.aspx?SoKhung="+Eval("SoKhung") %>' Font-Underline="False"
                   ></asp:HyperLink>
                </td>
            </tr>
         <tr><td><asp:Image alt="No images" ID="Image1" runat="server" ImageUrl='<%# "~/Images/"+Eval("Anh") %>' /></td></tr>
           
            <br />
             <tr> <td><asp:Label ID="lbGia" runat="server" class="gia" Text='<%# "  "+Eval("DonGia","{0:0,000} VNĐ")%>'></asp:Label></td></tr>
           
                <tr>
                <td>
                    <asp:Button ID="btnthem" runat="server" style="border-radius: 5px;" Text="Đặt Mua" CommandArgument='<%# Eval("SoKhung") %>' OnCommand="btnthem_Command" Width="137px" />
                </td>
            </tr>

            </table>
        </ItemTemplate>
          </asp:DataList>
         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=.;Initial Catalog=Website;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT top(8) *  FROM [sanpham] order by(SoKhung) desc"></asp:SqlDataSource>
  
</asp:Content>
