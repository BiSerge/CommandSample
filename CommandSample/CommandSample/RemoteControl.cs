using System;
using System.Collections.Generic;
using CommandSample.Commands;

namespace CommandSample
{
    class RemoteControl
    {
        public string input = "";

        private Dictionary<string, ICommand> _commands;

        public RemoteControl()
        {
            _commands = new Dictionary<string, ICommand>();
            _commands.Add("1", new LightCommand());
            _commands.Add("3", new TvCommand());
            _commands.Add("5", new MusicCommand());
        }

        public void DrawMenu()
        {
            Console.WriteLine("Выбирете вариант ниже:");

            foreach (var buttonId in _commands.Keys)
            {
                Console.WriteLine("{0} \t- {1}", buttonId, _commands[buttonId]);
            }

            Console.WriteLine("2 \t- Выключить свет");
            Console.WriteLine("4 \t- Выключить телевизор");
            Console.WriteLine("6 \t- Выключить музыку");
            Console.WriteLine("0 \t- Выход");
            Console.WriteLine();
        }

        public void PerfomAction()
        {
            Console.Write("Ваш выбор: ");
            input = Console.ReadLine();

            switch (input)
            {
                case "2":
                    TurnLightOff();
                    break;
                case "4":
                    TurnTvOff();
                    break;
                case "6":
                    TurnMusicOff();
                    break;
            }

            if (_commands.ContainsKey(input))
                _commands[input].Execute();
        }

        public void SetCommandForButton(string buttonId, ICommand cmd)
        {
            _commands[buttonId] = cmd;
        }

        private void TurnLightOff()
        {
            Console.WriteLine("Свет выключен");
        }

        private void TurnTvOff()
        {
            Console.WriteLine("Телевизор выключен");
        }

        private void TurnMusicOff()
        {
            Console.WriteLine("Музыка выключена");
        }
    }
}
