using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Timer.For_MVVM
{
    public class Person
    {
        public string LastName {get; set;}

        public static Person[] GetPersons()
        {
            var result = new Person[]
            {
                new Person() {LastName = "Lol"},
                new Person() {LastName = "123"},
                new Person() {LastName = "erer"}
            };
            return result;
        }
    }
}
