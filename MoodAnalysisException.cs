using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerProblem
{
    public class MoodAnalysisException : Exception
    {

        public enum ExceptionType
        {
            NULL_MESSAGE, Empty_Message, NO_SUCH_CLASS, NO_SUCH_METHOD
        }
        private readonly ExceptionType type;


        public MoodAnalysisException(ExceptionType Type, string message) : base(message)
        {
            this.type = Type;
        }
    }
}
