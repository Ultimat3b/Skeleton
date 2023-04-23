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
            int orderID = 21;

            bool found = aPayment.Find(orderID);
            bool ok = !found && aPayment.OrderID == -1;

            Assert.IsTrue(ok, "Payment with ID " + orderID + " should not have been found.");
        }







        [TestMethod]
        public void TestDateAddedNotFound()
        {
            // Create an instance of the class we want to test
            clsPayment aPayment = new clsPayment();

            // Boolean variable to store the result of the search
            bool Found = false;

            // Boolean variable to record if data is OK (assume it is)
            bool OK = true;

            // Create some test data to use with the method
            int OrderID = -1;

            // Invoke the method to search for the order with the specified ID
            Found = aPayment.Find(OrderID);

            // Check that the DateAdded property is not found
            if (Found == true && aPayment.OrderDate != null)
            {
                OK = false;
            }

            // Test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestOrderIDNotFound()
        {
            // Create an instance of the class we want to test
            clsPayment aPayment = new clsPayment();

            // Boolean variable to store the result of the search
            bool Found = false;

            // Boolean variable to record if data is OK (assume it is)
            bool OK = true;

            // Create some test data to use with the method
            int OrderID = -1;

            // Invoke the method to search for the order with the specified ID
            Found = aPayment.Find(OrderID);

            // Check that the result is not found
            if (Found == true)
            {
                OK = false;
            }

            // Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerIDNotFound()
        {
            // Create an instance of the class we want to test
            clsPayment aPayment = new clsPayment();

            // Boolean variable to store the result of the search
            bool Found = false;

            // Boolean variable to record if data is OK (assume it is)
            bool OK = true;

            // Create some test data to use with the method
            int OrderID = -1;

            // Invoke the method to search for the order with the specified ID
            Found = aPayment.Find(OrderID);

            // Check that the CustomerID property is not found
            if (Found == true && aPayment.CustomerID != null)
            {
                OK = false;
            }

            // Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderStatusNotFound()
        {
            // Create an instance of the class we want to test
            clsPayment aPayment = new clsPayment();

            // Boolean variable to store the result of the search
            bool Found = false;

            // Boolean variable to record if data is OK (assume it is)
            bool OK = true;

            // Create some test data to use with the method
            int OrderID = -1;

            // Invoke the method to search for the order with the specified ID
            Found = aPayment.Find(OrderID);

            // Check that the OrderStatus property is not found
            if (Found == true && aPayment.OrderStatus != true)
            {
                OK = false;
            }

            // Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTotalAmountNotFound()
        {
            // Create an instance of the class we want to test
            clsPayment aPayment = new clsPayment();

            // Boolean variable to store the result of the search
            bool Found = false;

            // Boolean variable to record if data is OK (assume it is)
            bool OK = true;

            // Create some test data to use with the method
            int OrderID = 999;

            // Invoke the method to search for the order with the specified ID
            Found = aPayment.Find(OrderID);

            // Check that the order was not found
            if (Found == true)
            {
                OK = false;
            }

            // Test to see that the result is correct
            Assert.IsTrue(OK);
        }







    }
}

