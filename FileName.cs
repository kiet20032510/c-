using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ss1
{
    public class Student
    {
        public string Name { get; set; }
        public float Math { get; set; }
        public float Physics { get; set; }
        public float Chemistry { get; set; }  
        public Student(string name, float math, float physics, float chemistry)
        {
            Name = name;
            Math = math;
            Physics = physics;
            Chemistry = chemistry;
        }
        public float CalculateAverage()
        {
            float dtb = (float)System.Math.Round((Math + Physics + Chemistry) / 3.0f,2);
            return dtb; 
        }
        public void UpdateScore(ref float Math, float value)
        {
            Math = value;
        }
       
        public void GetTopSubject(out string subject)
        {
            float max = Math;
            subject = "Math: " + max;

            if (Physics > max)
            {
                max = Physics;
                subject = "Physics: " + max;
            }

            if (Chemistry > max)
            {
                subject = "Chemistry: " + max;
            }
        }


    }

}

