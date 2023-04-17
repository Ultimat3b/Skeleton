<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Stock DataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="StockID" runat="server" style="z-index: 1; left: 5px; top: 34px; position: absolute; " Text="ID number " width="151px"></asp:Label>
        <asp:TextBox ID="txtStockID" runat="server" MaxLength="100000" style="z-index: 1; left: 177px; top: 29px; position: absolute; width: 128px; height: 24px;" TextMode="Number"></asp:TextBox>
        <asp:Label ID="StcokName" runat="server" style="z-index: 1; left: 5px; top: 67px; position: absolute" Text="ProductName" width="151px"></asp:Label>
        <asp:TextBox ID="txtStockName" runat="server" style="z-index: 1; left: 177px; top: 61px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:Label ID="StcokLocation" runat="server" style="z-index: 1; left: 5px; top: 96px; position: absolute" Text="Origin of Goods" width="151px"></asp:Label>
        <asp:TextBox ID="txtStockLocation" runat="server" style="z-index: 1; left: 177px; top: 89px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:Label ID="StockNumber" runat="server" style="z-index: 1; left: 5px; top: 124px; position: absolute" Text="Product Amount" width="151px"></asp:Label>
        <asp:TextBox ID="txtStockAmount" runat="server" style="z-index: 1; left: 177px; top: 119px; position: absolute; bottom: 638px;" height="22px" width="128px"></asp:TextBox>
        <asp:Label ID="StockPrice" runat="server" style="z-index: 1; left: 5px; top: 155px; position: absolute" Text="Price of Singular Product"></asp:Label>
        <asp:TextBox ID="txtStockPrice" runat="server" style="z-index: 1; left: 177px; top: 151px; position: absolute" TextMode="Number" height="22px" width="128px"></asp:TextBox>
        <asp:Label ID="StockDate" runat="server" style="z-index: 1; left: 5px; top: 186px; position: absolute" Text="Date Added" width="151px"></asp:Label>
        <asp:TextBox ID="txtStockDate" runat="server" style="z-index: 1; left: 177px; top: 183px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:CheckBox ID="boxStockAvailability" runat="server" style="z-index: 1; left: 7px; top: 216px; position: absolute" Text="Stock Available" ValidationGroup="txtStockAmount" />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 5px; top: 287px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 44px; top: 288px; position: absolute" Text="Cancel" />
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 123px; top: 287px; position: absolute" Text="Find" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 11px; top: 253px; position: absolute"></asp:Label>
    </form>
</body>
</html>
