<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="4_CrossPagePostingDemo2.aspx.cs" Inherits="Lab_5._4_CrossPagePostingDemo2" %>

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
            Demo of Cross Page Posting. We are retriving data of previous page here.
        </h3>
        <div>
            <table>
                <tr>
                    <td>Enter Name :- </td>
                    <td>
                        <asp:Label ID="Name" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Enter Email :-</td>
                    <td>
                        <asp:Label ID="Email" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Enter Phone Number :- </td>
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
            </table>
        </div>
    </form>
</body>
</html>
