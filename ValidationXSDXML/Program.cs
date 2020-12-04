using McMaster.Extensions.CommandLineUtils;
using System;

namespace ValidationXSDXML
{
    [Command(Name = "XML XSD Validator", Description = "The application validates an XML against the given XSD")]
    [HelpOption("-?")]
    class Program
    {
        static void Main(string[] args) => CommandLineApplication.Execute<Program>(args);

        [Argument(0, Description = "Name of the XSD file i.e. xsdfile.xsd, must be same directory of executable")]
        private string Xsdfile { get; }
        [Argument(1, Description = "Name of the XML file i.e. xmlfile.xml, must be same directory of executable")]
        private string Xmlfile { get; }

        private void OnExecute()
        {
            if(Xsdfile == null)
            {
                Console.WriteLine("specify the xsd file (bla.xsd) ... better start with the parameter -?");
                return;
            }
            if (Xmlfile == null)
            {
                Console.WriteLine("specify the xml file (blub.xml) ... better start with the parameter -?");
                return;
            }
            var validate = new Validation();
            validate.Validate(Xsdfile, Xmlfile);
        }
    }
}
