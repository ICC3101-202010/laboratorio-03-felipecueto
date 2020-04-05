using System;
using System.Collections.Generic;  
namespace Lab3
{
    public class Client:Person
    {
        //List<Shopping_list> Lista_compras = new List<Shopping_list>();

        public Client(string name, string lastname, int id, string birthDate, string nationality) :base(name, lastname,id , birthDate, nationality)
        {


        }
        public string information()
        {
            return $"Nombre {name}\n Apelldio {lastname}\n ID {id}\n Fecha Nacimiento {birthDate}\n Nacionalidad {nationality}\n";
        }


    }
}
