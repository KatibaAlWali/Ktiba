using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace products
{
    interface Iproduct
    {
        void Display();
    }
    class product : Iproduct
    {

        public product()
        {
            Console.WriteLine("\n*** WELCOME IN OUR STORE *** \n");
        }

        string cat_name;
        public string Cat_Name
        {
            get
            {
                return cat_name;
            }

            set
            {
                cat_name = value;
            }
        }

        int id;
        public int ID
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        int quantity;
        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        string country;
        public string Country
        {
            get
            {
                return country;
            }

            set
            {
                country = value;
            }
        }

        int price;
        public int Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public void Display()
        {
            Console.WriteLine("Product ID: " + id);
            Console.WriteLine("Product Name: " + cat_name);
            Console.WriteLine("Product Price : " + price);
            Console.WriteLine("Product Country: " + country);
            Console.WriteLine("Product Quantity: " + quantity);

        }


    }

    class Program
    {

        static Dictionary<int, product> listDictionary = new Dictionary<int, product>();
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t ***********************************");
            Console.WriteLine("\t\t\t\t     WELCOME TO STORE PRODUCTS ");
            Console.WriteLine("\t\t\t\t ***********************************\n\n");

            while (true)
            {
                Console.WriteLine("\n\n....   ");
                Console.WriteLine("\t 1. Insert new Product       ");
                Console.WriteLine("\t 2. View list of Products    ");
                Console.WriteLine("\t 3. Search for Product       ");
                Console.WriteLine("\t 4. Exit                     \n\n");
                Console.WriteLine("---------------------------------------------------");
                Console.Write("Enter Number Of Choice: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        InsertProduct();
                        break;
                    case 2:
                        ViewList();
                        break;
                    case 3:
                        Search();
                        break;
                    case 4:
                        return;
                }
            }
        }

        private static void Search()
        {
            bool found = false;
            Console.Write("Input ID: ");
            int search = int.Parse(Console.ReadLine());
            Console.WriteLine("All Prudacts of ID " + search);
            foreach (product producte in listDictionary.Values)
            {
                if (producte.ID.Equals(search))
                {
                    Console.WriteLine("----------------------------");
                    producte.Display();
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("No Prodact were found!");
            }
        }


        private static void ViewList()
        {
            foreach (product i in listDictionary.Values)
            {
                Console.WriteLine("----------------------------");
                i.Display();
            }
        }

        private static void InsertProduct()
        {
            product producte = new product();
            Console.Write("Enter id: ");
            producte.ID = int.Parse(Console.ReadLine());

            Console.Write("Enter Product Name: ");
            producte.Cat_Name = Console.ReadLine();

            Console.Write("Enter Product Price: ");
            producte.Price = int.Parse(Console.ReadLine());

            Console.Write("Enter Product Quantity: ");
            producte.Quantity = int.Parse(Console.ReadLine());

            Console.Write("Enter Product Country: ");
            producte.Country = Console.ReadLine();


            listDictionary.Add(producte.ID, producte);
            Console.WriteLine("\n ...DONE :) ");
        }
    }
}
