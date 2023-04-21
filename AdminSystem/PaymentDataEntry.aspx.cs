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
        clsPayment Payment = new clsPayment();
    
      

        Session["Payment"] = Payment;

        Response.Redirect("PaymentViewer.aspx");
    }
}