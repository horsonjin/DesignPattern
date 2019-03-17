using Xunit;
using CommandPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Tests
{
    public class CommandPatternTests
    {
        [Fact()]
        public void RunCommandTest()
        {
            var openCommand = new OpenCommand();
            var closeCommand = new CloseCommand();
            var changeCommand = new ChangeCommand();
            var commandInvoker = new CommandInvoker();

            commandInvoker.AddCommand(openCommand);
            commandInvoker.AddCommand(closeCommand);

            commandInvoker.RunCommand();

            Assert.True(commandInvoker.Records[0]=="Open"
                &&commandInvoker.Records[1]=="Close");
        }
    }
}