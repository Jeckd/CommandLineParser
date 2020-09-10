using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommandLineParser.Test
{
    public class TestCommandLineOptions : CommandLineOptions
    {
        [CommandLineOptionAttribute("f", "field", HelpText = "Field")]
        public string OptionField;

        [CommandLineOptionAttribute("p", "property", HelpText = "Property")]
        public string OptionProperty { get; set; }
        public override string GetHelp()
        {
            throw new NotImplementedException();
        }
    }
}
