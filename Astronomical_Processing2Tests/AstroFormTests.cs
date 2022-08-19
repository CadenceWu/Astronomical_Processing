using Microsoft.VisualStudio.TestTools.UnitTesting;
using Astronomical_Processing2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astronomical_Processing2.Tests
{
    [TestClass()]
    public class AstroFormTests
    {
        [TestMethod()]
        public void MeanTest()
        {
            // Arrange
            AstroForm cal = new AstroForm();
            // Act
            int result = cal.Mean(20, 2);
            //Assert
            Assert.AreEqual(result, 11);

        }

        [TestMethod()]
        public void RangeTest()
        {
            // Arrange
            AstroForm cal = new AstroForm();
            // Act
            int result = cal.Range(20, 2);
            //Assert
            Assert.AreEqual(result, 18);
        }

        [TestMethod()]
        public void AverageTest()
        {
            // Arrange
            AstroForm cal = new AstroForm();
            // Act
            int result = cal.Average(60, 3);
            //Assert
            Assert.AreEqual(result, 20);
        }
    }
}

namespace Astronomical_Processing2Tests
{
    class AstroFormTests
    {
    }
}
