<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Customer DataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 502px;
        }
    </style>
</head>
<body style="height: 500px">
    <form id="form1" runat="server">
        <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 13px; top: 16px; position: absolute" Text="Customer ID No"></asp:Label>
        <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 246px; top: 15px; position: absolute; width: 272px"></asp:TextBox>
        <asp:Label ID="lblCustomerFirstName" runat="server" style="z-index: 1; left: 11px; top: 53px; position: absolute; height: 19px" Text="First Name" width="103px"></asp:Label>
        <asp:Label ID="lblCustomerSurname" runat="server" style="z-index: 1; left: 10px; top: 89px; position: absolute; height: 19px" Text="Surname" width="103px"></asp:Label>
        <asp:Label ID="lblCustomerAddress" runat="server" style="z-index: 1; left: 12px; top: 133px; position: absolute; height: 19px; width: 103px" Text="Email Address"></asp:Label>
        <asp:TextBox ID="txtCustomerFirstName" runat="server" height="22px" style="z-index: 1; left: 246px; top: 49px; position: absolute; width: 272px"></asp:TextBox>
        <asp:TextBox ID="txtCustomerSurname" runat="server" height="22px" style="z-index: 1; left: 246px; top: 85px; position: absolute; width: 272px"></asp:TextBox>
        <asp:TextBox ID="txtDateAdded" runat="server" height="22px" style="z-index: 1; left: 246px; top: 174px; position: absolute; width: 272px; "></asp:TextBox>
        <asp:TextBox ID="txtCustomerEmail" runat="server" height="22px" style="z-index: 1; left: 246px; top: 129px; position: absolute; width: 272px"></asp:TextBox>
        <asp:CheckBox ID="chkReturnCustomer" runat="server" style="z-index: 1; left: 11px; top: 257px; position: absolute" Text="Are you a return customer? Tick, if yes." />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 9px; top: 311px; position: absolute; height: 40px; width: 670px"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 13px; top: 380px; position: absolute; height: 29px; width: 103px" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 153px; top: 380px; position: absolute; height: 29px; width: 103px" Text="Cancel" />
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 562px; top: 15px; position: absolute; height: 29px; width: 103px" Text="Find" />
        <asp:Label ID="lblDateAdded" runat="server" style="z-index: 2; left: 12px; top: 183px; position: absolute; height: 19px; width: 103px" Text="Date"></asp:Label>
    </form>
</body>
</html>
