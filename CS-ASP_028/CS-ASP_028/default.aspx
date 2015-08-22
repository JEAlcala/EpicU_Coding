<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="CS_ASP_028.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Convert to Cups<br />
        <br />
        <asp:TextBox ID="quantityTextBox" runat="server" AutoPostBack="True" OnTextChanged="quantityTextBox_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:RadioButton ID="fromCupsRadio" runat="server" CausesValidation="True" Text="Cups" OnCheckedChanged="fromCupsRadio_CheckedChanged" />
        <br />
        <asp:RadioButton ID="fromPintsRadio" runat="server" CausesValidation="True" Text="Pints" OnCheckedChanged="fromPintsRadio_CheckedChanged" />
        <br />
        <asp:RadioButton ID="fromQuartsRadio" runat="server" CausesValidation="True" Text="Quarts" OnCheckedChanged="fromQuartsRadio_CheckedChanged" />
        <br />
        <asp:RadioButton ID="fromGallonsRadio" runat="server" CausesValidation="True" Text="Gallons" OnCheckedChanged="fromGallonsRadio_CheckedChanged" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
