using System;
using System.Collections.Generic;
using CommandSample.Commands;
using CommandSample.ControlledSystems;

namespace CommandSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var remote = new RemoteControl();
            string userInput = "";

            remote.SetCommandForButton(1, new LightCommand(new Light()));
            remote.SetCommandForButton(2, new TvCommand(new Tv()));
            remote.SetCommandForButton(3, new MusicCommand(new Music()));
            remote.SetCommandForButton(4, new TeapodCommand(new Teapod()));

            var teapodCommand = new TeapodCommand(new Teapod());
            var tvCommand = new TvCommand(new Tv());
            var macroCommand = new MacroCommand(new List<ICommand> { teapodCommand, tvCommand });

            remote.SetCommandForButton(5, macroCommand);

            do
            {
                Console.WriteLine("Выбирете вариант ниже:");
                Console.WriteLine(remote);

                Console.Write("\n Ваш выбор: ");
                var input = Console.ReadLine();
                int buttonId;
                int.TryParse(input, out buttonId);

                remote.PushButton(buttonId);
                //remote.PushButton(buttonId);
                //remote.PushButton(buttonId);
                //remote.PushButton(buttonId);
                //remote.PushButton(buttonId);
                //remote.PushButton(buttonId);

                remote.UndoButton(buttonId);
                //remote.UndoButton(buttonId);
                //remote.UndoButton(buttonId);

                Console.WriteLine("\n Хотите продолжить (Y/N): ");
                userInput = Console.ReadLine();
            } while (userInput == "y");
        }
    }
}
