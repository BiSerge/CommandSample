using System;

namespace CommandSample.Commands
{
    public class LightCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Свет включен");
        }
        public override string ToString()
        {
            return "Включить свет";
        }

    }
}
