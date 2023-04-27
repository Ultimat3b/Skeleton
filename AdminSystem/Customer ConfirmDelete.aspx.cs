﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 CustomerId;

    //event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the Customer to be deleted from the session object
        CustomerId = Convert.ToInt32(Session["CustomerId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the customer records class
        clsCustomerCollection CustomerRecords = new clsCustomerCollection();
        //find the record to delete
        CustomerRecords.ThisCustomer.Find(CustomerId);
        //delete the record
        CustomerRecords.Delete();
        //redirect back to the main page
        Response.Redirect("Customer List.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("Customer List.aspx");
    }
}