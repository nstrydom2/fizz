// See https://aka.ms/new-console-template for more information


namespace FizzBuzz {
    internal class Program {
        static void Main(string[] args)
        {
            // basic integration test
            var fizzbuzz = new FizzBuzz();
            fizzbuzz.IterFizzBuzz(20);

            // backup test
            fizzbuzz.IterFizzBuzz(50);
        }
    }
}