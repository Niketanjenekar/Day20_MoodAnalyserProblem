using Day20_MoodAnalyserProblems;

namespace MoodAnalyser_TestCase1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            //Arrange
            string expected = "Happy";
            string message = "I am in happy mood";

            MoodAnalyser_UC1 moodAnalyser = new MoodAnalyser_UC1(message);

            //Act
            string mood = moodAnalyser.AnalysetheMood();

            //Assert
            Assert.AreEqual(expected, mood);

        }



        [TestMethod]
        public void TestMethod2()
        {

            //Arrange
            string expected = "Happy";
            string message = "I am in any mood";

            MoodAnalyser_UC1 moodAnalyser = new MoodAnalyser_UC1(message);

            //Act
            string mood = moodAnalyser.AnalysetheMood();
            
            //Assert
            Assert.AreEqual(expected, mood);

        }
    }
}