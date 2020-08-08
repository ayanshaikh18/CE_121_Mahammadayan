<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="1_CookieDemo2.aspx.cs" Inherits="Lab_5.CookieDemo2" %>

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
        <h3 style="color:blue">
            Retived data that we stored in Cookie on previous page :-
        </h3>
        <h4>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label></h4>
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Get Cookie" OnClick="Button1_Click" /></td>
                        <td><asp:Button ID="Button2" runat="server" Text="Delete Cookie" OnClick="Button2_Click" /></td>
                </tr>
                <tr>
                    <td>Name :- </td>
                    <td>
                        <asp:Label ID="Name" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Email :-</td>
                    <td>
                        <asp:Label ID="Email" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Phone Number :- </td>
                    <td>
                        <asp:Label ID="Phone" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>City :-</td>
                    <td>
                        <asp:Label ID="City" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Branch :-</td>
                    <td>
                        <asp:Label ID="Branch" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Year :- </td>
                    <td>

                        <asp:Label ID="Year" runat="server" Text=""></asp:Label>

                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
