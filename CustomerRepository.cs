using Project.Admin;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Customer
{
    internal class CustomerRepository
    {
        private readonly string _filePath = "products.txt";

        public void Save(CustomerModel Product)
        {
            using (StreamWriter writer = new StreamWriter(_filePath, true))
            {
                writer.WriteLine(Product.ToString());
            }
        }

        public void SaveAll(List<CustomerModel> products)
        {
            using (StreamWriter writer = new StreamWriter(_filePath, false))
            {
                foreach (var product in products)
                {
                    writer.WriteLine(product.ToString());
                }
            }
        }

        public List<CustomerModel> GetAll()
        {
            List<CustomerModel> products = new List<CustomerModel>();
            if (!File.Exists(_filePath))
            {
                return products;
            }

            string[] lines = File.ReadAllLines(_filePath);
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length >= 4)
                {
                    CustomerModel p = new CustomerModel();
                    p.productname = parts[0];
                    p.category = parts[1];
                    p.quantity = int.Parse(parts[2]);
                    p.sellPrice = float.Parse(parts[3]);
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
    

