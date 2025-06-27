using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt1
{
    public class Student
    {
        public string Name;
        public int Age;
        public int Score;
        public Student(string Name, int Age, int Score)
        {
            this.Name = Name;
            this.Age = Age;
            this.Score = Score;

        }
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>
        { new Student("Kiet",22,10),
            new Student("Chinh",22,10),
            new Student("Quan",18,7),
            new Student("An",20,4),
            new Student("Quoc",21,9)
        };
            foreach (var s in list)
            {
                Console.WriteLine($"Name: {s.Name}, Tuoi: {s.Age}, Diem: {s.Score}");


            }
            var topStudent = list.Where(s => s.Score >= 8).ToList();

            Console.WriteLine("Hoc sinh co diem lon hon 8");
            foreach (var n in topStudent)
            {
                Console.WriteLine($"Name: {n.Name}, Tuoi: {n.Age}, Diem: {n.Score}");
            }
            var maxScoreStudent = list.FirstOrDefault(s => s.Score == list.Max(s => s.Score));
            Console.WriteLine("Hoc sinh dau tien co diem cao nhat :" + maxScoreStudent.Name);
            bool check = list.Any(s => s.Score <= 5);
            Console.WriteLine($"co hoc sinh diem duoi 5 khong:  + {check}");
        }









    }

}
