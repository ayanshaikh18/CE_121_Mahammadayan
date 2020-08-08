<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="4_CrossPagePostingDemo.aspx.cs" Inherits="Lab_5._4_CrossPagePostingDemo" %>

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
            Demo of Cross Page Posting.
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
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Submit" PostBackUrl="~/4_CrossPagePostingDemo2.aspx" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
