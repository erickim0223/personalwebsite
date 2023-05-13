using System;

namespace Helloworld
{
    class Hello {
        static void Main(string[] args) {
            helloworld();
        }
        public static void helloworld() {
            Console.WriteLine(add(2,3));
        }
        public static int add(int number_one, int number_two) {
            return number_one + number_two;
        }
    }
}