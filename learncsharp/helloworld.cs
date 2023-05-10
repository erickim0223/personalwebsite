namespace Helloworld
{
    class Hello {
        static void Main(string[] args) {
            helloworld();
        }
        public static void helloworld() {
            System.Console.WriteLine(add(1,3));
        }
        public static int add(int i, int i2) {
            return i + i2;
        }
    }
}