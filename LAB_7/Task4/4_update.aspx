<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="4_update.aspx.cs" Inherits="Lab7._4_update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
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
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/4_insert.aspx">Insert</asp:HyperLink>
&nbsp;
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/4_delete.aspx">Delete</asp:HyperLink>
&nbsp;<asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/4_show.aspx">Show</asp:HyperLink>
            </h3>
            <h3>Update Record : </h3>
            <br />
            <table>
                <tr>
                    <td>Enter SID : </td>
                    <td>
                        <asp:TextBox ID="Sid" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="text-align:center">
                        <asp:Button ID="Button1" runat="server" Text="Fetch Record" OnClick="Button1_Click" />
                        <br />
                        <br />
                        <asp:Label ID="Err_Label" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
            </table>
            <br /><br />
            <asp:Panel ID="Panel1" runat="server" Visible="false">
                <table>
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
                                <asp:ListItem Text="3" Value="3">3</asp:ListItem>
                                <asp:ListItem Text="5" Value="5">5</asp:ListItem>
                                <asp:ListItem Text="7" Value="7">7</asp:ListItem>
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
                            <asp:Button ID="Button2" runat="server" Text="Update" OnClick="Button2_Click" />
                            <br />
                            <br />
                            <asp:Label ID="Label1" runat="server" ForeColor="Green"></asp:Label>
                        </td>
                    </tr>
                </table>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
