<%@ Page Language="C#" AutoEventWireup="true" Async="true" CodeBehind="Home.aspx.cs" Inherits="Lab4.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
        <table style="padding:20px">
        <tr>
            <td>Enter Full Name :</td>
            <td><asp:TextBox ID="FullName" runat="server"></asp:TextBox></td>
            <td>
                <asp:RequiredFieldValidator ID="NameValidator" runat="server" ErrorMessage="Name is Required" ControlToValidate="FullName" ForeColor="Red">Name is Required</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Enter Age :</td>
            <td><asp:TextBox ID="Age" runat="server"></asp:TextBox></td>
            <td>
                <asp:RangeValidator ID="AgeValidator" runat="server" ErrorMessage="Age must be in range 18 to 50" ControlToValidate="Age" MaximumValue="50" MinimumValue="18" ForeColor="Red"></asp:RangeValidator></td>
        </tr>
        <tr>
            <td>Enter Password :</td>
            <td><asp:TextBox ID="Password" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Confirm Password :</td>
            <td><asp:TextBox ID="CPassword" runat="server"></asp:TextBox></td>
            <td>
                <asp:CompareValidator ID="ConfirmPasswordValidator" runat="server" ErrorMessage="Passwords don't match" ControlToCompare="Password" ControlToValidate="CPassword" ForeColor="Red"></asp:CompareValidator></td>
        </tr>
        <tr>
            <td>Gender :&nbsp;</td>
            <td>
                <asp:RadioButtonList ID="Gender" runat="server" AutoPostBack="True">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                    <asp:ListItem>Other</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td>Mobile No :</td>
            <td><asp:TextBox ID="Mobile" runat="server"></asp:TextBox></td>
            <td>
                <asp:RegularExpressionValidator ID="MobileNumberValidator" runat="server" ControlToValidate="Mobile" Display="Dynamic" ErrorMessage="Invalid Mobile Number" ForeColor="Red" ValidationExpression="\d{10}"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr><td></td><td></td></tr>
        <tr>
            <td>Hobbies :</td>
            <td>
                <asp:CheckBox ID="CheckBox1" runat="server" Text="Dance" />
                <br />
                <asp:CheckBox ID="CheckBox2" runat="server" OnCheckedChanged="CheckBox2_CheckedChanged" Text="Sports" />
                <br />
                <asp:CheckBox ID="CheckBox3" runat="server" Text="Singing" />
            </td>
        </tr>
        <tr><td></td><td></td></tr>
        <tr>
            <td>State :</td>
            <td>
                <asp:DropDownList ID="State" runat="server" AutoPostBack="True" OnSelectedIndexChanged="State_SelectedIndexChanged">
                    <asp:ListItem>Gujarat</asp:ListItem>
                    <asp:ListItem>Maharashtra</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">City :</td>
            <td class="auto-style1">
                <asp:DropDownList ID="City" runat="server" AutoPostBack="True" >
                    <asp:ListItem>Ahmedabad</asp:ListItem>
                    <asp:ListItem>Vadodara</asp:ListItem>
                </asp:DropDownList>
            <td class="auto-style1">
            </td>
        </tr>
        <tr>
            <td>PAN Number :</td>
            <td><asp:TextBox ID="PanNo" runat="server"></asp:TextBox></td>
            <td>
                <asp:CustomValidator ID="PANValidator" runat="server" ControlToValidate="PanNo" Display="Dynamic" ErrorMessage="Invalid PAN number" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td><asp:Button runat="server" Text="Button" OnClick="Unnamed1_Click" /></td>
        </tr>
        <tr>
            <td><asp:Label ID="Data" runat="server"></asp:Label></td>
        </tr>
        </table>
        <br />
        
        <br />
      </form>
    
</body>
</html>
