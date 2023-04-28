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
            TestStaff.StaffFirstName = "";
            TestStaff.StaffSurname = "";
            TestStaff.StaffEmail = "";
            TestStaff.StaffPhoneNumber = 0;
            TestStaff.StaffStartDate = DateTime.Now.Date;
            TestStaff.StaffSalary = 0;

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
            TestItem.StaffFirstName = "";
            TestItem.StaffSurname = "";
            TestItem.StaffEmail = "";
            TestItem.StaffPhoneNumber = 0;
            TestItem.StaffStartDate = DateTime.Now.Date;
            TestItem.StaffSalary = 0;

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
            TestItem.StaffFirstName = "";
            TestItem.StaffSurname = "";
            TestItem.StaffEmail = "";
            TestItem.StaffPhoneNumber = 0;
            TestItem.StaffStartDate = DateTime.Now.Date;
            TestItem.StaffSalary = 0;

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
            TestItem.StaffFirstName = "";
            TestItem.StaffSurname = "";
            TestItem.StaffEmail = "";
            TestItem.StaffPhoneNumber = 0;
            TestItem.StaffStartDate = DateTime.Now.Date;
            TestItem.StaffSalary = 0;

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
            TestItem.StaffFirstName = "";
            TestItem.StaffSurname = "";
            TestItem.StaffEmail = "";
            TestItem.StaffPhoneNumber = 0;
            TestItem.StaffStartDate = DateTime.Now.Date;
            TestItem.StaffSalary = 0;

            PrimaryKey = AllStaff.Add();
            TestItem.StaffId = PrimaryKey;

            TestItem.Active = false;
            TestItem.StaffId = 3;
            TestItem.StaffFirstName = "";
            TestItem.StaffSurname = "";
            TestItem.StaffEmail = "";
            TestItem.StaffPhoneNumber = 0;
            TestItem.StaffStartDate = DateTime.Now.Date;
            TestItem.StaffSalary = 0;

            AllStaff.ThisStaff = TestItem;
            AllStaff.Update();
            AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }
    }
}
