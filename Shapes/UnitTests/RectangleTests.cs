using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace UnitTests
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void Rectangle2X3MustHaveArea6()
        {
            Rectangle rectangle = new Rectangle { Height = 2, Width = 3 };

            Assert.AreEqual(6, rectangle.CalculateArea());
        }

        [TestMethod]
        public void Square3X3MustHaveArea9()
        {
            Square square = new Square { Height = 3 };

            Assert.AreEqual(9, square.CalculateArea());
        }

        [TestMethod]
        public void Rectangle4X3MustHaveArea12()
        {
            Rectangle rectangle = new Square()
            {
                Height = 4,
                Width = 3
            };

            Assert.AreEqual(12, rectangle.CalculateArea());
        }
    }
}
