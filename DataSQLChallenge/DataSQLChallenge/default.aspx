<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="DataSQLChallenge._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        State Search:
        <asp:TextBox ID="stateSearchTextBox" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="stateSearchButton" runat="server" Text="Search" OnClick="stateSearchButton_Click" />
    
        <br />
        <br />
        <asp:Label ID="stateSearchResultLabel" runat="server"></asp:Label>
        <br />
    
    
    </div>
    </form>
</body>
</html>
