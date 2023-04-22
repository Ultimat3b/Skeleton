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
     

        Response.Redirect("PaymentViewer.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}