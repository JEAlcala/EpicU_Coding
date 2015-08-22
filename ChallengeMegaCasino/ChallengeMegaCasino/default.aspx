<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ChallengeMegaCasino._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Image ID="Image1" runat="server" Height="155px" Width="152px" />
&nbsp;&nbsp;
        <asp:Image ID="Image2" runat="server" Height="155px" style="margin-left: 0px; margin-right: 0px" Width="152px" />
&nbsp;&nbsp;
        <asp:Image ID="Image3" runat="server" Height="155px" Width="152px" />
        <br />
        <br />
        Your Bet : <asp:TextBox ID="yourBetTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="leverButton" runat="server" OnClick="leverButton_Click" Text="Pull The Lever!" Width="174px" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
        <asp:Label ID="imgLabel" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="moneyLabel" runat="server"></asp:Label>
        <br />
        <br />
        1 Cherry - x2 Your Bet<br />
        2 Cherries - x3 Your Bet<br />
        3 Cherries - x4 Your Bet<br />
        3 7&#39;s - Jackpot - x100 Your Bet<br />
        HOWEVER ... if there&#39;s even one BAR you win nothing<br />
    </form>
</body>
</html>
