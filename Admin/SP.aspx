<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.Master" AutoEventWireup="true" CodeBehind="SP.aspx.cs" Inherits="MinKi.Admin.SP" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="headAd">
        
&nbsp;Quản Lý Sản Phẩm</div>
    <div style="font-family:'Times New Roman';float:right; font-size:20px; color:red; text-align:left">Tìm kiếm:&nbsp;&nbsp;&nbsp;<asp:DropDownList Width="177px" ID="drTK" runat="server" Height="25px">
        <asp:ListItem>Tìm Theo Mã</asp:ListItem>
        <asp:ListItem>Tìm Theo Tên</asp:ListItem>
        <asp:ListItem>Tìm Theo Loại Xe</asp:ListItem>
        <asp:ListItem>Tìm Theo Dòng Xe</asp:ListItem>
           </asp:DropDownList>
        <asp:TextBox ID="txtTim" runat="server" Width="137px" placeholder="Nhập từ khóa cần tìm"></asp:TextBox>
        <asp:Button id="btnTim" runat="server" Text="Tìm Kiếm" OnClick="btnTim_Click"/></div>
    <asp:Label ID="Label12" runat="server" style="color:red"></asp:Label>
    <br /><br />
    <asp:GridView ID="gvSP" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" Width="100%" ShowFooter="True" OnRowCancelingEdit="gvSP_RowCancelingEdit" OnRowDeleting="gvSP_RowDeleting" OnRowEditing="gvSP_RowEditing" OnRowUpdating="gvSP_RowUpdating" AllowPaging="True" OnPageIndexChanging="gvSP_PageIndexChanging" PageSize="3" OnSelectedIndexChanged="gvSP_SelectedIndexChanged" style="margin-left: 0px; margin-right: 0px">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:TemplateField HeaderText="Số Khung">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("SoKhung") %>'></asp:Label>
                </ItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="txtSoKhung" placeholder="Số khung" runat="server" Width="65px"></asp:TextBox>
                    <br />
                    <asp:Label ID="lbSokhung"  style="color:red" runat="server" ></asp:Label>
                </FooterTemplate>
          <ItemStyle HorizontalAlign="Right" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Loại Xe">
                <EditItemTemplate>
                    <asp:DropDownList ID="drLoaiXe" runat="server"></asp:DropDownList>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("TenLoai") %>'></asp:Label>
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                <FooterTemplate>
                    <asp:DropDownList ID="drLoai" runat="server"></asp:DropDownList>
                    <br />
                    <asp:Label ID="lbLoai" runat="server" style="color:red"></asp:Label>
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Dòng Xe">
                <EditItemTemplate>
                    <asp:DropDownList ID="drHSX" runat="server" DataTextField="TenDX" DataValueField="MaDX"></asp:DropDownList>
                   
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("TenDX") %>'></asp:Label>
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                <FooterTemplate>
                   <asp:DropDownList ID="drHangSX" runat="server"></asp:DropDownList>
                    <asp:Label ID="lbHSX" runat="server" style="color:red"></asp:Label>
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Tên Xe">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("TenXe") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("TenXe") %>'></asp:Label>
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                <FooterTemplate>
                    <asp:TextBox ID="txtTen" placeholder="Nhập tên xe" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="lbTen"  style="color:red" runat="server" ></asp:Label>
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Giá Bán">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("DonGia") %>' Height="17px" Width="75px"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label5" runat="server" Text='<%# Bind("DonGia","{0:0,000}") %>'></asp:Label>
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Right"/>
                 <FooterTemplate>
                    <asp:TextBox ID="txtGia" placeholder="Nhập giá xe" runat="server" Width="75px"></asp:TextBox>
                     <br />
                    <asp:Label ID="lbGia" style="color:red" runat="server" ></asp:Label>
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Số Lượng">
       
                <ItemTemplate>
                    <asp:Label ID="Label6" runat="server" Text='<%# Bind("SL") %>'></asp:Label>
                </ItemTemplate>
              <ItemStyle HorizontalAlign="Right" />
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Màu Xe">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox7" runat="server" Text='<%# Bind("MauXe") %>' Width="65px"></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label7" runat="server" Text='<%# Bind("MauXe") %>'></asp:Label>
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                 <FooterTemplate>
                    <asp:TextBox ID="txtMauXe" placeholder="Nhập màu xe" runat="server" Width="65px"></asp:TextBox>
                     <br />
                     <asp:Label ID="lbMau" style="color:red" runat="server" ></asp:Label>
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Ảnh">
                <ItemTemplate>
                 <asp:Image runat="server" Width="100" Height="120"
                  ImageUrl ='<%# Eval("Anh","~/Images/{0}") %>' />
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                 <FooterTemplate>
                     <asp:FileUpload ID="fUpLoad" runat="server" Width="143px" />
                           <br />
                     <asp:Label ID="lbAnh" runat="server" style="color:red"></asp:Label>
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Mô Tả">
                <EditItemTemplate>
                    <asp:TextBox ID="TextBox11" TextMode="MultiLine" runat="server" Text='<%# Bind("Mota") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label11" runat="server" Text='<%# Bind("Mota") %>'></asp:Label>
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                 <FooterTemplate>
                    <asp:TextBox ID="txtMoTa" placeholder="Nhập mô tả" TextMode="MultiLine" runat="server"></asp:TextBox>
                     <br />
                     <asp:Label ID="lbMoTa" runat="server" style="color:red"></asp:Label>
                </FooterTemplate>
            </asp:TemplateField>
            <asp:TemplateField ShowHeader="False" HeaderText="Cập Nhật">
                <EditItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Update" Text="Cập Nhật"></asp:LinkButton>
                    &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel" Text="Hủy Bỏ"></asp:LinkButton>
                </EditItemTemplate>
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
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
        <RowStyle BackColor="#F7F7DE" Wrap="True" />
        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FBFBF2" />
        <SortedAscendingHeaderStyle BackColor="#848384" />
        <SortedDescendingCellStyle BackColor="#EAEAD3" />
        <SortedDescendingHeaderStyle BackColor="#575357" />
    </asp:GridView>

</asp:Content>
