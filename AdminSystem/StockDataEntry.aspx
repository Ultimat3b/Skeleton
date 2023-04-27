<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
        <form id="form1" runat="server">
            <asp:Label ID="StockID" runat="server" style="z-index: 1; left: 5px; top: 34px; position: absolute; " Text="ID number " width="151px"></asp:Label>
            <asp:TextBox ID="txtStockID" runat="server" style="z-index: 1; left: 177px; top: 29px; position: absolute; width: 128px; height: 24px;"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 320px; top: 33px; position: absolute" Text="Find" />
            <asp:Label ID="lblProductName" runat="server" style="z-index: 1; left: 5px; top: 67px; position: absolute" Text="ProductName " width="151px"></asp:Label>
            <asp:TextBox ID="txtProductName" runat="server" style="z-index: 1; left: 177px; top: 61px; position: absolute" height="22px" width="128px"></asp:TextBox>
            <asp:Label ID="lblStockLocation" runat="server" style="z-index: 1; left: 5px; top: 96px; position: absolute" Text="Origin of Goods" width="151px"></asp:Label>
            <asp:TextBox ID="txtStockLocation" runat="server" style="z-index: 1; left: 177px; top: 89px; position: absolute" height="22px" width="128px"></asp:TextBox>
            <asp:Label ID="lblProductAmount" runat="server" style="z-index: 1; left: 5px; top: 124px; position: absolute" Text="Product Amount" width="151px"></asp:Label>
            <asp:TextBox ID="txtProductAmount" runat="server" style="z-index: 1; left: 177px; top: 119px; position: absolute; bottom: 638px;" height="22px" width="128px"></asp:TextBox>
            <asp:Label ID="lblStockPrice" runat="server" style="z-index: 1; left: 5px; top: 155px; position: absolute" Text="Price of Singular Product"></asp:Label>
            <asp:TextBox ID="txtStockPrice" runat="server" style="z-index: 1; left: 177px; top: 151px; position: absolute" TextMode="Number" height="22px" width="128px"></asp:TextBox>
            <asp:Label ID="lblStockDate" runat="server" style="z-index: 1; left: 5px; top: 186px; position: absolute" Text="Date Added" width="151px"></asp:Label>
            <asp:TextBox ID="txtStockDate" runat="server" style="z-index: 1; left: 177px; top: 183px; position: absolute" height="22px" width="128px"></asp:TextBox>
            <asp:CheckBox ID="chkStockAvailability" runat="server" style="z-index: 1; left: 7px; top: 216px; position: absolute" Text="Stock Available" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 11px; top: 253px; position: absolute"></asp:Label>
            <asp:Button ID="btnOK2" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 5px; top: 287px; position: absolute;" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 44px; top: 288px; position: absolute;" Text="Cancel" />
        </form>
</body>
</html>