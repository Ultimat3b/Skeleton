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
        clsPayment aPayment = new clsPayment();



        Response.Write(aPayment.OrderID);
        Response.Write(aPayment.CustomerID);
        Response.Write(aPayment.TotalAmount);
        Response.Write(aPayment.OrderDate);
        Response.Write(aPayment.OrderStatus);


        
    }
}


