using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt1
{
    public class Dictionary
    {
        public static void Main(string[] args)
        {
            Dictionary<string, List<double>> list = new Dictionary<string, List<double>>
            {
                { "nam", new List<double> {100,50,80}},
                { "nu", new List<double> {50,50,80}},
                { "kiet", new List<double> {200,50,80}},
                { "hung", new List<double> {100,50,}},
            };
            Dictionary<string, double> totalSpending = new Dictionary<string, double>();
            foreach (var person in list)
            {
                double total = person.Value.Sum();
                totalSpending[person.Key] = total;
            }


            Console.WriteLine("Tong chi tieu tung nguoi:");
            foreach (var person in totalSpending)
            {
                Console.WriteLine($"{person.Key} : {person.Value} ");

            }
            var maxSpender = totalSpending.Where(p => p.Value == totalSpending.Max(p => p.Value)).ToList();
            foreach (var person in maxSpender) { Console.WriteLine("nguoi tieu nhieu nhat: " + person.Key + " ," + person.Value); }
            var spender = totalSpending.Where(p => p.Value > 200).ToList();
            foreach (var person in spender)
            {
                Console.WriteLine("Nguoi tieu nhieu hon 200: " + person);
            }


        }
    }
}
