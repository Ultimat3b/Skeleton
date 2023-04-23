using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{


    protected void btnOK_Click(object sender, EventArgs e)
    {

       

        // create new instance of clsPayment
        clsPayment aPayment = new clsPayment();

        // capture the input values
        int OrderID = Convert.ToInt32(txtOrderID.Text);
        DateTime OrderDate = Convert.ToDateTime(txtOrderDate.Text);
        decimal TotalAmount = Convert.ToDecimal(txtTotalAmount.Text);
        string OrderStatus = chkOrderStatus.Text;
        string CustomerID = txtCustomerID.Text;

        // validate the input values
        string Error = aPayment.Valid(OrderID, OrderDate, CustomerID, TotalAmount, OrderStatus);

        if (Error == "")
        {
            // set the properties of the clsPayment object
            aPayment.OrderID = OrderID;
            aPayment.OrderDate = OrderDate;
            aPayment.TotalAmount = TotalAmount;
            aPayment.OrderStatus = (OrderStatus == "Yes");

            // redirect to PaymentViewer.aspx page
            Response.Redirect("PaymentViewer.aspx");
        }
        else
        {
            // display the error message
            lblError.Text = Error;
        }
    }




    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        {
            // create an instance of the Stock class
            clsPayment aPayment = new clsPayment();
            // variable to store primary key 
            Int32 OrderID;
            // variable to store the result of the find operation
            Boolean Found = false;
            // get primary key entered by the user
            OrderID = Convert.ToInt32(txtOrderID.Text);
            // find record
            Found = aPayment.Find(OrderID);
            // if found
            if (Found == true)
            {
                // displaying the values of the properties in the form
                txtCustomerID.Text = aPayment.CustomerID.ToString();
                txtTotalAmount.Text = aPayment.TotalAmount.ToString();
                txtOrderDate.Text = aPayment.OrderDate.ToString();
                
            }
        }
    }
}

