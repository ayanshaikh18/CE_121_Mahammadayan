<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="2_Login.aspx.cs" Inherits="Lab6.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        td{
            padding:10px;
        }
        body{
            margin-left:35%;
            margin-top:10%;
        }
        header{
            color:blue;
            font-size:35px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <header>
                Login
            </header>
            <br />

            <table>
                <tr>
                    <td>Enter Userid : </td>
                    <td>
                        <asp:TextBox ID="Username" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Enter Password : </td>
                    <td>
                        <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="text-align:center">
                        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
                    </td>
                </tr><tr>
                    <td colspan="2" style="text-align:center">
                        
                        <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
                        
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
