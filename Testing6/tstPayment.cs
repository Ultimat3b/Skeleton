using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;

namespace Testing6
{
    [TestClass]
    public class tstPayment
    {

        string OrderID = "1";
        string OrderDate = DateTime.Now.Date.ToString();
        string CustomerID = "12345";
        string OrderStatus = "Pending";
        string TotalAmount = "100.00";

        [TestMethod]
        public void ValidMethodOK()
        {
            // create an instance of the class we want to test
            clsPayment aPayment = new clsPayment();
            // String variable to store any error message 
            string Error = "";
            // invoke the method 
            Error = aPayment.Valid(1, DateTime.Now, "C001", 10.00m, "Processing");

            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void OrderIDExtremeMin()
        {
            // create an instance of the class we want to test
            clsPayment aPayment = new clsPayment();
            // String variable to store any error message 
            string Error = "";
            // create some test data to pass the method
            int OrderID = -10000000;
            // invoke the method
            Error = aPayment.Valid(OrderID, DateTime.Now, "C001", 10.00m, "Processing");
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateExtremeMin()
        {
            // create an instance of the class we want to test
            clsPayment aPayment = new clsPayment();
            // String variable to store any error message 
            string Error = "";
            // create some test data to pass the method
            DateTime OrderDate = DateTime.MinValue;
            // invoke the method
            Error = aPayment.Valid(1, OrderDate, "C001", 10.00m, "Processing");
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusExtremeMin()
        {
            // create an instance of the class we want to test
            clsPayment aPayment = new clsPayment();
            // String variable to store any error message 
            string Error = "";
            // create some test data to pass the method
            string OrderStatus = "";
            // invoke the method
            Error = aPayment.Valid(1, DateTime.Now, "C001", 10.00m, OrderStatus);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalAmountExtremeMin()
        {
            // create an instance of the class we want to test
            clsPayment aPayment = new clsPayment();
            // String variable to store any error message 
            string Error = "";
            // create some test data to pass the method
            decimal TotalAmount = decimal.MinValue;
            // invoke the method
            Error = aPayment.Valid(1, DateTime.Now, "C001", TotalAmount, "Processing");
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerIDExtremeMin()
        {
            // create an instance of the class we want to test
            clsPayment aPayment = new clsPayment();
            // String variable to store any error message 
            string Error = "";
            // create some test data to pass the method
            string CustomerID = "";
            // invoke the method
            Error = aPayment.Valid(1, DateTime.Now, CustomerID, 10.00m, "Processing");
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDMinLessOne()
        {
            // create an instance of the class we want to test
            clsPayment aPayment = new clsPayment();
            // String variable to store any error message 
            string Error = "";
            // create some test data to pass the method
            string CustomerID = "";
            // invoke the method
            Error = aPayment.Valid(1, DateTime.Now, CustomerID, 10.00m, "Processing");
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateMinLessOne()
        {
            // create an instance of the class we want to test
            clsPayment aPayment = new clsPayment();
            // String variable to store any error message 
            string Error = "";
            // create some test data to pass the method
            string OrderDate = "01/01/0001";
            // invoke the method
            Error = aPayment.Valid(1, DateTime.Parse(OrderDate), "C001", 10.00m, "Processing");
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TotalAmountMinLessOne()
        {
            // create an instance of the class we want to test
            clsPayment aPayment = new clsPayment();
            // String variable to store any error message 
            string Error = "";
            // create some test data to pass the method
            decimal TotalAmount = -0.01m;
            // invoke the method
            Error = aPayment.Valid(1, DateTime.Now, "C001", TotalAmount, "Processing");
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderStatusMinLessOne()
        {
            // create an instance of the class we want to test
            clsPayment aPayment = new clsPayment();
            // String variable to store any error message 
            string Error = "";
            // create some test data to pass the method
            string OrderStatus = "";
            // invoke the method
            Error = aPayment.Valid(1, DateTime.Now, "C001", 10.00m, OrderStatus);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }






        [TestMethod]
        
        public void OrderIDMinLessOne()
        {
            // create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            // String Variable to store any error message 
            String Error = "";
            // create a test to pass the method
            int OrderID = -1; // change to int
                              // invoke the method
            Error = aPayment.Valid(OrderID, DateTime.Now, "C001", 10.00m, "Processing"); // pass OrderID as int
                                                                                         //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }





        [TestMethod]
        public void OrderIDMin()
        {
            // create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            // String Variable to store any error message 
            String Error = "";
            // create a test to pass the method
            int OrderID = 0;
            // invoke the method
            Error = aPayment.Valid(OrderID, DateTime.Now, "C001", 10.00m, "Processing");
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDMin()
        {
            // create an instance of the class we want to test
            clsPayment aPayment = new clsPayment();
            // String variable to store any error message 
            string Error = "";
            // create some test data to pass the method
            string CustomerID = "";
            // invoke the method
            Error = aPayment.Valid(1, DateTime.Now, CustomerID, 10.00m, "Processing");
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateMin()
        {
            // create an instance of the class we want to test
            clsPayment aPayment = new clsPayment();
            // String variable to store any error message 
            string Error = "";
            // create some test data to pass the method
            DateTime OrderDate = DateTime.MinValue;
            // invoke the method
            Error = aPayment.Valid(1, OrderDate, "C001", 10.00m, "Processing");
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TotalAmountMin()
        {
            // create an instance of the class we want to test
            clsPayment aPayment = new clsPayment();
            // String variable to store any error message 
            string Error = "";
            // create some test data to pass the method
            decimal TotalAmount = decimal.MinValue;
            // invoke the method
            Error = aPayment.Valid(1, DateTime.Now, "C001", TotalAmount, "Processing");
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderStatusMin()
        {
            // create an instance of the class we want to test
            clsPayment aPayment = new clsPayment();
            // String variable to store any error message 
            string Error = "";
            // create some test data to pass the method
            string OrderStatus = "";
            // invoke the method
            Error = aPayment.Valid(1, DateTime.Now, "C001", 10.00m, OrderStatus);
            // test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void OrderIDMinPlusOne()
        {
            // create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            // String Variable to store any error message 
            String Error = "";
            // create a test to pass the method
            int OrderID = 1;
            // invoke the method
            Error = aPayment.Valid(OrderID, DateTime.Now, "C001", 10.00m, "Processing");
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDMinPlusOne()
        {
            // create an instance of the class we want to test
            clsPayment aPayment = new clsPayment();
            // String variable to store any error message 
            string Error = "";
            // create some test data to pass the method
            string CustomerID = "1";
            // invoke the method
            Error = aPayment.Valid(1, DateTime.Now, CustomerID, 10.00m, "Processing");
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateMinPlusOne()
        {
            // create an instance of the class we want to test
            clsPayment aPayment = new clsPayment();
            // String variable to store any error message 
            string Error = "";
            // create some test data to pass the method
            string OrderDate = DateTime.Now.AddDays(1).Date.ToString();
            // invoke the method
            Error = aPayment.Valid(1, DateTime.Parse(OrderDate), "C001", 10.00m, "Processing");
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TotalAmountMinPlusOne()
        {
            // create an instance of the class we want to test
            clsPayment aPayment = new clsPayment();
            // String variable to store any error message 
            string Error = "";
            // create some test data to pass the method
            decimal TotalAmount = 0.01m;
            // invoke the method
            Error = aPayment.Valid(1, DateTime.Now, "C001", TotalAmount, "Processing");
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderStatusMinPlusOne()
        {
            // create an instance of the class we want to test
            clsPayment aPayment = new clsPayment();
            // String variable to store any error message 
            string Error = "";
            // create some test data to pass the method
            string OrderStatus = "Processed";
            // invoke the method
            Error = aPayment.Valid(1, DateTime.Now, "C001", 10.00m, OrderStatus);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void OrderIDMaxLessOne()
        {
            // create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            // String Variable to store any error message 
            String Error = "";
            // create a test to pass the method
            int OrderID = 2147483646;
            // invoke the method
            Error = aPayment.Valid(OrderID, DateTime.Now, "C001", 10.00m, "Processing");
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMaxLessOne()
        {
            // create an instance of the class we want to test
            clsPayment aPayment = new clsPayment();
            // String variable to store any error message 
            string Error = "";
            // create some test data to pass the method
            string CustomerID = new string('9', 49);
            // invoke the method
            Error = aPayment.Valid(1, DateTime.Now, CustomerID, 99999.99m, "Processing");
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMaxLessOne()
        {
            // create an instance of the class we want to test
            clsPayment aPayment = new clsPayment();
            // String variable to store any error message 
            string Error = "";
            // create some test data to pass the method
            DateTime OrderDate = DateTime.MaxValue.AddDays(-1);
            // invoke the method
            Error = aPayment.Valid(1, OrderDate, "C001", 99999.99m, "Processing");
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalAmountMaxLessOne()
        {
            // create an instance of the class we want to test
            clsPayment aPayment = new clsPayment();
            // String variable to store any error message 
            string Error = "";


        }


            [TestMethod]
        public void OrderIDMid()
        {
            clsPayment aPayment = new clsPayment();
            // String Variable to store any error message 
            String Error = "";
            // create a test to pass the method
            int OrderID = 2147483646;

            Error = aPayment.Valid(OrderID, DateTime.Now, "C001", 10.00m, "Processing");
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerIDMid()
        {
            // create an instance of the class we want to test
            clsPayment aPayment = new clsPayment();
            // String variable to store any error message 
            string Error = "";
            // create some test data to pass the method
            string CustomerID = "C" + new string('0', 48) + "1";
            // invoke the method
            Error = aPayment.Valid(1, DateTime.Now, CustomerID, 9999.99m, "Processing");
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMid()
        {
            // create an instance of the class we want to test
            clsPayment aPayment = new clsPayment();
            // String variable to store any error message 
            string Error = "";
            // create some test data to pass the method
            DateTime OrderDate = DateTime.Now;
            // invoke the method
            Error = aPayment.Valid(1, OrderDate, "C001", 999.99m, "Processing");
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalAmountMid()
        {
            // create an instance of the class we want to test
            clsPayment aPayment = new clsPayment();
            // String variable to store any error message 
            string Error = "";
            // create some test data to pass the method
            decimal TotalAmount = 999999999.99m / 2;
            // invoke the method
            Error = aPayment.Valid(1, DateTime.Now, "C001", 999.99m, "Processing");
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusMid()
        {
            // create an instance of the class we want to test
            clsPayment aPayment = new clsPayment();
            // String variable to store any error message 
            string Error = "";
            // create some test data to pass the method
            string OrderStatus = "P" + new string('0', 48) + "1";
            // invoke the method
            Error = aPayment.Valid(1, DateTime.Now, "C001", 9999.99m, OrderStatus);
            // test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIDInvalidData()
        {
            // create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            // String variable to store any error message 
            string Error = "";
            //create some test to pass the method
            int OrderID = -1; // setting an invalid value
                              // invoke the method
            Error = aPayment.Valid(OrderID, DateTime.Now, "C001", 9999.99m, "Processing");
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        

        [TestMethod]
        public void TotalAmountInvalidData()
        {
            // create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            // String variable to store any error message 
            string Error = "";
            //create some test to pass the method
            decimal TotalAmount = -10.00m;
            // invoke the method
            Error = aPayment.Valid(1, DateTime.Now, "C001", TotalAmount, "Processing");
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerIDInvalidData()
        {
            // create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            // String variable to store any error message 
            string Error = "";
            //create some test to pass the method
            string CustomerID = new string('X', 11); // 11 is the max length for CustomerID
                                                     // invoke the method
            Error = aPayment.Valid(1, DateTime.Now, CustomerID, 9999.99m, "Processing");
            //test to see that the result is correct
            Assert.AreNotEqual(Error,"The customer ID should not be more than 10 characters");
        }

        [TestMethod]
        public void OrderDateInvalidData()
        {
            // create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            // String variable to store any error message 
            string Error = "";
            //create some test to pass the method
            DateTime OrderDate = DateTime.MaxValue;
            // invoke the method
            Error = aPayment.Valid(1, OrderDate, "C001", 9999.99m, "Processing");
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderStatusInvalidData()
        {
            // create an instance of the class we want to create
            clsPayment aPayment = new clsPayment();
            // String variable to store any error message 
            string Error = "";
            //create some test to pass the method
            string OrderStatus = new string('X', 51); // 50 is the max length for OrderStatus
                                                      // invoke the method
            Error = aPayment.Valid(1, DateTime.Now, "C001", 9999.99m, OrderStatus);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }






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

