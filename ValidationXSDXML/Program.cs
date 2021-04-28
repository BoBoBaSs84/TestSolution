using McMaster.Extensions.CommandLineUtils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;

namespace ValidationXSDXML
{
    [Command(Name = "XML/XSD Validator", Description = "The application validates an XML against the given XSD")]
    [HelpOption("-?")]
    class Program
    {
        /// <summary>
        /// Paramter -? wirft ein how to...
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) => CommandLineApplication.Execute<Program>(args);

        [Argument(0, Description = "Name of the XSD file i.e. xsdfile.xsd, must be same directory of executable")]
        private string Xsdfile { get; }

        [Argument(1, Description = "Name of the XML file i.e. xmlfile.xml, must be same directory of executable")]
        private string Xmlfile { get; }

        private void OnExecute()
        {
            if (Xsdfile == null)
            {
                Console.WriteLine("specify the xsd file (bla.xsd) ... better start with the parameter -?");
                return;
            }
            if (Xmlfile == null)
            {
                Console.WriteLine("specify the xml file (blub.xml) ... better start with the parameter -?");
                return;
            }
            bool valid = CheckXmlViaXsd(Xsdfile, Xmlfile);
            if(valid == true)
            {
                var path = new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).LocalPath;
                XmlReader rd = XmlReader.Create(path + "\\" + Xmlfile);
                XDocument doc = XDocument.Load(rd);

                DesrializeXml(doc.ToString());
            }
        }
        /// <summary>
        /// Methode prüft ob XML zu XSD valide ist...
        /// </summary>
        /// <param name="p_strXsd"></param>
        /// <param name="p_strXml"></param>
        /// <returns></returns>
        private static bool CheckXmlViaXsd(string p_strXsd, string p_strXml)
        {
            CValidation validate = new();
            try
            {
                validate.Validate(p_strXsd, p_strXml);
                return true;
            }
            catch (Exception)
            {
                return false;
            }            
        }
        /// <summary>
        /// Deserialisieren des XML in das passende Objekt, und ein bisschen Konsolen-Prosa...
        /// </summary>
        /// <param name="p_strXml"></param>
        private static void DesrializeXml(string p_strXml)
        {
            DataType dataType = CXmlSerializerDeserializer<DataType>.ToObject(p_strXml);            
            DeviceType deviceType = dataType.Devices[0];

            
            Console.WriteLine($"{deviceType.ID}, {deviceType.MLFB}, {deviceType.Name}, {deviceType.FirmwareID}");
        }
    }
}
