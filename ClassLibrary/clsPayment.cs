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
        get
        {
            return mOrderDate;
        }
        set
        {
            mOrderDate = value;
        }
    }




    public decimal TotalAmount
    {
        get
        {
            return mTotalAmount;
        }
        set
        {
            mTotalAmount = value;
        }
    }


    public bool OrderStatus
    {
        get
        {
            return mOrderStatus;
        }
        set
        {
            mOrderStatus = value;
        }
    }

    public int CustomerID
    {
        get
        {
            return mCustomerID;
        }
        set
        {
            mCustomerID = value;
        }


    }

    public int OrderID
    {
        get
        {
            return mOrderID;
        }
        set
        {
            mOrderID = value;
        }
    }

    public bool Find(int orderID)
    {
        clsDataConnection DB = new clsDataConnection();

        //add the parameter for the adress no to search for
        DB.AddParameter("@orderID", orderID);

        //execte the stored procedure
        DB.Execute("sproc_tblPaymentProcess_FilterByorderID");

        //if one record is found (there should be either 1 or 0)
        if (DB.Count == 1)
        {
            //copied the data from the database to the private data memebers

            mOrderStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["Order Status"]);
            mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["Order ID"]);
            mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["Customer ID"]);
            mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Order Date"]);
            mTotalAmount = Convert.ToDecimal(DB.DataTable.Rows[0]["Total Amount"]);
            // Always return True
            return true;
        }

        else
        {
            // return false indicating a problem 
            return false;
        }
    }







}


