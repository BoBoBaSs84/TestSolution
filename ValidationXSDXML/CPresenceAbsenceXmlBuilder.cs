using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using ValidationXSDXML.PresenceAbsenceSchema;

namespace ValidationXSDXML
{
    public class CPresenceAbsenceXmlBuilder
    {
        public void CreateXml()
        {
            var pa = new PresenceAbsence() { version = "1.0.0" };

            pa.create = new create[2]
            {
                (create)AddCreateToXml(DateTime.Parse("1900-01-01"), "Z0024KJP", 61, 1, DateTime.Parse("06:00:00"), DateTime.ParseExact("15:00:00", "HH:mm:ss", null)),
                (create)AddCreateToXml(DateTime.Parse("1900-01-02"), "Z0024KJP", 61, 1, DateTime.Parse("06:00:00"), DateTime.ParseExact("16:00:00", "HH:mm:ss", null))
            };
            pa.update = new update[1]
            {
                (update)AddUpdateToXml(DateTime.Parse("1900-01-01"), "Z0024KJP", 61, 1, DateTime.Parse("06:00:00"), DateTime.ParseExact("14:00:00", "HH:mm:ss", null))
            };
            pa.delete = new delete[1]
            {
                (delete)AddDeletetoXml(DateTime.Parse("1900-01-02"), "Z0024KJP", 61)
            };

            var serializer = new XmlSerializer(typeof(PresenceAbsence));
            using (var stream = new StreamWriter("D:\\CSC\\TestSolution\\ValidationXSDXML\\misc\\PresenceAbsenceTest.xml"))
            {
                serializer.Serialize(stream, pa);
            };
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_dtDate"></param>
        /// <param name="p_strGid"></param>
        /// <param name="p_nIdOrganisation"></param>
        /// <param name="p_nIdDayType"></param>
        /// <param name="p_dtStartTime"></param>
        /// <param name="p_dtEndTime"></param>
        /// <returns></returns>
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_dtDate"></param>
        /// <param name="p_strGid"></param>
        /// <param name="p_nIdOrganisation"></param>
        /// <param name="p_nIdDayType"></param>
        /// <param name="p_dtStartTime"></param>
        /// <param name="p_dtEndTime"></param>
        /// <returns></returns>
        private static object AddUpdateToXml(DateTime p_dtDate, string p_strGid, int p_nIdOrganisation, int p_nIdDayType, DateTime p_dtStartTime, DateTime p_dtEndTime)
        {
            var up =
                new update()
                {
                    date = p_dtDate,
                    gid = p_strGid,
                    idorganisation = p_nIdOrganisation.ToString(),
                    iddaytype = p_nIdDayType.ToString(),
                    starttime = p_dtStartTime.ToUniversalTime(),
                    endtime = p_dtEndTime.ToUniversalTime()
                };
            return up;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_dtDate"></param>
        /// <param name="p_strGid"></param>
        /// <param name="p_nIdOrganisation"></param>
        /// <returns></returns>
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
