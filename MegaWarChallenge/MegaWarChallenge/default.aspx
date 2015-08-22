<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="MegaWarChallenge._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        PLAY WAR!!<br />
        <br />
        <asp:Button ID="playButton" runat="server" OnClick="playButton_Click" Text="PLAY" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server" Text="Label"></asp:Label>
        <br />
    
    </div>
    </form>
</body>
</html>
