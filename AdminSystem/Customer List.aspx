<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Customer List.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomerList" runat="server" OnSelectedIndexChanged="lstCustomerList_SelectedIndexChanged" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 385px; width: 397px"></asp:ListBox>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 10px; top: 429px; position: absolute; height: 34px; width: 97px" Text="Add" />
        </p>
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 119px; top: 429px; position: absolute; height: 34px; width: 97px" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" height="34px" OnClick="btnDelete_Click" style="z-index: 1; left: 231px; top: 429px; position: absolute" Text="Delete" width="97px" />
        <p>
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 119px; top: 537px; position: absolute; height: 34px; width: 97px" Text="Clear" />
        </p>
        <p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 631px; position: absolute; height: 34px; width: 546px"></asp:Label>
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 10px; top: 537px; position: absolute; height: 34px; width: 97px; right: 929px" Text="Apply" />
        </p>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblFilter" runat="server" style="z-index: 1; left: 10px; top: 482px; position: absolute; height: 34px; width: 392px" Text="Enter a Customer surname"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 485px; top: 476px; position: absolute; height: 34px; width: 300px"></asp:TextBox>
    </form>
</body>
</html>
