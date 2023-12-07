namespace LibraryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Book MyBook = new Book ("Colors",200,true);

            MyBook.Title = "Colors";
            MyBook.Pages = 200;
            MyBook.InGoodCOndition = true;

            Console.WriteLine("Book Title: " + MyBook.Title);
            Console.WriteLine("Book Pages: " + MyBook.Pages);
            if (MyBook.InGoodCOndition)
            {

                Console.WriteLine("Book Condition: Good ");
            }
            else 
            {
                Console.WriteLine("Book Condition: Not Good ");


            }

            Author BookAuthor = new Author("Danny", 31, true);

            BookAuthor.Name = "Danny";
            BookAuthor.Age = 31;
            BookAuthor.LocalOrInternational = true;

            Console.WriteLine("Author Age: " + BookAuthor.Name );
            Console.WriteLine("Author Age: " + BookAuthor.Age);

            if (BookAuthor.LocalOrInternational)
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
