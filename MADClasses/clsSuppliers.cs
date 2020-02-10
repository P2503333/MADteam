using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MADClasses
{
    public class clsSuppliers
    {
        public bool Active { get; set; }
        public int ID { get; set; }
        public DateTime LastDelivery { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
