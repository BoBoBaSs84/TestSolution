using McMaster.Extensions.CommandLineUtils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
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
        private string Xsdfile { get; set; }

        [Argument(1, Description = "Name of the XML file i.e. xmlfile.xml, must be same directory of executable")]
        private string Xmlfile { get; set; }

        private void OnExecute()
        {
            if (Xsdfile == null)
            {
                //DEBUG
                //let's set it hard ... for debuging purpose and shit...
                Xsdfile = "MCP.xsd";
                //Console.WriteLine("specify the xsd file (bla.xsd) ... better start with the parameter -?");
                //return;
            }
            if (Xmlfile == null)
            {
                //DEBUG
                //let's set it hard ... for debuging purpose and shit...
                Xmlfile = "MCP.xml";
                //Console.WriteLine("specify the xml file (blub.xml) ... better start with the parameter -?");
                //return;
            }
            bool valid = CheckXmlViaXsd(Xsdfile, Xmlfile);
            if(valid == true)
            {
                var path = new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).LocalPath;
                XmlReader rd = XmlReader.Create(path + "\\" + Xmlfile);
                XDocument doc = XDocument.Load(rd);

                DesrializeXmlToArray(doc.ToString());
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
        /// Deserialisieren des XML in das passende Objekt und ein bisschen Konsolen-Prosa Array[]...
        /// </summary>
        /// <param name="p_strXml"></param>
        private static void DesrializeXmlToArray(string p_strXml)
        {
            //putting them xml into lovely defined objects...
            DataType dataType = CXmlSerializerDeserializer<DataType>.ToObject(p_strXml);
            //array to col...
            ICollection<DeviceType> deviceTypes = dataType.Devices.ToList();
            ICollection<PanelType> panelTypes = dataType.Panels.ToList();
            //let's do some prosa....
            Console.WriteLine($"Reading some devices from xml ...{Environment.NewLine}");

            Thread.Sleep(1500);

            foreach (DeviceType device in deviceTypes)
            {
                Console.WriteLine($"{device.ID}|{device.Name}|{device.ItemNumber}|{device.Revision}|{device.MLFB}|{device.InternalName}");
            }
            
            Console.WriteLine($"{Environment.NewLine}Want some panels too?{Environment.NewLine}");
            
            Thread.Sleep(1500);
            
            foreach (PanelType panel in panelTypes)
            {
                Console.WriteLine($"{panel.ID}|{panel.Name}|{panel.ItemNumber}|{panel.Revision}|{panel.Instance}|{panel.Segment}");
            }
        }
    }
}
