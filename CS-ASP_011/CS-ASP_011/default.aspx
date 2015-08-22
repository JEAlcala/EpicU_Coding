<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="CS_ASP_011._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Is
        <asp:TextBox ID="firstTextBox" runat="server"></asp:TextBox>
&nbsp;equal to
        <asp:TextBox ID="secondTextBox" runat="server"></asp:TextBox>
&nbsp;?<br />
        <br />
        <asp:CheckBox ID="coolCheckBox" runat="server" Text="Are You Cool?" />
        <br />
        <br />
        If you could eat one foor for the rest of your life, what would you choose?<br />
        <asp:RadioButton ID="pizzaRadioButton" runat="server" GroupName="FoodGroup" Text="Pizza" />
        <br />
        <asp:RadioButton ID="saladRadioButton" runat="server" GroupName="FoodGroup" OnCheckedChanged="saladRadioButton_CheckedChanged" Text="Salad" />
        <br />
        <asp:RadioButton ID="pbjRadioButton" runat="server" GroupName="FoodGroup" Text="Peanut Butter and Jelly" />
        <br />
        <br />
        <asp:Button ID="okButtonTextBox" runat="server" OnClick="okButtonTextBox_Click" Text="OK" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
