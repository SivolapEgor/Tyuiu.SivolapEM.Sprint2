using Tyuiu.SivolapEM.Sprint2.Task4.V10.Lib;

namespace Tyuiu.SivolapEM.Sprint2.Task4.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpressios()
        {
            DataService ds = new DataService();
            Assert.IsNotNull(ds.Calculate(1,2));
        }
    }
}
