using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_Scratchpad
{
    public class Dog
    {
        public string Name { get; set; }
        public List<string> Skills { get; set; }

        public int Age { get; set;  }

        public Dog(string name, List<string> skills, int age)
        {
            Name = name;
            Skills = skills;
            Age = age;
        }
    }
}
