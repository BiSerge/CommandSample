using System;

namespace CommandSample.ControlledSystems
{
    public class Tv
    {
        public void TurnOn()
        {
            Console.WriteLine("Телевизор включен");
            State = State.On;
        }

        public void TurnOff()
        {
            Console.WriteLine("Телевизор выключен");
            State = State.Off;
        }

        public State State { set; get; }
    }
}
