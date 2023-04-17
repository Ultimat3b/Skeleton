<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Customer DataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 393px;
        }
    </style>
</head>
<body style="height: 389px">
    <form id="form1" runat="server">
        <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 10px; top: 223px; position: absolute; height: 22px" Text="Date"></asp:Label>
        <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 13px; top: 17px; position: absolute" Text="Customer ID No"></asp:Label>
        <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 246px; top: 15px; position: absolute; width: 272px"></asp:TextBox>
        <asp:Label ID="lblCustomerFirstName" runat="server" style="z-index: 1; left: 10px; top: 50px; position: absolute; height: 19px" Text="First Name"></asp:Label>
        <asp:Label ID="lblCustomerSurname" runat="server" style="z-index: 1; left: 10px; top: 86px; position: absolute; height: 20px" Text="Surname"></asp:Label>
        <asp:Label ID="lblCustomerAddress" runat="server" style="z-index: 1; left: 11px; top: 136px; position: absolute; height: 19px; width: 93px" Text="Email Address"></asp:Label>
        <asp:Label ID="lblCustomerPhoneNumber" runat="server" style="z-index: 1; left: 10px; top: 181px; position: absolute; height: 19px" Text="Phone Number"></asp:Label>
        <asp:TextBox ID="txtCustomerFirstName" runat="server" style="z-index: 1; left: 245px; top: 49px; position: absolute; width: 275px"></asp:TextBox>
        <asp:TextBox ID="txtCustomerPhoneNumber" runat="server" style="z-index: 1; left: 240px; top: 171px; position: absolute; width: 280px"></asp:TextBox>
        <asp:TextBox ID="txtCustomerSurname" runat="server" style="z-index: 1; left: 246px; top: 85px; position: absolute; width: 276px"></asp:TextBox>
        <asp:TextBox ID="txtCustomerDateAdded" runat="server" style="z-index: 1; left: 241px; top: 215px; position: absolute; width: 278px"></asp:TextBox>
        <asp:TextBox ID="txtCustomerEmail" runat="server" style="z-index: 1; left: 242px; top: 129px; position: absolute; width: 281px"></asp:TextBox>
        <asp:CheckBox ID="chkReturnCustomer" runat="server" style="z-index: 1; left: 11px; top: 274px; position: absolute" Text="Are you a return customer? Tick, if yes." />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 9px; top: 311px; position: absolute; height: 17px; width: 163px"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 13px; top: 361px; position: absolute; height: 29px; width: 103px" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 152px; top: 361px; position: absolute; height: 31px; width: 98px" Text="Cancel" />
    </form>
</body>
</html>
