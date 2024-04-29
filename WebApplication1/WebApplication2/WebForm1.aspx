<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="z-index: 1; left: 0px; top: 0px; position: absolute; height: 44px; width: 1512px">
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 201px; top: 70px; position: absolute"></asp:TextBox>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 109px; top: 70px; position: absolute" Text="Firstname"></asp:Label>
        <div>
            <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 198px; top: 136px; position: absolute"></asp:TextBox>
        </div>
           <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 108px; top: 135px; position: absolute" Text="Lastname"></asp:Label>
        <div>
            <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 198px; top: 191px; position: absolute"></asp:TextBox>
        </div>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 127px; top: 194px; position: absolute" Text="Age"></asp:Label>
        
        
        <p>
            &nbsp;</p>
        <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 245px; top: 267px; position: absolute" Text="Insert" />
    </form>
</body>
</html>
