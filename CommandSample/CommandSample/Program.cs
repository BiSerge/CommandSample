using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            remote.SetCommandForButton(3, new TvCommand(new Tv()));
            remote.SetCommandForButton(5, new MusicCommand(new Music()));
            remote.SetCommandForButton(7, new TeapodCommand(new Teapod()));

            do
            {
                Console.WriteLine("Выбирете вариант ниже:");
                Console.WriteLine(remote);

                Console.Write("\n Ваш выбор: ");
                var input = Console.ReadLine();
                int buttonId;
                int.TryParse(input, out buttonId);

                remote.PushButton(buttonId);

                Console.WriteLine("\n Хотите продолжить (Y/N): ");
                userInput = Console.ReadLine();
                //Console.WriteLine();
            } while (userInput == "y"); //while (userInput == "y");
        }
    }
}
