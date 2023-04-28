using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void CountOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Int32 SomeCount = 2;
            AllStaff.Count = SomeCount;
            Assert.AreEqual(AllStaff.Count, SomeCount);
        }

        [TestMethod]
        public void ThisAddressPropertyOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestStaff = new clsStaff();

            TestStaff.Active = true;
            TestStaff.StaffId = 1;
            TestStaff.StaffFirstName = "Bill";
            TestStaff.StaffSurname = "Jobs";
            TestStaff.StaffEmail = "BillJobs@outlook.com";
            TestStaff.StaffPhoneNumber = 07213953278;
            TestStaff.StaffStartDate = DateTime.Now.Date;
            TestStaff.StaffSalary = 27000;

            AllStaff.ThisStaff = TestStaff;
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.Active = true;
            TestItem.StaffId = 1;
            TestItem.StaffFirstName = "Bill";
            TestItem.StaffSurname = "Jobs";
            TestItem.StaffEmail = "BillJobs@outlook.com";
            TestItem.StaffPhoneNumber = 07213953278;
            TestItem.StaffStartDate = DateTime.Now.Date;
            TestItem.StaffSalary = 27000;

            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();

            TestItem.Active = true;
            TestItem.StaffId = 1;
            TestItem.StaffFirstName = "Bill";
            TestItem.StaffSurname = "Jobs";
            TestItem.StaffEmail = "BillJobs@outlook.com";
            TestItem.StaffPhoneNumber = 07213953278;
            TestItem.StaffStartDate = DateTime.Now.Date;
            TestItem.StaffSalary = 27000;

            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        [TestMethod]
        public void TwoRecordsPresent()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Assert.AreEqual(AllStaff.Count, 2);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;

            TestItem.Active = true;
            TestItem.StaffId = 1;
            TestItem.StaffFirstName = "Bill";
            TestItem.StaffSurname = "Jobs";
            TestItem.StaffEmail = "BillJobs@outlook.com";
            TestItem.StaffPhoneNumber = 07213953278;
            TestItem.StaffStartDate = DateTime.Now.Date;
            TestItem.StaffSalary = 27000;

            AllStaff.ThisStaff = TestItem;
            TestItem.StaffId = PrimaryKey;
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;

            TestItem.Active = true;
            TestItem.StaffId = 1;
            TestItem.StaffFirstName = "Bill";
            TestItem.StaffSurname = "Jobs";
            TestItem.StaffEmail = "BillJobs@outlook.com";
            TestItem.StaffPhoneNumber = 07213953278;
            TestItem.StaffStartDate = DateTime.Now.Date;
            TestItem.StaffSalary = 27000;

            PrimaryKey = AllStaff.Add();
            TestItem.StaffId = PrimaryKey;

            TestItem.Active = true;
            TestItem.StaffId = 1;
            TestItem.StaffFirstName = "Bill";
            TestItem.StaffSurname = "Jobs";
            TestItem.StaffEmail = "BillJobs@outlook.com";
            TestItem.StaffPhoneNumber = 07213953278;
            TestItem.StaffStartDate = DateTime.Now.Date;
            TestItem.StaffSalary = 27000;

            AllStaff.ThisStaff = TestItem;
            AllStaff.Update();
            AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        [TestMethod]
        public void DeletemethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;

            TestItem.Active = true;
            TestItem.StaffId = 1;
            TestItem.StaffFirstName = "Bill";
            TestItem.StaffSurname = "Jobs";
            TestItem.StaffEmail = "BillJobs@outlook.com";
            TestItem.StaffPhoneNumber = 07213953278;
            TestItem.StaffStartDate = DateTime.Now.Date;
            TestItem.StaffSalary = 27000;

            AllStaff.ThisStaff = TestItem;
            PrimaryKey = AllStaff.Add();
            AllStaff.StaffID = PrimaryKey;
            AllStaff.ThisStaff.Find(PrimaryKey);
            AllStaff.Delete();
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByFirstNameMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            FilteredStaff.ReporByFirstName("");
            Assert.AreEqual(AllStaff.Count, AllStaff.Count);
        }
        [TestMethod]
        public void ReportByFirstNameNoneFound()
        {
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            FilteredStaff.ReporByFirstName("bob");
            Assert.AreEqual(0, FilteredStaff.Count);
        }

        [TestMethod]
        public void ReportbyFirstNameTestDataFound()
        {
            clsStaffCollection FilterStaff = new clsStaffCollection();
            Boolean OK = true;
            FilterStaff.ReporByFirstName("bob");
            if (FilterStaff.Count == 2)
            {
                if (FilterStaff.StaffList[0].StaffId != 36)
                {
                    OK = false;
                }
                if (FilterStaff.StaffList[1].StaffId != 37)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
