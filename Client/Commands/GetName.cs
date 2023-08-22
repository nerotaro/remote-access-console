using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Client.Commands
{
    public class GetName : Command
    {
        public GetName(string name) : base(name) { }

        public override string execute(string[] args)
        {
            if (args.Length == 0)
            {
                return Environment.UserName;
            }
            else return "Invalid arguments for GetName. Takes 0 arguments, but " + args.Length.ToString() + " was given.";
        }
    }
}
