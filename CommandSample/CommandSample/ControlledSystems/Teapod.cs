using System;

namespace CommandSample.ControlledSystems
{
    public class Teapod
    {
        public void TurnOn()
        {
            Console.WriteLine("Чайник включен");
            State = State.On;
        }

        public void TurnOff()
        {
            Console.WriteLine("Чайник выключен");
            State = State.Off;
        }

        public State State { set; get; }
    }
}
