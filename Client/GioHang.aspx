<%@ Page Title="" Language="C#" MasterPageFile="~/Client/Home.Master" AutoEventWireup="true" CodeBehind="GioHang.aspx.cs" Inherits="MinKi.Client.GioHang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div style="text-align:center;">
        <div class="box-head">Giỏ Hàng:</div>
    </div>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="100%" BackColor="#FF3399" BorderColor="#CC9966" BorderStyle="Dotted" BorderWidth="1px" CellPadding="4" GridLines="Horizontal" OnRowCancelingEdit="GridView1_RowCancelingEdit1" OnRowDeleting="GridView1_RowDeleting1" OnRowEditing="GridView1_RowEditing1" OnRowUpdating="GridView1_RowUpdating">
        <Columns>
            <asp:TemplateField HeaderText="Mã Xe">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("SoKhung") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Tên Xe">
                <ItemTemplate>
                    &nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("Tenxe") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Đơn Giá">
              
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("Dongia","{0:0,000}") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="Soluong" HeaderText="Số lượng" />
            <asp:BoundField DataField="Thanhtien" HeaderText="Tổng tiền" ReadOnly="True" />
            <asp:TemplateField HeaderText="Ảnh">
                <ItemTemplate>
                    <asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("Anh","~/Images/{0}") %>' Width="100" Height="100" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:CommandField HeaderText="Cập Nhật" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" DeleteText="Xóa" EditText="Sửa" />
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
Tổng Tiền
<asp:Label ID="lblTongTien" runat="server" ForeColor="Red" Text="0"></asp:Label>VNĐ
<asp:Button ID="Button1" runat="server" Text="Đặt Hàng" OnClick="Button1_Click" />
    <asp:Button ID="Button2" runat="server" Text="Mua Tiếp" OnClick="Button2_Click" />

</asp:Content>
