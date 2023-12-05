using Project;
namespace ValidationTest
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int num = 3;

            bool result = Ex1.IsPositive(num);

            Assert.IsTrue(result);

        }
        [TestMethod]
        public void TestMethod2()
        {
            int num = 6;

            bool result = Ex1.IsPositive(num);

            Assert.IsTrue(result);

        }
        [TestMethod]
        public void TestMethod3()
        {
            int num = -5;

            bool result = Ex1.IsPositive(num);

            Assert.IsTrue(result);

        }
    }
}