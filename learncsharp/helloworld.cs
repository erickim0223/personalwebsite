using System;

namespace Helloworld
{
    class Hello {
        static void Main(string[] args) {
            string firstName = "Eric";
            string lastName = "Kim";
            string name = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name);
        }
    }
}