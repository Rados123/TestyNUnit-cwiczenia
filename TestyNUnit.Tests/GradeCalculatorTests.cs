using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestyNUnit.Tests
{
    [TestFixture]
    public class GradeCalculatorTests
    {
        [TestCase("bdb", 100)]
        [TestCase("db", 90)]
        [TestCase("db", 80)]
        [TestCase("dst", 60)]
        [TestCase("dop", 45)]
        [TestCase("ndst", 0)]
        [TestCase("invalid", -35)]

        public void TestGradeCalculator(string expected, int percentage)
        {
            Assert.AreEqual(expected, GradeCalculator.GetGrade(percentage));
        }
    }
}
