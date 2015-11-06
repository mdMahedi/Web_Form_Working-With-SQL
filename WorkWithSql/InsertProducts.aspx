<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertProducts.aspx.cs" Inherits="WorkWithSql.InsertProducts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        
        table {
            border-style: solid;
            border-color: inherit;
            border-width: medium;
            margin: auto;
            background-color:#e0fe89;
            width:321px;
        }       
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>                    
    <table>
        <tr>
            <td colspan="2"><h2 style="text-decoration: underline">Insert Product</h2></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblID" runat="server" Text="Product ID  " Font-Bold="True" Font-Underline="False"></asp:Label></td>
            <td><asp:TextBox ID="txtPid" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblName" runat="server" Text="Product Name  " Font-Bold="True"></asp:Label></td>
            <td><asp:TextBox ID="txtPname" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblPrice" runat="server" Text="Product Price  " Font-Bold="True"></asp:Label></td>
            <td><asp:TextBox ID="txtPprice" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblQty" runat="server" Text="Product Quantity  " Font-Bold="True"></asp:Label></td>
            <td><asp:TextBox ID="txtPqty" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td></td>
            <td><asp:Button ID="Button1" runat="server" Text="Save" Font-Bold="True" Font-Overline="False" OnClick="Button1_Click" Width="82px" /></td>
        </tr>
    </table>
        <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>  
    </div>
    </form>
</body>
</html>
