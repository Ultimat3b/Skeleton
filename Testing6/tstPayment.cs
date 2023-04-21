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

            // Create some test data
            string testData = "Paid";

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







    }
}

