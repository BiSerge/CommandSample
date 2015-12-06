using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var remote = new RemoteControl();
            do
            {
                remote.DrawMenu();
                remote.PerfomAction();

                Console.WriteLine();
            } while (remote.input != "0"); //while (userInput == "y");
        }
    }
}
