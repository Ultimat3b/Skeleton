using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new intsance of clsCustomer
        clsCustomer aCustomer = new clsCustomer();
        //get the data from the session object
        aCustomer = (clsCustomer)Session["aCustomer"];
        //display the customer id for this entry
        Response.Write(aCustomer.CustomerId);
        //display the customer first name for this entry
        Response.Write(aCustomer.CustomerFirstName);
        //display the customer surname for this entry
        Response.Write(aCustomer.CustomerSurname);
        //display the customer email for this entry
        Response.Write(aCustomer.CustomerEmail);
        //display the date added for this entry
        Response.Write(aCustomer.DateAdded);
        //display the result for this entry
        Response.Write(aCustomer.ReturnCustomer);

    }
}