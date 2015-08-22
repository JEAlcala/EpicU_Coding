<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="CS_ASP_019._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Loan Application Form<br />
        <br />
        Name:
        <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Phone Number: <asp:TextBox ID="phoneNumberTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Social Security Number : <asp:TextBox ID="socialSecurityNumberTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Loan Origination Date:<br />
        <asp:Calendar ID="myCalendar" runat="server"></asp:Calendar>
        <br />
        <asp:Button ID="submitButton" runat="server" OnClick="submitButton_Click" Text="Submit" />
        <br />
        Salary:
        <asp:TextBox ID="salaryTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
