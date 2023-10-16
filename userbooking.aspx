<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="userbooking.aspx.cs" Inherits="hotelmanagement.userbooking" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div class="cancel">
    <asp:TextBox ID="search" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" />
    <asp:Button ID="delete" runat="server" Text="Delete" OnClick="delete_Click" />
    <asp:Button ID="showall" runat="server" Text="Show All" OnClick="showall_Click" />
    
    </div>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="BookingId"  ForeColor="#333333" GridLines="None" Height="266px" Width="1404px">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="BookingId" HeaderText="BookingId" InsertVisible="False" ReadOnly="True" SortExpression="BookingId" />
            <asp:BoundField DataField="FullName" HeaderText="FullName" SortExpression="FullName" />
            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
            <asp:BoundField DataField="PhoneNumber" HeaderText="PhoneNumber" SortExpression="PhoneNumber" />
            <asp:BoundField DataField="CheckIn" HeaderText="CheckIn" SortExpression="CheckIn" />
            <asp:BoundField DataField="CheckOut" HeaderText="CheckOut" SortExpression="CheckOut" />
            <asp:BoundField DataField="Rooms" HeaderText="Rooms" SortExpression="Rooms" />
            <asp:BoundField DataField="Guests" HeaderText="Guests" SortExpression="Guests" />
            <asp:BoundField DataField="Cost" HeaderText="Cost" SortExpression="Cost" />
            <asp:BoundField DataField="loginid" HeaderText="loginid" SortExpression="loginid" />
            <asp:BoundField DataField="HotelId" HeaderText="HotelId" SortExpression="HotelId" />
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
</asp:GridView>

    <br />

</asp:Content>
