﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        //good test data
        //create some test data to pass to the method
        string StockAmount = "500";
        string StockDate = DateTime.Now.Date.ToString();
        string StockLocation = "Leicester";
        string StockName = "T-shirt";
        string StockPrice = "5";
        // hi

        [TestMethod]
        public void ValidMethodOK()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            // String Variable to store any error message 
            String Error = "";
            // invoke message 
            Error = AnStock.Valid(StockAmount, StockDate, StockLocation, StockName, StockPrice);

            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        // /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        [TestMethod]
        public void StockAmountExtremeMin()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            // String Variable to store any error message 
            String Error = "";
            //create some test to pass the method
            string StockAmount = "-10000000";// this should fail
            // invoke the method
            Error = AnStock.Valid(StockAmount, StockDate, StockLocation, StockName, StockPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockAmountMinLessOne()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            // String Variable to store any error message 
            String Error = "";
            //create some test to pass the method
            string StockAmount = "-1";// this should fail
            // invoke the method
            Error = AnStock.Valid(StockAmount, StockDate, StockLocation, StockName, StockPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockAmountMin()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            // String Variable to store any error message 
            String Error = "";
            //create some test to pass the method
            string StockAmount = "0";// this should be ok
            // invoke the method
            Error = AnStock.Valid(StockAmount, StockDate, StockLocation, StockName, StockPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockAmountMinPlusone()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            // String Variable to store any error message 
            String Error = "";
            //create some test to pass the method
            string StockAmount = "1";// this should be ok
            // invoke the method
            Error = AnStock.Valid(StockAmount, StockDate, StockLocation, StockName, StockPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockAmountMaxLessOne()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            // String Variable to store any error message 
            String Error = "";
            //create some test to pass the method
            string StockAmount = "2147483646";// this should be ok
            // invoke the method
            Error = AnStock.Valid(StockAmount, StockDate, StockLocation, StockName, StockPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockAmountMax()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            // String Variable to store any error message 
            String Error = "";
            //create some test to pass the method
            string StockAmount = "2147483647";// this should be ok
            // invoke the method
            Error = AnStock.Valid(StockAmount, StockDate, StockLocation, StockName, StockPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockAmountMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            // String Variable to store any error message 
            String Error = "";
            //create some test to pass the method
            string StockAmount = "2147483648";
            // invoke the method
            Error = AnStock.Valid(StockAmount, StockDate, StockLocation, StockName, StockPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockAmountMid()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            // String Variable to store any error message 
            String Error = "";
            //create some test to pass the method
            string StockAmount = "1073741824";// this should be ok
            // invoke the method
            Error = AnStock.Valid(StockAmount, StockDate, StockLocation, StockName, StockPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockAmountInvalidData()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            // String Variable to store any error message 
            String Error = "";
            //create some test to pass the method
            string StockAmount = "not a number";// this should be fail
            // invoke the method
            Error = AnStock.Valid(StockAmount, StockDate, StockLocation, StockName, StockPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void NameMinLessOne()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            // String Variable to store any error message 
            String Error = "";
            //create some test to pass the method
            string StockName = "";// this should fail
            // invoke the method
            Error = AnStock.Valid(StockAmount, StockDate, StockLocation, StockName, StockPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void NameMin()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            // String Variable to store any error message 
            String Error = "";
            //create some test to pass the method
            string StockName = "a";// this should be ok
            // invoke the method
            Error = AnStock.Valid(StockAmount, StockDate, StockLocation, StockName, StockPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameMinPlusOne()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            // String Variable to store any error message 
            String Error = "";
            //create some test to pass the method
            string StockName = "aa";// this should be ok
            // invoke the method
            Error = AnStock.Valid(StockAmount, StockDate, StockLocation, StockName, StockPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameMaxLessOne()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            // String Variable to store any error message 
            String Error = "";
            //create some test to pass the method
            string StockName = "";
            StockName = StockName.PadRight(49, 'a');// this should be ok
            // invoke the method
            Error = AnStock.Valid(StockAmount, StockDate, StockLocation, StockName, StockPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameMax()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            // String Variable to store any error message 
            String Error = "";
            //create some test to pass the method
            string StockName = "";
            StockName = StockName.PadRight(50, 'a');// this should be ok
            // invoke the method
            Error = AnStock.Valid(StockAmount, StockDate, StockLocation, StockName, StockPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            // String Variable to store any error message 
            String Error = "";
            //create some test to pass the method
            string StockName = "";
            StockName = StockName.PadRight(51, 'a');// this should fail
            // invoke the method
            Error = AnStock.Valid(StockAmount, StockDate, StockLocation, StockName, StockPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void NameMid()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            // String Variable to store any error message 
            String Error = "";
            //create some test to pass the method
            string StockName = "";
            StockName = StockName.PadRight(25, 'a');// this should be ok
            // invoke the method
            Error = AnStock.Valid(StockAmount, StockDate, StockLocation, StockName, StockPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void NameExtremeMax()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            // String Variable to store any error message 
            String Error = "";
            //create some test to pass the method
            string StockName = "";
            StockName = StockName.PadRight(200, 'a');// this should fail
            // invoke the method
            Error = AnStock.Valid(StockAmount, StockDate, StockLocation, StockName, StockPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMin()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            // String Variable to store any error message 
            String Error = "";
            //create a variable to store the test data data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variables to a string variable 
            string StockDate = TestDate.ToString();
            // invoke the method
            Error = AnStock.Valid(StockAmount, StockDate, StockLocation, StockName, StockPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string StockDate = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(StockAmount, StockDate, StockLocation, StockName, StockPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string StockDate = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(StockAmount, StockDate, StockLocation, StockName, StockPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string StockDate = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(StockAmount, StockDate, StockLocation, StockName, StockPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string StockDate = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(StockAmount, StockDate, StockLocation, StockName, StockPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //convert the date variable to a string variable
            string StockDate = "this is not a date";
            //invoke the method
            Error = AnStock.Valid(StockAmount, StockDate, StockLocation, StockName, StockPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockLocationMinLessOne()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            // String Variable to store any error message 
            String Error = "";
            //create some test to pass the method
            string StockLocation = "";// this should fail
            // invoke the method
            Error = AnStock.Valid(StockAmount, StockDate, StockLocation, StockName, StockPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockLocationMin()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            // String Variable to store any error message 
            String Error = "";
            //create some test to pass the method
            string StockLocation = "a";// this should be ok
            // invoke the method
            Error = AnStock.Valid(StockAmount, StockDate, StockLocation, StockName, StockPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockLocationMinPlusone()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            // String Variable to store any error message 
            String Error = "";
            //create some test to pass the method
            string StockLocation = "aa";// this should be ok
            // invoke the method
            Error = AnStock.Valid(StockAmount, StockDate, StockLocation, StockName, StockPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockLocationMaxLessOne()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            // String Variable to store any error message 
            String Error = "";
            //create some test to pass the method
            string StockLocation = "";
            StockLocation = StockLocation.PadRight(49, 'a');// this should pass
            // invoke the method
            Error = AnStock.Valid(StockAmount, StockDate, StockLocation, StockName, StockPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockLocationMax()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            // String Variable to store any error message 
            String Error = "";
            //create some test to pass the method
            string StockLocation = "";
            StockLocation = StockLocation.PadRight(50, 'a');// this should pass
            // invoke the method
            Error = AnStock.Valid(StockAmount, StockDate, StockLocation, StockName, StockPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockLocationMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            // String Variable to store any error message 
            String Error = "";
            //create some test to pass the method
            string StockLocation = "";
            StockLocation = StockLocation.PadRight(51, 'a');// this should fail
            // invoke the method
            Error = AnStock.Valid(StockAmount, StockDate, StockLocation, StockName, StockPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockLocationMid()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            // String Variable to store any error message 
            String Error = "";
            //create some test to pass the method
            string StockLocation = "";
            StockLocation = StockLocation.PadRight(25, 'a');// this should pass
            // invoke the method
            Error = AnStock.Valid(StockAmount, StockDate, StockLocation, StockName, StockPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockLocationExtremeMax()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            // String Variable to store any error message 
            String Error = "";
            //create some test to pass the method
            string StockLocation = "";
            StockLocation = StockLocation.PadRight(200, 'a');// this should pass
            // invoke the method
            Error = AnStock.Valid(StockAmount, StockDate, StockLocation, StockName, StockPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockPriceExtremeMin()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            // String Variable to store any error message 
            String Error = "";
            //create some test to pass the method
            string StockPrice = "-1000000000";// this should fail
            // invoke the method
            Error = AnStock.Valid(StockAmount, StockDate, StockLocation, StockName, StockPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockPriceMinLessOne()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            // String Variable to store any error message 
            String Error = "";
            //create some test to pass the method
            string StockPrice = "-1";// this should fail
            // invoke the method
            Error = AnStock.Valid(StockAmount, StockDate, StockLocation, StockName, StockPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockPriceMin()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            // String Variable to store any error message 
            String Error = "";
            //create some test to pass the method
            string StockPrice = "0";// this should be ok
            // invoke the method
            Error = AnStock.Valid(StockAmount, StockDate, StockLocation, StockName, StockPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockPriceMinPlusone()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            // String Variable to store any error message 
            String Error = "";
            //create some test to pass the method
            string StockPrice = "1";// this should be ok
            // invoke the method
            Error = AnStock.Valid(StockAmount, StockDate, StockLocation, StockName, StockPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockPriceMaxLessOne()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            // String Variable to store any error message 
            String Error = "";
            //create some test to pass the method
            string StockPrice = "999999";// this should be ok
            // invoke the method
            Error = AnStock.Valid(StockAmount, StockDate, StockLocation, StockName, StockPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockPriceMax()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            // String Variable to store any error message 
            String Error = "";
            //create some test to pass the method
            string StockPrice = "1000000";// this should be ok
            // invoke the method
            Error = AnStock.Valid(StockAmount, StockDate, StockLocation, StockName, StockPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockPriceMaxPlusOne()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            // String Variable to store any error message 
            String Error = "";
            //create some test to pass the method
            string StockPrice = "1000001";
            // invoke the method
            Error = AnStock.Valid(StockAmount, StockDate, StockLocation, StockName, StockPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StockPriceMid()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            // String Variable to store any error message 
            String Error = "";
            //create some test to pass the method
            string StockPrice = "500000";// this should be ok
            // invoke the method
            Error = AnStock.Valid(StockAmount, StockDate, StockLocation, StockName, StockPrice);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StockPriceInvalidData()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            // String Variable to store any error message 
            String Error = "";
            //create some test to pass the method
            string StockPrice = "not a number";
            // invoke the method
            Error = AnStock.Valid(StockAmount, StockDate, StockLocation, StockName, StockPrice);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        // /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        [TestMethod]
        public void InstanceOK()
        {
            // create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            // test to see that it exist
            Assert.IsNotNull(AnStock);
        }
        [TestMethod] // dont need this method but just check 
        public void ActivePropertOk()
        {
            //create an instance of class we want to create
            clsStock Anstock = new clsStock();
            // create some test data
            Boolean TestData = true;
            //assign the data to the property
            Anstock.Active = TestData;
            //test to see if the two values are the same 
            Assert.AreEqual(Anstock.Active, TestData);
        }
        [TestMethod]
        public void tstStockID()
        {
            clsStock Anstock = new clsStock();
            int TestData = 123;
            Anstock.StockID = TestData;
            Assert.AreEqual(Anstock.StockID, TestData);
        }
        [TestMethod]
        public void tstStockName()
        {
            clsStock Anstock = new clsStock();
            string TestData = "Hat";
            Anstock.Name = TestData;
            Assert.AreEqual(Anstock.Name, TestData);
        }
        [TestMethod]
        public void tstStockLocation()
        {
            clsStock Anstock = new clsStock();
            string TestData = "Leicester";
            Anstock.Location = TestData;
            Assert.AreEqual(Anstock.Location, TestData);
        }
        [TestMethod]
        public void tstStockDate()
        {
            //create an instance of class we want to create
            clsStock Anstock = new clsStock();
            //create some data to assign to property
            DateTime TestData = DateTime.Now.Date;
            // assign the data to property 
            Anstock.DateAdded = TestData;
            // test to check both values are the same
            Assert.AreEqual(Anstock.DateAdded, TestData);
        }
        [TestMethod]
        public void tstStockPrice()
        {
            clsStock Anstock = new clsStock();
            Double TestData = 2.1;
            Anstock.Price = TestData;
            Assert.AreEqual(Anstock.Price, TestData);
        }
        [TestMethod]
        public void tstStockAmount()
        {
            clsStock Anstock = new clsStock();
            int TestData = 123;
            Anstock.Amount = TestData;
            Assert.AreEqual(Anstock.Amount, TestData);
        }
        [TestMethod]
        // links with the Stock Amount to check if the products is available 
        public void tstStockAvailability()
        {
            clsStock Anstock = new clsStock();
            Boolean TestData = true;
            Anstock.Availability = TestData;
            Assert.AreEqual(Anstock.Availability, TestData);
        }
        /// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        [TestMethod]
        public void FindMethodOk()
        {
            //create an instance of the class we want to create
            clsStock Anstock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 Amount = 1;
            //check Found method 
            Found = Anstock.Find(Amount);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void tstStockLocationNoFound()
        {
            //create an instance of the class we want to create
            clsStock Anstock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Amount = 1;
            //invoke the method
            Found = Anstock.Find(Amount);
            //check the address no
            if (Anstock.Location != "Leicester")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void tstStockAmountFound()
        {
            //create an instance of the class we want to create
            clsStock Anstock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Amount = 2;
            //invoke the method
            Found = Anstock.Find(Amount);
            //check the address no
            if (Anstock.Amount != 500)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void tstStockIDFound()
        {
            //create an instance of the class we want to create
            clsStock Anstock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Amount = 3;
            //invoke the method
            Found = Anstock.Find(Amount);
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void tstStockPriceFound()
        {
            //create an instance of the class we want to create
            clsStock Anstock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Amount = 4;
            //invoke the method
            Found = Anstock.Find(Amount);
            //check the address no
            if (Anstock.Price != 5)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void tstStockNameNoFound()
        {
            //create an instance of the class we want to create
            clsStock Anstock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Amount = 5;
            //invoke the method
            Found = Anstock.Find(Amount);
            //check the address no
            if (Anstock.Name != "TrackSuit")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void tstStockDateAddedFound()
        {
            //create an instance of the class we want to create
            clsStock Anstock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Amount = 6;
            //invoke the method
            Found = Anstock.Find(Amount);
            //check the property 19/03/2023
            if (Anstock.DateAdded != Convert.ToDateTime("1/12/2022"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void tstAvailability()
        {
            //create an instance of the class we want to create
            clsStock Anstock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Amount = 8;
            //invoke the method
            Found = Anstock.Find(Amount);
            //check the property
            if (Anstock.Availability == true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}