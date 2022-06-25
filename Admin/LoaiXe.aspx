<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.Master" AutoEventWireup="true" CodeBehind="LoaiXe.aspx.cs" Inherits="MinKi.Admin.LoaiXe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="headAd">Quản Lý Loại Xe</div>
   <div style="padding-top:36px;"><center> <asp:GridView ID="gvLX" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" ShowFooter="True" Width="50%" OnRowCancelingEdit="gvLX_RowCancelingEdit" OnRowDeleting="gvLX_RowDeleting" OnRowEditing="gvLX_RowEditing" OnRowUpdated="gvLX_RowUpdated" OnRowUpdating="gvLX_RowUpdating">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:TemplateField HeaderText="Mã Loại">
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("MaLoai") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Tên Loại">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("TenLoai") %>' Width="253px"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("TenLoai") %>'></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                <asp:TextBox ID="txtTen" placeholder="Nhập tên loại xe" runat="server" Width="258px"></asp:TextBox></FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField ShowHeader="False">
                <EditItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Update" Text="Cập Nhật"></asp:LinkButton>
                    &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel" Text="Hủy Bỏ"></asp:LinkButton>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Edit" Text="Sửa"></asp:LinkButton>
                    &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" OnClientClick="return confirm ('Bạn có muốn xóa?');" CausesValidation="False" CommandName="Delete" Text="Xóa"></asp:LinkButton>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:Button ID="btnThem" runat="server" Text="Thêm" OnClick="btnThem_Click" />
                </FooterTemplate>
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
