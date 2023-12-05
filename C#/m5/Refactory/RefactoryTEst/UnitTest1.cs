using Refactoring;
namespace RefactoryTEst
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] nums = {1,2,3,4,5};

            string result = FirstRefactoringExercise.Calc(nums);

            Assert.AreEqual(nums);
        }
    }
}