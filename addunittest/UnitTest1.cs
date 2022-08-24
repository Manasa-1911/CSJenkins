using NewConsoleApp;
namespace addunittest
    
{
    [TestClass]
    public class TestCalculator
    {
        [TestMethod]
        public void TestAdd()
        {
            Calculator c = new Calculator();
            int result = c.Add(10, 20);
            Assert.AreEqual(30, result);
        }
    }
}