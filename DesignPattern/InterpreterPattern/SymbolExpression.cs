using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    public class SymbolExpression : IExpression
    {
        private string _SymbolChar;
        public SymbolExpression(string symbolChar)
        {
            _SymbolChar = symbolChar;
        }
        public void Interpreter(StringBuilder sb)
        {
            string result = string.Empty;
            switch (_SymbolChar)
            {
                case ".":
                    result = "。";
                    break;
                default:
                    result = _SymbolChar;
                    break;
            }
            sb.Append(result);
        }
    }
}
