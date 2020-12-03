using McMaster.Extensions.CommandLineUtils;
using System;

namespace ValidationXSDXML
{
    [Command(Name = "XML XSD Validator", Description = "The application validates an XML against the given XSD")]
    [HelpOption("-?")]
    class Program
    {
        static void Main(string[] args) => CommandLineApplication.Execute<Program>(args);

        [Argument(0, Description = "XSD file")]
        private string xsdfile { get; }
        [Argument(1, Description ="XML file")]
        private string xmlfile { get; }

        private void OnExecute()
        {
            if(xsdfile == null)
            {
                Console.WriteLine("specify the xsd file ... better start with the parameter -?");
                return;
            }
            if (xmlfile == null)
            {
                Console.WriteLine("specify the xml file ... better start with the parameter -?");
                return;
            }
            var validate = new Validation();
            validate.Validate(xsdfile, xmlfile);
        }
    }
}
