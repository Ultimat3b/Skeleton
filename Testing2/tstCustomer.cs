using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        //good test data
        private string strngTest = "Charliechaplin";
      
        [TestMethod]
        public void InstanceOK() 
            //this method is to test if we can make an instance of class Customer
            //ie a customer object
        {
            clsCustomer aCustomer = new clsCustomer();
            Assert.IsNotNull(aCustomer);
        }

        [TestMethod]
        public void CustomerIdOK()

        {
            clsCustomer aCustomer = new clsCustomer();
            Int32 TestData = 1;
            aCustomer.CustomerId = TestData;
            Assert.AreEqual(aCustomer.CustomerId, TestData);
        }

        [TestMethod]
        public void CustomerFirstNameOK()
       
        {
            clsCustomer aCustomer = new clsCustomer();
            string TestData = strngTest;
            aCustomer.CustomerFirstName = TestData;
            Assert.AreEqual(aCustomer.CustomerFirstName, TestData);
        }

        [TestMethod]
        public void CustomerSurnameOK()

        {
            clsCustomer aCustomer = new clsCustomer();
            string TestData = strngTest;
            aCustomer.CustomerSurname = TestData;
            Assert.AreEqual(aCustomer.CustomerSurname, TestData);
        }

        [TestMethod]
        public void CustomerEmailOK()

        {
            clsCustomer aCustomer = new clsCustomer();
            string TestData = strngTest;
            aCustomer.CustomerEmail = TestData;
            Assert.AreEqual(aCustomer.CustomerEmail, TestData);
        }

        [TestMethod]
        public void CustomerPhoneNumberOK()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create some test data to assign to the Customer
            float TestData = 07798389043;
            //assign the data to the Customer
            aCustomer.CustomerPhoneNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCustomer.CustomerPhoneNumber, TestData);
        }

        [TestMethod]
        public void DateAddedOK() 
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create some test data to assign to the Customer
            DateTime TestData = DateTime.Now.Date;
            //assihm the data to the Customer
            aCustomer.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCustomer.DateAdded, TestData);
        }

        [TestMethod]
        public void ReturnCustomerOK()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create some test data to assign to the Customer
            bool TestData = true;
            //assign the data to the Customer
            aCustomer.ReturnCustomer = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCustomer.ReturnCustomer, TestData);
        }

        [TestMethod]
        public void ValidOK()
     
        {
            clsCustomer aCustomer = new clsCustomer();
            string Error = "";
            string TestData = strngTest;
            Error = aCustomer.Valid(strngTest);
            Assert.AreEqual(Error, "");
        }

        /*
        [TestMethod]

        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create 
            clsCustomer aCustomer = new clsCustomer();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string CustomeFirstName = "Thomas";
            string CustomerSurname = "Jones";
            int CustomerID = 10093;
            string CustomerEmail = "t.jones@email.com";
            string = DateAdded = "this is not a date";
            //invoke the method
            Error = aCustomer.Valid(CustomeFirstName, CustomerSurname, 
                CustomerID, CustomerEmail, DateAdded);
            // test to see the result is correct
            Assert.AreNotEqual(Error, "");
        } */


        [TestMethod]
        public void MinLessOne()
        
        {
            clsCustomer aCustomer = new clsCustomer();
            string Error = "";
            string TestData = "";
            Error = aCustomer.Valid(TestData);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void MaxPlusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            string Error = "";
            string TestData = "";
            TestData = TestData.PadLeft(51, '*');
            Error = aCustomer.Valid(TestData);
            Assert.AreNotEqual(Error, "");
        }
    }
}
