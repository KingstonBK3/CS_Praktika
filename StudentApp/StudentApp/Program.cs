using System;

namespace StudentApp
{
    class Program
    {
        class Student
        {
             //Variant 1
            public string firstname;
            public string lastname;
            public string group;
            
            //Variant 2
            public Student(string firstname, string lname)
            {
                this.firstname = firstname;
                this.lastname = lname;
                this.group = "PTVR19";
            }

            public void GetInfo()
            {
                Console.WriteLine($"Student: {firstname} - {lastname}, Group: {group}");
            }
        }

        static void Main(string[] args)
        {

            /*
            Student stud1 = new Student();
            stud1.firstname = "Andrjuxa";
            stud1.lastname = "Yspeh";
            stud1.group = "PTVR18";
            */
            Student stud1 = new Student("Andrjuha", "Yspeh");

            //.............................................

            stud1.GetInfo();
            //.............................................
            Console.Write("Press any key.......");
            Console.ReadKey();
        }
    }
}
