using System;
using System.Text;
using System.Threading.Tasks;

namespace FCC_Bootcamp
{
    class Student
    {
        private string name;
        private string course;
        public double grade;

        // static variable
        public static int studentCount = 0;
        
        // Constructor method
        public Student(string aName, string aCourse, double aGrade)
        {   
            name = aName;
            // This goes through the setter below
            Course  = aCourse;
            grade = aGrade;
            studentCount++;
        }

        // This is a getter and setter
        // It's named the same as a variable with a capital letter instead
        public string Course 
        {
            get { return course; }
            set {
                if (value == "Business" || value == "Art" || value == "Science")
                {
                    course = value;
                } else {
                    course = "N/A";
                }
            }
        }

        public bool HasHonors() 
        {
            if (grade >= 3.5)
            {
                return true;
            }

            return false;
        }
    }
}