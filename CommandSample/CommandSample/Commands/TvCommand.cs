using System;
using CommandSample.ControlledSystems;

namespace CommandSample.Commands
{
    public class TvCommand : ICommand
    {
        private Tv _tv;

        public TvCommand(Tv tv)
        {
            _tv = tv;
        }

        public void Execute()
        {
            _tv.TurnOn();
        }

        public override string ToString()
        {
            return "Включить телевизор";
        }
    }
}
