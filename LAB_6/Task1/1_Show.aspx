<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="1_Show.aspx.cs" Inherits="Lab6.Show" %>

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
        header{
            color:blue;
            font-size:20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/1_Insert.aspx">Insert</asp:HyperLink>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:HyperLink ID="HyperLink1"  runat="server" NavigateUrl="~/1_Edit.aspx">Edit</asp:HyperLink>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/1_Delete.aspx">Delete</asp:HyperLink>
        <br />
        <br />
        <header>Data Of Students :</header>
        <br />
        <br />
        <div>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />

            <br />
            <asp:Label ID="Err_Label1" runat="server" ForeColor="Red"></asp:Label>

        </div>
    </form>
</body>
</html>
