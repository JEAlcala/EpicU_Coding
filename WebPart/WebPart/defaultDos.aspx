<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="defaultDos.aspx.cs" Inherits="WebPart.defaultDos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Balloon Color:
        <asp:TextBox ID="balloonColorTextBox" runat="server"></asp:TextBox>
        <br />
        Amount Air:
        <asp:TextBox ID="amountAirTextBox" runat="server"></asp:TextBox>
&nbsp;<br />
        <br />
        <asp:Button ID="saveButton" runat="server" Text="SAVE" />
&nbsp;<asp:Button ID="refreshButton" runat="server" Text="REFRESH" />
    
    </div>
    </form>
</body>
</html>
