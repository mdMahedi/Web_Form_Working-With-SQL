<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditProductsThenUpdate.aspx.cs" Inherits="WorkWithSql.EditProductsThenUpdate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 238px;
        }

        .auto-style2 {
            height: 26px;
        }

        .auto-style3 {
            width: 238px;
            height: 26px;
        }
                
        table {
            border-style: solid;
            border-color: inherit;
            border-width: medium;
            margin: auto;
            background-color:#e0fe89;
            width:435px;
        }       
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td colspan="2"><h2 style="text-decoration: underline">Update Product</h2></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblID" runat="server" Text="Product ID  " Font-Bold="True" Font-Underline="False"></asp:Label></td>
            <td class="auto-style1"><asp:TextBox ID="txtPid" runat="server"></asp:TextBox>
                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Edit Data</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="lblName" runat="server" Text="Product Name  " Font-Bold="True"></asp:Label></td>
            <td class="auto-style1"><asp:TextBox ID="txtPname" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td class="auto-style2"><asp:Label ID="lblPrice" runat="server" Text="Product Price  " Font-Bold="True"></asp:Label></td>
            <td class="auto-style3"><asp:TextBox ID="txtPprice" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Label ID="lblQty" runat="server" Text="Product Quantity  " Font-Bold="True"></asp:Label></td>
            <td class="auto-style1"><asp:TextBox ID="txtPqty" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style1"><asp:Button ID="btnSave" runat="server" Text="Update Data" Font-Bold="True" Font-Overline="False" Width="129px" OnClick="btnSave_Click" /></td>
        </tr>
    </table>
        <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
