namespace Tyuiu.BorisovaAD.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Анастасия";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Анастасия, res");
        }
    }
}
