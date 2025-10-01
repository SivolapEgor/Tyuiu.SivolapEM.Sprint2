using Tyuiu.SivolapEM.Sprint2.Task7.V7.Lib;

namespace Tyuiu.SivolapEM.Sprint2.Task7.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpressions()
        {
            DataService dataService = new DataService();
            Assert.AreEqual(true, dataService.CheckDotInShadedArea(0, 0));
        }
    }
}
