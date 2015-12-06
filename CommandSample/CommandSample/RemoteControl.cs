using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandSample
{
    class RemoteControl
    {
        public void DrawMenu()
        {
            Console.WriteLine("Выбирете вариант ниже:");
            Console.WriteLine("1 \t- Включить свет");
            Console.WriteLine("2 \t- Выключить свет");
            Console.WriteLine("3 \t- Включить телевизор");
            Console.WriteLine("4 \t- Выключить телевизор");
            Console.WriteLine("5 \t- Включить музыку");
            Console.WriteLine("6 \t- Выключить музыку");
            Console.WriteLine("0 \t- Выход");
            Console.WriteLine();
        }

        public void PerfomAction()
        {
            Console.Write("Ваш выбор: ");
            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    TurnLightOn();
                    break;
                case "2":
                    TurnLightOff();
                    break;
                case "3":
                    TurnTvOn();
                    break;
                case "4":
                    TurnTvOff();
                    break;
                case "5":
                    TurnMusicOn();
                    break;
                case "6":
                    TurnMusicOff();
                    break;
            }
        }

        private void TurnLightOn()
        {

        }

        private void TurnLightOff()
        {

        }

        private void TurnTvOn()
        {

        }

        private void TurnTvOff()
        {

        }

        private void TurnMusicOn()
        {

        }

        private void TurnMusicOff()
        {

        }
    }
}
