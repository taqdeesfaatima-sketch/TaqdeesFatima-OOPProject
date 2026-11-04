using Project.Customer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Admin
{
    internal class AdminRepository
    {
        private readonly string _filePath = "products.txt";
        public void Save(AdminModel Product)
        {
            using (StreamWriter writer = new StreamWriter(_filePath, true))
            {
                writer.WriteLine(Product.ToString());
            }
        }
        public void SaveAll(List<AdminModel> products)
        {
            using (StreamWriter writer =new StreamWriter(_filePath,false))
            {
                foreach(var product in products)
                {
                    writer.WriteLine(product.ToString());
                }
            }
        }
        public List<AdminModel> GetAll()
        {
            List<AdminModel> products = new List<AdminModel>();
            if(!File.Exists(_filePath))
            {
                return products;
            }
            string[] lines = File.ReadAllLines(_filePath);
            foreach(var line in lines)
            {
                var parts = line.Split(',');
                if(parts.Length >=6)
                {
                    AdminModel p = new AdminModel();
                    p.productName = parts[0];
                    p.category = parts[1];
                    p.supplierName = parts[2];
                    p.expiryDate = parts[3];
                    p.status = parts[4];
                    p.quantity = int.Parse(parts[5]);
                    products.Add(p);
                }
            }
            return products;
        }
        public void ClearAll()
        {
            File.WriteAllText(_filePath, string.Empty);
        }
    }
}


