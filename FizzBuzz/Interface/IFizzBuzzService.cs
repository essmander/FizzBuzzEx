using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    interface IFizzBuzzService
    {
        IList<string> GetFizzBuzz { get; }
        void PrintList();
       
    }
}
