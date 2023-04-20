using System.Collections;
using ACadSharp.Blocks;
using ACadSharp.Entities;
using CADTest;
using NUnit.Framework;

namespace TestProject
{
    [TestFixture]
    public class ReadDXFTests
    {
        [Test]
        public void Test1()
        {
            IEnumerable actual = ReadDXF.GetAllEntitiesInModel("Test2.dxf");

            foreach (Entity anObject in actual)
            {
                Assert.IsNotNull(anObject);
                var name = anObject.ObjectName;
                var temp = anObject;
                
                
            }

            Assert.True(true);
        }
    }
}