using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace ClassLibrary
{
    public class clsStock
    {

        //private data member for active
        private Boolean mActive;
        //public property for active
        public bool Active
        {
            get
            {
                //return the private data
                return mActive;
            }
            set
            {
                //set the private data
                mActive = value;
            }
        }


        //private date added data member
        private DateTime mDateAdded;
        //public property for date added
        public DateTime DateAdded
        {
            get
            {
                //return the private data
                return mDateAdded;
            }
            set
            {
                //set the private data
                mDateAdded = value;
            }
        }



        //private data member for Location
        private string mLocation;
        //public property for Location
        public string Location
        {
            get
            {
                //return the private data
                return mLocation;
            }
            set
            {
                //set the private data
                mLocation = value;
            }
        }


        //private data member for Stock no
        private Int32 mStockID;
        //public property for Stock no
        public int StockID
        {
            get
            {
                //return the private data
                return mStockID;
            }
            set
            {
                //set the private data
                mStockID = value;
            }
        }

        //private data member for Name
        private string mName;
        //public property for Name
        public string Name
        {
            get
            {
                //return the private data
                return mName;
            }
            set
            {
                //set the private data
                mName = value;
            }
        }

        //private data member for price
        private Double mPrice;
        //public property for price
        public Double Price
        {
            get
            {
                //return the private data
                return mPrice;
            }
            set
            {
                //set the private data
                mPrice = value;
            }
        }

        //private data member for Amount
        private Int32 mAmount;
        //public property for Amount
        public int Amount
        {
            get
            {
                //return the private data
                return mAmount;
            }
            set
            {
                //set the private data
                mAmount = value;
            }
        }


        //private data member for availability
        private Boolean mAvailability;
        //public property for availability
        public bool Availability
        {
            get
            {
                //return the private data
                return mAvailability;
            }
            set
            {
                //set the private data
                mAvailability = value;
            }
        }



        public bool Find(int amount)
        {
            // creates an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            //add the parameter for the adress no to search for
            DB.AddParameter("amount", amount);

            //execte the stored procedure
            DB.Execute("sproc_tblStock_FilterByTestData");

            //if one record is found (there should be either 1 or 0)
            if (DB.Count == 1)
            {
                //copied the data from the database to the private data memebers

                mAvailability = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);
                mAmount = Convert.ToInt32(DB.DataTable.Rows[0]["Stockamount"]);
                mLocation = Convert.ToString(DB.DataTable.Rows[0]["StockLocation"]);
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["StockName"]);
                mStockID = Convert.ToInt32(DB.DataTable.Rows[0]["StockID"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                // Always return True
                return true;
            }
            // if no record was found
            else
            {
                // return false indicating a problem 
                return false;
            }
        }
        public string Valid(string StockAmount, string StockDate, string StockLocation, string StockName, string StockPrice)
        {
            String Error = "";
            DateTime DateTemp;
            Int32 AmountTemp;
            float PriceTemp;

            try
            {
                AmountTemp = Convert.ToInt32(StockAmount);
                if (AmountTemp < 0)
                {
                    Error = Error + "The stock amount must be at least 0 : ";
                }
            }
            catch (OverflowException)
            {
                Error = Error + "The stock amount is too high : ";
            }
            catch (FormatException)
            {
                Error = Error + "The stock amount was not a valid number : ";
            }

            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(StockDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }

            // if Value is blank
            if (StockLocation.Length == 0)
            {
                Error = Error + "The StockLocation should not be left blank : ";
            }
            // if Value is greater than 50 characters 
            if (StockLocation.Length > 50)
            {
                Error = Error + "The StockLocation should not be more than 50 characters : ";
            }

            // if Value is blank
            if (StockName.Length == 0)
            {
                Error = Error + "The StockName should not be left blank: ";
            }
            // if Value is greater than 50 characters 
            if (StockName.Length > 50)
            {
                Error = Error + "The StockName should not be more than 50 characters : ";
            }
            if (StockName.Length == 0)
            {
                Error = Error + "The StockName should not be left blank : ";
            }

            try
            {
                PriceTemp = Convert.ToSingle(StockPrice);
                if (PriceTemp < 0)
                {
                    Error = Error + "The price cannot be negative : ";
                }
                if (PriceTemp > 1000000.00)
                {
                    Error = Error + "The price must be below 1000000.00 : ";
                }
            }
            catch
            {
                Error = Error + "The price was not a valid number : ";
            }

            // return any error messages 
            return Error;
        }
    }
}