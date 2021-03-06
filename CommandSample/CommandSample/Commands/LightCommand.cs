﻿using System.Collections.Generic;
using CommandSample.ControlledSystems;

namespace CommandSample.Commands
{
    public class LightCommand : ICommand
    {
        private Light _light;
        private Stack<LightState> _states;

        public LightCommand(Light light)
        {
            _light = light;
            _states = new Stack<LightState>();
        }

        public void Execute()
        {
            _states.Push(_light.State);
            _light.ToggleLight();
        }

        public void Undo()
        {
            var prevState = _states.Pop();
            _light.SetState(prevState);
        }

        public override string ToString()
        {
            return "Включить свет";
        }
    }
}
