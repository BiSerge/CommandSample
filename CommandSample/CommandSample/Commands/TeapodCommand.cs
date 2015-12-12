using System;
using CommandSample.ControlledSystems;

namespace CommandSample.Commands
{
    public class TeapodCommand : ICommand
    {
        private Teapod _teapod;

        public TeapodCommand(Teapod teapod)
        {
            _teapod = teapod;
        }

        public void Execute()
        {
            _teapod.TurnOn();
        }

        public void Undo()
        {
            _teapod.TurnOff();
        }

        public override string ToString()
        {
            return "Включить чайник";
        }
    }
}