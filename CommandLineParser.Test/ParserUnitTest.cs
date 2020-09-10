using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommandLineParser.Test
{
    /// <summary>
    /// Summary description for ParserUnitTest
    /// </summary>
    [TestClass]
    public class ParserUnitTest
    {

        [TestMethod]
        public void Parser_returns_an_options_class()
        {
            Assert.IsNotNull(CommandLineParser<TestCommandLineOptions>.GetOptions(null));
        }
    }
}
