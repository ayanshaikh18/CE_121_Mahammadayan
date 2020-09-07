<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="4_show.aspx.cs" Inherits="Lab7._4_show" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
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
&nbsp;<asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/4_delete.aspx">Delete</asp:HyperLink>
            </h3>
            <h3>All Records : </h3>
            <br />

            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="sid" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                    <asp:BoundField DataField="sid" HeaderText="sid" ReadOnly="True" SortExpression="sid" />
                    <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                    <asp:BoundField DataField="sem" HeaderText="sem" SortExpression="sem" />
                    <asp:BoundField DataField="cpi" HeaderText="cpi" SortExpression="cpi" />
                    <asp:BoundField DataField="contactno" HeaderText="contactno" SortExpression="contactno" />
                    <asp:BoundField DataField="emailid" HeaderText="emailid" SortExpression="emailid" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM [Student] WHERE [sid] = @sid" InsertCommand="INSERT INTO [Student] ([sid], [name], [sem], [cpi], [contactno], [emailid]) VALUES (@sid, @name, @sem, @cpi, @contactno, @emailid)" SelectCommand="SELECT * FROM [Student]" UpdateCommand="UPDATE [Student] SET [name] = @name, [sem] = @sem, [cpi] = @cpi, [contactno] = @contactno, [emailid] = @emailid WHERE [sid] = @sid">
                <DeleteParameters>
                    <asp:Parameter Name="sid" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="sid" Type="Int32" />
                    <asp:Parameter Name="name" Type="String" />
                    <asp:Parameter Name="sem" Type="Int32" />
                    <asp:Parameter Name="cpi" Type="Double" />
                    <asp:Parameter Name="contactno" Type="String" />
                    <asp:Parameter Name="emailid" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="name" Type="String" />
                    <asp:Parameter Name="sem" Type="Int32" />
                    <asp:Parameter Name="cpi" Type="Double" />
                    <asp:Parameter Name="contactno" Type="String" />
                    <asp:Parameter Name="emailid" Type="String" />
                    <asp:Parameter Name="sid" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
            <br />
            <br />
            <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="sid" DataSourceID="SqlDataSource2" Height="50px" Width="125px">
                <Fields>
                    <asp:BoundField DataField="sid" HeaderText="sid" ReadOnly="True" SortExpression="sid" />
                    <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                    <asp:BoundField DataField="sem" HeaderText="sem" SortExpression="sem" />
                    <asp:BoundField DataField="cpi" HeaderText="cpi" SortExpression="cpi" />
                    <asp:BoundField DataField="contactno" HeaderText="contactno" SortExpression="contactno" />
                    <asp:BoundField DataField="emailid" HeaderText="emailid" SortExpression="emailid" />
                </Fields>
            </asp:DetailsView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Student] WHERE ([sid] = @sid)">
                <SelectParameters>
                    <asp:ControlParameter ControlID="GridView1" Name="sid" PropertyName="SelectedValue" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>

        </div>
    </form>
</body>
</html>
