<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChallengeDaysBetweenDates.aspx.cs" Inherits="WebApplication1.ChallengeDaysBetweenDates" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Please Select First Date"></asp:Label>
            <br />
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Please Slect Second Date"></asp:Label>
            <br />
            <asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
            <asp:Button ID="btnCalc" runat="server" OnClick="btnCalc_Click" Text="OK" />
            <br />
            <br />
            <asp:Label ID="lblAnswer" runat="server"></asp:Label>
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
