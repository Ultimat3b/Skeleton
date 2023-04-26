using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {


        //if this is the first time the page is displayed
        OrderID = Convert.ToInt32(Session["OrderID"]);

        //if this is the first time the page is displayed
        if (IsPostBack == false)
            {
                //update the list box
                DisplayPayments();
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

    protected void Button2_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 OrderID;
        //if a record has been selected from the list
        if (lstPaymentList.SelectedIndex != -1)
        {
            //get the primary key value of the record to be edited
            OrderID = Convert.ToInt32(lstPaymentList.SelectedValue);
            //store the data in the session object
            Session["OrderID"] = OrderID;
            //redirect to the edit page
            Response.Redirect("PaymentDataEntry.aspx");
        }
        else
        //if no record has been selected
        {
            lblError.Text = "Please select other";
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    
        {
            // var to store the primary key value of the record to be deleted 
            Int32 StockID;
            //if the record has been selected from the list
            if (lstPaymentList.SelectedIndex != -1)
            {
                //get the primarykey value of the record to delete
                OrderID =Convert.ToInt32(lstPaymentList.SelectedValue);
                //store the data in the session object 
                Session["OrderID"] = OrderID;
                //redirect to the delete page
                Response.Redirect("PaymentConfirmDelete.aspx");
            }
            else //if no record has been selected
            {
                //display an error 
                lblError.Text = "please select a record a delete from the list";
            }
        }

    
}



