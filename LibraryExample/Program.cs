namespace LibraryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Book MyBook = new Book ("Colors",200,true);
            Book MyBook2 = new Book("People", 150, false);


            Console.WriteLine("Book Title: " + MyBook2.Title);
            Console.WriteLine("Book Pages: " + MyBook2.Pages);
            if (MyBook2.InGoodCOndition)
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
