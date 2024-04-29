<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 195px; top: 422px; position: absolute" Text="insert" />
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 218px; top: 178px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 130px; top: 181px; position: absolute" Text="Name"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 132px; top: 249px; position: absolute" Text="email"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 220px; top: 249px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 220px; top: 325px; position: absolute"></asp:TextBox>
        <p>
            <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 120px; top: 329px; position: absolute" Text="mobileno"></asp:Label>
        </p>
        <asp:Button ID="Button2" runat="server" style="z-index: 1; left: 285px; top: 423px; position: absolute" Text="update" OnClick="Button2_Click" />
        <asp:Button ID="Button3" runat="server" style="z-index: 1; left: 391px; top: 423px; position: absolute" Text="delete" OnClick="Button3_Click" />
    </form>
</body>
</html>
