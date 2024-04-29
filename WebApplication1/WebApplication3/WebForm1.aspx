<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 233px; top: 190px; position: absolute" Text="Insert" />
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; top: 89px; position: absolute; left: 188px"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 123px; top: 89px; position: absolute" Text="Name"></asp:Label>
        <p>
            <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 125px; top: 152px; position: absolute" Text="age"></asp:Label>
        </p>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 188px; top: 154px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 472px; top: 86px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 382px; top: 157px; position: absolute" Text="New age"></asp:Label>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 512px; top: 192px; position: absolute" Text="Update" />
        <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 471px; top: 157px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 403px; top: 93px; position: absolute" Text="Name"></asp:Label>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 686px; top: 87px; position: absolute" Text="Name"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server" style="z-index: 1; left: 748px; top: 89px; position: absolute"></asp:TextBox>
        <p>
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" style="z-index: 1; top: 191px; position: absolute; height: 29px; left: 812px" Text="Delete" />
        </p>
    </form>
</body>
</html>
