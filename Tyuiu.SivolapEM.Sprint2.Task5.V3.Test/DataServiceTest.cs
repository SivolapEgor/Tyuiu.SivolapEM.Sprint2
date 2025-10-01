using Tyuiu.SivolapEM.Sprint2.Task5.V3.Lib;

namespace Tyuiu.SivolapEM.Sprint2.Task5.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService dataService = new DataService();
            Assert.IsNotNull(dataService.FindDayName(1));
        }
    }
}
