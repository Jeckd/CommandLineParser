using System;
using System.Collections.Generic;
using System.Text;

namespace CommandLineParser
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class CommandLineOptionAttribute: System.Attribute
    {

        public string ShortName;
        public string LongName;
        public string HelpText;

        public CommandLineOptionAttribute(string shortName, string longName)
        {
            this.ShortName = shortName;
            this.LongName = longName;
            HelpText = string.Empty;
        }
    }
}
