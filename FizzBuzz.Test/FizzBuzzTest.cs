using FizzBuzz.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Test
{
    [TestClass]
    public class FizzBuzzTest
    {
      
        [TestMethod]
        public void FizzBuzz()
        {
            //Arrange
            var fizzBuzzProp = new FizzBuzzProperties
            {
                Length = 100,
                Fizz = "Fizz",
                Buzz = "Buzz",
                DividerOne = 3,
                DividerTwo = 5
            };

            //Act
            var fizzBuzzService = new FizzBuzzService(fizzBuzzProp);
            var fizzBuzzList = fizzBuzzService.GetFizzBuzz;

            //Assert
            Assert.AreEqual("Fizz Buzz", fizzBuzzList[15]);
            Assert.AreEqual("Fizz", fizzBuzzList[3]);
            Assert.AreEqual("Buzz", fizzBuzzList[5]);
            Assert.AreEqual("2", fizzBuzzList[2]);

        }
        [TestMethod]
        public void JazzBuzz()
        {
            //Arrange
            var propJazz = new JazzFuzzProperties
            {
                Length = 100,
                DividerOne = 9,
                DividerTwo = 4,
                Jazz = "Jazz",
                Fuzz = "Fuzz"
            };

            //Act
            var jazzFuzzService = new JazzFuzzService(propJazz);
            var jazzBuzzList = jazzFuzzService.GetJazzFuzz;

            //Assert
            Assert.AreEqual("Fuzz", jazzBuzzList[4]);
            Assert.AreEqual("Jazz", jazzBuzzList[9]);
            Assert.AreEqual("2", jazzBuzzList[2]);

        }
        [TestMethod]
        public void JazzBuzzWithFizzBuzzList()
        {
            //Arrange
            var propJazz = new JazzFuzzProperties
            {
                Length = 100,
                DividerOne = 9,
                DividerTwo = 4,
                Jazz = "Jazz",
                Fuzz = "Fuzz",
            };

            var fizzBuzzProp = new FizzBuzzProperties
            {
                Length = 100,
                Fizz = "Fizz",
                Buzz = "Buzz",
                DividerOne = 3,
                DividerTwo = 5
            };

            //Act
            var fizzBuzzService = new FizzBuzzService(fizzBuzzProp);
            var fizzBuzzList = fizzBuzzService.GetFizzBuzz;
            propJazz.ListToCorrect = fizzBuzzService.GetFizzBuzz;
            var jazzFuzzService = new JazzFuzzService(propJazz);
            var jazzBuzzList = jazzFuzzService.GetJazzFuzz;


            //Assert
            Assert.AreEqual("Fizz", jazzBuzzList[3]);
            Assert.AreEqual("Fuzz", jazzBuzzList[4]);
            Assert.AreEqual("Jazz", jazzBuzzList[9]);
            Assert.AreEqual("2", jazzBuzzList[2]);
        }
    }
}
