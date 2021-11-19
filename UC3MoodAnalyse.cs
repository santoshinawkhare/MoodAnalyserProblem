using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerProblem
{
    public class UC3MoodAnalyse
    {
        private string message;

        public UC3MoodAnalyse()
        {
        }

        public UC3MoodAnalyse(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.Empty_Message, "Mood should not be Empty");
                }


                if (this.message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
            }
        }
    }
}