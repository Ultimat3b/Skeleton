using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private member for the list
        private List<clsCustomer> mCustomerList = new List<clsCustomer>();

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
            //get the count of records
            RecordCount = DB.Count;
            //while there are record to process
            while (Index < RecordCount) //index should always be RecordCount-1
            {
                //create a blank customer object
                clsCustomer aCustomer = new clsCustomer();
                //read in the fields from the current record
                aCustomer.CustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                aCustomer.CustomerFirstName = Convert.ToString(DB.DataTable.Rows[0]["CustomerFirstName"]);
                aCustomer.CustomerSurname = Convert.ToString(DB.DataTable.Rows[0]["CustomerSurname"]);
                aCustomer.CustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                aCustomer.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                aCustomer.ReturnCustomer = Convert.ToBoolean(DB.DataTable.Rows[0]["ReturnCustomer"]);
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

        public clsCustomer ThisCustomer { get; set; }
    }
}