using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary; //importing class library



public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        /* we are now creating instances of the class clsCustomer and store 
         * some of the data in the object to display on a second page. */

        //create a new instance of clsAddress
        clsCustomer aCustomer = new clsCustomer();
        //capture the customer ID
       // String CustomerId = txtCustomerId.Text;
        //capture the customer first name
        String CustomerFirstName = txtCustomerFirstName.Text;
        //capture the customer Surname
        String CustomerSurname = txtCustomerSurname.Text;
        //capture the customer email
        String CustomerEmail = txtCustomerEmail.Text;
        //capture the date added
        String DateAdded = txtDateAdded.Text;
        //capture checkbox
        //String ReturnCustomer = chkReturnCustomer.Text;
        //variable to store any error messages
        String Error = "";
        //validate the data
        Error = aCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, DateAdded);
        if (Error == "")
        {
            
            //capture the customer first name
            aCustomer.CustomerFirstName = txtCustomerFirstName.Text;
            //capture the customer Surname
            aCustomer.CustomerSurname = txtCustomerSurname.Text;
            //capture the customer email
            aCustomer.CustomerEmail = txtCustomerEmail.Text;
            //capture the date added
            aCustomer.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
            //capture checkbox
            //aCustomer.ReturnCustomer = chkReturnCustomer.Checked;
            //store the Customer in the session object
            Session["aCustomer"] = aCustomer;
            //redirect to the viewer page
            Response.Write("Customer Viewer.aspx");

            /*Notice how we now capture the inputted data to the string variables 
             * first and then pass these values to the validation method*/
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsCustomer aCustomer = new clsCustomer();
        //variable to store the primary key
        Int32 CustomerId;
        //variable to store the result of the find operation
        Boolean found = false;
        //get the primary key entred by the user
        CustomerId = Convert.ToInt32(txtCustomerId.Text);
        //find the record
        found = aCustomer.Find(CustomerId);
        //if found
        if (found == true)
        {
            //display the values of the properties in the form
            txtCustomerFirstName.Text = aCustomer.CustomerFirstName;
            txtCustomerSurname.Text = aCustomer.CustomerSurname;
            txtCustomerEmail.Text = aCustomer.CustomerEmail;
            txtDateAdded.Text = aCustomer.DateAdded.ToString();
            chkReturnCustomer.Checked = aCustomer.ReturnCustomer;



        }

    }
}