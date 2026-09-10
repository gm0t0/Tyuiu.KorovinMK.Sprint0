using Tyuiu.KorovinMK.Sprint0.Task2.V0.Lib;
namespace Tyuiu.KorovinMK.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServicTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Матвей";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Матвей", res);  
        }
    }
}
