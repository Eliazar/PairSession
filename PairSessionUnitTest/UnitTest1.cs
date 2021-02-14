using NUnit.Framework;
using PairSession;
namespace Tests
{
    public class Tests
    {

        Program pairSession;

        [SetUp]
        public void Setup()
        {
            pairSession = new Program();
        }

        [Test]
        public void testSumaBien()
        {
            int resultado = pairSession.sumar(15, 15);
            //Assert.Pass();
            Assert.AreEqual(resultado, 30);
        }

        [Test]
        public void testSumaMal()
        {
            int resultado = pairSession.sumar(20, 40);
            Assert.AreEqual(resultado, 30);
            //Assert.Fail();
        }
    }
}