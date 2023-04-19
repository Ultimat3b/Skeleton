<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Staff DataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:Label ID="lblstaff_id" runat="server" Text="Staff ID:" width="122px"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="txtStaff_id" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblStaff_FirstName" runat="server" Text="Staff Firstname:" height="19px" width="122px"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="txtStaffFirstname" runat="server"></asp:TextBox>
            <br />
             <asp:Label ID="lblStaff_Surname" runat="server" Text="Staff Surname:" height="19px" width="122px"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="txtSurname" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblStaff_PhoneNumber" runat="server" Text="Staff Phone number:" height="19px"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="txtphoneNumber" runat="server"></asp:TextBox>
            <br />
             <asp:Label ID="lblStaff_email" runat="server" Text="Staff email:" height="19px" width="122px"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblStaff_StartDate" runat="server" Text="Staff Start Date:" height="19px" width="122px"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="txtStartDate" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblStaff_Salary" runat="server" Text="Staff Salary:" height="19px" width="122px"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="txtSalary" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 10px; top: 216px; position: absolute" Text="Active" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 254px; position: absolute"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnOk" runat="server" style="z-index: 1; left: 10px; top: 292px; position: absolute; width: 34px" Text="OK" OnClick="btnOk_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 54px; top: 292px; position: absolute" Text="Cancel" />
        </div>
    </form>
</body>
</html>
