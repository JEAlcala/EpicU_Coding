<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="TetsingGround._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="myTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="mySecondTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="OKButton" runat="server" OnClick="OKButton_Click" Text="OK" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
