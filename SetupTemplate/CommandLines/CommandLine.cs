using SetupTemplate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetupTemplate.CommandLines
{
    public class CommandLine
    {
        /// Example command lines are:
        /// cmd first -o outfile.txt --compile second \errors=errors.txt third fourth --test = "the value" fifth
        public static CommandArgs Parse(string[] args,bool ignoreCase=true)
        {
            //if (ignoreCase)
            //{
            //    args = args.Select(item => { return item.ToLower(); }).ToArray();
            //}
            char[] kEqual = new char[] { '=' };
            char[] kArgStart = new char[] { '-', '\\' };
            CommandArgs ca = new CommandArgs();
            int ii = -1;
            string token = NextToken(args, ref ii);
            while (token != null)
            {
                if (IsArg(token))
                {
                    string arg = token.TrimStart(kArgStart).TrimEnd(kEqual);
                    string value = null;
                    if (arg.Contains("="))
                    {
                        string[] r = arg.Split(kEqual, 2);

                        if (r.Length == 2 && r[1] != string.Empty)
                        {
                            arg = r[0];
                            value = r[1];
                        }
                    }
                    while (value == null)
                    {
                        string next = NextToken(args, ref ii);
                        if (next != null)
                        {
                            if (IsArg(next))
                            {
                                ii--;
                                value = "true";
                            }
                            else if (next != "=")
                            {
                                value = next.TrimStart(kEqual);
                            }
                        }
                        else
                            break;
                    }
                    ca.ArgPairs.Add(arg.ToLower(), value);
                }
                else if (token != string.Empty)
                {
                    ca.Params.Add(token);
                }
                token = NextToken(args, ref ii);
            }
            return ca;
        }

        /// <summary>       
        /// '-', '--', or '\'.)
        /// 前缀为'-', '--', 或者'\'则代表参数
        /// </summary>
        static bool IsArg(string arg)
        {
            return (arg.StartsWith("-") || arg.StartsWith("\\"));
        }
        static string NextToken(string[] args, ref int ii)
        {
            ii++;
            while (ii < args.Length)
            {
                string cur = args[ii].Trim();
                if (cur != string.Empty)
                {
                    return cur;
                }
                ii++;
            }
            return null;
        }

        public static void ExecCmd(string[] args)
        {
            CommandArgs cmdArgs = Parse(args);
            if (cmdArgs.ArgPairs.ContainsKey("update"))
            {
                //todo
            }
        }
    }
}
