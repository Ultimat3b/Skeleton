using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary; //importing class library



public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 CustomerId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        CustomerId = Convert.ToInt32(Session["CustomerId"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (CustomerId != -1)
            {
                //display the current data for the record
                DisplayAddress();
            }
        }
    }

    void DisplayAddress()
    {
        //create an instance of the customer
        clsCustomerCollection CustomerRecords = new clsCustomerCollection();
        //find the record to update
        CustomerRecords.ThisCustomer.Find(CustomerId);
        //displya the data for this record
        txtCustomerId.Text = CustomerRecords.ThisCustomer.CustomerId.ToString();
        txtCustomerFirstName.Text = CustomerRecords.ThisCustomer.CustomerFirstName;
        txtCustomerSurname.Text = CustomerRecords.ThisCustomer.CustomerSurname;
        txtCustomerEmail.Text = CustomerRecords.ThisCustomer.CustomerEmail;
        txtDateAdded.Text = CustomerRecords.ThisCustomer.DateAdded.ToString();
        chkReturnCustomer.Checked = CustomerRecords.ThisCustomer.ReturnCustomer;
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
        string CustomerFirstName = txtCustomerFirstName.Text;
        //capture the customer Surname
        string CustomerSurname = txtCustomerSurname.Text;
        //capture the customer email
        string CustomerEmail = txtCustomerEmail.Text;
        //capture the date added
        string DateAdded = txtDateAdded.Text;
        //capture checkbox
        //String ReturnCustomer = chkReturnCustomer.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = aCustomer.Valid(CustomerFirstName, CustomerSurname, CustomerEmail, DateAdded);
        if (Error == "")
        {
            //capture the customer Id
            aCustomer.CustomerId = CustomerId;
            //capture the customer first name
            aCustomer.CustomerFirstName = CustomerFirstName;
            //capture the customer Surname
            aCustomer.CustomerSurname = CustomerSurname;
            //capture the customer email
            aCustomer.CustomerEmail = CustomerEmail;
            //capture the date added
            aCustomer.DateAdded = Convert.ToDateTime(DateAdded);
            //capture checkbox
            aCustomer.ReturnCustomer = chkReturnCustomer.Checked;
            //create a new instance of the customer collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();

            //if this is a new record i.e CustomerId = -1 then add the data
            if (CustomerId == -1)
            {   
                //set the ThisCustomer property
                CustomerList.ThisCustomer = aCustomer;
                //add the new record
                CustomerList.Add();
            }
            else
            {
                //find the record to update
                CustomerList.ThisCustomer.Find(CustomerId);
                //set the ThisCustomer property
                CustomerList.ThisCustomer = aCustomer;
                //update the record
                CustomerList.Update();
            }
            //redirect to the viewer page
            Response.Redirect("Customer List.aspx");

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
        //find the record using Find() method in clsCustomer
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

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Customer List.aspx");
    }
}