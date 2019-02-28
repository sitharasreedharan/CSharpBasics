using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Shapes.Test
{
    [TestClass]   //[TestFixture]
    public class UnitTest1
    {
        [TestMethod] //[Test]
        public void TestAdd()
        {
            //arrange
            int num1 = 10;
            int num2 = 10;
            //action
            BasicOperations obj = new BasicOperations();
            int result = obj.Add(num1, num2);
            //assert
            Assert.AreEqual(20,result);            
        }

        [TestMethod]
        public void TestSub()
        {
            BasicOperations obj = new BasicOperations();
            int result = obj.Subt(20, 10);
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Trapezoid tr = new Trapezoid();
            double area = tr.TrapezoidArea(2, 2, 3);           
            if (area != 6)
                Assert.Fail();
            Assert.AreEqual(6, area, "area should be 6");
            Assert.AreNotEqual(-1, area, "area should not be -1");

           
        }
    }
}
