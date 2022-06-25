<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.Master" AutoEventWireup="true" CodeBehind="HSX.aspx.cs" Inherits="MinKi.Admin.HSX" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div id="headAd">Quản Lý Dòng Xe</div>
    <div style="font-family:'Times New Roman';float:right; font-size:20px; color:red; text-align:left">Tìm kiếm:&nbsp;&nbsp;&nbsp;<asp:DropDownList Width="300px" ID="drTK" runat="server" Height="20px">
        <asp:ListItem>Tìm Theo Mã</asp:ListItem>
        <asp:ListItem>Tìm Theo Tên</asp:ListItem>                                                                                      </asp:DropDownList>
           <asp:TextBox ID="txtTim" runat="server" Width="137px" placeholder="Nhập từ khóa cần tìm"></asp:TextBox>
        <asp:Button id="btnTim" runat="server" Text="Tìm Kiếm" OnClick="btnTim_Click"/></div>
    <asp:Label ID="lbSP" runat="server" style="color:red"></asp:Label>
    <br /><br />
    <asp:GridView ID="gvHSX" runat="server" CellPadding="4"  GridLines="Vertical" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" ShowFooter="True" Width="100%" ForeColor="Black" OnRowDeleting="gvHSX_RowDeleting" OnRowCancelingEdit="gvHSX_RowCancelingEdit" OnRowEditing="gvHSX_RowEditing" OnRowUpdating="gvHSX_RowUpdating" AllowPaging="True" OnPageIndexChanging="gvHSX_PageIndexChanging" AllowSorting="True">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:TemplateField HeaderText="Mã dòng xe">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("MaDX") %>'></asp:Label>
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="20%" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Tên dòng xe">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("TenDX") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("TenDX") %>'></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="txtTen" runat="server" Width="65%" placeholder="Nhập tên dòng xe"></asp:TextBox>
                 
                </FooterTemplate>
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:TemplateField>
            <asp:TemplateField ShowHeader="False">
                <EditItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Update" Text="Cập Nhật"></asp:LinkButton>
                    &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel" Text="Hủy Bỏ"></asp:LinkButton>
                </EditItemTemplate>
                <ItemTemplate>
                    &nbsp;
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Edit" Text="Sửa"></asp:LinkButton>
                   &nbsp;&nbsp; &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" OnClientClick="return confirm ('Bạn có muốn xóa?');" CausesValidation="False" CommandName="Delete" Text="Xóa"></asp:LinkButton>
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
</asp:Content>
