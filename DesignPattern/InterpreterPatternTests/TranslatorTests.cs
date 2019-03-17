using Xunit;
using InterpreterPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern.Tests
{
    public class TranslatorTests
    {
        [Fact()]
        public void TranslateTest()
        {
            string sentence = "This is an apple.";
            string expected = "这是一个苹果。";
            var actual = Translator.Translate(sentence);
            Assert.Equal(expected,actual);
        }
    }
}