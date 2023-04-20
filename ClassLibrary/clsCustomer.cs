using System;
//v00egd00001l.lec-admin.dmu.ac.uk
namespace ClassLibrary
{
    public class clsCustomer

    {
        //private data member (field) for the customer id property
        private Int32 mCustomerId;
        //other private properties
        private string mCustomerFirstName;
        private string mCustomerSurname;
        private string mCustomerEmail;
        private DateTime mDateAdded;
        private bool mReturnCustomer;


        public Int32 CustomerId 
        { 
            get
            {
                //this line of code sends data out of the propety
                return mCustomerId;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerId = value;
            }
        }

        public string CustomerFirstName 
        {
            get
            {
                //this line of code sends data out of the propety
                return mCustomerFirstName;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerFirstName = value;
            }
        }

        public string CustomerSurname 
        {
            get
            {
                //this line of code sends data out of the propety
                return mCustomerSurname;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerSurname = value;
            }
        }


        public string CustomerEmail 
        {
            get
            {
                //this line of code sends data out of the propety
                return mCustomerEmail;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerEmail = value;
            }
        }

        public DateTime DateAdded 
        {
            get
            {
                //this line of code sends data out of the propety
                return mDateAdded;
            }
            set
            {
                //this line of code allows data into the property
                mDateAdded = value;
            }
        }

        public bool ReturnCustomer 
        {
            get
            {
                //this line of code sends data out of the propety
                return mReturnCustomer;
            }
            set
            {
                //this line of code allows data into the property
                mReturnCustomer = value;
            }
        }

        public string Valid(string CustomerFirstName, string CustomerSurname, string CustomerEmail, string DateAdded)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;

            //if customer First name is blank
            if (CustomerFirstName.Length == 0)
            {
                //record the error
                Error = Error + "The Customer First Name may not be blank : ";
            }
            //if the customer first name is greater than 50 characters
            if (CustomerFirstName.Length > 50)
            {
                //record the error
                Error = Error + "The Customer First Name may not be more than 50 characters : ";
            }

            //if customer surname is blank
            if (CustomerSurname.Length == 0)
            {
                //record the error
                Error = Error + "The Customer Surname may not be blank : ";
            }
            //if the customer Surname is greater than 50 characters
            if (CustomerSurname.Length > 50)
            {
                //record the error
                Error = Error + "The Customer Surname may not be more than 50 characters : ";
            }

            //if customer email is blank
            if (CustomerEmail.Length == 0)
            {
                //record the error
                Error = Error + "The Customer Email may not be blank : ";
            }
            //if the customer Email is greater than 50 characters
            if (CustomerEmail.Length > 50)
            {
                //record the error
                Error = Error + "The Customer Email may not be more than 50 characters : ";
            }

            try
            {
                //copy the DateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(DateAdded);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date is not valid : ";
            }

            //return any error messages
            return Error;
        }

        public bool Find(int CustomerId)
        {
 
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer Id to search for
            DB.AddParameter("@CustomerId", CustomerId);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerId");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mCustomerFirstName = Convert.ToString(DB.DataTable.Rows[0]["CustomerFirstName"]);
                mCustomerSurname = Convert.ToString(DB.DataTable.Rows[0]["CustomerSurname"]);
                mCustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mReturnCustomer = Convert.ToBoolean(DB.DataTable.Rows[0]["ReturnCustomer"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }
    }
}