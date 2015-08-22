<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebForm._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Make
    
        <asp:Label ID="makeLabel" runat="server"></asp:Label>
        <br />
        <br />
        Model
        <asp:Label ID="modelLabel" runat="server"></asp:Label>
        <br />
        <br />
        Year
        <asp:Label ID="yearLabel" runat="server"></asp:Label>
        <br />
        <br />
        Color
        <asp:Label ID="colorLabel" runat="server"></asp:Label>
        <br />
        <br />
        Bid
        <asp:TextBox ID="bidTextBox" runat="server" OnTextChanged="bidTextBox_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="saveButton" runat="server" Text="SAVE" OnClick="saveButton_Click" />
&nbsp;
        <asp:Button ID="refreshButton" runat="server" OnClick="refreshButton_Click" style="height: 26px" Text="REFRESH" />
    
    </div>
    </form>
</body>
</html>
