using System;

namespace MADClasses
{
    public class ClsCustomer
    {
        public int CustomerId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Adress { get; set; }
        public DateTime JoinDate { get; set; }
        public bool Active { get; set; }
    }
}
