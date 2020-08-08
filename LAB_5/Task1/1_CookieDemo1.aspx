<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="1_CookieDemo1.aspx.cs" Inherits="Lab_5.CookieDemo1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        form{
            margin-left:30%;
        }
        td{
            padding:7px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h3 style="color:blue">
            Entered Data will be stored as Cookie & will be displayed on another web form.
        </h3>
        <div>
            <table>
                <tr>
                    <td>Enter Name :- </td>
                    <td>

                        <asp:TextBox ID="Name" runat="server"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td>Enter Email :-</td>
                    <td>

                        <asp:TextBox ID="Email" runat="server"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td>Enter Phone Number :- </td>
                    <td>

                        <asp:TextBox ID="Phone" runat="server"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td>Enter Your City :-</td>
                    <td>

                        <asp:TextBox ID="City" runat="server"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td>Select Your Branch :-</td>
                    <td>

                        <asp:DropDownList ID="Branch" runat="server">
                            <asp:ListItem>--Select Branch--</asp:ListItem>
                            <asp:ListItem>CE</asp:ListItem>
                            <asp:ListItem>EC</asp:ListItem>
                            <asp:ListItem>IT</asp:ListItem>
                            <asp:ListItem>MH</asp:ListItem>
                            <asp:ListItem>CH</asp:ListItem>
                            <asp:ListItem>CL</asp:ListItem>
                            <asp:ListItem>IC</asp:ListItem>
                        </asp:DropDownList>

                    </td>
                </tr>
                <tr>
                    <td>Select Year :- </td>
                    <td>

                        <asp:DropDownList ID="Year" runat="server">
                            <asp:ListItem>--Select Year--</asp:ListItem>
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
