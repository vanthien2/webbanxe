<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.Master" AutoEventWireup="true" CodeBehind="SanPhamDaHet.aspx.cs" Inherits="MinKi.Admin.SanPhamDaHet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> <div id="headAd">Danh Sách Sản Phẩm Cần Nhập Về</div>
   <div>
       <asp:Label ID="lbSP" runat="server" style="color:red"></asp:Label></div>
    <div style="padding-top:18px"><asp:GridView ID="gvSP" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" Width="100%"  AllowPaging="True" PageSize="3" style="margin-left: 0px; margin-right: 0px" OnPageIndexChanging="gvSP_PageIndexChanging">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:TemplateField HeaderText="Mã">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("SoKhung") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Loại Xe">
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("TenLoai") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Dòng Xe">
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("TenDX") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Tên Xe">
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("TenXe") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Giá Bán">
                <ItemTemplate>
                    <asp:Label ID="Label5" runat="server" Text='<%# Bind("DonGia","{0:0,000}") %>'></asp:Label>
                </ItemTemplate>
                <ItemStyle />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Số Lượng">
       
                <ItemTemplate>
                    <asp:Label ID="Label6" runat="server" Text='<%# Bind("SL") %>'></asp:Label>
                </ItemTemplate>
                
                <ItemStyle />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Màu Xe">
          
                <ItemTemplate>
                    <asp:Label ID="Label7" runat="server" Text='<%# Bind("MauXe") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Ảnh">
                <ItemTemplate>
                 <asp:Image runat="server" Width="100" Height="120"
                  ImageUrl ='<%# Eval("Anh","~/Images/{0}") %>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Mô Tả">
                <ItemTemplate>
                    <asp:Label ID="Label11" runat="server" Text='<%# Bind("Mota") %>' Width="280px"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Nhập Hàng">
            <ItemTemplate>
                <a href="PhieuNhap.aspx">Nhập Hàng</a>
            </ItemTemplate>
        </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="#CCCC99" />
        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
        <RowStyle BackColor="#F7F7DE" Wrap="True" />
        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FBFBF2" />
        <SortedAscendingHeaderStyle BackColor="#848384" />
        <SortedDescendingCellStyle BackColor="#EAEAD3" />
        <SortedDescendingHeaderStyle BackColor="#575357" />
    </asp:GridView>
       </div>
</asp:Content>
