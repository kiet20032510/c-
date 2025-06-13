using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ss1
{
    public static class StudentHelper
    {
        public static void PrintStudentInfo(Student student)
        {
            student.GetTopSubject(out string subject);
            Console.WriteLine("Name: {0}, Math: {1}, Physics: {2}, Chemistry: {3}, Average: {4}, Top Subject: {5}", student.Name, student.Math, student.Physics, student.Chemistry, student.CalculateAverage(), subject);
        }
       
    }

}
            
          

            
