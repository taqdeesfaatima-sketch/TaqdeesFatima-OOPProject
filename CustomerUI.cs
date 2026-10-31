using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project.Customer
{
    public class CustomerUI
    {
        private readonly CustomerService _customerService;

        public CustomerUI()
        {
            _customerService = new CustomerService();
        }

        public void menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("customer management system");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. View all products");
                Console.WriteLine("3. Find product by name");
                Console.WriteLine("4. Delete product by name");
                Console.WriteLine("5. Clear all products");
                Console.WriteLine("6. Exit");
                Console.Write("Select option : ");

                string option = Console.ReadLine();
                if (option == "1")
                {
                    AddProduct();
                }
                else if (option == "2")
                {
                    Viewallproducts();
                }
                else if (option == "3")
                {
                    Findproductbyname();
                }
                else if (option == "4")
                {
                    Deleteproductbyname();
                }
                else if (option == "5")
                {
                    ClearAllProducts();
                }
                else if (option == "6")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option! Press any key to continue.");
                    Console.ReadKey();
                }
            }
        }
        private void AddProduct()
        {
            Console.Clear();
            Console.WriteLine("Enter Product name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter category :");
            string category = Console.ReadLine();
            Console.WriteLine("Enter quantity :");
            int quantity = int.Parse(Console.ReadLine());

            CustomerModel product = new CustomerModel(name, category, quantity, 0, "", "availablex");
            _customerService.addproduct(product);

            Console.WriteLine("product added successfully!");
            Console.ReadKey();
        }
        private void Viewallproducts()
        {
            Console.Clear();
            var products = _customerService.GetAllProducts();
            Console.WriteLine("--- Product List ---");
            foreach (var p in products)
            {
                Console.WriteLine($"Name:{p.productname},category:{p.category},quantity:{p.quantity}");
            }
            Console.ReadKey();
        }
        private void Findproductbyname()
        {
            Console.Clear();
            Console.WriteLine("Enter product name to search :");
            string name = Console.ReadLine();
            var p = _customerService.FindProductbyName(name);

            if (p != null)
            {
                Console.WriteLine($"Found ! Name :{p.productname},quantity:{p.quantity},category:{p.category}");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
            Console.ReadKey();
        }
        private void Deleteproductbyname()
        {
            Console.Clear();
            Console.WriteLine("Enter product name to delete:");
            string name = Console.ReadLine();
            bool deleted = _customerService.DeleteProductbyName(name);

            if (deleted)
            {
                Console.WriteLine("product deleted successfully !");
            }
            else
            {
                Console.WriteLine("product not found .");
            }
            Console.ReadKey();
        }
        private void ClearAllProducts()
        {
            Console.Clear();
            _customerService.Clearallproducts();
            Console.WriteLine("All records cleared.");
            Console.ReadKey();
        }
    }
        
}

