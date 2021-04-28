using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace XmlConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).LocalPath;

            string TestXml = path + $"\\" + $"PresenceAbsence.xml";

            //fix for https://www.ipreferjim.com/2014/09/data-at-the-root-level-is-invalid-line-1-position-1/
            string _byteOrderMarkUtf8 = Encoding.UTF8.GetString(Encoding.UTF8.GetPreamble());
            if (TestXml.StartsWith(_byteOrderMarkUtf8))
            {
                var lastIndexOfUtf8 = _byteOrderMarkUtf8.Length - 1;
                TestXml = TestXml.Remove(0, lastIndexOfUtf8);
            }
            PresenceAbsence presenceAbsence = CXmlSerializerDeserializer<PresenceAbsence>.ToObject(TestXml);

        }
    }
}
