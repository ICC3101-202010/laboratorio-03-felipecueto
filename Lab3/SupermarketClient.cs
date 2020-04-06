using System;
using System.Collections.Generic;
using System.Linq;
namespace Lab3
{
    public class SupermarketClient
    {
        List<Product> products = new List<Product>();
        private Client client;
        ShoppingCart shoppingCart;
        List<ShoppingCart> sells = new List<ShoppingCart>();
        List<Cajero> cajeros = new List<Cajero>();

        public SupermarketClient( List<Product> products,Client client,List<ShoppingCart> sells, List<Cajero>cajeros)
        {
            this.products = products;
            this.client = client;
            this.sells = sells;
            this.cajeros = cajeros;
            this.shoppingCart = new ShoppingCart(client);
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
                        {
                            Console.WriteLine("Agregar Procutos al carro:\n");
                          
                            Console.WriteLine("Nombre: Filete \n");
                            Console.WriteLine("Marca: ChileBeef \n");
                            Product product = findProduct("Filete", "ChileBeef");
                            if (product==null)
                            {
                                Console.WriteLine("No hay Stock Disponibe");
                                break;
                            }

                            Console.WriteLine(product.informationProduct());
                            product.Stock -= 1;
                            shoppingCart.AddProduct(product);

                            Console.WriteLine("\nProducto agregado \n");
                            System.Threading.Thread.Sleep(1000);

                            Console.WriteLine("Nombre: Gransola \n");
                            Console.WriteLine("Marca: Vivo \n");
                            Product product1 = findProduct("Granola", "Vivo");

                            if (product1 == null)
                            {
                                Console.WriteLine("No hay Stock Disponibe");
                                break;
                            }

                            Console.WriteLine(product1.informationProduct());
                            product1.Stock -= 1;
                            shoppingCart.AddProduct(product1);
                            System.Threading.Thread.Sleep(1000);


                            break;
                        }

                    case 3:

                        Console.WriteLine("Pagar Productos:\n");
                        Console.WriteLine("Total a pagar: ",shoppingCart.TotalPrice);
                        shoppingCart.Pay(cajeros[1]);
                        sells.Add(shoppingCart);
                        Console.WriteLine(shoppingCart.informationPayed());
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

        private Product findProduct(string name, string brand)
        {
            foreach (Product product in products)
            {
                if (product.Name == name && product.Brand == brand && product.Stock> 0)
                {
                    return product;
                }
                
            }

            return null;

        }
    }
}
