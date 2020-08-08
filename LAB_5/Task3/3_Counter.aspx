<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="3_Counter.aspx.cs" Inherits="Lab_5.Counter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" style="margin-left:40%">
        <div>
            <asp:Label ID="count" runat="server" Text="Count : 0"></asp:Label>
            <br /><br />
            <asp:Button ID="Button1" runat="server" Text="Increment Count" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
