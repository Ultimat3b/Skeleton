using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff aStaff = new clsStaff();
        //capture the staff name
        aStaff.StaffFirstname = txtStaffFirstname.Text;
        aStaff.StaffSurname = txtSurname.Text;
        aStaff.StaffEmail = txtEmail.Text;
        aStaff.StaffPhoneNumber = txtphoneNumber.Text;

        //store the data in the session object
        Session["aStaff"] = aStaff;
        //navigate to the viewer page
        Response.Redirect("1Viewer.aspx");
    }
}