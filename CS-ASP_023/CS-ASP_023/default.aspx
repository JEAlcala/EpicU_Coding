﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="CS_ASP_023._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Hours worked on Project:&nbsp;
        <asp:TextBox ID="hoursTextBox" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="addHoursButton" runat="server" OnClick="addHoursButton_Click" Text="Add Hours" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
