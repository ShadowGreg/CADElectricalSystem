using CADTest;
using NUnit.Framework;

namespace TestProject
{
    [TestFixture]
    public class Tests
    {
        Class1 cl = new Class1();
        [Test]
        public void Test1()
        {
            
            cl.Write("test.dxf");

            Assert.True(true);
        }
    }
}