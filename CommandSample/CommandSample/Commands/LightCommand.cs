﻿using System;
using CommandSample.ControlledSystems;

namespace CommandSample.Commands
{
    public class LightCommand : ICommand
    {
        private Light _light;

        public LightCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOn();
        }

        public override string ToString()
        {
            return "Включить свет";
        }

    }
}
