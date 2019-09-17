using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzzService : IFizzBuzzService
    {
        private readonly IFizzBuzzProperties fizzBuzzProperties;
        private IList<string> fizzBuzzArray = null;
        public FizzBuzzService(IFizzBuzzProperties fizzBuzzProperties)
        {
            this.fizzBuzzProperties = fizzBuzzProperties;
            fizzBuzzArray ??= new List<string>(fizzBuzzProperties.Length);
            PopulateFizzBuzzArray();
            SwitchNumbersToWords();
        }


        public IList<string> GetFizzBuzz
        {
           get{ return fizzBuzzArray; }
        }

        public void PrintList()
        {
            foreach (var item in this.fizzBuzzArray)
            {
                Console.WriteLine(item);
            }
        }

        public void SwitchNumbersToWords()
        {
            for (int i = 1; i < fizzBuzzProperties.Length; i++)
            {
                if (i%fizzBuzzProperties.DividerOne==0)
                    fizzBuzzArray[i] = fizzBuzzProperties.Fizz;

                if (i % fizzBuzzProperties.DividerTwo == 0)
                    fizzBuzzArray[i] = fizzBuzzProperties.Buzz;

                if ((i % fizzBuzzProperties.DividerOne == 0) && (i % fizzBuzzProperties.DividerTwo == 0))
                    fizzBuzzArray[i] = fizzBuzzProperties.Fizz +" "+ fizzBuzzProperties.Buzz;
            }
        }

        private void PopulateFizzBuzzArray()
        {
            for (int i = 0; i < fizzBuzzProperties.Length; i++)
            {
                fizzBuzzArray.Add(i.ToString());
            }
        }
    }
}
