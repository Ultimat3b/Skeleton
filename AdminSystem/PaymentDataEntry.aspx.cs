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
        // create new instance of clsAdress
        clsPayment aPayment = new clsPayment();


        // capture the StockName ect
        string Name = txtOrderID.Text;
        string Date = txtOrderDate.Text;
        string Amount = txtTotalAmount.Text;
   
        string Availability = chkOrderStatus.Text;
        string Customer = txtCustomerID.Text;
        // variable to store any error messages
        string Error = "";
        // validate the data
        if (Error == "")
        {
            //capture the Name
            aPayment.OrderID = Convert.ToInt32(Name);
            //capture the Date
            aPayment.OrderDate = Convert.ToDateTime(Date);
          
            aPayment.TotalAmount = Convert.ToInt32(Amount);
            aPayment.CustomerID = Convert.ToInt32(Customer);



            Response.Redirect("PaymentViewer.aspx");
        }
        else
     
        {
            //display the error message
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

