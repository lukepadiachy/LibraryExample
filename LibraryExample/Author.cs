using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryExample
{
    internal class Author
    {
        public string Name;
        public int Age;
        public bool LocalOrInternational;

        public Author(string name, int age, bool localOrInternational) 
        { 
            Name = name;
            Age = age;
            LocalOrInternational = localOrInternational;
        
        
        }


    }
}
