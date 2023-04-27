using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        // create new instance of clsAdress
        clsStock Anstock = new clsStock();


        // capture the StockName ect
        string Name = txtProductName.Text;
        string Date = txtStockDate.Text;
        string Amount = txtProductAmount.Text;
        string Location = txtStockLocation.Text;
        string Availability = chkStockAvailability.Text;
        string Price = txtStockPrice.Text;
        // variable to store any error messages
        string Error = "";
        // validate the data
        Error = Anstock.Valid(Amount, Date, Location, Name, Price);
        if (Error == "")
        {
            //capture the Name
            Anstock.Name = Name;
            //capture the Date
            Anstock.DateAdded = Convert.ToDateTime(Date);
            //capture the Price ect..
            Anstock.Price = Convert.ToDouble(Price);
            Anstock.Amount = Convert.ToInt32(Amount);
            Anstock.Location = Location;
            clsStockCollection StockList = new clsStockCollection();
            //set the ThisStock property
            StockList.ThisStock = Anstock;
            //add the new record
            StockList.Add();
            //navigate to the viewer page
            Response.Redirect("Stock List.aspx");
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
        // create an instance of the Stock class
        clsStock Anstock = new clsStock();
        // variable to store primary key 
        Int32 Amount;
        // variable to store the result of the find operation
        Boolean Found = false;
        // get primary key entered by the user
        Amount = Convert.ToInt32(txtStockID.Text);
        // find record
        Found = Anstock.Find(Amount);
        // if found
        if (Found == true)
        {
            // displaying the values of the properties in the form
            txtStockID.Text = Anstock.StockID.ToString();
            txtProductAmount.Text = Anstock.Amount.ToString();
            txtStockDate.Text = Anstock.DateAdded.ToString();
            txtStockLocation.Text = Anstock.Location;
            txtProductName.Text = Anstock.Name;
            txtStockPrice.Text = Anstock.Price.ToString();
            chkStockAvailability.Checked = Anstock.Availability;
        }
    }
}
