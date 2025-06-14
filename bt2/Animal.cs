using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace bt2
{
    public class Animal
    {
        protected string name = "CAT";
    }
    public class Dog : Animal 
    {
        public void Bark()
        {
            Console.WriteLine("Ten cua con vat la: " + name);
        }
    }
}