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
                    Console.WriteLine("Свет тусклый");
                    break;
                case LightState.Low:
                    State = LightState.Medium;
                    Console.WriteLine("Свет средний");
                    break;
                case LightState.Medium:
                    State = LightState.High;
                    Console.WriteLine("Свет яркий");
                    break;
                case LightState.High:
                    State = LightState.Low;
                    Console.WriteLine("Свет тусклый");
                    break;
            }
            
            //State = State.On;
        }

        public void TurnOff()
        {
            Console.WriteLine("Свет выключен");
            State = LightState.Off;
        }

        public void SetState(LightState state)
        {
            State = state;
        }

        public LightState State { set; get; }
    }
}
