using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console
{
    public static class Obfuscation
    {
        public static string obfuscate (this string s)
        {
            s = s.ToLower ();
            StringBuilder sb = new StringBuilder ();
            foreach (char c in s)
            {
                switch (c)
                {
                    case 'a':
                        sb.Append ('\u0025');
                        break;
                    case 'b':
                        sb.Append('\u002D');
                        break;
                    case 'c':
                        sb.Append('\u0024');
                        break;
                    case 'd':
                        sb.Append('\u003D');
                        break;
                    case 'e':
                        sb.Append('\u00A1');
                        break;
                    case 'f':
                        sb.Append('\u00A5');
                        break;
                    case 'g':
                        sb.Append('\u00A9');
                        break;
                    case 'h':
                        sb.Append('\u00AE');
                        break;
                    case 'i':
                        sb.Append('\u00AB');
                        break;
                    case 'j':
                        sb.Append('\u00AD');
                        break;
                    case 'k':
                        sb.Append('\u00A6');
                        break;
                    case 'l':
                        sb.Append('\u00B5');
                        break;
                    case 'm':
                        sb.Append('\u00B1');
                        break;
                    case 'n':
                        sb.Append('\u00B4');
                        break;
                    case 'o':
                        sb.Append('\u00B3');
                        break;
                    case 'p':
                        sb.Append('\u00B2');
                        break;
                    case 'q':
                        sb.Append('\u00BA');
                        break;
                    case 'r':
                        sb.Append('\u00B6');
                        break;
                    case 's':
                        sb.Append('\u00B9');
                        break;
                    case 't':
                        sb.Append('\u00B8');
                        break;
                    case 'u':
                        sb.Append('\u00B7');
                        break;
                    case 'v':
                        sb.Append('\u00BF');
                        break;
                    case 'w':
                        sb.Append('\u00BB');
                        break;
                    case 'x':
                        sb.Append('\u00BE');
                        break;
                    case 'y':
                        sb.Append('\u00BC');
                        break;
                    case 'z':
                        sb.Append('\u00BD');
                        break;
                    default:
                        sb.Append(c);
                        break;
                
                }
            }
            return String.Concat(sb.ToString().Reverse()); ;
        }
        public static string deobfuscate (this string s)
        {
            s = s.ToLower();
            StringBuilder sb = new StringBuilder();
            foreach (char c in s)
            {
                switch (c)
                {
                    case '\u0025':
                        sb.Append('a');
                        break;
                    case '\u002D':
                        sb.Append('b');
                        break;
                    case '\u0024':
                        sb.Append('c');
                        break;
                    case '\u003D':
                        sb.Append('d');
                        break;
                    case '\u00A1':
                        sb.Append('e');
                        break;
                    case '\u00A5':
                        sb.Append('f');
                        break;
                    case '\u00A9':
                        sb.Append('g');
                        break;
                    case '\u00AE':
                        sb.Append('h');
                        break;
                    case '\u00AB':
                        sb.Append('i');
                        break;
                    case '\u00AD':
                        sb.Append('j');
                        break;
                    case '\u00A6':
                        sb.Append('k');
                        break;
                    case '\u00B5':
                        sb.Append('l');
                        break;
                    case '\u00B1':
                        sb.Append('m');
                        break;
                    case '\u00B4':
                        sb.Append('n');
                        break;
                    case '\u00B3':
                        sb.Append('o');
                        break;
                    case '\u00B2':
                        sb.Append('p');
                        break;
                    case '\u00BA':
                        sb.Append('q');
                        break;
                    case '\u00B6':
                        sb.Append('r');
                        break;
                    case '\u00B9':
                        sb.Append('s');
                        break;
                    case '\u00B8':
                        sb.Append('t');
                        break;
                    case '\u00B7':
                        sb.Append('u');
                        break;
                    case '\u00BF':
                        sb.Append('v');
                        break;
                    case '\u00BB':
                        sb.Append('w');
                        break;
                    case '\u00BE':
                        sb.Append('x');
                        break;
                    case '\u00BC':
                        sb.Append('y');
                        break;
                    case '\u00BD':
                        sb.Append('z');
                        break;
                    default:
                        sb.Append(c);
                        break;

                }
            }
            return String.Concat( sb.ToString().Reverse());

        }
    }
}
