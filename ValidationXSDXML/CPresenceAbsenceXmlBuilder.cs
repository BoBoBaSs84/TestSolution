using System;
using System.IO;
using System.Xml.Serialization;
using ValidationXSDXML.PresenceAbsenceSchema;

namespace ValidationXSDXML
{
    public class CPresenceAbsenceXmlBuilder
    {
        public void CreateXml()
        {
            var pa = new PresenceAbsence();
            pa.Items = new create[1];

            var cr = new create()
            { 
                Date = DateTime.Now, 
                GID = "Z0024KJP", 
                IdOrganisation = 61, 
                IdDayType = 0, 
                StartTime = DateTime.Now, 
                EndTime = DateTime.Now 
            };
            pa.Items[0] = cr;

            var serializer = new XmlSerializer(typeof(PresenceAbsence));
            using (var stream = new StreamWriter("D:\\Test.xml"))
            {
                serializer.Serialize(stream, pa);
            }
        }
    }
}
