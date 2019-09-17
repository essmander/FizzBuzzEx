using FizzBuzz.Models;
using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var prop = new FizzBuzzProperties
            {
                Length = 100,
                DividerOne = 3,
                DividerTwo = 5,
                Fizz = "Fizz",
                Buzz = "Buzz"
            };

            var fizzBuzzService = new FizzBuzzService(prop);
            fizzBuzzService.PrintList();

            Console.WriteLine("---------------------------------------------------------------------------------------------");

            var propJazz = new JazzFuzzProperties
            {
                Length = 100,
                DividerOne = 9,
                DividerTwo = 4,
                Jazz = "Jazz",
                Fuzz = "Fuzz"
            };

            var jazzFuzzService = new JazzFuzzService(propJazz);
            jazzFuzzService.PrintJazzBuzzBackward();
        }
    }
}
