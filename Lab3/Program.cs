using System;

namespace Lab3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] options = { "Entrar como Jefe automatico", "Entrar como cliente automatico","Entrar como Supervisor" ,"Salir" };

            bool selectingMenu = true;
            int selectedOption = 2;
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
                        SupermarketBoss supermarketBoss = new SupermarketBoss();
                        supermarketBoss.showMenu();
                        break;
                    case 2:
                        
                        Console.WriteLine("Entreaste Cliente");
                        SupermarketClient supermarketClient = new SupermarketClient();
                        supermarketClient.showMenu();
                        System.Threading.Thread.Sleep(1000);
                        break;

                    case 3:

                        Console.WriteLine("Entreaste como supervisor");
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
