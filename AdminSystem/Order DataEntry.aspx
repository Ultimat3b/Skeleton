<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Order DataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    This is the order entry page
    <form id="form1" runat="server">
        <div>
        <asp:CheckBox ID="chkReturnCustomer" runat="server" style="z-index: 1; left: 11px; top: 257px; position: absolute" Text="Are you a return customer? Tick, if yes." />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 9px; top: 311px; position: absolute; height: 40px; width: 670px"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 13px; top: 380px; position: absolute; height: 29px; width: 103px" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 153px; top: 380px; position: absolute; height: 29px; width: 103px" Text="Cancel" />
        <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 153px; top: 380px; position: absolute; height: 29px; width: 103px" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 562px; top: 15px; position: absolute; height: 29px; width: 103px" Text="Find" />
        <asp:Label ID="lblDateAdded" runat="server" style="z-index: 2; left: 12px; top: 183px; position: absolute; height: 19px; width: 103px" Text="Date"></asp:Label>
        </div>
    </form>
     
</body>
</html>
