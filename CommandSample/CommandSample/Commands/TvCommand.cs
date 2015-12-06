using System;

namespace CommandSample.Commands
{
    public class TvCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Телевизор включен");
        }

        public override string ToString()
        {
            return "Включить телевизор";
        }
    }
}
