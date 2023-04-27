<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Order ConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Order Confirm/Delete</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <div style="height: 114px">
        </div>
        <asp:Label ID="lblSure" runat="server" style="z-index: 1; left: 10px; top: 19px; position: absolute; height: 32px; width: 660px" Text="Are you sure you want to delete this order?"></asp:Label>
        <asp:Button ID="btnYes" runat="server" height="34px" OnClick="btnYes_Click" style="z-index: 1; left: 10px; top: 71px; position: absolute" Text="Yes" width="99px" />
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 125px; top: 71px; position: absolute; height: 34px; width: 99px" Text="No" />
    </form>
</body>
</html>