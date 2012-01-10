using FizzBuzz.Core;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FzBzTests
    {
        FzBz fb;

        [SetUp]
        public void Setup()
        {
            fb = new FzBz();
        }
        [Test]
        public void returns_Fizz_when_divisible_by_3_and_not_by_15([Values(3, 12, 27, 54, 66, 78, 99)] int x)
        {
            Assert.That(fb.GetFizzBuzz(x).ToLower() == "fizz");
        }
        [Test]
        public void returns_Buzz_when_divisible_by_5_and_not_by_15([Values(5, 10, 25, 55, 85, 95)] int x)
        {
            Assert.That(fb.GetFizzBuzz(x).ToLower() == "buzz");
        }
        [Test]
        public void returns_FizzBuzz_when_divisible_by_15([Values(15, 30, 45, 60, 75, 90)] int x)
        {
            Assert.That(fb.GetFizzBuzz(x).ToLower() == "fizzbuzz");
        }
        [Test]
        public void returns_empty_when_not_divisible_by_3_5_15([Values(1, 11, 23, 44, 86, 98)] int x)
        {
            Assert.That(fb.GetFizzBuzz(x).ToLower() == string.Empty);
        }
    }
}
