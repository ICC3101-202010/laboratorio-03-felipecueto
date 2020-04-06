using System;
using System.Collections.Generic;
using System.Linq;
namespace Lab3
{
    public class SupermarketClient
    {
        List<Product> products = new List<Product>();
        List<Client> clients = new List<Client>();
        


        public SupermarketClient(List<Client> clients, List<Product> products)
        {
            this.products = products;
            this.clients = clients;

        }

        public void showMenu()
        {
            string[] options = { "Ver productos", "Agregar Producto al Carro", "Pagar Productos", "Volver menu inico" };

            bool selectingMenu = true;

            int selectedOption = 1;
            while (selectingMenu)
            {
                Console.Clear();

                int optionIndex = 1;
                foreach (string option in options)
                {
                    Console.WriteLine($"{optionIndex} - {option}");

                    optionIndex += 1;
                }

                Console.WriteLine("\n Selecion automatica");

                System.Threading.Thread.Sleep(1000);


                Console.Clear();
                switch (selectedOption)
                {
                    case 1:

                        Console.WriteLine("Prodcutos:\n");
                        foreach (Product product in products)
                        {
                            Console.WriteLine(product.informationProduct());
                        }
                        System.Threading.Thread.Sleep(1000);
                        break;

                    case 2:

                        Console.WriteLine("Agregar Procutos al carro:\n");
                        System.Threading.Thread.Sleep(1000);

                        break;
                    case 3:

                        Console.WriteLine("Pagar Productos:\n");
                        System.Threading.Thread.Sleep(1000);

                        break;

                    case 4:
                        Console.WriteLine("Volviendo a Menu inical");
                        System.Threading.Thread.Sleep(1000);
                        selectingMenu = false;
                        break;


                    default:
                        Console.WriteLine("Ingrese option valida...");
                        Console.WriteLine("Precione cualquier tecla para continuar");
                        break;



                }
                selectedOption += 1;
            }
        }
    }
}
