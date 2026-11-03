using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Customer
{
    public class CustomerModel
    {
        public string productname { get; set; }
        public string category { get; set; }
        public int quantity { get; set; }
        public float sellPrice { get; set; }
        public string expirydate { get; set; }
        public string status { get; set; }

        public CustomerModel()
        {
            productname = "";
            category = "";
            quantity = 0;
            sellPrice = 0;
            expirydate = "";
            status = "Available";
        }

        public CustomerModel(string name,string category,int qty,float sprice,string expirydate,string status )
        {
            productname = name;
            this.category = category;
            quantity = qty;
            sellPrice = sprice;
            this.expirydate = expirydate;
            this.status = status;
        }

        public override string ToString()
        {
            return $"{productname},{category},{quantity},{sellPrice},{expirydate},{status}";
        }
    }
}
