using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryExample
{
    internal class Book
    {
         private string Title;
         private int Pages;
         private  bool InGoodCOndition;

        public Book(string title, int pages, bool inGoodcondition) 
        
        {
            Title = title;
            Pages = pages;
            InGoodCOndition = inGoodcondition;
        }

         public string GetTitle ()
        { 
            return Title; 
        
        }
        public int GetPages()
        {
            return Pages;

        }
        public bool GetCondition()
        {
            return InGoodCOndition;

        }
    }
}
