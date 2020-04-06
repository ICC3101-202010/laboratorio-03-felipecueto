using System;
using System.Collections.Generic;
namespace Lab3
{
    class MainClass
    {
        public static void Main(string[] args)
        {   //Base de datos falsa
            List<Product> products = new List<Product>();
            List<Client> clientes = new List<Client>();

            Product product1 = new Product("Leche", 1000, "Colun", "Leche descremada", 100);
            products.Add(product1);
            Product product2 = new Product("Granola", 4000, "Vivo", "Cereal", 25);
            products.Add(product2);
            Product product3 = new Product("Pan De Molde", 1000, "Binbo", "Pan", 40);
            products.Add(product3);
            Product product4 = new Product("Filete", 30000, "ChileBeef", "Carne", 10);
            products.Add(product4);
            Product product5 = new Product("Arroz", 5000, "Jumbo", "Arroz", 30);
            products.Add(product5);

            Client cliente1 = new Client("Elisa", "Verdu", 937462920, "08/09/1998", "Chile");
            clientes.Add(cliente1);
            Client cliente2 = new Client("Pablo", "Bur", 638492703, "15/02/1992", "EEUU");
            clientes.Add(cliente2);

            string[] options = { "Entrar como Jefe automatico", "Entrar como cliente automatico","Entrar como Supervisor" ,"Salir" };

            bool selectingMenu = true;
            int selectedOption = 1;
            while (selectingMenu)
            {
                Console.Clear();
                Console.WriteLine("Bienvenido al Supermecado Automatico\n");
                Console.WriteLine("Elije una opcion\n");

                int optionIndex = 1;
                foreach (string option in options)
                {
                    Console.WriteLine($"{optionIndex} - {option}");

                    optionIndex += 1;
                }
                System.Threading.Thread.Sleep(2000);
                //int selectedOption = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                switch (selectedOption)
                { 
                    case 1:
          
                        Console.WriteLine("Entreaste como jefe");
                        SupermarketBoss supermarketBoss = new SupermarketBoss(clientes,products);
                        supermarketBoss.showMenu();
                        break;
                    case 2:
                        
                        Console.WriteLine("Entreaste Cliente");
                        SupermarketClient supermarketClient = new SupermarketClient(clientes,products);
                        supermarketClient.showMenu();
                        System.Threading.Thread.Sleep(1000);
                        break;

                    case 3:

                        Console.WriteLine("Entreaste como supervisor");
                        SupermarketSupervisor supermarketSupervisor = new SupermarketSupervisor(products);
                        supermarketSupervisor.showMenu();
                        System.Threading.Thread.Sleep(1000);
                        break;

                    case 4:
                        Console.WriteLine("Programa cerrado");
                        selectingMenu = false;
                        break;


                    default:
                        Console.WriteLine("Ingrese option valida...");
                        Console.WriteLine("Precione cualquier tecla para continuar");
                        Console.ReadLine();
                    
                        break;


                
                }
                selectedOption += 1;
            }
            
        }
    }
}
