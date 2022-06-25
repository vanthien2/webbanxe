<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="MinKi.Admin.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div id="headAd">ĐĂNG NHẬP HỆ THỐNG</div>
     <br />
    <br />
    <table border="1" align="center" cellspacing="0" cellpadding="0" style="border:1px solid #b200ff;color:red;background:#ffffff">
        <tr><th colspan="2">Đăng Nhập Hệ Thống</th></tr>
        <tr><th style="width:140px">Tên Đăng Nhập</th><td><asp:TextBox runat="server" ID="txtTenDN" Width="250px"></asp:TextBox></td></tr>
        <tr><th style="width:140px">Mật Khẩu</th><td><asp:TextBox TextMode="Password" ID="txtMK" runat="server" Width="250px"></asp:TextBox></td></tr>
        <tr><th colspan="2"><asp:Button ID="btnDN" style="color:#b200ff" runat="server" Text="Đăng Nhập" OnClick="btnDN_Click"/><asp:Button ID="btnHuy" runat="server"  style="color:#b200ff" Text="Hủy Bỏ"/></th></tr>
    </table>
</asp:Content>
