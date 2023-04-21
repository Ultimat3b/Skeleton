using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace ClassLibrary
{
    public class clsStockCollection
    {
        //private data member for the list
        List<clsStock> mStockList = new List<clsStock>();
        // private data member thisStock
        clsStock mThisStock = new clsStock();

        public clsStockCollection()
        {

            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            // populate the array list with data from the table 
            PopulateArray(DB);
        }
        public List<clsStock> StockList
        {
            get
            {
                //return the private data
                return mStockList;
            }
            set
            {
                //set the private data
                mStockList = value;
            }
        }
        public int Count
        {
            get
            {
                //return count of the list
                return mStockList.Count;
            }
            set
            {
                //set the private data

            }
        }
        //public property for ThisStock
        public clsStock ThisStock
        {
            get
            {
                //return the private data
                return mThisStock;
            }
            set
            {
                //set the private data
                mThisStock = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database based o the value of mThisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //seth tehe parameter for the stored procedure
            DB.AddParameter("@StockName", mThisStock.Name);
            DB.AddParameter("@StockLocation", mThisStock.Location);
            DB.AddParameter("@DateAdded", mThisStock.DateAdded);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@Available", mThisStock.Availability);
            DB.AddParameter("@StockAmount", mThisStock.Amount);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStock_Insert");
        }
        public void Update()
        {
            //Update an existing record based on the values of thisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StockId", mThisStock.StockID);
            DB.AddParameter("@StockName", mThisStock.Name);
            DB.AddParameter("@StockLocation", mThisStock.Location);
            DB.AddParameter("@DateAdded", mThisStock.DateAdded);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@Available", mThisStock.Availability);
            DB.AddParameter("@StockAmount", mThisStock.Amount);
            //execute the query returning the primary key value
            DB.Execute("sproc_tblStock_Update");
        }
        public void Delete()
        {
            //deleted the record pointed to by AnStock
            //connect to teh database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StockID", ThisStock.StockID);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_Delete");
        }

        public void ReportByStock(string StockName)
        {
            //filters the records based on the full or partaial StockID's
            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send teh StockId parameter to the database
            DB.AddParameter("@StockName", StockName);
            //execute the stored procedure 
            DB.Execute("sproc_tblStock_FilterByStock");
            // Populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populate the array list based on teh data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of the record
            RecordCount = DB.Count;
            //clear the private array list
            mStockList = new List<clsStock>();
            // while there are records to process
            while (Index < RecordCount)
            {
                // create a blank address
                clsStock AnStock = new clsStock();
                //read in the fields from the current record
                AnStock.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Available"]);
                AnStock.Amount = Convert.ToInt32(DB.DataTable.Rows[Index]["Stockamount"]);
                AnStock.Location = Convert.ToString(DB.DataTable.Rows[Index]["StockLocation"]);
                AnStock.Price = Convert.ToDouble(DB.DataTable.Rows[Index]["Price"]);
                AnStock.Name = Convert.ToString(DB.DataTable.Rows[Index]["StockName"]);
                AnStock.StockID = Convert.ToInt32(DB.DataTable.Rows[Index]["StockID"]);
                AnStock.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                //add the record to the private data member
                mStockList.Add(AnStock);
                //point at the next record
                Index++;
            }

        }
    }

}
