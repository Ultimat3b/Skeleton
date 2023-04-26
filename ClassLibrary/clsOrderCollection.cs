using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        List<clsOrder> mOrderList = new List<clsOrder>();

        public clsOrderCollection()
        {
            clsOrder TestItem = new clsOrder();
            TestItem.OrderID = 1;
            TestItem.OrderNumber = 112451;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.DispatchDate = DateTime.Now.Date;
            TestItem.TotalAmount = 10.00m;
            TestItem.CustomerID = 1;
            TestItem.ProductID = 1;
            TestItem.OrderStatus = true;
            mOrderList.Add(TestItem);

            TestItem = new clsOrder();
            TestItem.OrderID = 2;
            TestItem.OrderNumber = 112455;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.DispatchDate = DateTime.Now.Date;
            TestItem.TotalAmount = 20.00m;
            TestItem.CustomerID = 2;
            TestItem.ProductID = 1;
            TestItem.OrderStatus = false;
            mOrderList.Add(TestItem);

            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_OrderProcess_SelectAll");
            RecordCount = DB.Count;

            while (Index < RecordCount)
            {
                clsOrder aOrder = new clsOrder();
                aOrder.OrderStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["OrderStatus"]);
                aOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                aOrder.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                aOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDate"]);
                aOrder.TotalAmount = Convert.ToDecimal(DB.DataTable.Rows[Index]["TotalAmount"]);
                aOrder.OrderNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["Order Number"]);
                aOrder.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["Product ID"]);
                aOrder.DispatchDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["Order Number"]);
                mOrderList.Add(aOrder);
                Index++;
            }
        }

        public List<clsOrder> OrderList
        {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }

        public int Count
        {
            get
            {
                return mOrderList.Count;
            }
        }

        public clsOrder ThisOrder { get; set; }

        public int Add(clsOrder order)
        {
            mOrderList.Add(order);
            return mOrderList.Count;
        }

        public void Delete(int index)
        {
            if (index >= 0 && index < mOrderList.Count)
            {
                mOrderList.RemoveAt(index);
            }
            else
            {
                throw new Exception("Invalid index specified.");
            }
        }
    }
}