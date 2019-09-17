using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    interface IJazzFuzzService
    {
        IList<string> GetJazzFuzz { get; }
        void PrintJazzBuzz();
        void PrintJazzBuzzBackward();
        void SwitchNumberToWords();
    }
}
