<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_006.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #CC0000;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            background-color: #FFFF66;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Head Line 1</h1>
    
    </div>
        <h2>Head Line 2</h2>
        <h3>Head Line 3</h3>
        <h4>Head Line 4</h4>
        <h5>Head Line 5</h5>
        <h6>Head Line 6</h6>
        <p style="font-family: Arial, Helvetica, sans-serif">
            This is some text that i want to<span class="auto-style1"> apply</span> a style to.</p>
        <p>
            <a href="http://www.google.com">Add a hyperlink </a>
        </p>
        <p>
            <a id="Hyperlink1" href="http://www.facebook.com">This is another hyperlink</a></p>
        <p id="Image1">
            <asp:Image ID="Image1" runat="server" Height="89px" ImageUrl="~/386859-Dollar-1338471757-838-640x480.jpg" style="margin-right: 0px" Width="151px" />
        </p>
        <table class="auto-style2">
            <tr>
                <td>Player</td>
                <td>Year</td>
                <td>Home Runs</td>
            </tr>
            <tr>
                <td>Sammy Sosa</td>
                <td>2005</td>
                <td>100</td>
            </tr>
            <tr>
                <td>Mark MacGuire</td>
                <td>2005</td>
                <td>102<br />
                </td>
            </tr>
        </table>
    </form>
    <ol>
        <li>First Item</li>
        <li>Second Item</li>
        <li>Third Item</li>
    </ol>
    <ul>
        <li class="auto-style3">This is an Idea</li>
        <li class="auto-style3">This is an equally good idea</li>
        <li class="auto-style3">Yet one more idea to consider</li>
    </ul>
</body>
</html>
