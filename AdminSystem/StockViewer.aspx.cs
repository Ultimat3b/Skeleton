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
        //create a new isnatnce of clsStock
        clsStock Anstock = new clsStock();
        // get data from the session object
        Anstock = (clsStock)Session["Anstock"];
        //display the StockName for this entry
        Response.Write(Anstock.Amount);
        Response.Write(Anstock.Availability);
        Response.Write(Anstock.DateAdded);
        Response.Write(Anstock.Location);
        Response.Write(Anstock.Name);
        Response.Write(Anstock.Price);
        Response.Write(Anstock.StockID);

    }
}