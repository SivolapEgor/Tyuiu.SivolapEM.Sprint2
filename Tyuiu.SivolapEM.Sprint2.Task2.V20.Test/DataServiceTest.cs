using Tyuiu.SivolapEM.Sprint2.Task2.V20.Lib;

namespace Tyuiu.SivolapEM.Sprint2.Task2.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpressions()
        {
            DataService dataService = new DataService();

            Assert.AreEqual(false, dataService.CheckDotInShadedArea(1,1));
            Assert.AreEqual(true, dataService.CheckDotInShadedArea(13, 6));
;        }
    }
}
