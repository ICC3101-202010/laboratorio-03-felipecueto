using System;
using System.Collections.Generic;
namespace Lab3
{
    public class SupermarketSupervisor

    {
        List<Product> products = new List<Product>();
        public SupermarketSupervisor(List<Product> products)
        {
            this.products = products;
        }

        public void showMenu()
        {
            string[] options = { "Ver productos", "Agregar Producto ", "Eliminar Producto", "Cambiar Stock", "Volver menu inico" };

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

                        Console.WriteLine("Agregar Producto:\n");
                        Console.WriteLine("Ingrese Nombre: Alcohol Gel");
                        Console.WriteLine("Ingrese Precio: 10000");
                        Console.WriteLine("Ingrese Marca: EcoLab");
                        Console.WriteLine("Ingrese Descripcion: 5 litro");
                        Console.WriteLine("Ingrese Stock: 5");

                        Product newproduct = new Product("Añcohol gel", 10000, "EcoLab", "5 Litros", 5);
                        foreach (Product product in products)
                        {
                            if (newproduct.informationProduct() == product.informationProduct())
                            {
                                Console.WriteLine("Producto ya existe \n");
                                break;
                            }

                        }

                        Console.WriteLine("\n Producto Agregado \n");
                        Console.WriteLine(newproduct.informationProduct());
                        products.Add(newproduct);

                        System.Threading.Thread.Sleep(1000);

                        break;

                    case 3:
                        {
                            Console.WriteLine("Eliminar Productos:\n");
                            Console.WriteLine("Nombre: Leche \n");
                            Console.WriteLine("Marca: Colun \n");
                            Product product = findProduct("Leche", "Colun");
                            Console.WriteLine(product.informationProduct());
                            products.Remove(product);
                            Console.WriteLine("\nProdcuto Eliminado \n");
                            foreach (Product product2 in products)
                            {
                                Console.WriteLine(product2.informationProduct());
                            }
                            System.Threading.Thread.Sleep(1000);

                            break;

                        }
                    case 4:
                        {
                            Console.WriteLine("Cambiar stock:\n");
                            Console.WriteLine("Nombre: Fielte \n");
                            Console.WriteLine("Marca: ChileBeef \n");
                            Product product = findProduct("Filete", "ChileBeef");
                            Console.WriteLine(product.informationProduct());
                            Console.WriteLine("\n Ingrese nuevo Stock: 50\n");
                            product.Stock = 50;
                            Console.WriteLine("Stock Cambiado");
                            foreach (Product product2 in products)
                            {
                                Console.WriteLine(product2.informationProduct());
                            }
                            System.Threading.Thread.Sleep(1000);

                            break;
                        }

                    case 5:
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

        private Product findProduct(string name,string brand)
        {
            foreach (Product product in products)
            {
                if (product.Name == name && product.Brand== brand)
                {
                    return product;
                }
            }

            return null;

        }
    }
}
        



    

