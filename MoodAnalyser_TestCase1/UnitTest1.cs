using Day20_MoodAnalyserProblems;

namespace MoodAnalyser_TestCase1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            try
            {

                //Arrange
                string expected = "Sad";
                string message = "";

                MoodAnalyser_UC1 moodAnalyser = new MoodAnalyser_UC1(message);

                //Act
                string mood = moodAnalyser.AnalysetheMood();

                //Assert
                

            }catch(Exception ex)
            {
                Assert.AreEqual("Mood should not be null", ex.Message);
                
            }


        }



        [TestMethod]
        public void TestMethod2()
        {

            try
            {

                //Arrange
                string expected = "Happy";
                //string message = "I am in any mood";

                MoodAnalyser_UC1 moodAnalyser = new MoodAnalyser_UC1("I am in null mood");

                //Act
                string mood = moodAnalyser.AnalysetheMood();

                //Assert
                Assert.AreEqual(expected, mood);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}