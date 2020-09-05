<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="2_Product.aspx.cs" Inherits="Lab6.Product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body{
            margin-left:40%;
            margin-top:10%;
        }
    </style>
</head> 
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            <br />
            Select Items :
            <br />
            <br />
            <asp:ListBox ID="ListBox1" runat="server" Height="150px" Width="200px"  SelectionMode="Multiple" ></asp:ListBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Place Order" OnClick="Button1_Click" />
            <br />
            <br />

            <asp:Label ID="Err_Label" runat="server" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
