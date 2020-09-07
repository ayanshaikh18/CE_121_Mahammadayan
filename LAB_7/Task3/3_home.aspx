<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="3_home.aspx.cs" Inherits="Lab7._2_home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        form{
            margin-left:30%;
            margin-top:10%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter ID : <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Button ID="Button1" runat="server" Text="Fetch Record" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/3_allproduct.aspx">View All Products</asp:HyperLink>
        </div>
    </form>
</body>
</html>
