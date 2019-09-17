using FizzBuzz.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class JazzFuzzService : IJazzFuzzService
    {
        private readonly IJazzFuzzProperties jazzFuzzProperties;
        private IList<string> jazzFuzzList = null;
        public JazzFuzzService(IJazzFuzzProperties jazzFuzzProperties)
        {
            this.jazzFuzzProperties = jazzFuzzProperties;

            InitJazzFuzzArray();
            SwitchNumberToWords();
        }

        public IList<string> GetJazzFuzz
        {
            get { return jazzFuzzList;}
        }

        public void PrintJazzBuzz()
        {
            foreach (var item in jazzFuzzList)
            {
                Console.WriteLine(item);
            }
        }

        public void PrintJazzBuzzBackward()
        {
            for (int i = jazzFuzzProperties.Length-1; i > 0; i--)
            {
                Console.WriteLine(jazzFuzzList[i]);
            }
        }

        public void SwitchNumberToWords()
        {
            for (int i = 1; i < jazzFuzzProperties.Length; i++)
            {
                if (i % jazzFuzzProperties.DividerOne == 0)
                    jazzFuzzList[i] = jazzFuzzProperties.Jazz;

                if (i % jazzFuzzProperties.DividerTwo == 0)
                    jazzFuzzList[i] = jazzFuzzProperties.Fuzz;
               
            }
        }

        private void InitJazzFuzzArray()
        {
            if (jazzFuzzProperties.ListToCorrect != null)
            {
                jazzFuzzList = jazzFuzzProperties.ListToCorrect;
            }
            else
            {
                jazzFuzzList ??= new List<string>(jazzFuzzProperties.Length);
                PopulateJazzFuzzArray();
            }
        }

        private void PopulateJazzFuzzArray()
        {
            for (int i = 0; i < jazzFuzzProperties.Length; i++)
            {
                jazzFuzzList.Add(i.ToString());
            }
        }
    }
}
