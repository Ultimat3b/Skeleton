using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;

namespace Testing6
{
    [TestClass]
    public class tstPayment
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsPayment Payment = new clsPayment();
            Assert.IsNotNull(Payment);

        }

        public void CustomerIDPropertyOK()
        {
            // Create an instance of the class we want to test
            clsPayment payment = new clsPayment();

            // Create some test data
            int testData = 12345;

            // Assign the data to the property
            payment.CustomerID = testData;

            // Test to see if the two values are the same
            Assert.AreEqual(payment.CustomerID, testData);
        }




        [TestMethod]
        public void OrderDatePropertyOK()
        {
            // Create an instance of the class we want to test
            clsPayment payment = new clsPayment();

            // Create some test data
            DateTime testData = DateTime.Now;

            // Assign the data to the property
            payment.OrderDate = testData;

            // Test to see if the two values are the same
            Assert.AreEqual(payment.OrderDate, testData);
        }

        [TestMethod]
        public void TotalAmountPropertyOK()
        {
            // Create an instance of the class we want to test
            clsPayment payment = new clsPayment();

            // Create some test data
            decimal testData = 50.00m;

            // Assign the data to the property
            payment.TotalAmount = testData;

            // Test to see if the two values are the same
            Assert.AreEqual(payment.TotalAmount, testData);
        }

        [TestMethod]
        public void OrderStatusPropertyOK()
        {
            // Create an instance of the class we want to test
            clsPayment payment = new clsPayment();

            bool testData = true;

            // Assign the data to the property
            payment.OrderStatus = testData;


            // Test to see if the two values are the same
            Assert.AreEqual(payment.OrderStatus, testData);
        }

        [TestMethod]
        public void OrderIDPropertyOK()
        {
            // Create an instance of the class we want to test
            clsPayment payment = new clsPayment();

            // Create some test data
            int testData = 100;

            // Assign the data to the property
            payment.OrderID = testData;

            // Test to see if the two values are the same
            Assert.AreEqual(payment.OrderID, testData);
        }

        public void FindMethodOk()
        {
            // Create an instance of the class we want to test
            clsPayment aPayment = new clsPayment();

            // Create some test data to use with the method
            Int32 OrderID = 1;

            // Call the Find method to search for the order with the specified ID
            Boolean Found = aPayment.Find(OrderID);

            // Check that the result is correct
            Assert.IsTrue(Found);
            Assert.AreEqual(OrderID, aPayment.OrderID);
        }


        [TestMethod]
        public void TestPaymentNoFound()
        {
            clsPayment aPayment = new clsPayment();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 21;
            Found = aPayment.Find(OrderID);
            if (aPayment.OrderID != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestDateAddedFound()
        {
            // Create an instance of the class we want to test
            clsPayment aPayment = new clsPayment();
            Boolean Found = false;
            Boolean OK = true;

            int OrderID = 21;
            Found = aPayment.Find(OrderID);

            if (aPayment.OrderDate != Convert.ToDateTime("16/9/2015"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);

           
        }

        public void TestOrderIDFound()
        {
            //create an instance of the class we want to test
            clsPayment aPayment = new clsPayment();
            //boolean variable to store the result of the search
            bool Found = false;
            //boolean variable to record if data is OK (assume it is)
            bool OK = true;
            //create some test data to use with the method
            Int32 OrderID = 21;
            //invoke the method
            Found = aPayment.Find(OrderID);
            //check the property
            if (aPayment.OrderID != OrderID)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to test
            clsPayment aPayment = new clsPayment();
            //boolean variable to store the result of the search
            bool Found = false;
            //boolean variable to record if data is OK (assume it is)
            bool OK = true;
            //create some test data to use with the method
            int OrderID = 21;
            //invoke the method
            Found = aPayment.Find(OrderID);
            //check the property
            if (aPayment.CustomerID != 12345)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
















    }
}

