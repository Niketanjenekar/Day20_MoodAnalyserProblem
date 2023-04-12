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
            if (message.Contains("any"))
            {
                return "Happy";
            }
            else if (message.Contains("happy"))
            {
                return "Happy";
            }
            else if (message.Contains("sad"))
            {
                return "Sad";
            }
            else
            {
                return "Can't Analyse your mood, i.e., Mood is Unkown";
            }
        }
    }
}
