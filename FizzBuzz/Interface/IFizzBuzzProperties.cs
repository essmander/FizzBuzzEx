using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public interface IFizzBuzzProperties
    {
        public int Length { get; set; }
        public string Fizz { get; set; }
        public string Buzz { get; set; }
        public int? DividerOne { get; set; }
        public int? DividerTwo { get; set; }
        public int? DividerThree { get; set; }
    }
}
