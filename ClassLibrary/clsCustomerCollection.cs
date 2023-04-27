using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private member for the list
        private List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private data member thisCustomer
        private clsCustomer mThisCustomer = new clsCustomer();

        public clsCustomerCollection()
        {
            //var of the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
            //get the count of records
            RecordCount = DB.Count;
            //while there are record to process
            while (Index < RecordCount) //index should always be RecordCount-1
            {
                //create a blank customer object
                clsCustomer aCustomer = new clsCustomer();
                //read in the fields from the current record
                aCustomer.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                aCustomer.CustomerFirstName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerFirstName"]);
                aCustomer.CustomerSurname = Convert.ToString(DB.DataTable.Rows[Index]["CustomerSurname"]);
                aCustomer.CustomerEmail = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmail"]);
                aCustomer.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                aCustomer.ReturnCustomer = Convert.ToBoolean(DB.DataTable.Rows[Index]["ReturnCustomer"]);
                //add the record to the private data member
                mCustomerList.Add(aCustomer);
                //point at the next record
                Index++;
            }
        }

        public List<clsCustomer> CustomerList 
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            } 
        }

        public int Count 
        {
            get
            {
                return mCustomerList.Count;
            }
            set
            {
                //oh well
            }
        }

        public clsCustomer ThisCustomer 
        {
            get 
            {
                return mThisCustomer;
            }
            set
            {
                mThisCustomer = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerFirstName", mThisCustomer.CustomerFirstName);
            DB.AddParameter("@CustomerSurname", mThisCustomer.CustomerSurname);
            DB.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@DateAdded", mThisCustomer.DateAdded);
            DB.AddParameter("@ReturnCustomer", mThisCustomer.ReturnCustomer);
            //execute the query returning the primary key
            return DB.Execute("sproc_tblCustomer_Insert");
        }
        
        public void Update()
        {
            //update an existing record based on the values of ThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            DB.AddParameter("@CustomerFirstName", mThisCustomer.CustomerFirstName);
            DB.AddParameter("@CustomerSurname", mThisCustomer.CustomerSurname);
            DB.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@DateAdded", mThisCustomer.DateAdded);
            DB.AddParameter("@ReturnCustomer", mThisCustomer.ReturnCustomer);
            //execute the query returning the primary key
            DB.Execute("sproc_tblCustomer_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by ThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameter for the stored procedure
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerId);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void ReportBySurname(string CustomerSurname)
        {
            //filters the records based on a full or partial Customer surname
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the CustomerSurname parameter to the database
            DB.AddParameter("@CustomerSurname", CustomerSurname);
            //execute stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerSurname");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var of the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of the records
            RecordCount = DB.Count;
            //clear the pirvate array list
            mCustomerList = new List<clsCustomer>();
            ///while there are record to process
            while (Index < RecordCount) //index should always be RecordCount-1
            {
                //create a blank customer object
                clsCustomer aCustomer = new clsCustomer();
                //read in the fields from the current record
                aCustomer.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                aCustomer.CustomerFirstName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerFirstName"]);
                aCustomer.CustomerSurname = Convert.ToString(DB.DataTable.Rows[Index]["CustomerSurname"]);
                aCustomer.CustomerEmail = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmail"]);
                aCustomer.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                aCustomer.ReturnCustomer = Convert.ToBoolean(DB.DataTable.Rows[Index]["ReturnCustomer"]);
                //add the record to the private data member
                mCustomerList.Add(aCustomer);
                //point at the next record
                Index++;

            }
        }

    }
}