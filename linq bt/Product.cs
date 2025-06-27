using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace bt1
{
    public class Product
    {
        public string Name;
        public string Category;
        public double Price;
        public Product(string Name, string Category, double Price)
        {
           this.Name = Name;
            this.Category = Category;
            this.Price = Price;

        }
        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Category: {Category}, Price: {Price}");
        }
         
    }
    public class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product("Cake","Food",10),
                new Product("Coca","Drink",15),
                new Product("Pepsi","Drink",15),
                new Product("Gundam","Toy",30),
                new Product("Watermelon","Fruit",13),
                new Product("Car","Toy",60),
                new Product("Tank","Toy",40),
                new Product("Fanta","Drink",20),
                new Product("Ice Cream","Food",10),
                new Product("Rice","Food",16),
                new Product("Banana","Fruit",12),
                new Product("Orange","Fruit",10)

            };
            //Nhom san pham theo Category
            HashSet<string> category = new HashSet<string>(products.Select(p => p.Category));
            foreach (var s in category)
            {
                Console.WriteLine(s);
            }
            
            var group = products.GroupBy(p => p.Category);
            foreach (var s in group)
            {
                Console.WriteLine($"San pham theo nhom: {s.Key}");
                foreach (var c in s)
                {
                    c.Display();
                }


            }
            //Tinh gia trung binh cua moi nhom
            Console.WriteLine("Gia trung binh cua moi nhom");
            foreach (var g in group)
            {
                double avg = Math.Round(g.Average(p => p.Price), 2);
                Console.WriteLine($"{g.Key}: {avg}");
            }
            var maxPrice = products.First(p=>p.Price == products.Max(p => p.Price));
            Console.WriteLine("san pham co gia cao nhat");
            maxPrice.Display();
           



        }
        public static T FindMax<T>(List<T> list, Func<T, double> selector)
        {
            T maxItem = list[0];
            double maxPrice = selector(maxItem);
            foreach (var item in list)
            {
                double value = selector(item);
                if (value > maxPrice)
                {
                    maxPrice = value;
                    maxItem = item;
                }
            }
            return maxItem;
        }
        
    }
    
}
