<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Image.aspx.cs" Inherits="Lab4.Image" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body{
            text-align:center;
            margin-top:10%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Click to see image" />
            <br />
            <br />
            <asp:Image ID="Image1"  ImageUrl="~/image.png" runat="server" Height="300px" Width="300px" Visible="False" />
            <br />
            <asp:HiddenField ID="HiddenField1" runat="server" Value="0" />
            <br />
        </div>
    </form>
</body>
</html>
