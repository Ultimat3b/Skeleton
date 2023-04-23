using System;

public class clsPayment
{



    private int mOrderID;
    private DateTime mOrderDate;
    private decimal mTotalAmount;
    private int mCustomerID;
    private bool mOrderStatus;

    public DateTime OrderDate
    {
        get { return mOrderDate; }
        set { mOrderDate = value; }
    }

    public decimal TotalAmount
    {
        get { return mTotalAmount; }
        set { mTotalAmount = value; }
    }

    public bool OrderStatus
    {
        get { return mOrderStatus; }
        set { mOrderStatus = value; }
    }

    public int CustomerID
    {
        get { return mCustomerID; }
        set { mCustomerID = value; }
    }

    public int OrderID
    {
        get { return mOrderID; }
        set { mOrderID = value; }
    }

    public bool Find(int orderID)
    {
        clsDataConnection DB = new clsDataConnection();
        DB.AddParameter("@OrderID", orderID);
        DB.Execute("sproc_tblPaymentProcess_FilterByorderID");
        if (DB.Count == 1)
        {
            mOrderStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["Order Status"]);
            mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["Order ID"]);
            mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["Customer ID"]);
            mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Order Date"]);
            mTotalAmount = Convert.ToDecimal(DB.DataTable.Rows[0]["Total Amount"]);
            return true;
        }
        else
        {
            mOrderID = -1;
            return false;
        }
    }


}









