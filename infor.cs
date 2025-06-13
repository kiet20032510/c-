using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ss1
{
    

    class Infor
    {
        static void Main(string[] args)
        {
            
            Student s1 = new Student("Kiet PT", 8.5f, 7, 9.3f);
            Student s2 = new Student("chinh LV", 6.5f, 9, 8.8f);
            Student s3 = new Student("Hung PT", 7, 6.8f, 5);

            
            StudentHelper.PrintStudentInfo(s1);
            StudentHelper.PrintStudentInfo(s2);
            StudentHelper.PrintStudentInfo(s3);
            float newMath = s1.Math;     
            s1.UpdateScore(ref newMath, 10); 
            s1.Math = newMath;
            StudentHelper.PrintStudentInfo(s1);

        }
    }
     
}
