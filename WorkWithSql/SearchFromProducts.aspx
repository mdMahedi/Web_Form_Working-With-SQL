<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchFromProducts.aspx.cs" Inherits="WorkWithSql.SearchFromProducts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Enter Product Item&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>pid</asp:ListItem>
            <asp:ListItem>pname</asp:ListItem>
            <asp:ListItem>pprice</asp:ListItem>
            <asp:ListItem>pqty</asp:ListItem>
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp; Chose Operator
        <asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem>=</asp:ListItem>
            <asp:ListItem>!=</asp:ListItem>
            <asp:ListItem>&gt;</asp:ListItem>
            <asp:ListItem>&gt;=</asp:ListItem>
            <asp:ListItem>&lt;</asp:ListItem>
            <asp:ListItem>&lt;=</asp:ListItem>
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Enter Your Values
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search Item" Width="111px" />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </div>
    </form>
</body>
</html>
