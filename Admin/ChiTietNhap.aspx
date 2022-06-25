<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.Master" AutoEventWireup="true" CodeBehind="ChiTietNhap.aspx.cs" Inherits="MinKi.Admin.ChiTietNhap" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="headAd">Quản Lý Chi Tiết Phiếu Nhập</div>
        <div class="ctpn" style="float:left">
            <table style="width: 300px; border:1px solid #ffd800;margin-left:5px" >
            <tr style="border:1px solid #ffd800"><th colspan="2">Thông tin chi tiết phiếu nhập</th></tr>
           <tr style="border:1px solid #ffd800"><td><asp:Label runat="server" Text="Mã phiếu nhập:" Width="110"></asp:Label></td><td><asp:Label style="color:red" runat="server" ID="lbMaPN"></asp:Label></td></tr>
      <tr style="border:1px solid #ffd800"><td><asp:Label runat="server" Text="Tên xe:" Width="110"></asp:Label></td>
                <td><asp:DropDownList runat="server" ID="drXe"  Width="175px"></asp:DropDownList>&nbsp;</td></tr>
               <tr style="border:1px solid #ffd800"> <td><asp:Label runat="server" Text="Đơn giá:" Width="110"></asp:Label></td><td><asp:TextBox runat="server" ID="txtDG"></asp:TextBox></td></tr>
            <tr style="border:1px solid #ffd800"><td><asp:Label runat="server" Text="Số Lượng:"></asp:Label></td><td><asp:DropDownList runat="server" ID="drSL">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
                <asp:ListItem>9</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
                <asp:ListItem>11</asp:ListItem>
                <asp:ListItem>12</asp:ListItem>
                <asp:ListItem>13</asp:ListItem>
                <asp:ListItem>14</asp:ListItem>
                <asp:ListItem>15</asp:ListItem>
                <asp:ListItem>16</asp:ListItem>
                <asp:ListItem>17</asp:ListItem>
                <asp:ListItem>18</asp:ListItem>
                <asp:ListItem>19</asp:ListItem>
                <asp:ListItem>20</asp:ListItem>
                <asp:ListItem>21</asp:ListItem>
                <asp:ListItem>22</asp:ListItem>
                <asp:ListItem>23</asp:ListItem>
                <asp:ListItem>24</asp:ListItem>
                <asp:ListItem>25</asp:ListItem>
                <asp:ListItem>26</asp:ListItem>
                <asp:ListItem>27</asp:ListItem>
                <asp:ListItem>28</asp:ListItem>
                <asp:ListItem>29</asp:ListItem>
                <asp:ListItem>30</asp:ListItem>
                <asp:ListItem>31</asp:ListItem>
                <asp:ListItem>32</asp:ListItem>
                <asp:ListItem>33</asp:ListItem>
                <asp:ListItem>34</asp:ListItem>
                <asp:ListItem>35</asp:ListItem>
                <asp:ListItem>36</asp:ListItem>
                <asp:ListItem>37</asp:ListItem>
                <asp:ListItem>38</asp:ListItem>
                <asp:ListItem>39</asp:ListItem>
                <asp:ListItem>40</asp:ListItem>
                <asp:ListItem>41</asp:ListItem>
                <asp:ListItem>42</asp:ListItem>
                <asp:ListItem>43</asp:ListItem>
                <asp:ListItem>44</asp:ListItem>
                <asp:ListItem>45</asp:ListItem>
                <asp:ListItem>46</asp:ListItem>
                <asp:ListItem>47</asp:ListItem>
                <asp:ListItem>48</asp:ListItem>
                <asp:ListItem>49</asp:ListItem>
                <asp:ListItem>50</asp:ListItem>
              
                </asp:DropDownList></td>
            </tr>
                <tr style="border:1px solid #ffd800"><td colspan="2"><asp:Label runat="server" Text="Số Sản Phẩm:" Width="110"></asp:Label><asp:Label ID="lbSP" style="color:red;" runat="server"></asp:Label></td></tr>
                <tr style="border:1px solid #ffd800"><td colspan="2"> <asp:Label runat="server" Text="Tổng Tiền:" Width="110"></asp:Label><asp:Label style="color:red;" ID="lbTong" runat="server"></asp:Label></td></tr>
            <tr style="border:1px solid #ffd800"><th colspan="2"><asp:Button runat="server" ID="btnThem" Text="Thêm" OnClick="btnThem_Click"></asp:Button></th></tr>
        </table>
           </div>
    <br />
 

    <br />
    <div style="float:left;width: 750px;margin-left: 26px; margin-right: 26px;">
        <div style="text-align:center; font-family:'Times New Roman';font-size:20px;color:#ffd800">Danh Sách Chi Tiết Phiếu Nhập</div>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" Width="782px" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="Mã">
               
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("MaPN") %>'></asp:Label>
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
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("SL") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("SL") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Đơn Giá">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("DonGia") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("DonGia","{0:0,000}") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="ThanhTien" HeaderText="Thành Tiền(VNĐ)" ReadOnly="true" />
                <asp:TemplateField ShowHeader="False">
                    <EditItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Update" Text="Cập Nhật"></asp:LinkButton>
                        &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel" Text="Hủy Bỏ"></asp:LinkButton>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Edit" Text="Sửa"></asp:LinkButton>
                        &nbsp;<asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" OnClientClick="return confirm ('Bạn có muốn xóa?');" CommandName="Delete" Text="Xóa"></asp:LinkButton>
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
