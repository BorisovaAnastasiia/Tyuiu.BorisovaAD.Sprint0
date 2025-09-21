using Tyuiu.BorisovaAD.Sprint0.Task4.V0.Lib;
namespace Tyuiu.BorisovaAD.Sprint0.Task4.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }
        public void CheckedSubtractionValid()
        {
            Assert.AreEqual(20, DataService.Subtraction(100, 80));
        }

        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(27, DataService.Multiplication(9, 3));
        }

        public void CheckedDivisionValid()
        {
            Assert.AreEqual(9, DataService.Division(72, 8));
        }
    }
}
