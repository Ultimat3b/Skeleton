using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;


namespace Testing6
{
    [TestClass]
    public class tstPaymentCollection
    {
        public object TestPayment { get; private set; }
        public int SomeCount { get; private set; }

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
        public void AddMethodOK()
        {
            // Create an instance of the class we want to create
            clsPaymentCollection AllPayments = new clsPaymentCollection();

            // Create some test data to assign to the property
            clsPayment TestPayment = new clsPayment();
            Int32 PrimaryKey = 0;
            // Add an item to the list
            clsPayment TestItem = new clsPayment();
            TestPayment.OrderID = 1;
            TestPayment.OrderDate = DateTime.Now.Date;
            TestPayment.TotalAmount = 10.00m;
            TestPayment.CustomerID = 1;
            TestPayment.OrderStatus = true;


            // Assign the data to the property
            AllPayments.ThisPayment = TestPayment;
            PrimaryKey = AllPayments.Add();
            TestPayment.OrderID = PrimaryKey;
            AllPayments.ThisPayment.Find(PrimaryKey);
            // Test to see that the two values are the same
            Assert.AreEqual(AllPayments.ThisPayment, TestPayment);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            // Create an instance of the class we want to create
            clsPaymentCollection AllPayments = new clsPaymentCollection();

            // Create some test data to assign to the property
            clsPayment TestPayment = new clsPayment();
            Int32 PrimaryKey = 0;
            // Add an item to the list

            TestPayment.OrderID = 1;
            TestPayment.OrderDate = DateTime.Now.Date;
            TestPayment.TotalAmount = 10.00m;
            TestPayment.CustomerID = 1;
            TestPayment.OrderStatus = true;


            // Assign the data to the property
            AllPayments.ThisPayment = TestPayment;
            PrimaryKey = AllPayments.Add();
            TestPayment.OrderID = PrimaryKey;
            AllPayments.ThisPayment.Find(PrimaryKey);
            AllPayments.Delete();
            Boolean Found = AllPayments.ThisPayment.Find(PrimaryKey);
            // Test to see that the two values are the same
            Assert.IsFalse(Found);



        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            // Create an instance of the class we want to update
            clsPaymentCollection AllPayments = new clsPaymentCollection();

            // Create some test data to assign to the property
            clsPayment TestPayment = new clsPayment();
            Int32 PrimaryKey = 0;

            // Add an item to the list
            TestPayment.OrderID = 0;
            TestPayment.OrderDate = DateTime.Now.Date;
            TestPayment.TotalAmount = 10.00m;
            TestPayment.CustomerID = 1;
            TestPayment.OrderStatus = true;

            // Assign the data to the property
            AllPayments.ThisPayment = TestPayment;


            PrimaryKey = AllPayments.Add();
            TestPayment.OrderID =PrimaryKey;

            // Modify the data
            TestPayment.OrderDate = DateTime.Now.AddDays(-1).Date;
            TestPayment.TotalAmount = 20.00m;
            TestPayment.CustomerID = 2;
            TestPayment.OrderStatus = false;

            // Update the record in the database
            AllPayments.ThisPayment = TestPayment;
            AllPayments.Update();

            // Retrieve the updated record from the database
            AllPayments.ThisPayment.Find(PrimaryKey);

            // Test to see that the updated record matches the modified data
            Assert.AreEqual(AllPayments.ThisPayment, TestPayment);
        }


            [TestMethod]
        public void ThisPaymentPropertyOK()
        {
            // Create an instance of the class we want to create
            clsPaymentCollection AllPayments = new clsPaymentCollection();

            // Create some test data to assign to the property
            clsPayment TestPayment = new clsPayment();

            // Add an item to the list
            clsPayment TestItem = new clsPayment();
            TestPayment.OrderID = 1;
            TestPayment.OrderDate = DateTime.Now.Date;
            TestPayment.TotalAmount = 10.00m;
            TestPayment.CustomerID = 1;
            TestPayment.OrderStatus = true;
          

            // Assign the data to the property
            AllPayments.ThisPayment = TestPayment;

            // Test to see that the two values are the same
            Assert.AreEqual(AllPayments.ThisPayment, TestPayment);
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



    
        

        




    }
}
