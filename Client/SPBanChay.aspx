<%@ Page Title="" Language="C#" MasterPageFile="~/Client/Home.Master" AutoEventWireup="true" CodeBehind="SPBanChay.aspx.cs" Inherits="MinKi.Client.SPBanChay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div id="col-mid">
        <div class="box-head" style="padding-left:229px"> TOP 8 SẢN PHẨM BÁN CHẠY NHẤT</div>
    </div>
     <asp:DataList ID="DataList1" runat="server"  RepeatColumns="4">
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
                    <asp:Button ID="btnthem" runat="server"  Text="Đặt Mua" CommandArgument='<%# Eval("SoKhung") %>' oncommand="btnthem_Command" Width="137px" />
                </td>
            </tr>

            </table>
        </ItemTemplate>
          </asp:DataList>
</asp:Content>
