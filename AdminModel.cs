using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Admin
{
    public class AdminModel
    {
        public string productName { get; set; }
        public string category { get; set; }
        public string  supplierName{ get; set; }
        public string expiryDate { get; set; }
        public string status { get; set; }
       
        public int quantity { get; set; }
        public int soldQty { get; set; }
        public float buyPrice { get; set; }
        public float sellPrice { get; set; }
        public float totalSale { get; set; }

        public AdminModel()
        {
            productName = "";
            category = "";
            quantity = 0;
            soldQty = 0;
            buyPrice = 0;
            sellPrice = 0;
            totalSale = 0;
            expiryDate = "";
            status = "";
            supplierName = "";
        }

        public AdminModel(string productName, string category, string supplierName, string expiryDate, string status, int quantity, int soldQty, float buyPrice, float sellPrice, float totalSale )
        {
            this.productName = productName;
            this.category = category;
            this.supplierName = supplierName;
            this.expiryDate = expiryDate;
            this.status = status;
            this.quantity = quantity;
            this.soldQty = soldQty;
            this.buyPrice = buyPrice;
            this.sellPrice = sellPrice;
            this.totalSale = totalSale;
        }

        public override string ToString()
        {
            return $"{productName},{category},{supplierName},{expiryDate},{status},{quantity},{soldQty},{buyPrice},{sellPrice},{totalSale}";
        }
        public AdminModel(string productName,int quantity, string category)
        {
            this.productName = productName = productName;
            this.quantity = quantity;
            this.category = category;
        }
    }
}
