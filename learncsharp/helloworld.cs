using System;

namespace Helloworld
{
    class Hello {
        static void Main(string[] args) {
            helloworld();
            Console.WriteLine(Math.Max(1, 5));
        }
        public static void helloworld() {
            // Console.WriteLine("Enter your name: ");
            // string name = Console.ReadLine();
            // Console.WriteLine("Hi, " + name);
            Console.WriteLine(add(2,3));
        }
        //comment add function
        public static int add(int number_one, int number_two) {
            return number_one + number_two;
        }
    }
}