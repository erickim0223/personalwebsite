using System;

namespace Helloworld
{
    class Person {
        public string Name  // property
        { get; set; }
    }
    class Hello {
        static void Main(string[] args) {
            Person mypers = new Person();
            mypers.Name = "Name";
            Console.WriteLine(mypers.Name);
        }
    }
}