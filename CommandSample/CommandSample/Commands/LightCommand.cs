using System;
using CommandSample.ControlledSystems;

namespace CommandSample.Commands
{
    public class LightCommand : ICommand
    {
        private Light _light;
        private LightState _previosState;

        public LightCommand(Light light)
        {
            _light = light;
            _previosState = LightState.Off;
        }

        public void Execute()
        {
            _previosState = _light.State;
            _light.ToggleLight();
        }

        public void Undo()
        {
            _light.TurnOff();
        }

        public override string ToString()
        {
            return "Включить свет";
        }

    }
}
