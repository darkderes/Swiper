using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Swiper.Utils
{
    public class DescriptionGenerator
    {
        private string[] _adjetives = { "Nice","Horrible","great","terrible old","brand new" };
        private string[] _other = { "picture of grandpa","car","photo of a forest","duck" };
        
        private static Random random = new Random();

        public string Generate()
        {
            var a = _adjetives[random.Next(_adjetives.Count())];   
            var b = _other[random.Next(_other.Count())];

            return $"A {a} {b}";
        }
    }
}
