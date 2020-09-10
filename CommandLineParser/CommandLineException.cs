using System;
using System.Collections.Generic;
using System.Text;

namespace CommandLineParser
{
    public class CommandLineException:InvalidOperationException
    {
        public CommandLineException(string message) : base(message)
        { }
    }
}
