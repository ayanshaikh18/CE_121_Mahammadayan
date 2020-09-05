<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="1_Insert.aspx.cs" Inherits="Lab6.Insert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        td{
            padding:10px;
        }
        body{
            margin-left:30%;
            margin-top:10%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td colspan="3">
                        <asp:HyperLink ID="HyperLink4"  runat="server" NavigateUrl="~/1_Edit.aspx">Edit</asp:HyperLink>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/1_Delete.aspx">Delete</asp:HyperLink>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:HyperLink ID="Hyperlink6" runat="server" NavigateUrl="~/1_Show.aspx">Show</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td>Enter Name : </td>
                    <td>
                        <asp:TextBox ID="Name" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Enter Sem :</td>
                    <td>
                        <asp:TextBox ID="Sem" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Enter Mobile Number :</td>
                    <td>
                        <asp:TextBox ID="MobNo" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Enter Email Id : </td>
                    <td>
                        <asp:TextBox ID="EmailId" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="text-align:center">
                        <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" />
                        <br />
                        <br />
                        <asp:Label ID="Label1" runat="server" ForeColor="Green"></asp:Label>
                        <br />
                        <asp:Label ID="Err_Label" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
