<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.Master" AutoEventWireup="true" CodeBehind="ChiTietBan.aspx.cs" Inherits="MinKi.Admin.ChiTietBan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div id="headAd">Quản Lý Chi Tiết Đơn Hàng</div>
            
    <div style="float:left;width: 900px;margin-left: 100px; padding-top:10px;">
        <div style="text-align:center; font-family:'Times New Roman';font-size:20px;color:#ffd800">Danh Sách Chi Tiết Đơn Hàng</div>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" Width="900px" OnPageIndexChanging="GridView1_PageIndexChanging">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="Mã Đơn Hàng">
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("MaDH") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Số Khung">
                    <ItemTemplate>
                        <asp:Label ID="Label5" runat="server" Text='<%# Bind("SoKhung") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Tên Xe">
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("TenXe") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Số lượng">
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("SL") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Đơn Giá">
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("DonGia","{0:0,000}") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Thành Tiền(VNĐ)">
                    <ItemTemplate>
                        <asp:Label ID="Label6" runat="server" Text='<%# Bind("ThanhTien","{0:0,000}") %>'></asp:Label>
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
    </div>
</asp:Content>
