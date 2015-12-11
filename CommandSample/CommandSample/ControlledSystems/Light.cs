using System;

namespace CommandSample.ControlledSystems
{
    public enum State
    {
        Off = 0,
        On = 1
    }

    public enum LightState
    {
        Off = 0,
        Low = 1,
        Medium = 2,
        High = 3
    }

    public class Light
    {
        public void ToggleLight()
        {
            switch(State)
            {
                case LightState.Off:
                    State = LightState.Low;
                    break;
                case LightState.Low:
                    State = LightState.Medium;
                    break;
                case LightState.Medium:
                    State = LightState.High;
                    break;
                case LightState.High:
                    State = LightState.Off;
                    break;
            }

            PrintLight();
        }

        public void TurnOff()
        {
            State = LightState.Off;
            PrintLight();
        }

        public void SetState(LightState state)
        {
            State = state;
            PrintLight();
        }

        public LightState State { set; get; }

        private void PrintLight()
        {
            switch (State)
            {
                case LightState.Off:
                    Console.WriteLine("Свет выключен");
                    break;
                case LightState.Low:
                    Console.WriteLine("Свет тусклый");
                    break;
                case LightState.Medium:
                    Console.WriteLine("Свет средний");
                    break;
                case LightState.High:
                    Console.WriteLine("Свет яркий");
                    break;
            }
        }
    }
}
