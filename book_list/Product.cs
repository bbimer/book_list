using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyNamespace2;

namespace MyNamespace3
{
    internal class Product
    {
        private string _name;
        private int _quantity { get; set; }
        private double _price { get; set; }

        public Product(string name, int quantity, double price)
        {
            if (_quantity < 0) throw new ArgumentException("the quantity of goods cannot be negative.");

            _name = name;
            _quantity = quantity;
            _price = price;
        }

        public static Product operator +(Product obj, int q)
        {
            return new Product(obj._name, obj._quantity += q, obj._price);
        }

        public static Product operator -(Product obj, int q)
        {
            return new Product(obj._name, obj._quantity -= q, obj._price);
        }

        public static bool operator ==(Product a, Product b)
        {
            return (a._price == b._price);
        }

        public static bool operator !=(Product a, Product b)
        {
            return !(a._price == b._price);
        }

        public static bool operator >(Product a, Product b)
        {
            return (a._price > b._price);
        }

        public static bool operator <(Product a, Product b)
        {
            return (a._price < b._price);
        }



        public void Show()
        {
            Console.WriteLine($"name: {_name}\nquantity: {_quantity}\nprice: {_price}");
        }
    }
}
