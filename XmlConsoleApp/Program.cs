using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Xml;
using System.Xml.XPath;

namespace XmlConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = new Uri(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).LocalPath;
            string Input_FilePath = $"{path}\\MCP.xml";

            XmlDocument doc = new XmlDocument();
            doc.Load(Input_FilePath);

            StringBuilder sb = XmlHandler.StringBuilderFromXmlDocument(doc);
            Console.WriteLine(sb.ToString());

            Thread.Sleep(5000);

            sb = XmlHandler.StringBuilderFromXPathDocument(new XPathDocument(Input_FilePath));
            Console.WriteLine(sb.ToString());

            Thread.Sleep(5000);

            sb = XmlHandler.StringBuilderFromXPathNavigator(new XPathDocument(Input_FilePath).CreateNavigator());
            Console.WriteLine(sb.ToString());

            Thread.Sleep(5000);

            String ss = XmlHandler.StringFromXmlDocument(doc);
            Console.WriteLine(ss);

            Thread.Sleep(5000);

            ss = XmlHandler.StringFromXPathDocument(new XPathDocument(Input_FilePath));
            Console.WriteLine(ss);

            Thread.Sleep(5000);

            ss = XmlHandler.StringFromXPathNavigator(new XPathDocument(Input_FilePath).CreateNavigator());
            Console.WriteLine(ss);
        }
    }
}
