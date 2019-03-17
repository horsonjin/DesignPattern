using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class CommandInvoker
    {
        private List<Command> _Commands;

        public CommandInvoker()
        {
            _Commands = new List<Command>();
            _Records = new List<string>();
        }

        public void AddCommand(Command command)
        {
            _Commands.Add(command);
        }

        public void ClearCommands()
        {
            _Commands.Clear();
        }

        public void RunCommand()
        {
            foreach (var command in _Commands)
            {
                _Records.Add(command.Execute());
            }
        }

        #region for unit test
        private List<string> _Records;

        public List<string> Records { get => _Records; set => _Records = value; }

        #endregion
    }
}
