using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CommandLineParser
{
    public class CommandLineParser<T> where T: CommandLineOptions, new()
    {

        public static T GetOptions(string[] args)
        {
            return GetOptions(ArgArrayToDictionary(args));
        }

        private static T GetOptions(IDictionary<string, string> argumentsDictionary)
        {

            var o = new T();

            foreach (var a in argumentsDictionary)
            {
                o.SetValue(a.Key, a.Value);
            }

            return o;
        }

        private static IDictionary<string, string> ArgArrayToDictionary(string[] args)
        {
            var dict = new Dictionary<string, string>();

            foreach (var s in args)
            {
                var pair = GetArgPair(s);
                dict.Add(pair.Key, pair.Value);
            }

            return dict;
        }

        private static KeyValuePair<string, string> GetArgPair(string s)
        {
            var ss = s.Split('=');

            if (ss.Length == 1)
            {
                //return single pair
                return new KeyValuePair<string, string>(SanitizeArg(ss[0]), null);
            }
            else if (ss.Length == 2)
            {
                return new KeyValuePair<string, string>(SanitizeArg(ss[0]), SanitizeArg(ss[1]));
            }

            throw new CommandLineException($"Command line argument parsing: Can't parse {s}");
        }

        private static string SanitizeArg(string s)
        {
            return s.Trim(' ', '"');
        }
    }
}
