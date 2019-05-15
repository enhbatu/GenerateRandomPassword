using NUnit.Framework;
using GenerateRandomPassword;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GeneratePasswordString_1_100Length()
        {
            Generator g = new Generator();
            for (int i = 1; i <= 100; i++)
            {
                string pass = g.GeneratePasswordString(i);
                if (!string.IsNullOrEmpty(pass))
                    System.Console.WriteLine(pass);
                else
                    Assert.Fail(pass);
            }
            Assert.Pass();
        }

        [Test]
        public void GeneratePasswordStringNumber_1_100Length()
        {
            Generator g = new Generator();
            for (int i = 1; i <= 100; i++)
            {
                string pass = g.GeneratePasswordStringNumber(i);
                if (!string.IsNullOrEmpty(pass))
                    System.Console.WriteLine(pass);
                else
                    Assert.Fail(pass);
            }
            Assert.Pass();
        }

        [Test]
        public void GeneratePasswordStringNumberChar_1_100Length()
        {
            Generator g = new Generator();
            for (int i = 1; i <= 100; i++)
            {
                string pass = g.GeneratePasswordStringNumberChar(i);
                if (!string.IsNullOrEmpty(pass))
                    System.Console.WriteLine(pass);
                else
                    Assert.Fail(pass);
            }
            Assert.Pass();
        }
    }
}