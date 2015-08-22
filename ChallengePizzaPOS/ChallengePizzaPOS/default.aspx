<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ChallengePizzaPOS._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            font-family: "Buxton Sketch";
        }
        .auto-style3 {
            font-family: "Buxton Sketch";
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1 class="auto-style3">DALLAS PIZZA PIE CO.</h1>
        <h2><span class="auto-style2">Customer Name</span><asp:TextBox ID="customerNameTextBox" runat="server" OnTextChanged="TextBox1_TextChanged" style="margin-left: 21px"></asp:TextBox>
        </h2>
        <h3><span class="auto-style2">Number of Pizzas $9.99</span>
            <asp:TextBox ID="numberTextBox" runat="server" OnTextChanged="TextBox1_TextChanged3"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp; </h3>
        <h4 class="auto-style3">Ingredients</h4>
        <h4><span class="auto-style2">Ricotta Cheese $1.50</span>
            <asp:CheckBox ID="ricottaCheckBox" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" style="font-family: 'buxton Sketch'" />
&nbsp; </h4>
        <h4 style="font-family: 'buxton Sketch'">Pepperoni $2.04
            <asp:CheckBox ID="pepperoniCheckBox" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged1" />
        </h4>
        <h3 style="font-family: 'buxton Sketch'">Spinach $1.00
            <asp:CheckBox ID="spinachCheckBox" runat="server" OnCheckedChanged="spinachCheckBox_CheckedChanged" />
        </h3>
        <h3 style="font-family: 'buxton Sketch'">Extra Cheese $1.05
            <asp:CheckBox ID="extraCheckBox" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged3" />
        </h3>
        <p style="font-family: 'buxton Sketch'">
            <asp:Button ID="totalButton" runat="server" OnClick="totalButton_Click" Text="Total" />
        </p>
        <p style="font-family: 'buxton Sketch'">
            <asp:Label ID="totalLabel" runat="server"></asp:Label>
        </p>
        <p style="font-family: 'buxton Sketch'">
            &nbsp;</p>
        <p style="font-family: 'buxton Sketch'">
            \</p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</p>
        <p>
            &nbsp;</p>
        <br />
        <br />
    </form>
</body>
</html>
