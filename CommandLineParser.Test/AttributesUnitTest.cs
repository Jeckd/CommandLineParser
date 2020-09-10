using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CommandLineParser;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;

namespace CommandLineParser.Test
{
    [TestClass]
    public class AttributesUnitTest
    {
        

        [TestMethod]
        public void Class_has_a_field_with_an_OptionAttribute()
        {
            var t = typeof(TestCommandLineOptions);
            var fieldAttribute = t.GetFields()
                .FirstOrDefault(
                    (p) => p.GetCustomAttributes<CommandLineOptionAttribute>()
                        .FirstOrDefault((a) => a.LongName == "field") != null
            );

            Assert.IsNotNull(fieldAttribute);
        }

        [TestMethod]
        public void Class_has_a_property_with_an_OptionAttribute()
        {
            var t = typeof(TestCommandLineOptions);
            var propAttribute = t.GetProperties()
                .FirstOrDefault(
                    (p)=>p.GetCustomAttributes<CommandLineOptionAttribute>()
                        .FirstOrDefault((a)=>a.LongName == "property") !=null
                );
            
            Assert.IsNotNull(propAttribute);
        }

        [TestMethod]
        public void Class_doesnt_have_a_field_with_an_OptionAttribute()
        {
            var t = typeof(TestCommandLineOptions);
            var fieldAttribute = t.GetFields()
                .FirstOrDefault(
                    (p) => p.GetCustomAttributes<CommandLineOptionAttribute>()
                        .FirstOrDefault((a) => a.LongName == "unknownField") != null
            );

            Assert.IsNull(fieldAttribute);
        }

        [TestMethod]
        public void Class_doesnt_have_a_property_with_an_OptionAttribute()
        {
            var t = typeof(TestCommandLineOptions);
            var propAttribute = t.GetProperties()
                .FirstOrDefault(
                    (p) => p.GetCustomAttributes<CommandLineOptionAttribute>()
                        .FirstOrDefault((a) => a.LongName == "UnknownProperty") != null
                );

            Assert.IsNull(propAttribute);
        }

    }
}
