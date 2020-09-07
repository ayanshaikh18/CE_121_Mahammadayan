<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="4_delete.aspx.cs" Inherits="Lab7._4_delete" %>
    
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
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/4_update.aspx">Update</asp:HyperLink>
&nbsp;<asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/4_show.aspx">Show</asp:HyperLink>
            </h3>
            <h3>Delete Record : </h3>
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
                            <asp:Button ID="Button1" runat="server" Text="Delete Record" OnClick="Button1_Click" />
                            <br />
                            <br />
                            <asp:Label ID="Err_Label" runat="server" ForeColor="Red"></asp:Label>
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
