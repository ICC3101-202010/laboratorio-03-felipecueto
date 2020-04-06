using System;
using System.Collections.Generic;
namespace Lab3
{
    public class ShoppingCart
    {
        List<Product> products = new List<Product>();
        private Cajero cajero;
        private int totalPrice = 0;
        private bool payed = false;
        private DateTime payedAt;
        private Client client;
   
        public ShoppingCart(Client client)
        {
            this.client = client;
        }
        public void AddProduct(Product product)
        {
            products.Add(product);
            totalPrice += product.Price;
        }
        public int TotalPrice
        {
            get { return totalPrice; }
        }
        public void Pay(Cajero cajero)
        {
            this.cajero = cajero;
            payed = true;
            payedAt = DateTime.Now;
        }
        public string informationPayed()
        {
            string infoProductos= "" ;
            foreach(Product product in products)
            {
                infoProductos += product.informationProduct();
            }


            return $"Monto: {totalPrice}\nCajero: {cajero.Name}\nFecha Compra {payedAt}\nCliente: {client.Name} {client.Id}\n Prodcutos: {infoProductos}\n";
        }


    }
}
