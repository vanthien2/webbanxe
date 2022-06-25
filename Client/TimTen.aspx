<%@ Page Title="" Language="C#" MasterPageFile="~/Client/Home.Master" AutoEventWireup="true" CodeBehind="TimTen.aspx.cs" Inherits="MinKi.Client.TimTen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="dlKQ" runat="server" DataKeyField="SoKhung" RepeatColumns="4">
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
