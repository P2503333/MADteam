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
        public clsSuppliers ThisSupplier { get; set; }
        public int Count
        {
            get
            {
                return mSupplierList.Count;s
            }
            set
            {

            }
        }

        public clsSupplierCollection()
        {
            clsSuppliers TestItem = new clsSuppliers();
            TestItem.Active = true;
            TestItem.Address = "123 WotC Lane";
            TestItem.Email = "wotc@wotc.com";
            TestItem.ID = 10;
            TestItem.LastDelivery = DateTime.Now.Date;
            TestItem.Name = "WotC";
            mSupplierList.Add(TestItem);

            TestItem = new clsSuppliers();
            TestItem.Active = true;
            TestItem.Address = "1 Konami Road";
            TestItem.Email = "yu@gi.oh";
            TestItem.ID = 11;
            TestItem.LastDelivery = DateTime.Now.Date;
            TestItem.Name = "Konami";
            mSupplierList.Add(TestItem);

        }

    }
}