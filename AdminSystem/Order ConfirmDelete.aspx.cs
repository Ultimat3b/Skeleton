﻿using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 OrderId;

    //event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the Customer to be deleted from the session object
        OrderId = Convert.ToInt32(Session["OrderId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the customer records class
        clsOrderCollection OrderRecords = new clsOrderCollection();
        //find the record to delete
        OrderRecords.ThisOrder.Find(OrderId);
        //delete the record
        OrderRecords.Delete();
        //redirect back to the main page
        Response.Redirect("Order List.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("Order List.aspx");
    }
}