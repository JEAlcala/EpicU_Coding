<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ChallengeEpicSpiesAssetTracker._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 155px;
            height: 190px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <img class="auto-style1" src="epic-spies-logo.jpg" /><br />
        <br />
        <h1>Asset Performance Tracker</h1>
        <p>
            Asset Name:
            <asp:TextBox ID="assetNameTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            Elections Rigged:
            <asp:TextBox ID="electionsRiggedTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            Acts of Subterfuge Performed:
            <asp:TextBox ID="actsTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="addAssetButton" runat="server" OnClick="addAssetButton_Click" Text="Add Asset" />
        </p>
        <p>
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
    
    </div>
    </form>
</body>
</html>
