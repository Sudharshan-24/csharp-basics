using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_methods
{
    class Student
    {
        public string name;
        public string course;
        public int gpa;

        public Student(string studName, string courseTaken, int studGPA)
        {
            name = studName;
            course = courseTaken;
            gpa = studGPA;
        }

        public bool HasHonors()
        {
            if (gpa >= 3.5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Country(string country)
        {
            return $"from {country}";
        }
    }
}
