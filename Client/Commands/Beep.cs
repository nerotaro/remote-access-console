using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Client.Commands
{
    public class Beep : Command
    {
        public Beep(string name) : base(name) {}

        public override string execute(string[] args)
        {
            if (args.Length == 0) 
            { 
                Console.Beep();
                return "beep";
            }
            else
            {
                if (args.Length == 1)
                {
                    int i = 0;
                    while (i != Int32.Parse(args.First()))
                    {
                        Console.Beep();
                        ++i;
                        Console.WriteLine("beep");
                    }
                    return "";
                }
                else
                {
                    return "Invalid arguments for beep. Takes 0 - 1 arguments.";
                }
            }
        }
    }
}
