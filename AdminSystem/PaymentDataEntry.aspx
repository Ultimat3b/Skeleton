<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PaymentDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 442px;
        }
    </style>
</head>
<body style="height: 381px">
    <form id="form1" runat="server">
    <asp:Label ID="OrderID" runat="server" style="z-index: 1; left: 5px; top: 34px; position: absolute;" Text="Order ID:" width="151px"></asp:Label>
    <asp:TextBox ID="txtOrderID" runat="server" style="z-index: 1; left: 177px; top: 29px; position: absolute; width: 128px; height: 24px;"></asp:TextBox>
    <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 320px; top: 33px; position: absolute" Text="Find" />
    
    <asp:Label ID="CustomerID" runat="server" style="z-index: 1; left: 5px; top: 67px; position: absolute;" Text="Customer ID:" width="151px"></asp:Label>
    <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 177px; top: 61px; position: absolute; height: 22px; width: 128px;"></asp:TextBox>
    
    <asp:Label ID="TotalAmount" runat="server" style="z-index: 1; left: 5px; top: 96px; position: absolute;" Text="Total Amount:" width="151px"></asp:Label>
    <asp:TextBox ID="txtTotalAmount" runat="server" style="z-index: 1; left: 177px; top: 89px; position: absolute; height: 22px; width: 128px;" TextMode="Number"></asp:TextBox>
    
    <asp:Label ID="OrderDate" runat="server" style="z-index: 1; left: 5px; top: 124px; position: absolute;" Text="Order Date:" width="151px"></asp:Label>
    <asp:TextBox ID="txtOrderDate" runat="server" style="z-index: 1; left: 177px; top: 119px; position: absolute; height: 22px; width: 128px;"></asp:TextBox>
    
    <asp:Label ID="OrderStatus" runat="server" style="z-index: 1; left: 5px; top: 155px; position: absolute;" Text="Order Status:" width="151px"></asp:Label>
    <asp:CheckBox ID="chkOrderStatus" runat="server" style="z-index: 1; left: 177px; top: 151px; position: absolute;" Text="Order Completed"></asp:CheckBox>
    
    <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 11px; top: 253px; position: absolute;"></asp:Label>
    
    <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 5px; top: 287px; position: absolute;" Text="OK" />
    <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 44px; top: 288px; position: absolute;" Text="Cancel" />
    
</form>

</body>
</html>
