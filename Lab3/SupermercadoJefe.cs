using System;
using System.Collections.Generic;
using System.Linq;
namespace Lab3
{
    public class SupermercadoJefe

    {   List<Employee> employees = new List<Employee>();
        //List<Supervisor> supervisors = new List<Supervisor>();
        //List<Auxiliar> auxiliars = new List<Auxiliar>();
        //List<Cajero> cajeros = new List<Cajero>();
        List<Client> clientes = new List<Client>();

        public SupermercadoJefe()
        {
            Supervisor supervisor1 = new Supervisor("Felipe", "Ruiz", 123456789, "02/9/1990", "Chile", 2000, "Supervisor Pasillos", "8:00", "18:00");
            employees.Add(supervisor1);
            Supervisor supervisor2 = new Supervisor("Ignacio", "Gonzales", 253749174, "10/12/1985", "Chile", 2000, "Supervisor Cajas", "8:00", "18:00");
            employees.Add(supervisor2);
            Auxiliar auxiliar1 = new Auxiliar("Rodrigo", "Neffs", 264835183, "29/01/1960", "Bolivia", 500, "Auxilar Reponedor", "6:00", "12:00");
            employees.Add(auxiliar1);
            Auxiliar auxiliar2 = new Auxiliar("Monica", "Cafe", 637492746, "04/05/1969", "Brasil", 500, "Auxilar limpieza", "12:00", "18:00");
            employees.Add(auxiliar2);
            Cajero cajero1 = new Cajero("Claudia", "Verdugo", 364789254, "25/07/1975", "España", 1000, "Cajero", "8:00", "17:00");
            employees.Add(cajero1);
            Cajero cajero2 = new Cajero("Luis", "Singer", 364713946, "16/01/1960", "Chile", 1000, "Cajero", "8:00", "17:00");
            employees.Add(cajero2);
            Client cliente1 = new Client("Elisa", "Verdu", 937462920, "08/09/1998", "Chile");
            clientes.Add(cliente1);
            Client cliente2 = new Client("Pablo", "Bur", 638492703, "15/02/1992", "EEUU");
            clientes.Add(cliente2);
        }

    
        public void showMenu()
        {
            string[] options = { "Ver Auxiliares", "Ver Supervisores ", "Ver Cajeros","Ver Clientes","Cambiar puesto de trabajo","Cambiar Sueldo", "Cambiar Horario", "Volver menu inico"};

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

                        Console.WriteLine("Ver Auxiliares");
                        //List<Auxiliar> auxiliars = employees.OfType<Auxiliar>.ToList();

                        foreach (Auxiliar auxiliar in employees.OfType<Auxiliar>())
                        {
                            Console.WriteLine(auxiliar.information());
                        }
                        System.Threading.Thread.Sleep(1000);
                        break;

                    case 2:

                        Console.WriteLine("Ver Supervisores");
                        foreach (Supervisor supervisor in employees.OfType<Supervisor>())
                        {
                            Console.WriteLine(supervisor.information());
                        }
                        System.Threading.Thread.Sleep(1000);

                        break;
                    case 3:

                        Console.WriteLine("Ver Cajeros");
                        foreach (Cajero cajero in employees.OfType<Cajero>())
                        {
                            Console.WriteLine(cajero.information());
                        }
                        System.Threading.Thread.Sleep(1000);

                        break;

                    case 4:

                        Console.WriteLine("Ver Cliente");

                        foreach (Client client in clientes)
                        {
                            Console.WriteLine(client.information());
                        }
                        System.Threading.Thread.Sleep(1000);

                        break;
                    case 5:
                        changeJob();
                            
                            break;
                        
                    case 6:
                      
                            changeSalary();
                            break;
                        
                    case 7:
                        changeWorkingTime();
                        break;
                    case 8:
                        Console.WriteLine("Volver a menu inical");
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

         private Employee findEmployee(int id)
        {
            foreach(Employee employee in employees)
            {
                if (employee.Id==id)
                {
                    return employee;
                }
            }

            return null;
        }

        private void changeJob()
        {
            Console.WriteLine("Cambiar puesto de trabajo");
            Console.WriteLine("Ingrese rut Del empleado a cambiar de puesto\n");

            Employee employee = findEmployee(123456789);
            Console.WriteLine(employee.information());
            Console.WriteLine("Ingrese puesto que lo quiere cambiar\n");
            Cajero cajero = new Cajero(employee.Name, employee.Lastname, employee.Id, employee.BirthDate, employee.Nationality, employee.Salary, "Cajero", employee.StartTime, employee.EndTime);
            employees.Remove(employee);
            employees.Add(cajero);
            Console.WriteLine("Puesto Cambiado\n");
            Console.WriteLine(findEmployee(123456789).information());
            System.Threading.Thread.Sleep(3000);
        }
       private void changeSalary()
        {
            Console.WriteLine("Cambio de salario");
            Console.WriteLine("Ingrese rut Del empleado a cambiar de Salario\n");
            Employee employee = findEmployee(264835183);
            Console.WriteLine(employee.information());
            Console.WriteLine("Ingrese nuevo salario\n");
            employee.Salary = 750;
            Console.WriteLine("Salario Cambiado\n");
            Console.WriteLine(employee.information());
            System.Threading.Thread.Sleep(3000);

        }
        private void changeWorkingTime()
        {
            Console.WriteLine("Cambio de Horario");
            Console.WriteLine("Ingrese rut Del empleado a cambiar de Horaio\n");
            Employee employee = findEmployee(364713946);
            Console.WriteLine(employee.information());
            Console.WriteLine("Ingrese nuevo horario de partida\n");
            Console.WriteLine("Ingrese nuevo horario de termnio\n");
            employee.StartTime = "10:00";
            employee.EndTime = "18:00";
            Console.WriteLine("Horario Cambiado\n");
            Console.WriteLine(employee.information());
            System.Threading.Thread.Sleep(3000);
        }

    }
}
