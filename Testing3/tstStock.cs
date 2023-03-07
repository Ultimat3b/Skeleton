using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
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

            Anstock.ID = TestData;

            Assert.AreEqual(Anstock.ID, TestData);


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
        public void tstStockAvailibility()
        {
            clsStock Anstock = new clsStock();

            Boolean TestData = true;

            Anstock.Availibility = TestData;

            Assert.AreEqual(Anstock.Availibility, TestData);


        }
    }
}
