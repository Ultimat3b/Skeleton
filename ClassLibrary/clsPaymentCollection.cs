using System;
using System.Collections.Generic;

namespace ClassLibrary
{

    



    public class clsPaymentCollection
    {

        
      
          
            List<clsPayment> mPaymentList = new List<clsPayment>();

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
                aPayment.OrderStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["Order Status"]);
                aPayment.OrderID = Convert.ToInt32(DB.DataTable.Rows[0]["Order ID"]);
                aPayment.CustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["Customer ID"]);
                aPayment.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Order Date"]);
                aPayment.TotalAmount = Convert.ToDecimal(DB.DataTable.Rows[0]["Total Amount"]);
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


        public clsPayment ThisPayment { get; set; }




        public int Add()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }
    }

    
    
        

    }