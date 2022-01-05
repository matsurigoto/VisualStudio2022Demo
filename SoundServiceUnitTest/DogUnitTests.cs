using SoundService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SoundServiceUnitTest
{
    [TestClass]
    public class DogUnitTests
    {
        [TestMethod]
        public void DogShouldBarkOneTime()
        {
            Console.WriteLine("Console.WriteLine() now prits to Test Explorer - Console.WriteLine() now prits to Test Explorer - Console.WriteLine() now prits to Test Explorer");
            var dog = new Dog();
            var response = dog.Bark(1);
            Assert.AreEqual(1, response.Count);
        }
    }
}
