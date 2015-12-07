using System;

namespace CommandSample.ControlledSystems
{
    public class Music
    {
        public void TurnOn()
        {
            Console.WriteLine("Музыка включена");
            State = State.On;
        }

        public void TurnOff()
        {
            Console.WriteLine("Музыка выключена");
            State = State.Off;
        }

        public State State { set; get; }
    }
}
