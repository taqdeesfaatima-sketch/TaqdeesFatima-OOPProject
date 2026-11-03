using Project.Admin;
using Project.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AdminUI adminUI = new AdminUI();
            CustomerUI customerUI = new CustomerUI();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("===========================");
                Console.WriteLine("   SHOP MANAGEMENT SYSTEM  ");
                Console.WriteLine("===========================");
                Console.WriteLine("1. Admin Menu");
                Console.WriteLine("2. Customer Menu");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Select option");

                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    adminUI.Menu();
                }
                else if (choice == "2")
                {
                    customerUI.menu();
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Thank you for using the system !");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option ! Press any key to try again.");
                    Console.ReadKey();
                }
            }
        }
    }
}
   
