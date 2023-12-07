using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryExample
{
    internal class Author
    {
        private string Name;
        private int Age;
        private bool LocalOrInternational;

        public Author(string name, int age, bool localOrInternational) 
        { 
            Name = name;
            Age = age;
            LocalOrInternational = localOrInternational;
        }

        public string GetName()
        {
            return Name;

        }
        public int GetAge()
        {
            return Age;

        }
        public bool GetLocalOrInternational()
        {
            return LocalOrInternational;

        }

    }
}
