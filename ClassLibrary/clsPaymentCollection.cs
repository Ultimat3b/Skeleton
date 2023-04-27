using ClassLibrary;

using System;
using System.Collections.Generic;

namespace ClassLibrary
{





    public class clsPaymentCollection
    {




        List<clsPayment> mPaymentList = new List<clsPayment>();
        clsPayment mThisPayment = new clsPayment();
        public clsPaymentCollection()
        {
            
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_PaymentProcess_SelectAll");
            PopulateArray(DB);
            
        }




        public List<clsPayment> PaymentList
        {
            get
            {
                return mPaymentList;
            }

            set
            {
                mPaymentList = value;
            }
        }


        public int Count
        {
            get
            {
                return mPaymentList.Count;

            }

            set
            {

            }

        }


        public clsPayment ThisPayment
        {
            get
            {
                return mThisPayment;
            }


            set
            {
                mThisPayment = value;
            }
        }




        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            // Add the parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisPayment.CustomerID);
            DB.AddParameter("@OrderDate", mThisPayment.OrderDate);
            DB.AddParameter("@OrderStatus", mThisPayment.OrderStatus);
            DB.AddParameter("@TotalAmount", mThisPayment.TotalAmount);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblPayment_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@OrderID", mThisPayment.OrderID);
            DB.AddParameter("@OrderDate", mThisPayment.OrderDate);
            DB.AddParameter("@CustomerID", mThisPayment.CustomerID);
            DB.AddParameter("@TotalAmount", mThisPayment.TotalAmount);
            DB.AddParameter("@OrderStatus", mThisPayment.OrderStatus);

            // execute the query returning the primary key value
            DB.Execute("sproc_tblPayment_Update");
        }






        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@OrderID", mThisPayment.OrderID);

            // execute the query returning the primary key value
            DB.Execute("sproc_tblPayment_Delete");
        }

        public void ReportByCustomerID(string CustomerID)
        {


            // connect to the database
            clsDataConnection DB = new clsDataConnection();
            // send the CustomerID parameter to the database
            DB.AddParameter("@CustomerID", CustomerID);
            // execute the stored procedure
            Convert.ToInt32(DB.Execute("sproc_tblPayment_FilterByCustomerID"));
            // populate the array list with the data table
            PopulateArray(DB);
        }

        public void ReportByCustomerID(object text)
        {
            throw new NotImplementedException();
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mPaymentList = new List<clsPayment>();

            while (Index < RecordCount)
            {
                clsPayment aPayment = new clsPayment();
                aPayment.OrderStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["OrderStatus"]);
                aPayment.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                aPayment.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                aPayment.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                aPayment.TotalAmount = Convert.ToDecimal(DB.DataTable.Rows[Index]["TotalAmount"]);
                mPaymentList.Add(aPayment);
                Index++;
            }
        }

    }

  


}

    
    
        

    