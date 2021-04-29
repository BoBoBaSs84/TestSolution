using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Reflection;

namespace ValidationXSDXML
{
    public class CValidation
    {
        /// <summary>
        /// Die Methode validiert das xml mit dem xsd, gibt abweichungen line by line aus
        /// </summary>
        /// <param name="p_strXSD"></param>
        /// <param name="p_strXML"></param>
        public void Validate(string p_strXSD, string p_strXML)
        {
            var path = new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).LocalPath;
            XmlSchemaSet schema = new();
            schema.Add(null, path + "\\" + p_strXSD);

            XmlReader rd = XmlReader.Create(path + "\\" + p_strXML);
            XDocument doc = XDocument.Load(rd);

            bool errors = false;
            doc.Validate(schema, (o, e) =>
            {
                Console.WriteLine("{0}", e.Message, o.ToString());
                errors = true;
            });
            Console.WriteLine(p_strXML + " {0} ", errors ? $"{Environment.NewLine}is not valid compared with {p_strXSD}{Environment.NewLine}" : $"{Environment.NewLine}is valid compared with {p_strXSD}{Environment.NewLine}");
        }
    }
}
