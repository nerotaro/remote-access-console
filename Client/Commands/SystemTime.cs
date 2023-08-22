using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Client.Commands
{
    public class SystemTime : Command
    {
        public SystemTime(string name) : base(name) { }

        public override string execute(string[] args)
        {
            if (args.Length == 0)
            {
                return DateTime.Now.ToString();
            }
            else return "Invalid arguments for SystemTime. Takes 0 arguments, but " + args.Length.ToString() + " was given.";
        }
    }
}
