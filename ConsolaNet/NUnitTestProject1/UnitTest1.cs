using NUnit.Framework;
using ConsolaNet;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            if(ConsolaNet.Program.ComprobarCliente("Sodimac"))
            Assert.Pass();
            else
            {
                Assert.Fail();
            }

        }
    }
}