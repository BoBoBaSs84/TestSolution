using System;
using System.IO;
using System.Xml.Serialization;
using ValidationXSDXML.misc;

namespace ValidationXSDXML
{
    public class CPresenceAbsenceXmlBuilder
    {
        public void CreateXml()
        {
            var pa = new PresenceAbsence();            

            var serializer = new XmlSerializer(typeof(PresenceAbsence));
            using (var stream = new StreamWriter("D:\\Text.xml"))
            {
                serializer.Serialize(stream, pa);
            }
        }
    }
}
