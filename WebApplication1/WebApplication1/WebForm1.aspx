<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="z-index: 1; left: 0px; top: 0px; position: absolute; height: 361px; width: 1037px">
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="customer_id" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="customer_id" HeaderText="customer_id" ReadOnly="True" SortExpression="customer_id" />
                <asp:BoundField DataField="customer_name" HeaderText="customer_name" SortExpression="customer_name" />
                <asp:BoundField DataField="city" HeaderText="city" SortExpression="city" />
                <asp:BoundField DataField="grade" HeaderText="grade" SortExpression="grade" />
                <asp:BoundField DataField="salesman_id" HeaderText="salesman_id" SortExpression="salesman_id" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PracticeConnectionString %>" OnSelecting="SqlDataSource1_Selecting" ProviderName="<%$ ConnectionStrings:PracticeConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [customer]"></asp:SqlDataSource>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:CheckBox ID="CheckBox1" runat="server" style="z-index: 1; left: 191px; top: 324px; position: absolute" />
        <asp:Button ID="Button1" runat="server" OnClick="Visibility" style="z-index: 1; left: 370px; top: 318px; position: absolute; height: 26px" Text="Button" />
    </form>
</body>
</html>
