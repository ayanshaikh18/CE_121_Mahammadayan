<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="1_Edit.aspx.cs" Inherits="Lab6.Edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        td{
            padding:8px;
        }
        body{
            margin-left:30%;
        }
        header{
            color:blue;
            font-size:20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:HyperLink ID="HyperLink1"  runat="server" NavigateUrl="~/1_Insert.aspx">Insert</asp:HyperLink>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/1_Delete.aspx">Delete</asp:HyperLink>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:HyperLink ID="Hyperlink3" runat="server" NavigateUrl="~/1_Show.aspx">Show</asp:HyperLink>
        <br />
        <br />
        <header>
            Data Of Students : 
        </header>
        <br />
        <div>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
        </div>
        <div>
            <table>
                <tr>
                    <td>Enter Id : </td>
                    <td>

                        <asp:TextBox ID="Id" runat="server"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="text-align:center">
                        <asp:Button ID="Fetch" runat="server" Text="Fetch" OnClick="Fetch_Click" />
                    </td>
                </tr>
            </table>
        </div>
        <asp:Panel ID="Panel1" runat="server">
            <header>
                Update Record: 
            </header>
        
            <table>
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
                        <asp:Button ID="Submit" runat="server" Text="Update" OnClick="Submit_Click" />
                       
                    </td>
                </tr>
            </table>
        </asp:Panel>
         <asp:Label ID="Err_Label" runat="server" ForeColor="Red"></asp:Label>
    </form>
</body>
</html>
