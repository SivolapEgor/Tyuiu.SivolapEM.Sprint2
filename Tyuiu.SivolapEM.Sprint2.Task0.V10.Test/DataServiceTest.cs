using Tyuiu.SivolapEM.Sprint2.Task0.V10.Lib;

namespace Tyuiu.SivolapEM.Sprint2.Task0.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExperessions()
        {
            DataService ds = new DataService();
            bool[] res = new bool[6];
            res[0] = false;
            res[1] = true;
            res[2] = false;
            res[3] = true;
            res[4] = false;
            res[5] = true;
            CollectionAssert.AreEqual(res, ds.GetCompareOperations(1305, 475));
        }
    }
}
