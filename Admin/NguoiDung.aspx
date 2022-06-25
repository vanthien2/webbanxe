<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.Master" AutoEventWireup="true" CodeBehind="NguoiDung.aspx.cs" Inherits="MinKi.Admin.NguoiDung" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
            <style type="text/css">
        .style1
        {
            width: 80%;
            height: 340px;
        }
        .style2
        {
            text-align: left;
            font-weight: 700;
            color: #006666;
        }
      
        .style4
        {
            width: 158px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div style="font-family:Arial; text-align:center; font-size:20px; ">Thêm Tài Khoản</div>
    <div style="width:691px;">
        <table class="style1" style="margin:20px auto;" cellspacing="0" cellpadding="0">
        <tr>
            <td class="style2">
                <asp:Label ID="lblTendangnhap" runat="server" Text="Tên đăng nhập" 
                    ForeColor="#663300"></asp:Label>
            &nbsp;</td>
            <td class="style3">
                <asp:TextBox ID="txtTendangnhap" runat="server" Height="26px" Width="161px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="lblMatkhau" runat="server" Text="Mật khẩu" ForeColor="#663300"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td class="style3">
                <asp:TextBox ID="txtMatkhau" runat="server" Height="26px" Width="161px" 
                    TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="lblNhaplaimatkhau" runat="server" Text="Nhập lại mật khẩu" 
                    ForeColor="#663300" ></asp:Label>
            &nbsp;&nbsp;&nbsp;
            </td>
            <td class="style3">
                <asp:TextBox ID="txtNLMatkhau" runat="server" Height="26px" Width="161px" 
                    TextMode="Password"></asp:TextBox>
            </td>
          
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="Label4" runat="server" Text="Họ tên" ForeColor="#663300"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="txtHoten" runat="server" Height="26px" Width="161px"></asp:TextBox>
            </td>
          
        </tr>
              <tr>
            <td class="style2">
                <asp:Label ID="Label6" runat="server" Text="Địa chỉ" ForeColor="#663300"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="txtDiachi" runat="server" Height="26px" Width="161px"></asp:TextBox>
            </td>
          
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="Label5" runat="server" Text="Giới tính" ForeColor="#663300"></asp:Label>
            </td>
            <td class="style2">
            <asp:RadioButtonList ID="rblGioitinh" runat="server" ForeColor="#663300" Height="36px" style="margin-left: 31px">
                    <asp:ListItem>Nam</asp:ListItem>
                    <asp:ListItem>Nữ</asp:ListItem>
                </asp:RadioButtonList>
            </td>
          
        </tr>
      
        <tr>
            <td class="style2">
                <asp:Label ID="Label7" runat="server" Text="Ngày Sinh" ForeColor="#663300"></asp:Label>
            </td>
            <td class="style3">
                <asp:TextBox ID="txtNS" runat="server" Height="26px" Width="161px"></asp:TextBox>
            </td>
           
        </tr>
        <tr>
            <td class="style2">
                         <asp:Label ID="lblDienthoai" runat="server" Text="Số điện thoại" ForeColor="#663300"></asp:Label></td>
            <td class="style3">
                <asp:TextBox ID="txtDienthoai" runat="server"  Height="26px" Width="161px" 
                    TabIndex="1" ForeColor="#663300" ></asp:TextBox>
            </td>
     
                
        </tr>
        <tr>
            <td class="style2" colspan="2">
            <br />
                <asp:Button ID="btnXacnhan" runat="server" Text="Xác nhận" ForeColor="Black" 
                    Height="35px" Width="102px" OnClick="btnXacnhan_Click"  />     
                &nbsp;     
                  <asp:Button ID="BtnHuy" runat="server" Text="Hủy Bỏ" ForeColor="Black" 
                    Height="35px" Width="102px"  />     
                &nbsp;     
                <br />
            </td>
            <td class="style4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2" colspan="3" align="center">
                <asp:Label ID="lblThongBao" runat="server" Font-Size="X-Large" ForeColor="Red"></asp:Label>
            </td>
        </tr>
    </table>
    
    </div>
</asp:Content>
