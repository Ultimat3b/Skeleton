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
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 15px; top: 37px; position: absolute; width: 67px; right: 1192px" Text="OrderID"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox2" runat="server" height="22px" style="z-index: 1; left: 99px; top: 34px; position: absolute" width="128px"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="TextBox3" runat="server" height="22px" style="z-index: 1; left: 99px; top: 65px; position: absolute" width="128px"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="TextBox4" runat="server" height="22px" style="z-index: 1; left: 99px; top: 108px; position: absolute; width: 128px"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox ID="TextBox5" runat="server" height="22px" style="z-index: 1; left: 99px; top: 146px; position: absolute" width="128px"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="OrderStatus" runat="server" style="z-index: 1; left: 10px; top: 186px; position: absolute" Text="OrderStatus" />
        <br />
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 15px; top: 68px; position: absolute; right: 1184px" Text="CostumerID"></asp:Label>
        <br />
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 15px; top: 149px; position: absolute" Text="OrderDate"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 12px; top: 226px; position: absolute" Text="OK" />
&nbsp;
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; top: 226px; position: absolute; left: 62px; width: 68px" Text="Cancel" />
        <br />
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 15px; top: 110px; position: absolute; height: 20px; margin-top: 0px" Text="TotalAmount" width="35"></asp:Label>
&nbsp;
        <br />
        <br />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
