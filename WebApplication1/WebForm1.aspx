<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Style.css" rel="stylesheet" />
</head>
<body style="height: 124px">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblName" runat="server" Text="Name">

            </asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
            </br>
            <asp:Label ID="lblDisplay" runat="server"></asp:Label>
            <asp:DropDownList ID="ddlDays" runat="server" OnSelectedIndexChanged="ddlDays_SelectedIndexChanged"></asp:DropDownList>
            <asp:RadioButtonList ID="rbList" runat="server" />
            <asp:CheckBoxList ID="chList" runat="server"></asp:CheckBoxList>
        </div>
    </form>
</body>
</html>
