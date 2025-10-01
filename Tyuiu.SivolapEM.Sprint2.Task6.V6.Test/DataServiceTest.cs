using Tyuiu.SivolapEM.Sprint2.Task6.V6.Lib;

namespace Tyuiu.SivolapEM.Sprint2.Task6.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpressions()
        {
            DataService dataService = new DataService();
            Assert.IsNotNull(dataService.FindCardNameAndValue(1, 6));
        }
    }
}
