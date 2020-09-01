using System;
using System.Linq;

namespace AuthorApp
{
    class Program
    {
        public class Author{
            public string Firstname { get; set; }
            public string Lastname { get; set; }

            public override string ToString()
            {
                string str=$"Author: {Firstname}  {Lastname}";
                return str;
            }
        }


        static void Main(string[] args)
        {
            Author[] authors =
            {
                new Author{Firstname="Andrjuxa",Lastname="Yspeh"},
                new Author{Firstname="Andrjuxa",Lastname="Yspeh2"},
                new Author{Firstname="Andrjuxa",Lastname="Yspeh3"},
                new Author{Firstname="Andrjuxa",Lastname="Yspeh4"},
            };
            //....................for............................
            Console.WriteLine("\nFor");
            for (int i=0; i<authors.Length; i++)
            {
                Console.Write((i + 1)+$". {authors[i]}\n");
            }

            //.....................foreach........................
            Console.WriteLine("\nForeach");
            int n = 0;
            foreach(Author author in authors)
            {
                n++;
                Console.WriteLine($"\n{n}. {author}\n");
            }
            //....................................................
            Console.WriteLine("\nLinQ");
            var selectedAuthor = from author in authors
                                 /*where author.Firstname=="Andrjuxa"
                                 orderby author.Lastname descending*/
                                 select author;//full array
            n = 0;
            foreach (Author author in selectedAuthor)
            {
                n++;
                Console.WriteLine($"\n{n}. {author}\n");
            }

            //....................................................
            Console.Write("Press any key.......");
            Console.ReadKey();
        }
    }
}
