using Tyuiu.SivolapEM.Sprint2.Task3.V25.Lib;

namespace Tyuiu.SivolapEM.Sprint2.Task3.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValueExceptions()
        {
            DataService ds = new DataService();
            Assert.IsNotNull(ds.Calculate(5));
        }
    }
}
