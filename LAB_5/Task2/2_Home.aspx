<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="2_Home.aspx.cs" Inherits="Lab_5.Home" %>

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
        <h2><asp:Label ID="Welcome" runat="server" Text=""></asp:Label></h2>
        <br /><br />
    
        <table>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Choose Catagory : "></asp:Label>
                </td>
                <td>
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                        <asp:ListItem Selected="True">Electronics</asp:ListItem>
                        <asp:ListItem>Books</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Select Item : "></asp:Label>
                </td>
                <td>

                    <asp:ListBox ID="ListBox1" runat="server" Height="150px" Width="200px" SelectionMode="Multiple" >
                        <asp:ListItem>Pendrive</asp:ListItem>
                        <asp:ListItem>Laptop</asp:ListItem>
                        <asp:ListItem>Smart Phone</asp:ListItem>
                        <asp:ListItem>Keyboard</asp:ListItem>
                        <asp:ListItem>Mouse</asp:ListItem>
                    </asp:ListBox>

                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Place Order" OnClick="Button1_Click" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
