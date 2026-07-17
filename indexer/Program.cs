using System;
namespace indexer
{

    class Student
    {
        private string[] name = new string[5];

        
        public string this[int index]
        {
            get
            {
                return name[index];
            }
            set
            {
                name[index] = value;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Student student = new Student();

            
            student[0] = "laxman";
            student[1] = "saroj";
            student[2] = "dipesh";

           
            Console.WriteLine(student[0]);
            Console.WriteLine(student[1]);
            Console.WriteLine(student[2]);
        }
    }
}