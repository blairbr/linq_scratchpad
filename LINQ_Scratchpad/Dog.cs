using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_Scratchpad
{
    public class Dog
    {
        public string Name { get; set; }
        public List<string> Skills {get; set;}

        public Dog()
        {

        }
        public Dog(string name) //, List<string> skills)
        {
            Name = name;
           // Skills = skills;
        }
    }
}
