using System;

namespace Helloworld
{
    class Animal {
        public string Name  // property
        { get; set; }
        public void sound() {
            Console.WriteLine("Animal sound");
        }
    }

    class Dog : Animal {
        public string type = "Dog";
    }
    class Cat : Animal {
        public string type = "Cat";
    }
    class Frog : Animal {
        public string type = "Frog";
    }

    class Hello {
        static void Main(string[] args) {
            try {
                int[] myNumbers = {1, 2, 3};
                Console.WriteLine(myNumbers[1]);
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            } finally {
                Console.WriteLine("FINALLY");
            }
        }
    }
}