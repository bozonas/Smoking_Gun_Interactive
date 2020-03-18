using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemQuestion;

namespace ProblemQuestionTests
{
    [TestClass]
    public class FindNumberTests
    {
        [DataRow(1, 1)]
        [DataRow(3, 3)]
        [DataRow(4, 4)]
        [DataRow(7, 8)]
        [DataRow(10, 12)]
        [DataRow(13, 18)]
        [DataRow(18, 30)]
        [DataRow(1500, 859963392)]
        [TestMethod]
        public void FindNumber_ReturnsCorectNo(int position, int correctNo)
        {
            // Act
            var number = Program.FindNumber(position);

            // Assert
            Assert.AreEqual(correctNo, number);
        }
    }
}
