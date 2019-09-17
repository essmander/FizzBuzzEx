using FizzBuzz.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz.Models
{
    public class JazzFuzzProperties : IJazzFuzzProperties
    {
        public int Length { get ; set ; }
        public string Jazz { get ; set ; }
        public string Fuzz { get ; set ; }
        public int? DividerOne { get ; set ; }
        public int? DividerTwo { get ; set ; }
        public int? DividerThree { get ; set ; }
        public IList<string> ListToCorrect { get ; set ; }
    }
}
