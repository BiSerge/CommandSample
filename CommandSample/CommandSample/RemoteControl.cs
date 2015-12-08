using System;
using System.Collections.Generic;
using CommandSample.Commands;
using System.Text;

namespace CommandSample
{
    class RemoteControl
    {
        //public string input = "";

        private Dictionary<int, ICommand> _commands;

        public RemoteControl()
        {
            _commands = new Dictionary<int, ICommand>();
        }

        public void PushButton(int buttonId)
        {
            if (_commands.ContainsKey(buttonId))
                _commands[buttonId].Execute();
        }

        public void UndoButton(int buttonId)
        {
            if (_commands.ContainsKey(buttonId))
                _commands[buttonId].Undo();
        }

        public void SetCommandForButton(int buttonId, ICommand cmd)
        {
            _commands[buttonId] = cmd;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var buttonId in _commands.Keys)
                sb.AppendFormat("{0} \t- {1}\n", buttonId, _commands[buttonId]);

            sb.Append("Проч. \t- Выход");

            return sb.ToString();
        }

        //public void DrawMenu()
        //{
        //    Console.WriteLine("Выбирете вариант ниже:");

        //    foreach (var buttonId in _commands.Keys)
        //    {
        //        Console.WriteLine("{0} \t- {1}", buttonId, _commands[buttonId]);
        //    }

        //    Console.WriteLine("0 \t- Выход");
        //    Console.WriteLine();
        //}

        //public void PerfomAction()
        //{
        //    Console.Write("Ваш выбор: ");
        //    input = Console.ReadLine();

        //    if (_commands.ContainsKey(input))
        //        _commands[input].Execute();
        //}


    }
}
