<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Challenge_Conditional_Radio_Button._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Constantia;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1><span class="auto-style1">Your Note Taking Preferences</span></h1>
        <br />
        <br />
        <asp:RadioButton ID="pencilRadioButton" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Pencil" GroupName="Selection" />
        <br />
        <asp:RadioButton ID="penRadioButton" runat="server" Text="Pen" GroupName="Selection" />
        <br />
        <asp:RadioButton ID="phoneRadioButton" runat="server" Text="Phone" GroupName="Selection" />
        <br />
        <asp:RadioButton ID="tabletRadioButton" runat="server" Text="Tablet" GroupName="Selection" OnCheckedChanged="tabletRadioButton_CheckedChanged" />
        <br />
        <br />
        <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="OK" />
        <br />
        <br />
        <asp:Image ID="resultImage" runat="server" Height="29px" Width="25px" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
