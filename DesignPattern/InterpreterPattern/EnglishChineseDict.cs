using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    public class EnglishChineseDict
    {
        private Dictionary<string, string> _Dict;
        public EnglishChineseDict()
        {
            _Dict = new Dictionary<string, string>();
            LoadDict();
        }

        public string GetChinese(string english)
        {
            if (_Dict.ContainsKey(english.ToLower()))
            {
                return _Dict[english.ToLower()];
            }
            else
            {
                return english;
            }
        }

        private void LoadDict()
        {
            _Dict.Add("this", "这");
            _Dict.Add("is", "是");
            _Dict.Add("an", "一个");
            _Dict.Add("apple", "苹果");
        }
    }
}
