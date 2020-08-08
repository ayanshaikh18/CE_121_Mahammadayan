<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="2_Login.aspx.cs" Inherits="Lab_5.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        td{
            padding:7px;
        }
        form{
            margin-left:30%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Login</h1>
        <br /><br />
        <table>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Enter Username : "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="Username" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Enter password : "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="Password" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td><asp:Button ID="Submit" runat="server" Text="Login" style="height: 26px" OnClick="Submit_Click" /></td>
            </tr>
            <tr>
                <td><asp:Label ID="Label3" runat="server" Text="" ForeColor="red"></asp:Label></td>
            </tr>
        </table>
    </form>
</body>
</html>
