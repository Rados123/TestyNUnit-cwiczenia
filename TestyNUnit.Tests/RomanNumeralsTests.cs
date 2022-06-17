using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestyNUnit.Tests
{
    [TestFixture]
    public class RomanNumeralsTests
    {
        [TestCase(1, "I")]
        [TestCase(5, "V")]
        [TestCase(2, "II")]
        [TestCase(4, "IV")]
        [TestCase(20, "XX")]
        [TestCase(55, "LV")]
        public void Parse(int expected, string roman)
        {
            Assert.AreEqual(expected, RomanNumerals.Parse(roman));
        }
    }
}
