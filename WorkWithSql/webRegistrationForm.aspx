<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webRegistrationForm.aspx.cs" Inherits="WorkWithSql.webRegistrationForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td>
                <asp:TextBox ID="txtFname" runat="server" Width="131px" placeholder="First Name"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="txtLname" runat="server" Width="131px" placeholder="Last Name"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:TextBox ID="txtEmail" runat="server" AutoCompleteType="Email" placeholder="example@new.com" Width="271px"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:TextBox ID="txtReEmail" runat="server" AutoCompleteType="Email" placeholder="example@new.com" Width="271px"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:TextBox ID="txtPasword" runat="server" Width="270px" TextMode="Password" ></asp:TextBox></td>
        </tr>
        <tr>
            <td></td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
