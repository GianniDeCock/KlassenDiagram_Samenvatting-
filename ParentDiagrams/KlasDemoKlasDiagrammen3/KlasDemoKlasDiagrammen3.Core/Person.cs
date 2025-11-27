using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasDemoKlasDiagrammen3.Core
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; private set; }
        //private int age;
        //public int Age
        //{
        //    get { return age; }
        //    private set
        //    {
        //        if (value <= 0)
        //        {
        //            throw new ArgumentException("Age cannot be negative.");
        //        }
        //        age = value;
        //    }

        //}
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
