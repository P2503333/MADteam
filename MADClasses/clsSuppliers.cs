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

            if(DB.Count == 1)
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
                            DateTime LastDelivery,
                            Boolean Active)
        {
            return "";
        }
    }
}
