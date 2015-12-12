using System.Collections.Generic;
using System.Text;

namespace CommandSample.Commands
{
    class MacroCommand  : ICommand
    {
        private List<ICommand> _innerCommands;

        public MacroCommand(List<ICommand> commands)
        {
            _innerCommands = commands;
        }

        public void Execute()
        {
            foreach(var inerCommand in _innerCommands)
            {
                inerCommand.Execute();
            }
        }

        public void Undo()
        {
            foreach (var inerCommand in _innerCommands)
            {
                inerCommand.Undo();
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var inerCommand in _innerCommands)
                sb.AppendFormat("{0}, ", inerCommand);
            return sb.ToString();
        }
    }
}
