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
            var pa = new PresenceAbsence.paDataTable();
            pa.AddpaRow("1,0");
            var cr = new PresenceAbsence.createDataTable();
            cr.AddcreateRow(DateTime.Now, "", 61, 1, DateTime.Now, DateTime.Now, pa[0]);
            var up = new PresenceAbsence.updateDataTable();
            var de = new PresenceAbsence.deleteDataTable();
        }
    }
}
