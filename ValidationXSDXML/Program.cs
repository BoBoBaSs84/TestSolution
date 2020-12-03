using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace ValidationXSDXML
{
    class Program
    {

        static void Main(string[] args)
        {
            var path = new Uri(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)).LocalPath;
            XmlSchemaSet schema = new XmlSchemaSet();
            schema.Add("", path + "\\mk.xsd");
            XmlReader rd = XmlReader.Create(path + "\\102865640.xml");
            XDocument doc = XDocument.Load(rd);
            doc.Validate(schema, ValidationEventHandler);
        }
        static void ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            XmlSeverityType type = XmlSeverityType.Warning;
            if (Enum.TryParse<XmlSeverityType>("Error", out type))
            {
                if (type == XmlSeverityType.Error) throw new Exception(e.Message);
            }
        }

    }
}
