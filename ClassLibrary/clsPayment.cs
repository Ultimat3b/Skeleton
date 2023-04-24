using System;
using System.Collections.Generic;

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

    public int PaymentID { get; set; }

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
    public string Valid(int OrderID, DateTime OrderDate, string CustomerID, decimal TotalAmount, string OrderStatus)
    {
        string Error = "";
        DateTime DateTemp;
        decimal AmountTemp;

        try
        {
            if (OrderID < 0)
            {
                Error = Error + "The order ID must be at least 0 : ";
            }
        }
        catch (OverflowException)
        {
            Error = Error + "The order ID is too high : ";
        }

        try
        {
            DateTemp = OrderDate;
            if (DateTemp < DateTime.Now.Date)
            {
                Error = Error + "The order date cannot be in the past : ";
            }
            else if (DateTemp > DateTime.Now.Date.AddYears(1))
            {
                Error = Error + "The order date cannot be more than one year in the future : ";
            }
        }
        catch
        {
            Error = Error + "The order date was not a valid date : ";
        }

        if (string.IsNullOrWhiteSpace(CustomerID))
        {
            Error = Error + "The customer ID should not be left blank : ";
        }
        else if (CustomerID.Length > 10)
        {
            Error = Error + "The customer ID should not be more than 10 characters : ";
        }

        try
        {
            AmountTemp = TotalAmount;
            if (AmountTemp < 0)
            {
                Error = Error + "The total amount cannot be negative : ";
            }
            if (AmountTemp > 1000000.00m)
            {
                Error = Error + "The total amount must be below 1000000.00 : ";
            }
        }
        catch
        {
            Error = Error + "The total amount was not a valid number : ";
        }

        if (string.IsNullOrWhiteSpace(OrderStatus))
        {
            Error = Error + "The order status should not be left blank : ";
        }
        if (OrderStatus.Length > 50)
        {
            Error = Error + "The order status should not be more than 50 characters : ";
        }

        return Error;
    }

    public static implicit operator List<object>(clsPayment v)
    {
        throw new NotImplementedException();
    }
}