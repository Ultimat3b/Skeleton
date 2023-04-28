using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        List<clsStaff> mStaffList = new List<clsStaff>();
        clsStaff mThisStaff = new clsStaff();

        public clsStaffCollection()
        { 

            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            PopulateArray(DB);
            
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;

            mStaffList = new List<clsStaff>();
            while (Index < RecordCount)
            {
                clsStaff aStaff = new clsStaff();
                aStaff.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                aStaff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["staff_Id"]);
                aStaff.StaffFirstName = Convert.ToString(DB.DataTable.Rows[Index]["Staff_FirstName"]);
                aStaff.StaffSurname = Convert.ToString(DB.DataTable.Rows[Index]["Staff_Surname"]);
                aStaff.StaffPhoneNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["Staff_PhoneNumber"]);
                aStaff.StaffEmail = Convert.ToString(DB.DataTable.Rows[Index]["Staff_Email"]);
                aStaff.StaffStartDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["Staff_StartDate"]);
                aStaff.StaffSalary = (float)Convert.ToDouble(DB.DataTable.Rows[Index]["Staff_Salary"]);
                mStaffList.Add(aStaff);
                Index++;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@Staff_FirstName", mThisStaff.StaffFirstName);
            DB.AddParameter("@Staff_Surname", mThisStaff.StaffSurname);
            DB.AddParameter("@Staff_PhoneNumber", mThisStaff.StaffPhoneNumber);
            DB.AddParameter("@Staff_Email", mThisStaff.StaffEmail);
            DB.AddParameter("@Staff_StartDate", mThisStaff.StaffStartDate);
            DB.AddParameter("@Staff_Salary", mThisStaff.StaffSalary);
            DB.AddParameter("@Staff_Active", mThisStaff.Active);

            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@Staff_FirstName", mThisStaff.StaffFirstName);
            DB.AddParameter("@Staff_Surname", mThisStaff.StaffSurname);
            DB.AddParameter("@Staff_PhoneNumber", mThisStaff.StaffPhoneNumber);
            DB.AddParameter("@Staff_Email", mThisStaff.StaffEmail);
            DB.AddParameter("@Staff_StartDate", mThisStaff.StaffStartDate);
            DB.AddParameter("@Staff_Salary", mThisStaff.StaffSalary);
            DB.AddParameter("@Staff_Active", mThisStaff.Active);

            DB.Execute("sproc_tblStaff_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@staff_Id", mThisStaff.StaffId);
            DB.Execute("sproc_tblStaff_Delete");
        }

        public List<clsStaff> StaffList
        {
            get
            {
                return mStaffList;
            }
            set
            {
                mStaffList = value;
            }
        }
        public int Count 
        {
            get
            {
                return mStaffList.Count;
            }
            set
            {

            }
        }
        public clsStaff ThisStaff
        {
            get
            {
                return mThisStaff;
            }
            set
            {
                mThisStaff = value;
            }
        }

        public void ReporByFirstName(string StaffFirstName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Staff_FirstName", StaffFirstName);
            DB.Execute("sproc_tblStaff_FilterByFirstName");
            PopulateArray(DB);
        }

       
}