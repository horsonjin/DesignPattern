using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    public class Translator
    {
        public static string Translate(string input)
        {
            StringBuilder sb = new StringBuilder();
            string[] sentences = input.Split(new char[] { '.' }, 
                StringSplitOptions.RemoveEmptyEntries);
            foreach (var sentence in sentences)
            {
                string[] words = sentence.Split(new char[] { ' ' }, 
                    StringSplitOptions.RemoveEmptyEntries);
                foreach (var word in words)
                {
                    IExpression wordExpression = new WordExpression(word);
                    wordExpression.Interpreter(sb);
                }
                IExpression symbolExpression = new SymbolExpression(".");
                symbolExpression.Interpreter(sb);
            }
            return sb.ToString();
        }
    }
}
