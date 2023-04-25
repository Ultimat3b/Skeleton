<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PaymentList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstPaymentList" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 309px; width: 535px"></asp:ListBox>

            
        </div>
        
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 16px; top: 362px; position: absolute" Text="Button" />
        
    </form>
</body>
</html>
