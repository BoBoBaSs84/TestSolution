using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace ValidationXSDXML
{
    public class Validation
    {
        public void Validate(string p_strXSD, string p_strXML)
        {            
            var path = new Uri(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)).LocalPath;
            XmlSchemaSet schema = new XmlSchemaSet();
            schema.Add("", path + "\\" + p_strXSD);

            XmlReader rd = XmlReader.Create(path + "\\" + p_strXML);
            XDocument doc = XDocument.Load(rd);
            
            bool errors = false;
            doc.Validate(schema, (o, e) =>
            {
                Console.WriteLine("{0}", e.Message, o.ToString());
                errors = true;
            });
            Console.WriteLine(p_strXML + " {0} ", errors ? "is not valid" : "is valid");
        }
    }
}
