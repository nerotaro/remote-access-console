using System;


namespace Client.Commands
{
    public class Command
    {

        public string name;
        public Command(string name){this.name = name;}
        public virtual string execute(string[] args) { return ""; }
    }

}