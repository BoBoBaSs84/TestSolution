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
            var pa =
                new PresenceAbsence() { version = "1.0.0" };

            pa.create = new create[1] 
            {
                (create)AddCreateToXml(DateTime.Now, "Z0024KJP", 61, 1, DateTime.Now, DateTime.Now) 
            };
            pa.update = new update[1]
            {
                (update)AddUpdateToXml(DateTime.Now, "Z0024KJP", 61, 1, DateTime.Now, DateTime.Now)
            };
            pa.delete = new delete[1]
            {
                (delete)AddDeletetoXml(DateTime.Now, "Z0024KJP", 61)
            };

            var serializer = new XmlSerializer(typeof(PresenceAbsence));
            using (var stream = new StreamWriter("D:\\CSC\\TestSolution\\ValidationXSDXML\\bin\\Debug\\netcoreapp3.1\\misc\\Test.xml"))
            {
                serializer.Serialize(stream, pa);
            }
        }
        private static object AddCreateToXml(DateTime p_dtDate, string p_strGid, int p_nIdOrganisation, int p_nIdDayType, DateTime p_dtStartTime, DateTime p_dtEndTime)
        {
            var cr =
                new create()
                {
                    date = p_dtDate,
                    gid = p_strGid,
                    idorganisation = p_nIdOrganisation.ToString(),
                    iddaytype = p_nIdDayType.ToString(),
                    starttime = p_dtStartTime,
                    endtime = p_dtEndTime
                };
            return cr;
        }
        private static object AddUpdateToXml(DateTime p_dtDate, string p_strGid, int p_nIdOrganisation, int p_nIdDayType, DateTime p_dtStartTime, DateTime p_dtEndTime)
        {
            var up =
                new update()
                {
                    date = p_dtDate,
                    gid = p_strGid,
                    idorganisation = p_nIdOrganisation.ToString(),
                    iddaytype = p_nIdDayType.ToString(),
                    starttime = p_dtStartTime,
                    endtime = p_dtEndTime
                };
            return up;
        }
        private static object AddDeletetoXml(DateTime p_dtDate, string p_strGid, int p_nIdOrganisation)
        {
            var de =
                new delete()
                {
                    date = p_dtDate,
                    gid = p_strGid,
                    idorganisation = p_nIdOrganisation.ToString()
                };
            return de;
        }
    }
}
