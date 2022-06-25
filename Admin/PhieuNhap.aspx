<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.Master" AutoEventWireup="true" CodeBehind="PhieuNhap.aspx.cs" Inherits="MinKi.Admin.PhieuNhap" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div id="headAd">Quản Lý Nhập Hàng</div>
    <div style="font-family:'Times New Roman';float:right; font-size:20px; color:red; text-align:left">Tìm kiếm:&nbsp;&nbsp;&nbsp;<asp:DropDownList Width="300px" ID="drTK" runat="server" Height="20px">
        <asp:ListItem>Tìm Theo Mã</asp:ListItem>
        <asp:ListItem>Tìm Theo Người Lập</asp:ListItem>
        <asp:ListItem>Tìm Theo Ngày</asp:ListItem>                                                                                   </asp:DropDownList>
        <asp:TextBox ID="txtTim" runat="server" Width="137px" placeholder="Nhập từ khóa cần tìm"></asp:TextBox>
        <asp:Button id="btnTim" runat="server" Text="Tìm Kiếm" OnClick="btnTim_Click"/></div>
    <asp:Label ID="Label12" runat="server" style="color:red"></asp:Label>
    <br /><br />
    <asp:GridView ID="gvPN" runat="server" AutoGenerateColumns="False" ShowFooter="True" Width="100%" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" OnRowCancelingEdit="gvPN_RowCancelingEdit" OnRowDeleting="gvPN_RowDeleting" OnRowEditing="gvPN_RowEditing"  AllowPaging="True" OnPageIndexChanging="gvPN_PageIndexChanging" PageSize="20" OnSelectedIndexChanged="gvPN_SelectedIndexChanged">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:TemplateField HeaderText="Mã">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("MaPN") %>'></asp:Label>
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Right" />
            </asp:TemplateField>
         
            <asp:TemplateField HeaderText="Tài Khoản">
             
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("TenTK") %>'></asp:Label>
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Ngày Tạo">
            
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("NgayTao","{0:dd/MM/yyyy}") %>'></asp:Label>
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Right" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Tổng Tiền(VNĐ)">
                <ItemTemplate>
                    <asp:Label ID="Label5" runat="server" Text='<%# Bind("TongTien","{0:0,000}") %>'></asp:Label>
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Right" />
            </asp:TemplateField>
            <asp:TemplateField ShowHeader="False" HeaderText="Cập Nhật">
                
                <ItemTemplate>
              <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" OnClientClick="return confirm ('Bạn có muốn xóa?');" CommandName="Delete" Text="Xóa"></asp:LinkButton>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:Button ID="btnThem" runat="server" Text="Thêm" OnClick="btnThem_Click" />
                </FooterTemplate>
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:TemplateField>
            <asp:HyperLinkField DataNavigateUrlFields="MaPN" DataNavigateUrlFormatString="ChiTietNhap.aspx?MaPN={0}" Text="Chi Tiết" HeaderText="Chi Tiết" >
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:HyperLinkField>
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
