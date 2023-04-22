using System;

public class clsPayment
{
    private int mOrderId;
    private DateTime mOrderDate;
    private decimal mTotalAmount;
    private int mCustomerID;

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




    public decimal TotalAmount { get; set; }
    public bool OrderStatus { get; set; }

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
            return mOrderId;
        }
        set
        {
            mOrderId = value;
        }
    }

    public bool Find(int orderID)
    {
        // code to find the order with the given orderID
        mOrderId = orderID;
        mOrderDate = Convert.ToDateTime("16/9/2015");
        mCustomerID = 12345; // replace with actual customer ID

        return true;
    }
}