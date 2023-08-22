using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.ComponentModel.Design;
using System.Net;

namespace Client.Commands
{
    public class File : Command
    {
        public File(string name) : base(name) {}
        /*
         * Run files
         * Download files
         * Create files
         * Write to files
         * View files
         */

        public override string execute(string[] args)
        {
            if (args.Length == 0) return "Expected 2 arguments for \"file\", got none";

            switch (args.First())
            {
                case "run":
                    if (args.Length != 2) return "Expected 2 arguments for \"file\", got " + args.Length.ToString();
                    return this.run(args[1]);
                case "download":
                    if (args.Length != 3) return "Expected 3 arguments for \"file\", got " + args.Length.ToString();
                    return this.download(args[1], args[2]);
                case "create":
                    if (args.Length != 2) return "Expected 2 arguments for \"file\", got " + args.Length.ToString();
                    return this.create(args[1]);
                case "write":
                    if (args.Length != 3) return "Expected 3 arguments for \"file\", got " + args.Length.ToString();
                    return this.write(args[1], args[2]);
                case "view":
                    if (args.Length != 2) return "Expected 2 arguments for \"file\", got " + args.Length.ToString();
                    return this.view(args[1]);
                case "remove":
                    if (args.Length != 2) return "Expected 2 arguments for \"file\", got " + args.Length.ToString();
                    return this.remove(args[1]);
                default:
                    return "Error at first positional argument; " + args[0];
            }
        }
        public string run(string fn) {return "Started process with id: " + Process.Start(fn).Id; }
        public string download(string fn, string url)
        {
            using (WebClient wc = new WebClient())
                wc.DownloadFile(url, fn);
            return "Downloaded file " + url;
        }
        public string create(string fn, string data = "") { System.IO.File.Create(fn).Close(); System.IO.File.AppendAllText(fn, data); return "Created file " + fn; }
        public string write(string fn, string data) { System.IO.File.AppendAllText(fn, data); return "Appended text to file " + fn; }
        public string view(string fn) { return System.IO.File.ReadAllText(fn); }
        public string remove(string fn) { System.IO.File.Delete(fn); return "Deleted file "+ fn; }
    }
}
