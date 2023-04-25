using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        {
            //if this is the first time the page is displayed
            if (IsPostBack == false)
            {
                //update the list box
                DisplayPayments();
            }
        }
    }

    void DisplayPayments()
    {
        clsPaymentCollection Payments = new clsPaymentCollection();
        // set the data source to list of payments in the collection
        lstPaymentList.DataSource = Payments.PaymentList;
        //set the name of the primary key
        lstPaymentList.DataValueField = "OrderID";
        //set the data field to display
        lstPaymentList.DataTextField = "CustomerID";
        lstPaymentList.DataBind();
    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["OrderID"] = -1;
        //redirect to the data entry page
        Response.Redirect("PaymentDataEntry.aspx");
    }
}



