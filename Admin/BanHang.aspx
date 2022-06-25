<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.Master" AutoEventWireup="true" CodeBehind="BanHang.aspx.cs" Inherits="MinKi.Admin.BanHang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
           <div id="headAd">Quản Lý Bán Hàng</div>
    <div style="font-family:'Times New Roman';float:left; font-size:20px; color:red; text-align:left">Lọc Theo:&nbsp;&nbsp;&nbsp;<asp:DropDownList Width="130px" ID="DrLoc" runat="server" Height="20px">
        <asp:ListItem>Chưa Duyệt</asp:ListItem>
        <asp:ListItem>Đã Duyệt</asp:ListItem>
        </asp:DropDownList>
        <asp:Button id="btnLoc" runat="server" Text="Lọc" OnClick="btnLoc_Click"/></div>
    <div style="font-family:'Times New Roman';float:right; font-size:20px; color:red; text-align:left">Tìm kiếm:&nbsp;&nbsp;&nbsp;<asp:DropDownList Width="250px" ID="drTK" runat="server" Height="20px">
        <asp:ListItem>Tìm Theo Mã</asp:ListItem>
        <asp:ListItem>Tìm Theo Tên Khách Hàng</asp:ListItem>
        <asp:ListItem>Tìm Theo Ngày Đặt Hàng</asp:ListItem>
                                                                                          </asp:DropDownList>
        <asp:TextBox ID="txtTim" runat="server" Width="137px" placeholder="Nhập từ khóa cần tìm"></asp:TextBox>
        <asp:Button id="btnTim" runat="server" Text="Tìm Kiếm" OnClick="btnTim_Click"/></div>
    
    <br /><br />
    <asp:GridView ID="gvDonHang" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" PageSize="20" ForeColor="Black" GridLines="Vertical" Width="100%" AllowPaging="True" OnRowDeleting="gvDonHang_RowDeleting" OnRowEditing="gvDonHang_RowEditing" OnRowUpdating="gvDonHang_RowUpdating" OnRowCancelingEdit="gvDonHang_RowCancelingEdit">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:TemplateField HeaderText="Mã">
                <ItemTemplate>
                    <asp:Label ID="Label7" runat="server" Text='<%# Bind("MaDH") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Tài Khoản">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("TenTK") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label9" runat="server" Text='<%# Bind("TenTK") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Khách Hàng">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("TenKH") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Số Điện Thoại">
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("SDT") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Ngày Đặt">
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("NgayDH","{0:dd/MM/yyyy}") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Người Nhận">
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("TenNN") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Địa Chỉ Giao Hàng">
                <ItemTemplate>
                    <asp:Label ID="Label5" runat="server" Text='<%# Bind("DC") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Tổng Tiền">
                <ItemTemplate>
                    <asp:Label ID="Label8" runat="server" Text='<%# Bind("TongTien","{0:0,000}") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Trạng Thái">
                <EditItemTemplate>
                    <asp:DropDownList ID="drTT" runat="server">
                        <asp:ListItem>Đã Duyệt</asp:ListItem>
                    </asp:DropDownList>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label6" runat="server" Text='<%# Bind("TT") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField ShowHeader="False">
                <EditItemTemplate>
                    <asp:LinkButton ID="LinkButton13" runat="server" CausesValidation="True" CommandName="Update" Text="Lưu"></asp:LinkButton>
                    &nbsp;<asp:LinkButton ID="LinkButton23" runat="server" CausesValidation="False" CommandName="Cancel" Text="Hủy"></asp:LinkButton>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Edit" Text="Duyệt"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete" Text="Xóa"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
           <asp:HyperLinkField DataNavigateUrlFields="MaDH" DataNavigateUrlFormatString="ChiTietBan.aspx?MaDH={0}" Text="Chi Tiết" HeaderText="Chi Tiết" />
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
</asp:Content>
