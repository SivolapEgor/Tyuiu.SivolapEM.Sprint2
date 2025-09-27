using Tyuiu.SivolapEM.Sprint2.Task1.V7.Lib;

namespace Tyuiu.SivolapEM.Spint2.Task1.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpressions()
        {
            DataService ds = new DataService();
            bool[] res = new bool[6];
            res = [true, false, false, false, true, false];

            CollectionAssert.AreEqual(res, ds.GetLogicOperations(195, 16, 14, 45));
        }
    }
}
