using Day20_MoodAnalyserProblems;

namespace MoodAnalyser_TestCase1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            try
            {

                //Arrange
                string message = null;
                

                MoodAnalyser_UC1 moodAnalyser = new MoodAnalyser_UC1(message);
                
                //Act
                string mood = moodAnalyser.AnalysetheMood();

               
                
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual("Mood should not be null", e.Message);
                              
                
            }
            


        }



        //[TestMethod]
        //public void TestMethod2()
        //{

        //    try
        //    {

        //        //Arrange
        //        string expected = "Happy";
        //        //string message = "I am in any mood";

        //        MoodAnalyser_UC1 moodAnalyser = new MoodAnalyser_UC1("I am in null mood");

        //        //Act
        //        string mood = moodAnalyser.AnalysetheMood();

        //        //Assert
        //        Assert.AreEqual(expected, mood);

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }

        //}
    }
}