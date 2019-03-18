<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PapaBobs.aspx.cs" Inherits="WebApplication1.PapaBobs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblWelcome" runat="server" Text="Papa Bob's Pizza"></asp:Label>
            <br />
            <br />
            <asp:RadioButtonList ID="rbSize" runat="server" />
            <br />
            <br />
            <asp:RadioButtonList ID="rbCrust" runat="server" />
            <br />
            <asp:CheckBoxList ID="chTopping" runat="server">
            </asp:CheckBoxList>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Papa Bob's"></asp:Label>
            <asp:Label ID="Label2" runat="server" Text="Special Deal" ForeColor="Red"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Save £2.00 when you add Pepperoni, Green Peppers and Anchovies OR Pepperoni, Red Peppers and Onions to your pizza"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnPurchase" runat="server" Text="Purchase" OnClick="btnPurchase_Click" />
            <br />
            <br />
            <asp:Label ID="lblOrder" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblTotal" runat="server" Text="Total: £0"></asp:Label>
        </div>
    </form>
</body>
</html>
