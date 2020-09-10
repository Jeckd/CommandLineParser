using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLineParser;

namespace CommandLineParser.Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            var options =  CommandLineParser<DemoCommandLineOptions>.GetOptions(args);


            Console.WriteLine("Application was started with fallowed arguments:");
            Console.WriteLine($"-Option1 = {options.Option1}");
            Console.WriteLine($"-Property1 = {options.Property1}");

            Console.ReadLine();
        }

        private class DemoCommandLineOptions : CommandLineOptions
        {
            [CommandLineOptionAttribute("o1", "option1")]
            public string Option1;

            [CommandLineOptionAttribute("p1", "property1")]
            public string Property1 { get; set; }

            public override string GetHelp()
            {
                throw new NotImplementedException();
            }
        }

    }
}
