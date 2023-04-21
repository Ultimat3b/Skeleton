using System;

namespace ClassLibrary
{
    public class clsPayment
    {
       
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public bool OrderStatus { get; set; }
        public int CustomerID { get; set; }
        public int OrderID { get; set; }
    }
}