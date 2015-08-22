<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="DateDeciderDatingApp._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Date Decider</h1>
        <br />
        <br />
        I am a <asp:CheckBox ID="manCheckBox" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Man" />
&nbsp;<asp:CheckBox ID="womanCheckBox" runat="server" Text="Woman" />
        <br />
        <br />
        I am <asp:TextBox ID="ageTextBox" runat="server"></asp:TextBox>
&nbsp;years old<br />
        <br />
        I am available for a date between:<br />
        <asp:Calendar ID="startCalendar" runat="server"></asp:Calendar>
        <br />
        <asp:Calendar ID="endCalendar" runat="server"></asp:Calendar>
        <br />
        I am seeking a
        <asp:CheckBox ID="seekingManCheckBox" runat="server" Text="Man" />
&nbsp;<asp:CheckBox ID="seekingWomenCheckBox" runat="server" Text="Women" />
        <br />
        who is between
        <asp:TextBox ID="dateMinTextBox" runat="server"></asp:TextBox>
&nbsp;and
        <asp:TextBox ID="dateMaxTextBox" runat="server"></asp:TextBox>
&nbsp;years old.<br />
        <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
