using System;

namespace Student2App
{
    class Program
    {
        class Student
        {
            public string Lastname { get; set; }
            public string Firstname { get; set; }
            public string PersonalID { get; set; }
            public string Group { get; set; }

            //.............................................

            private int cource;//get

            public int Cource
            {
                get { return cource; }
                set
                {
                    if(value >=1 && value <= 5)
                    {
                        cource = value;
                    }
                }
            }

            //Gender

            public string Gender()
            {
                if (PersonalID[0] ==  '3' || PersonalID[0] == '5')
                    return "male";
                else
                    return "female";
            }
            //.....................Coclusion..............
            public override string ToString()
            {
                string str = " Student: " + " " + Lastname + " " + Firstname + "\n\tGroup" + Group + "\n\tCourses: " + Cource + "\n\tGender: " + Gender();
                return str;
            }
            

        }

        static void Main(string[] args)
        {
            Student stud1 = new Student();
            stud1.Firstname = "Andrjuxa";
            stud1.Lastname = "Yspeh";
            stud1.PersonalID = "50202008262";
            stud1.Group = "PTVR18";
            stud1.Cource = 3;
            Console.WriteLine(stud1);



        //..............................................
        Console.Write("\n\tPress any key.........");
        Console.ReadKey();
        }
    }
}
