<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.Master" AutoEventWireup="true" CodeBehind="SanPhamBanChay.aspx.cs" Inherits="MinKi.Admin.SanPhamBanChay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <style type="text/css">
        .style2
        {
            font-family: Arial, Helvetica, sans-serif;
            font-weight: bold;
            font-size: medium;
        }
        .style3
        {
            width: 48%;
        }
        .style4
        {
            width: 200px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div  style="padding-top:60px">
        <center>
            <span class="style2">THỐNG KÊ SẢN PHẨM BÁN CHẠY</span>
        </center>
        <hr width="70%" />
    </div>
    <br />
    <div>
        <table cellpadding="0" cellspacing="0" class="style3" align="center">
            <tr>
                <td class="style4">
                            <asp:RadioButtonList ID="rdoTK" runat="server" Width="176px" >
                                <asp:ListItem>Theo tháng</asp:ListItem>
                                <asp:ListItem>Theo năm</asp:ListItem>
                            </asp:RadioButtonList>
                </td>
                <td>Tháng
                   <asp:DropDownList ID="drThang" runat="server" Width="104px">
                        <asp:ListItem>01</asp:ListItem>
                           <asp:ListItem>02</asp:ListItem>
                           <asp:ListItem>03</asp:ListItem>
                           <asp:ListItem>04</asp:ListItem>
                           <asp:ListItem>05</asp:ListItem>
                           <asp:ListItem>06</asp:ListItem>
                           <asp:ListItem>07</asp:ListItem>
                         <asp:ListItem>08</asp:ListItem>
                         <asp:ListItem>09</asp:ListItem>
                         <asp:ListItem>10</asp:ListItem>
                         <asp:ListItem>11</asp:ListItem>
                         <asp:ListItem>12</asp:ListItem>
                    </asp:DropDownList>
                   Năm
                     <asp:DropDownList ID="drmTrongNam" runat="server" Width="104px">
                        <asp:ListItem>2014</asp:ListItem>
                           <asp:ListItem>2015</asp:ListItem>
                           <asp:ListItem>2016</asp:ListItem>
                           <asp:ListItem>2017</asp:ListItem>
                           <asp:ListItem>2018</asp:ListItem>
                           <asp:ListItem>2019</asp:ListItem>
                           <asp:ListItem>2020</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <asp:DropDownList ID="drNam" runat="server" Width="104px" style="margin-left: 45px">
                        <asp:ListItem>2014</asp:ListItem>
                           <asp:ListItem>2015</asp:ListItem>
                           <asp:ListItem>2016</asp:ListItem>
                           <asp:ListItem>2017</asp:ListItem>
                           <asp:ListItem>2018</asp:ListItem>
                           <asp:ListItem>2019</asp:ListItem>
                           <asp:ListItem>2020</asp:ListItem>
                    </asp:DropDownList>
                  <asp:Button ID="btnThongke" runat="server" Text="Thống kê" OnClick="btnThongke_Click" style="margin-left: 38px" Width="99px" />
                </td>
                
            </tr>
        </table>
    </div>
    <br />
    <div>
    <center>
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" Width="80%">
    <AlternatingRowStyle BackColor="White" />
    <Columns>
        <asp:BoundField DataField="SoKhung" HeaderText="Số Khung" />
        <asp:BoundField DataField="TenXe" HeaderText="Tên Xe" />
        <asp:BoundField DataField="TenLoai" HeaderText="Tên Loại" />
        <asp:BoundField HeaderText="Dòng Xe" DataField="TenDX" />
        <asp:TemplateField HeaderText="Đơn Giá">
           
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%# Bind("DonGia","{0:0,000}") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:BoundField DataField="SL" HeaderText="Số Lượng Còn" />
        <asp:BoundField DataField="SLBan" HeaderText="Số Lượng Bán" />
        <asp:TemplateField HeaderText="Nhập Hàng">
            <ItemTemplate>
                <a href="PhieuNhap.aspx">Nhập Hàng</a>
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
    <FooterStyle BackColor="#CCCC99" />
    <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
    <RowStyle BackColor="#F7F7DE" />
    <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
    <SortedAscendingCellStyle BackColor="#FBFBF2" />
    <SortedAscendingHeaderStyle BackColor="#848384" />
    <SortedDescendingCellStyle BackColor="#EAEAD3" />
    <SortedDescendingHeaderStyle BackColor="#575357" />
        </asp:GridView>
    </center>
    </div>
    
</asp:Content>
