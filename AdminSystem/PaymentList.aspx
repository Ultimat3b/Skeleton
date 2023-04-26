<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PaymentList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" style="z-index: 1; left: 135px; top: 360px; position: absolute" Text="Delete" />
            <asp:ListBox ID="lstPaymentList" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 309px; width: 535px"></asp:ListBox>

            
        </div>
        
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 16px; top: 362px; position: absolute" Text="Add" />
        
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 64px; top: 361px; position: absolute; height: 28px; width: 46px" Text="Edit" />
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 11px; top: 480px; position: absolute"></asp:Label>
        
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 12px; top: 418px; position: absolute; right: 763px" Text="Enter a CustomerID"></asp:Label>
        <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 143px; top: 414px; position: absolute"></asp:TextBox>
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" style="z-index: 1; left: 50px; top: 454px; position: absolute" Text="Apply" />
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" style="z-index: 1; left: 121px; top: 453px; position: absolute" Text="Clear" />
        
    </form>
</body>
</html>
