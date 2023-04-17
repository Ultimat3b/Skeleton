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
        /*capture the StockID ect..
        string ID = txtStockID.Text;
        string Name = txtStockName.Text;
        string Date = txtStockDate.Text;
        string Amount = txtStockAmount.Text;
        string Location = txtStockLocation.Text;
        string Availibility = boxStockAvailability.Text;
        // variable to store any error messages
        string Error = "";
        // validate the data 
        Error = Anstock.valida(ID, Name, Date, Amount, Location, Availibility);
        if (Error == "")
        {*/
            //capture the Name
            Anstock.Name = txtStockName.Text;
            //capture the StockID
            Anstock.StockID = Convert.ToInt32(txtStockID.Text);
            //capture the Date
            Anstock.DateAdded = Convert.ToDateTime(txtStockDate.Text);
            //capture the Price ect..
            Anstock.Price = Convert.ToDouble(txtStockPrice.Text);
            Anstock.Amount = Convert.ToInt32(txtStockAmount.Text);
            Anstock.Location = txtStockLocation.Text;
            Anstock.Availibility = boxStockAvailability.Checked;
            //stores StockID in session object 
            Session["Anstock"] = Anstock;
            //navigate to the viewer page
            Response.Redirect("Stock Viewer.aspx");
        //}
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
            txtStockAmount.Text = Anstock.Amount.ToString();
            txtStockDate.Text = Anstock.DateAdded.ToString();
            txtStockLocation.Text = Anstock.Location;
            txtStockName.Text = Anstock.Name;
            txtStockPrice.Text = Anstock.Price.ToString();
            boxStockAvailability.Checked = Anstock.Availibility;
        }


    }
}