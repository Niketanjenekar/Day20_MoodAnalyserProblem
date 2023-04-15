using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20_MoodAnalyserProblems
{
    public class MoodAnalyser_UC1
    {
        private string message;

        public MoodAnalyser_UC1(string message)
        {
            this.message = message;

        }

        public string AnalysetheMood()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.EMPTY_MESSAGE, "Mood should not be null");
                }
                
                else if (this.message.Contains("sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }

            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
            }
            
        }
    }
}
