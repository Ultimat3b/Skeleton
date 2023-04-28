﻿using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 StaffID;
    protected void Page_Load(object sender, EventArgs e)
    {
        StaffID = Convert.ToInt32(Session[StaffID]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsStaffCollection Staff = new clsStaffCollection();
        Staff.ThisStaff.Find(StaffID);
        Staff.Delete();
        Response.Redirect("Staff List.aspx");
    }
}