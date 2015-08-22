<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ChallengeEpicSpiesAssignment._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>
            <asp:Image ID="Image1" runat="server" Height="190px" ImageUrl="~/epic-spies-logo.jpg" Width="145px" />
            <br />
            <br />
            Spy New Assignment Form</h1>
        <p>
            Spy Code Name :
            <asp:TextBox ID="spyCodeTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            New Assignment Name :
            <asp:TextBox ID="newAssignmentTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            End Date of Previous Assignment :
        </p>
        <p>
            <asp:Calendar ID="previousAssignmentDateCalendar" runat="server"></asp:Calendar>
        </p>
        <p>
            Start Date of New Assignment:</p>
        <p>
            <asp:Calendar ID="startDateCalendar" runat="server"></asp:Calendar>
        </p>
        <p>
            &nbsp;Projected End Date of New Assignment:</p>
        <p>
            <asp:Calendar ID="projectedEndCalendar" runat="server"></asp:Calendar>
        </p>
        <p>
            <asp:Button ID="assignSpyButton" runat="server" Text="Assign Spy" OnClick="assignSpyButton_Click" />
        </p>
        <p>
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    
    </div>
    </form>
</body>
</html>
