using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz.Models
{
    public class FizzBuzzProperties : IFizzBuzzProperties
    {
        //private string fizz;
        //private string buzz;
        public int Length { get; set; }
        //public string Fizz { get { return this.fizz; } set { this.fizz = "Fizz"; } }
        //public string Buzz { get { return this.buzz; } set { this.buzz = "Buzz"; } }
        public int? DividerOne { get; set; }
        public int? DividerTwo { get; set; }
        public int? DividerThree { get; set; }
        public string Fizz { get; set; }
        public string Buzz { get; set; }
    }
}
