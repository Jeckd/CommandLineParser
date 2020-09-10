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
        public void Parser_returns_an_options_instance_with_correct_field_string_value()
        {
            Assert.IsTrue(CommandLineParser<TestCommandLineOptions>.GetOptions(new string[]{ "field = field_string"}).OptionField == "field_string");
        }

        [TestMethod]
        public void Parser_returns_an_options_instance_with_correct_property_string_value()
        {
            Assert.IsTrue(CommandLineParser<TestCommandLineOptions>.GetOptions(new string[] { "property = property_string" }).OptionProperty == "property_string");
        }
    }
}
