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
            clsPayment TestItem = new clsPayment();
            TestItem.OrderID = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TotalAmount = 10.00m;
            TestItem.CustomerID = 1;
            TestItem.OrderStatus = true;
            mPaymentList.Add(TestItem);

            TestItem = new clsPayment();
            TestItem.OrderID = 2;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TotalAmount = 20.00m;
            TestItem.CustomerID = 2;
            TestItem.OrderStatus = false;
            mPaymentList.Add(TestItem);




            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_PaymentProcess_SelectAll");
            RecordCount = DB.Count;

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

            DB.AddParameter("@OrderID", mThisPayment.OrderID);
            DB.AddParameter("@OrderDate", mThisPayment.OrderDate);
            DB.AddParameter("@CustomerID", mThisPayment.CustomerID);
            DB.AddParameter("@TotalAmount", mThisPayment.TotalAmount);
            DB.AddParameter("@OrderStatus", mThisPayment.OrderStatus);
            
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblPayment_Insert");


        }


                


                
        
    

        public void Delete()
        {
            throw new NotImplementedException();
        }
    }

    
    
        

    }