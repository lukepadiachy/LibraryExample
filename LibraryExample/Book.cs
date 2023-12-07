using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryExample
{
    internal class Book
    {
         public string Title;
         public int Pages;
         public  bool InGoodCOndition;

        public Book(string title, int pages, bool inGoodcondition) 
        
        {
            Title = title;
            Pages = pages;
            InGoodCOndition = inGoodcondition;
        
        
        }

    }
}
