<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="4_insert.aspx.cs" Inherits="Lab7._4_insert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 128px;
        }
        td{
            padding:10px;
        }
        form{
            margin-left:30%
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <h3>
&nbsp;
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/4_update.aspx">Update</asp:HyperLink>
&nbsp;<asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/4_delete.aspx">Delete</asp:HyperLink>
&nbsp; <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/4_show.aspx">Show</asp:HyperLink>
            &nbsp;
            </h3>
            <h3>Insert Record : </h3>
            <br />
            <table>
                <tr>
                    <td>Enter Sid : </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="Sid" TextMode="Number" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Enter Name : </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="Name" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Enter Sem : </td>
                    <td class="auto-style1">
                        <asp:DropDownList ID="Sem" runat="server">
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                            <asp:ListItem>7</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Enter Cpi : </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="Cpi" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Enter Contact Number : </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="ContactNo" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Enter Email-Id : </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="Email" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="text-align:center">
                        <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Button1_Click" />
                        <br />
                        <br />
                        <asp:Label ID="Label1" runat="server" ForeColor="Green"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
