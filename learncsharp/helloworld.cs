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

    class Hello {
        static void Main(string[] args) {
            Dog dog = new Dog();
            dog.sound();
            Console.WriteLine(dog.type);
        }
    }
}