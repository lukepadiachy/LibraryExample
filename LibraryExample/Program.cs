using System.Runtime.InteropServices;

namespace LibraryExample
{ 
    internal class Program
        
    {
        static void Main(string[] args)
        {
            
            Book MyBook = new Book ("Colors",200,true);
            Book MyBook2 = new Book("People", 150, false);


            Console.WriteLine("Book Title: " + MyBook2.GetTitle());
            Console.WriteLine("Book Pages: " + MyBook2.GetPages());

            if (MyBook2.GetCondition())
            {

                Console.WriteLine("Book Condition: Good ");
            }
            else 
            {
                Console.WriteLine("Book Condition: Not Good ");


            }

            Author BookAuthor = new Author("Danny", 31, true);

            Console.WriteLine("Author Name: " + BookAuthor.GetName() );
            Console.WriteLine("Author Age: " + BookAuthor.GetAge());

            if (BookAuthor.GetLocalOrInternational())
            {

                 Console.WriteLine("Local: Local Author");

            }
            else
            {

                 Console.WriteLine("Local: Not Local Author");

            }

        }
    }
}
