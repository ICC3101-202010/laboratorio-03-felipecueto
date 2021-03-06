﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace Lab3
{
    public class SupermarketBoss

    {   List<Employee> employees = new List<Employee>();
        //List<Supervisor> supervisors = new List<Supervisor>();
        //List<Auxiliar> auxiliars = new List<Auxiliar>();
        List<Product> products = new List<Product>();
        List<Client> clients = new List<Client>();
        


        public SupermarketBoss(List<Client>clients,List<Product>products,List<Cajero>cajeros)
        {
            Supervisor supervisor1 = new Supervisor("Felipe", "Ruiz", 123456789, "02/9/1990", "Chile", 2000, "Supervisor Pasillos", "8:00", "18:00");
            employees.Add(supervisor1);
            Supervisor supervisor2 = new Supervisor("Ignacio", "Gonzales", 253749174, "10/12/1985", "Chile", 2000, "Supervisor Cajas", "8:00", "18:00");
            employees.Add(supervisor2);
            Auxiliar auxiliar1 = new Auxiliar("Rodrigo", "Neffs", 264835183, "29/01/1960", "Bolivia", 500, "Auxilar Reponedor", "6:00", "12:00");
            employees.Add(auxiliar1);
            Auxiliar auxiliar2 = new Auxiliar("Monica", "Cafe", 637492746, "04/05/1969", "Brasil", 500, "Auxilar limpieza", "12:00", "18:00");
            employees.Add(auxiliar2);
            this.products = products;
            this.clients = clients;
            foreach(Cajero cajero in cajeros)
            {
                employees.Add(cajero);
            }
            
           
        }

    
        public void showMenu()
        {
            string[] options = { "Ver Auxiliares", "Ver Supervisores ", "Ver Cajeros","Ver Clientes","Cambiar puesto de trabajo","Cambiar Sueldo", "Cambiar Horario", "Volver menu inico"};

            bool selectingMenu = true;

            int selectedOption = 1;
            while (selectingMenu)
            {
                Console.Clear();
                Console.WriteLine("Entreaste como jefe");
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

                        Console.WriteLine("Informacion Auxiliares: ");
                        //List<Auxiliar> auxiliars = employees.OfType<Auxiliar>.ToList();

                        foreach (Auxiliar auxiliar in employees.OfType<Auxiliar>())
                        {
                            Console.WriteLine(auxiliar.information());
                        }
                        System.Threading.Thread.Sleep(1000);
                        break;

                    case 2:

                        Console.WriteLine("Informacion Supervisores:");
                        foreach (Supervisor supervisor in employees.OfType<Supervisor>())
                        {
                            Console.WriteLine(supervisor.information());
                        }
                        System.Threading.Thread.Sleep(1000);

                        break;
                    case 3:

                        Console.WriteLine("Informacion Cajeros: ");

                        foreach (Cajero cajero in employees.OfType<Cajero>())
                        {
                            Console.WriteLine(cajero.information());
                        }
                        System.Threading.Thread.Sleep(1000);

                        break;

                    case 4:

                        Console.WriteLine("Informacion Cliente: ");

                        foreach (Client client in clients)
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
            Console.WriteLine("Cambiar puesto de trabajo:");
            Console.WriteLine("Ingrese rut Del empleado a cambiar de puesto\n");

            System.Threading.Thread.Sleep(1000);

            Employee employee = findEmployee(123456789);
            Console.WriteLine(employee.information());
            Console.WriteLine("Ingrese puesto que lo quiere cambiar\n");
            System.Threading.Thread.Sleep(1000);
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
            System.Threading.Thread.Sleep(1000);
            Employee employee = findEmployee(264835183);
            Console.WriteLine(employee.information());
            Console.WriteLine("Ingrese nuevo salario\n");
            System.Threading.Thread.Sleep(1000);
            employee.Salary = 750;
            Console.WriteLine("Salario Cambiado\n");
            Console.WriteLine(employee.information());
            System.Threading.Thread.Sleep(3000);

        }
        private void changeWorkingTime()
        {
            Console.WriteLine("Cambio de Horario");
            Console.WriteLine("Ingrese rut Del empleado a cambiar de Horaio\n");
            System.Threading.Thread.Sleep(1000);
            Employee employee = findEmployee(364713946);
            Console.WriteLine(employee.information());
            Console.WriteLine("Ingrese nuevo horario de partida\n");
            Console.WriteLine("Ingrese nuevo horario de termnio\n");
            System.Threading.Thread.Sleep(1000);
            employee.StartTime = "10:00";
            employee.EndTime = "18:00";
            Console.WriteLine("Horario Cambiado\n");
            Console.WriteLine(employee.information());
            System.Threading.Thread.Sleep(3000);
        }

    }
}
