<%@ Page Title="" Language="C#" MasterPageFile="~/Client/Home.Master" AutoEventWireup="true" CodeBehind="DatHang.aspx.cs" Inherits="MinKi.Client.DatHang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="100%" BackColor="#FF3399" BorderColor="#CC9966" BorderStyle="Dotted" BorderWidth="1px" CellPadding="4" GridLines="Horizontal" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" >
        <Columns>
            <asp:TemplateField HeaderText="Mã Xe">
              
                <ItemTemplate>
                    &nbsp;
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("SoKhung") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Tên Xe">
             
                <ItemTemplate>
                    &nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("Tenxe") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="Dongia" HeaderText="Đơn Giá" ReadOnly="True" />
            <asp:BoundField DataField="Soluong" HeaderText="Số lượng" />
            <asp:BoundField DataField="Thanhtien" HeaderText="Tổng tiền" ReadOnly="True" />
            <asp:TemplateField HeaderText="Ảnh">
             
                <ItemTemplate>
                    <asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("Anh","~/Images/{0}") %>' Width="100" Height="100" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:CommandField HeaderText="Cập Nhật" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" />
        </Columns>
        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="#330099" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
        <SortedAscendingCellStyle BackColor="#FEFCEB" />
        <SortedAscendingHeaderStyle BackColor="#AF0101" />
        <SortedDescendingCellStyle BackColor="#F6F0C0" />
        <SortedDescendingHeaderStyle BackColor="#7E0000" />
    </asp:GridView>
    
     <table style="margin-left:84px">
            <tr><td colspan="2" align="center" class="auto-style2"><strong>Thông Tin Người Mua</strong></td></tr>
            <tr><td>NGƯỜI ĐẶT HÀNG</td><td><asp:TextBox ID="txtkhachhang" runat="server" Width="350px"></asp:TextBox></td></tr>
            <tr><td>SỐ ĐIỆN THOẠI</td><td><asp:TextBox ID="txtsdt" runat="server" Width="350px"></asp:TextBox></td></tr>
            <tr><td>TÊN NGƯỜI NHẬN</td><td><asp:TextBox ID="txtnguoinhan" runat="server" Width="350px"></asp:TextBox></td></tr>
            <tr><td>ĐỊA CHỈ NHẬN</td><td><asp:TextBox ID="txtdiachi" runat="server" Width="350px"></asp:TextBox></td></tr>
            
        
        </table>
         <asp:Button ID="Button2" runat="server" Text="Gửi tin" OnClick="Button2_Click" />
    <asp:Button ID="Button1" runat="server" Text="Quay Lại" OnClick="Button1_Click" />
</asp:Content>
