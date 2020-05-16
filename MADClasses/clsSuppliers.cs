using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADClasses
{
    public class clsSuppliers
    {
        private Boolean mActive;
        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }

        private Int32 mID;
        public int ID
        {
            get
            {
                return mID;
            }
            set
            {
                mID = value;
            }

        }

        private DateTime mLastDelivery;
        public DateTime LastDelivery
        {
            get
            {
                return mLastDelivery;
            }
            set
            {
                mLastDelivery = value;
            }
        }

        private string mEmail;
        public string Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }

        private string mName;
        public string Name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }

        }

        private string mAddress;
        public string Address
        {
            get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
            }

        }

        public bool Find(int ID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ID", ID);
            DB.Execute("sproc_tblSuppliers_FindID");

            if (DB.Count == 1)
            {
                mID = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierID"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["SupplierName"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);

                if (!(DB.DataTable.Rows[0]["LastDelivery"] is DBNull))
                {
                    mLastDelivery = Convert.ToDateTime(DB.DataTable.Rows[0]["LastDelivery"]);
                }
                else
                {
                    mLastDelivery = new DateTime();
                }
                return true;
            }
            return false;
        }

        public string Valid(string SupplierName, 
                            string SupplierEmail, 
                            string SupplierAddress,
                            string LastDelivery)
        {
            String Error =  "";
            DateTime time;
            //int tempID;

            //if (ID.Length == 0)
            //{
            //    Error += "ID must not be blank \n";
            //}
            //else
            //{
            //    try
            //    {
            //        tempID = Convert.ToInt32(ID);
            //        if (tempID > 0)
            //        {
            //            if (!Find(tempID))
            //            {
            //                //Error += "ID must exist in the table \n";
            //            }
            //        }
            //        else
            //        {
            //            Error += "ID must be greater than 0 \n";
            //        }
            //    }
            //    catch (FormatException)
            //    {
            //        Error += "ID must be a number \n";
            //    }
            //    catch (OverflowException)
            //    {
            //        Error += "ID cannot be that large \n";
            //    }
            //}

            if (SupplierName.Length == 0)
            {
                Error += "Name must be longer than 0 characters \n";
            }
            //           else 
            if (SupplierName.Length > 50)
            {
                Error += "Name must be 50 characters or less \n";
            }

            if (SupplierAddress.Length == 0)
            {
                Error += "Address must be longer than 0 characters \n";
            }
            //           else 
            if (SupplierAddress.Length > 500)
            {
                Error += "Address must be 500 characters or less \n";
            }

            if (SupplierEmail.Length == 0)
            {
                Error += "Email must be longer than 0 characters \n";
            }
            //else 
            if (SupplierEmail.Length > 50)
            {
                Error += "Email must be 50 characters or less \n";
            }

            try
            {
                if (LastDelivery != null)
                {
                    time = Convert.ToDateTime(LastDelivery);
                    if (time.Year < 1900)
                    {
                        Error += "Last Delivery must be since 1900 \n";
                    }
                    else if (time.Year > 2099)
                    {
                        Error += "Last Delivery must be before 2100 \n";
                    }

                }
            }
            catch (FormatException)
            {
                Error += "Last Delivery must be a date \n";
            }

            return Error;
        }
    }
}
