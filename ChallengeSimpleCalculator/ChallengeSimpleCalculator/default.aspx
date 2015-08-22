<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ChallengeSimpleCalculator._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            font-family: Arial, Helvetica, sans-serif;
            font-size: small;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Simple Calculator</h1>
        <p>
            <span class="auto-style2">First Value</span>&nbsp;
            <asp:TextBox ID="firstNumberTextBox" runat="server" OnTextChanged="firstNumber_TextBox"></asp:TextBox>
        </p>
        <p>
            <span class="auto-style2">Second Value</span>&nbsp;
            <asp:TextBox ID="secondNumberTextBox" runat="server" OnTextChanged="secondNumber_TextBox"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="addition" runat="server" OnClick="addButton_Click" Text="+" />
&nbsp;
            <asp:Button ID="Subtraction" runat="server" OnClick="subButton_Click" Text="-" Width="22px" />
&nbsp;
            <asp:Button ID="Multiply" runat="server" OnClick="multiplyButton_Click" Text="*" />
&nbsp;&nbsp;
            <asp:Button ID="Divide" runat="server" OnClick="divideButton_Click" style="color: #666666" Text="/" />
        </p>
        <p style="font-size: x-large">
            <asp:Label ID="resultLabel" runat="server" style="font-weight: 700; background-color: #0099FF"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    
    </div>
    </form>
</body>
</html>
