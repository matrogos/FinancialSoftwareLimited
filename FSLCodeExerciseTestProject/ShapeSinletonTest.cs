using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FSLCodeExercise.Start;

namespace FSLCodeExerciseTestProject
{
    [TestClass]
    public class ShapeSinletonTest
    {
        [TestMethod]
        public void CalculateAreaTriangle()
        {
            double expectedResult = 2.6666666667;
            double result = ShapeSingleton.Instance.CalculateArea(3, 2);

            Assert.AreEqual(expectedResult, Math.Round(result, 10));
        }

        [TestMethod]
        public void CalculateAreaCircle()
        {
            double expectedResult = Math.PI;
            double result = ShapeSingleton.Instance.CalculateArea(2, 2);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void CalculateAreaSquare()
        {
            double expectedResult = 4;
            double result = ShapeSingleton.Instance.CalculateArea(1, 2);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
