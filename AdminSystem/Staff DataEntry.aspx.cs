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
        string StaffFirstName = txtStaffFirstname.Text;
        string StaffSurname = txtSurname.Text;
        string StaffEmail = txtStaffEmail.Text;
        string StaffPhoneNumber = txtphoneNumber.Text;
        string StaffStartDate = txtStartDate.Text;
        string StaffSalary = txtSalary.Text;
        string Error = "";

        Error = aStaff.Valid(StaffFirstName, StaffSurname, StaffEmail, StaffPhoneNumber, StaffStartDate, StaffSalary);
        if (Error == "")
        {
            aStaff.StaffId = Convert.ToInt32(txtStaff_id.Text);
            aStaff.StaffFirstName = txtStaffFirstname.Text;
            aStaff.StaffSurname = txtSurname.Text;
            aStaff.StaffEmail = txtStaffEmail.Text;
            aStaff.StaffPhoneNumber = Convert.ToInt32(txtphoneNumber.Text);
            aStaff.StaffStartDate = Convert.ToDateTime(txtStartDate.Text);
            aStaff.StaffSalary = (float)Convert.ToDouble(txtSalary.Text);
            aStaff.Active = chkActive.Checked;

            clsStaffCollection StaffList = new clsStaffCollection();
            //store the data in the session object
            Session["aStaff"] = aStaff;
            //navigate to the viewer page
            Response.Redirect("Staff List.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStaff aStaff = new clsStaff();
        Int32 StaffId;
        Boolean Found = false;
        StaffId = Convert.ToInt32(txtStaff_id.Text);
        Found = aStaff.Find(StaffId);
        if (Found == true)
        {
            txtStaffFirstname.Text = aStaff.StaffFirstName;
            txtSurname.Text = aStaff.StaffSurname;
            txtStaffEmail.Text = aStaff.StaffEmail;
            txtphoneNumber.Text = aStaff.StaffPhoneNumber.ToString();
            txtStartDate.Text = aStaff.StaffStartDate.ToString();
            txtSalary.Text = aStaff.StaffSalary.ToString();
            chkActive.Checked = aStaff.Active;
        }


    }
}