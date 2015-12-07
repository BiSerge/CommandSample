using System;

namespace CommandSample.ControlledSystems
{
    public enum State
    {
        Off = 0,
        On = 1
    }

    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("Свет включен");
            State = State.On;
        }

        public void TurnOff()
        {
            Console.WriteLine("Свет выключен");
            State = State.Off;
        }

        public State State { set; get; }
    }
}
