<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="CS_ASP_022._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        From:<br />
        <br />
        <asp:RadioButton ID="fromChicagoRadioButton" runat="server" Text="Chicago" />
        <br />
        <asp:RadioButton ID="fromNewYorkRadioButton" runat="server" Text="New York" />
        <br />
        <asp:RadioButton ID="fromLondonRadioButton" runat="server" Text="London" />
        <br />
        <br />
        To:<br />
        <br />
        <asp:RadioButton ID="toChicagoRadioButton" runat="server" Text="Chicago" />
        <br />
        <asp:RadioButton ID="toNewYorkRadioButton" runat="server" Text="New York" />
        <br />
        <asp:RadioButton ID="toLondonRadioButton" runat="server" Text="London" />
        <br />
        <br />
        <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="OK" />
        <br />
        <br />
&nbsp;Ticket Price:
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
