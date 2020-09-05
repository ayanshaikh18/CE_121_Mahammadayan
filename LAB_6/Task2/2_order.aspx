<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="2_order.aspx.cs" Inherits="Lab6.order" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        form{
            margin-left:30%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Your Order Details : </h3>
            <asp:Table ID="myTable" runat="server" Width="50%" BorderColor="Black" BorderWidth="2px">
                <asp:TableHeaderRow BorderStyle="Solid" BorderColor="Black" BorderWidth="2px">
                    <asp:TableHeaderCell HorizontalAlign="Justify">Name of Item</asp:TableHeaderCell>
                    <asp:TableHeaderCell HorizontalAlign="Justify">Prize</asp:TableHeaderCell>
                </asp:TableHeaderRow>
            </asp:Table>
            <br />
            <asp:Label ID="Total" runat="server" Text="Total Price :- "></asp:Label>
            <br />
            <asp:Label ID="Err_Label" runat="server" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
