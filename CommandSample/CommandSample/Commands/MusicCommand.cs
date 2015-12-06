using System;

namespace CommandSample.Commands
{
    public class MusicCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Музыка включена");
        }

        public override string ToString()
        {
            return "Включить музыку";
        }
    }
}
