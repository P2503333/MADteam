using System;
using System.Collections.Generic;

namespace MADClasses
{
    public class clsSupplierCollection
    {
        List<clsSuppliers> mSupplierList = new List<clsSuppliers>();
        public List<clsSuppliers> SupplierList {
            get
            {
                return mSupplierList;
            }
            set
            {
                mSupplierList = value;
            }
        }
        clsSuppliers mThisSupplier = new clsSuppliers();
        public clsSuppliers ThisSupplier
        {
            get
            {
                return mThisSupplier;
            }
            set
            {
                mThisSupplier = value;
            }
        }
        public int Count
        {
            get
            {
                return mSupplierList.Count;
            }
            set
            {

            }
        }

        public clsSupplierCollection()
        {

            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblSuppliers_SelectAll");

            PopulateArray(DB);

        }

        public int Add()
        {

            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@name", mThisSupplier.Name);
            DB.AddParameter("@address", mThisSupplier.Address);
            DB.AddParameter("@email", mThisSupplier.Email);
            if(mThisSupplier.LastDelivery == DateTime.MinValue)
            {
                DB.AddParameter("@delivery", null);
            }
            else
            {
                DB.AddParameter("@delivery", mThisSupplier.LastDelivery);
            }

            return DB.Execute("sproc_tblSuppliers_CreateSupplier");
        }

        public void DeleteSupplier()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ID", mThisSupplier.ID);
            DB.Execute("sproc_tblSuppliers_Delete");
        }

        public void EnableSupplier()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ID", mThisSupplier.ID);
            DB.Execute("sproc_tblSuppliers_EnableSupplier");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ID", mThisSupplier.ID);
            DB.AddParameter("@name", mThisSupplier.Name);
            DB.AddParameter("@email", mThisSupplier.Email);
            DB.AddParameter("@address", mThisSupplier.Address);
            DB.AddParameter("@delivery", mThisSupplier.LastDelivery);
            DB.AddParameter("@active", mThisSupplier.Active);
            DB.Execute("sproc_tblSuppliers_UpdateData");
        }

        public void Filter(string Name)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@name", Name);
            DB.Execute("sproc_tblSuppliers_FilterByName");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = DB.Count;
            mSupplierList = new List<clsSuppliers>();
            while (Index < RecordCount)
            {
                clsSuppliers TestItem = new clsSuppliers();
                TestItem.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                TestItem.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                TestItem.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                TestItem.ID = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierID"]);
                if (!(DB.DataTable.Rows[Index]["LastDelivery"] is DBNull))
                {
                    TestItem.LastDelivery = Convert.ToDateTime(DB.DataTable.Rows[Index]["LastDelivery"]);
                }
                else
                {
                    TestItem.LastDelivery = new DateTime();
                }
                TestItem.Name = Convert.ToString(DB.DataTable.Rows[Index]["SupplierName"]);
                mSupplierList.Add(TestItem);
                Index++;
            }
        }
    }
}