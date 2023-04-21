using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsStockCollection AllAnstock = new clsStockCollection();
            //test to see that it exists
            Assert.IsNotNull(AllAnstock);
        }

        [TestMethod]
        public void StockListOK()
        {
            //create an instance of the class we want to create 
            clsStockCollection AllAnstock = new clsStockCollection();
            //create some test data to assign to the property
            //data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //add an item to teh list
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.Active = true;
            TestItem.Name = "T-shirt";
            TestItem.Price = 5;
            TestItem.Location = "Leicester";
            TestItem.DateAdded = Convert.ToDateTime("01/12/2022");
            TestItem.Amount = 500;
            TestItem.Availability = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllAnstock.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllAnstock.StockList, TestList);
        }
        [TestMethod]
        public void ThisStockListOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllAnstock = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestStock = new clsStock();
            //set properties of the test object
            TestStock.Active = true;
            TestStock.Name = "T-shirt";
            TestStock.Price = 5;
            TestStock.Location = "Leicester";
            TestStock.DateAdded = Convert.ToDateTime("01/12/2022");
            TestStock.Amount = 500;
            TestStock.Availability = true;
            //assign the data to the property
            AllAnstock.ThisStock = TestStock;
            //test to see that the two values are the same
            Assert.AreEqual(AllAnstock.ThisStock, TestStock);


        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllAnstock = new clsStockCollection();
            //create some test data to assign to the property
            //data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            //create the item of the test data
            clsStock TestItem = new clsStock();
            // set its properties
            TestItem.Active = true;
            TestItem.Name = "T-shirt";
            TestItem.Price = 5;
            TestItem.Location = "Leicester";
            TestItem.DateAdded = Convert.ToDateTime("01/12/2022");
            TestItem.Amount = 500;
            TestItem.Availability = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllAnstock.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllAnstock.Count, TestList.Count);

        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllAnstock = new clsStockCollection();
            //create the item of the test data
            clsStock TestItem = new clsStock();
            //var to store primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.Name = "T-shirt";
            TestItem.Price = 5;
            TestItem.Location = "Leicester";
            TestItem.DateAdded = Convert.ToDateTime("01/12/2022");
            TestItem.Amount = 500;
            TestItem.Availability = true;
            //set ThisStock to the test data
            AllAnstock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllAnstock.Add();
            //set the primary key of the test data
            TestItem.StockID = PrimaryKey;
            // find the record
            AllAnstock.ThisStock.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllAnstock.ThisStock, TestItem);

        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllAnstock = new clsStockCollection();
            //create the item of the test data
            clsStock TestItem = new clsStock();
            //var to store primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.Name = "T-shirt";
            TestItem.Price = 5;
            TestItem.Location = "Leicester";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Amount = 500;
            TestItem.Availability = true;
            //set ThisStock to the test data
            AllAnstock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllAnstock.Add();
            //set the primary key of the test data
            TestItem.StockID = PrimaryKey;
            // modify the test data
            TestItem.Active = false;
            TestItem.Name = "Hat";
            TestItem.Price = 3;
            TestItem.Location = "London";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Amount = 0;
            TestItem.Availability = false;
            // set the record based on the new test data
            AllAnstock.ThisStock = TestItem;
            //update the record
            AllAnstock.Update();
            //find the records
            AllAnstock.ThisStock.Find(PrimaryKey);
            //test to see ThisStock matches the test data
            Assert.AreEqual(AllAnstock.ThisStock, TestItem);
        }


        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllAnstock = new clsStockCollection();
            //create the item of the test data
            clsStock TestItem = new clsStock();
            //var to store primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.Name = "T-shirt";
            TestItem.Price = 5;
            TestItem.Location = "Leicester";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Amount = 500;
            TestItem.Availability = true;
            //set ThisStock to the test data
            AllAnstock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllAnstock.Add();
            //set the primary key of the test data
            TestItem.StockID = PrimaryKey;
            //find the records
            AllAnstock.ThisStock.Find(PrimaryKey);
            //delete the record
            AllAnstock.Delete();
            // now find the record
            Boolean Found = AllAnstock.ThisStock.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByStockNoneFound()
        {
            //create an instance of the filtered data
            clsStockCollection FilteredStock = new clsStockCollection();
            //apply a stockName that doesn't exist
            FilteredStock.ReportByStock("yyyyyy");
            //test to see that the two values are the same 
            Assert.AreEqual(0, FilteredStock.Count);
        }

        [TestMethod]
        public void ReportByStockTestDataFound()
        {
            //create an instance of the filtered data
            clsStockCollection FilteredStock = new clsStockCollection();
            //apply a stockName that doesn't exist
            //var to store outcome
            Boolean OK = true;
            //apply a post code that doesn't exit
            FilteredStock.ReportByStock("xxxxx");
            //check that the correct numbers of records are found
            if (FilteredStock.Count == 2)
            {
                //check that the first record ID is 36
                if (FilteredStock.StockList[0].StockID != 36)
                {
                    OK = false;
                }
                //check that the first record is ID 37
                if (FilteredStock.StockList[1].StockID != 37)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}


