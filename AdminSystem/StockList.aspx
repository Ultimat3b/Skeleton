<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 338px">
            <asp:ListBox ID="lstStockList" runat="server" style="z-index: 1; left: 9px; top: 16px; position: absolute; height: 196px; width: 275px" OnSelectedIndexChanged="lstStockList_SelectedIndexChanged"></asp:ListBox>
            <asp:Button ID="btnAdd" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 16px; top: 227px; position: absolute;" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 59px; top: 227px; position: absolute; width: 34px;" Text="Edit" OnClick="btnEdit_Click1" />
            <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 97px; top: 227px; position: absolute; width: 54px" Text="Delete" OnClick="btnDelete_Click" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 18px; top: 327px; position: absolute"></asp:Label>
            <asp:Label ID="lblFilter" runat="server" style="z-index: 1; left: 17px; top: 259px; position: absolute" Text="Enter the product name"></asp:Label>
            <asp:TextBox ID="txtProductName" runat="server" style="z-index: 1; left: 169px; top: 252px; position: absolute"></asp:TextBox>
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 17px; top: 279px; position: absolute" Text="Apply" />
            <asp:Button ID="btnClear" runat="server" OnClick="Button1_Click1" style="z-index: 1; left: 76px; top: 279px; position: absolute" Text="Clear" />
        </div>
    </form>
</body>
</html>
