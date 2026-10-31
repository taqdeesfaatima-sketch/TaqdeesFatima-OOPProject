using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Project.Admin
{
    public class AdminUI
    {
        private readonly AdminService _adminservice;
        public AdminUI()
        {
            _adminservice = new AdminService();
        }
        public void Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===Product Management System===");
                Console.WriteLine("===Admin Menu===");
                Console.WriteLine("1. Add product");
                Console.WriteLine("2. View all products");
                Console.WriteLine("3. Clear all products");
                Console.WriteLine("4.exit");
                Console.Write("Select option :");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    AddProduct();
                }
                else if (choice == "2")
                {
                    Viewallproducts();
                }
                else if (choice == "3")
                {
                    Clearallproducts();
                }
                else if (choice == "4")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid option !");
                    Console.ReadKey();
                }
            }
        }
        private void AddProduct()
        {
            Console.Clear();
            Console.Write("Enter Name:");
            string name = Console.ReadLine();
            Console.Write("Enter quantity:");
            int quantity = int.Parse(Console.ReadLine());
            Console.Write("Enter category:");
            string category = Console.ReadLine();

            AdminModel product = new AdminModel(name, quantity, category);
            AdminService _adminService = new AdminService();
            _adminService.addproduct(product);

            Console.WriteLine("product added successfully!");
            Console.ReadKey();
        }
        private void Viewallproducts()
        {
            Console.Clear();
            var products = _adminservice.getallproducts();
            if (products.Count == 0)
            {
                Console.WriteLine("no records found");
            }
            else
            {
                {
                    Console.WriteLine("=== Product List ===");
                    foreach (var p in products)
                    {
                        Console.WriteLine($"name :{p.productName},quantity :{p.quantity}, category :{p.category}");
                    }
                }
            }
            Console.ReadKey();
        }
            private void Clearallproducts()
            {
            Console.Clear();
            _adminservice.clearallproducts();
            Console.WriteLine("All records clearred .");
            Console.ReadKey();
            }

    }

}
        
    

