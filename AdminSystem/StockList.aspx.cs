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
        if (IsPostBack == false)
        {
            //update the list box
            DisplayStocks();
        }
    }
    void DisplayStocks()
    {
        // create an instance of the stock collection
        clsStockCollection AnStock = new clsStockCollection();
        // set the data source to list of stock in the collection
        lstStockList.DataSource = AnStock.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "StockID";
        //set the data field to dipslay
        lstStockList.DataTextField = "Name";
        //bind the data to the list
        lstStockList.DataBind();
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        //storing -1 into the session object to indicate this is a new record
        Session["StockID"] = -1;
        //redirect to the data entry page
        Response.Redirect("StockDataEntry.aspx");
    }


    protected void lstStockList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnEdit_Click1(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 StockID;
        //if a record has been selected from the list
        if (lstStockList.SelectedIndex != -1)
        {
            //get the primary key value of the record to be edited
            StockID = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object
            Session["StockID"] = StockID;
            //redirect to the edit page
            Response.Redirect("StockDataEntry.aspx");
        }
        else
        //if no record has been selected
        {
            lblError.Text = "please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        // var to store the primary key value of the record to be deleted 
        Int32 StockID;
        //if the record has been selected from the list
        if (lstStockList.SelectedIndex != -1)
        {
            //get the primarykey value of the record to delete
            StockID = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object 
            Session["StockID"] = StockID;
            //redirect to the delete page
            Response.Redirect("StockConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            //display an error 
            lblError.Text = "please select a record a delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the Stock collection
        clsStockCollection Stock = new clsStockCollection();
        Stock.ReportByStock(txtProductName.Text);
        lstStockList.DataSource = Stock.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "StockID";
        //set the name of the field to display
        lstStockList.DataValueField = "Name";
        //bind the data to the list
        lstStockList.DataBind();
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        //create an instance of the stock collection
        clsStockCollection Stock = new clsStockCollection();
        Stock.ReportByStock("");
        // clear any existing fildter to tidy up the interface
        txtProductName.Text = "";
        lstStockList.DataSource = Stock.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "StockID";
        //set the name of the field to display
        lstStockList.DataValueField = "Name";
        //bind the data to the list
        lstStockList.DataBind();
    }
}