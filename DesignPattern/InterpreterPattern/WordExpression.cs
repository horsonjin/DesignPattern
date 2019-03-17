using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    public class WordExpression : IExpression
    {
        private string _Word;
        private EnglishChineseDict _EnglishChineseDict;

        public WordExpression(string word)
        {
            _Word = word;
            _EnglishChineseDict = new EnglishChineseDict();
        }

        public void Interpreter(StringBuilder sb)
        {
            sb.Append(_EnglishChineseDict.GetChinese(_Word));
        }
    }
}
