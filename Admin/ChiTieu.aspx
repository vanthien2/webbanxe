<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.Master" AutoEventWireup="true" CodeBehind="ChiTieu.aspx.cs" Inherits="MinKi.Admin.ChiTieu" %>
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
            width: 69%;
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
            <span class="style2">THỐNG KÊ NHẬP HÀNG</span>
        </center>
        <hr width="70%" />
    </div>
    <br />
    <div>
        <table cellpadding="0" cellspacing="0" class="style3" align="center">
            <tr>
                <td class="style4">
                            <asp:RadioButtonList ID="rdoTK" runat="server" >
                                <asp:ListItem>Theo ngày</asp:ListItem>
                                <asp:ListItem>Theo khoảng thời gian</asp:ListItem>
                                <asp:ListItem>Theo năm</asp:ListItem>
                            </asp:RadioButtonList>
                </td>
                <td>
                    <asp:TextBox ID="txtNgay" runat="server" Width="100px"></asp:TextBox>
                    <br />
                    <asp:TextBox ID="txtTungay" runat="server" Width="100px"></asp:TextBox>
        
                    &nbsp;&gt;&gt;
                    <asp:TextBox ID="txtDenngay" runat="server" Width="100px"></asp:TextBox>
                    <asp:Button ID="btnThongke" runat="server" Text="Thống kê" OnClick="btnThongke_Click" />
&nbsp;&nbsp;
                         <asp:Label ID="Label2" runat="server" style="color:blue" Text="Tổng Tiền Nhập:"></asp:Label>&nbsp;
        <asp:Label ID="Label1" runat="server" style="font-weight: 700; color:red;"></asp:Label>
                    <br />
                    <asp:DropDownList ID="drNam" runat="server" Width="104px">
                        <asp:ListItem>2014</asp:ListItem>
                           <asp:ListItem>2015</asp:ListItem>
                           <asp:ListItem>2016</asp:ListItem>
                           <asp:ListItem>2017</asp:ListItem>
                           <asp:ListItem>2018</asp:ListItem>
                           <asp:ListItem>2019</asp:ListItem>
                           <asp:ListItem>2020</asp:ListItem>
                    </asp:DropDownList>
                 
                </td>
                
            </tr>
        </table>
    </div>
    <br />
    <div>
    <center>
<asp:GridView ID="gvPN" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" OnPageIndexChanging="GridView1_PageIndexChanging" Width="100%">
    <AlternatingRowStyle BackColor="White" />
    <Columns>
        <asp:BoundField DataField="MaPN" HeaderText="Mã" />
        <asp:BoundField DataField="TenTK" HeaderText="Nhân Viên" />
        <asp:BoundField DataField="NgayTao" HeaderText="Ngày Tạo" DataFormatString="{0:dd/MM/yyyy}" />
        <asp:BoundField DataField="TongTien" HeaderText="Tổng Tiền" ReadOnly="true" />
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
