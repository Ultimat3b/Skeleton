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
        aStaff.Staff_Firstname = txtStaffFirstname.Text;
        aStaff.Staff_Surname = txtSurname.Text;
        aStaff.Staff_Email = txtEmail.Text;
        aStaff.Staff_PhoneNumber = txtphoneNumber.Text;

        //store the data in the session object
        Session["aStaff"] = aStaff;
        //navigate to the viewer page
        Response.Redirect("1Viewer.aspx");
    }
}