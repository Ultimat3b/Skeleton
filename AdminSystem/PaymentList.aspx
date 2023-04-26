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
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 20px; top: 407px; position: absolute"></asp:Label>
        
    </form>
</body>
</html>
