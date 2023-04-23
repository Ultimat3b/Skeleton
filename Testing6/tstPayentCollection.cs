using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;


namespace Testing6
{
    [TestClass]
    public class tstPaymentCollection
    {

        [TestMethod]
        public void PaymentListOK()
        {
            // Create an instance of the class we want to test
            clsPaymentCollection AllPayments = new clsPaymentCollection();

            // Create some test data to assign to the property
            // Data needs to be a list of objects
            List<clsPayment> TestList = new List<clsPayment>();

            // Add an item to the list
            // Create the item of test data
            clsPayment TestItem = new clsPayment();

            // Set its properties
            TestItem.OrderID = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.CustomerID = 1;
            TestItem.TotalAmount = 10.00m;
            TestItem.OrderStatus = true;

            // Add the item to the test list
            TestList.Add(TestItem);

            // Assign the data to the property
            AllPayments.PaymentList = TestList;

            // Test to see that the two values are the same
            Assert.AreEqual(AllPayments.PaymentList, TestList);
        }



        [TestMethod]
        public void ListAndCountOK()
        {
            // Create an instance of the class we want to create
            clsPaymentCollection AllPayments = new clsPaymentCollection();

            // Create some test data to assign to the property
            List<clsPayment> TestList = new List<clsPayment>();

            // Add an item to the list
            clsPayment TestItem = new clsPayment();
            TestItem.OrderID = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TotalAmount = 10.00m;
            TestItem.CustomerID = 1;
            TestItem.OrderStatus = true;
            TestList.Add(TestItem);

            // Assign the data to the property
            AllPayments.PaymentList = TestList;

            // Test to see that the two values are the same
            Assert.AreEqual(AllPayments.Count, TestList.Count);
        }



        [TestMethod]
        public void TwoRecordsPresent()
        {
            clsPaymentCollection AllPayments = new clsPaymentCollection();

            // Add two payments to PaymentList
            clsPayment TestItem1 = new clsPayment();
            TestItem1.OrderID = 1;
            TestItem1.OrderDate = DateTime.Now.Date;
            TestItem1.TotalAmount = 10.00m;
            TestItem1.CustomerID = 1;
            TestItem1.OrderStatus = true;
            AllPayments.PaymentList.Add(TestItem1);

            clsPayment TestItem2 = new clsPayment();
            TestItem2.OrderID = 2;
            TestItem2.OrderDate = DateTime.Now.Date;
            TestItem2.TotalAmount = 20.00m;
            TestItem2.CustomerID = 2;
            TestItem2.OrderStatus = false;
            AllPayments.PaymentList.Add(TestItem2);

            // Assert that the count of PaymentList is 2
            Assert.AreEqual(AllPayments.Count, 2);
        }

        
        


    }
}
