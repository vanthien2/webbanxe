<%@ Page Title="" Language="C#" MasterPageFile="~/Client/Home.Master" AutoEventWireup="true" CodeBehind="ChiTietSanPham.aspx.cs" Inherits="MinKi.Client.ChiTietSanPham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <style type="text/css">
         #trai2 img {
            width: 330px;
            height: 430px;
        }

        #anh img {
            width: 250px;
            height: 435px;
        }
        .style
        {
            width:200px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<asp:DataList ID="dlCTSP" runat="server" >
        <ItemTemplate>
            <div style="margin-right: 5px;width: 670px; height: 500px; margin-top: 10px;">
                <div id="trai2" style="width: 255px; float: left;">
                    <div id="anh">
                        <asp:Image ID="Image1" ImageUrl='<%# "~/Images/"+Eval("Anh") %>' runat="server" />
                    </div>
                </div>
                <div style="width: 395px; float:left">
                    <table cellspacing="0" cellpadding="0">
                     <tr><td colspan="2"></td><b style="font-size: 29px; text-align: center;color: blue;">
                    <asp:Label ID="ten" runat="server" Text='<%# Eval("TenXe") %>' /></b></tr>
                    <tr><th style="width:200px;height: 50px;">Loại Xe:</th>
                    <td><asp:Label ID="Label1" runat="server" Text='<%# Eval("TenLoai") %> ' /></td></tr>
                    <tr><th style="width:200px;height: 50px;">Màu Xe:</th><td><asp:Label ID="mauxe" runat="server" Text='<%# Eval("MauXe") %>' /></td></tr>
                        <tr><th style="width:200px;height: 50px;">Giá Bán:</th><td style="color:red;font-weight:bold;">
                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("DonGia","{0:0,000} VNĐ") %>' /></td></tr>
                    <tr><th style="width:200px;height: 115px;">Mô Tả:</th><td>
                    <asp:Label ID="Label3" runat="server" Text='<%# Eval("MoTa") %>' /></td></tr>
                    <tr><th colspan="2"><asp:Button ID="btnthem" runat="server"  Text="Đặt Mua" CommandArgument='<%# Eval("SoKhung") %>' oncommand="btnthem_Command" Width="137px" />
</th></tr>
                        </table>
                    </div>
                </div>
            </div>

        </ItemTemplate>

    </asp:DataList>

</asp:Content>
