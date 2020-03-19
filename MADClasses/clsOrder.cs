using System;

namespace MADClasses
{
    public class clsOrder
    {
        public int Order_ID { get; set; }
        public int CustomerId { get; set; }
        public int emp_ID { get; set; }
        public int Quantity { get; set; }
        public float TotalAmount { get; set; }
        public DateTime Order_Date { get; set; }
        public bool Dispatch { get; set; }
        public string ISBN { get; set; }
    }
}