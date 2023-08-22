using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Client.Commands
{
    public class CommandHandler
    {
        List<Command> commands;

        public CommandHandler()
        {
            
            //Liste av kommandoer
            this.commands = new List<Command>();
            this.commands.Add(new Beep("beep"));
            this.commands.Add(new GetName("getname"));
            this.commands.Add(new SystemTime("systemtime"));
            this.commands.Add(new File("file"));

        }
        public string runCommand (string cmd)
        {

            string[] sp = cmd.Split(' ');
            string name = sp.First();
            string[] args = sp.Skip(1).ToArray();

            foreach (Command c in this.commands)
            {
                if (c.name.ToLower() == name) return c.execute(args);
            }
            return "Command " + name + " does not exist.";
        }
    }

}