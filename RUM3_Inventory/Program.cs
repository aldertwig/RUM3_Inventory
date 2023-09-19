using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RUM3_Inventory
{
    /**
     * Dagens uppgift:
     * Skapa en klass Product med id (readonly), name, etc..
     * Skapa en klass Inventory med array av produkter.
     * Inventory ska ha metoderna:
     * AddProduct(Product product)
     * GetProductByIndex(int index)
     * GetProductById(int id)
     * GetProductByName(string name)
     */
    internal class Program
    {
        private static int inventorySize = 10;
        private static Inventory productInventory = new Inventory(inventorySize);

        static void Main(string[] args)
        {
            //Inventory productInventory = new Inventory(inventorySize);

            bool runProgram = true;
            while (runProgram)
            {
                PrintMenu();
                if (int.TryParse(Console.ReadLine(), out int option))
                {
                    int productId;
                    string name;
                    switch (option)
                    {
                        case 1:
                            // Get name, id and create product object
                            Console.Write("Enter product name: ");
                            name = Console.ReadLine();
                            Console.Write("Enter product id: ");
                            if (int.TryParse(Console.ReadLine(), out productId))
                            {
                                Product product = new Product(productId, name);
                                productInventory.AddProduct(product);
                            }
                            break;
                        case 2:
                            // Get inventory index from user
                            Console.Write("Enter inventory index: ");
                            if (int.TryParse(Console.ReadLine(), out productId))
                            {
                                ShowProduct(productId, 1);
                            }
                            break;
                        case 3:
                            // Get product id from user
                            Console.Write("Enter product id: ");
                            if (int.TryParse(Console.ReadLine(), out productId))
                            {
                                ShowProduct(productId, productBy: 2);

                            }
                            break;
                        case 4:
                            // Get product name from user
                            Console.Write("Enter product name: ");
                            name = Console.ReadLine();
                            ShowProduct(name);
                            break;
                        case 0:
                            // Exit the program
                            runProgram = false;
                            break;
                        default:
                            Console.WriteLine($"{option} is not a valid option...");
                            Console.Write("\nPress ENTER to continue...");
                            Console.ReadLine();
                            break;

                    }
                }
                else
                {
                    Console.Write("You need to choose a valid option...");
                    Console.Write("\nPress ENTER to continue...");
                    Console.ReadLine();
                }
            }
        }

        static void PrintMenu()
        {
            Console.Clear();
            Console.Write("Program usage: OPTION (ENTER)\n" +
                          "1: Add product\n" +
                          "2: Show product by index\n" +
                          "3: Show product by id\n" +
                          "4: Show product by name\n" +
                          "0: Quit\n" +
                          "Option: ");
        }

        static void ShowProduct(string productName)
        {
            Console.Clear();
            if (productInventory != null)
            {
                Console.WriteLine(productInventory.GetProductByName(name: productName));
                Console.Write("\nPress ENTER to continue...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Inventory is null");
                Console.Write("\nPress ENTER to continue...");
                Console.ReadLine();
            }
        }

        static void ShowProduct(int productIdentifier, int productBy)
        {
            Console.Clear();
            if (productInventory != null)
            {
                switch (productBy)
                {
                    case 1:
                        Console.WriteLine(productInventory.GetProductByIndex(productIdentifier));
                        Console.Write("\nPress ENTER to continue...");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine(productInventory.GetProductById(productIdentifier));
                        Console.Write("\nPress ENTER to continue...");
                        Console.ReadLine();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Inventory is null");
                Console.Write("\nPress ENTER to continue...");
                Console.ReadLine();
            }
        }
    }
}