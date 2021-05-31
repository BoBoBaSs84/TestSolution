using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.XPath;

namespace XmlConsoleApp
{
    public class XmlHandler
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_xd"></param>
        /// <returns></returns>
        public static StringBuilder StringBuilderFromXmlDocument(XmlDocument _xd)
        {
            XPathNavigator _xpn;
            try
            {
                _xpn = _xd.CreateNavigator();
            }
            catch (Exception ex)
            {
                
                _xd.LoadXml(ex.Message);
                _xpn = _xd.CreateNavigator();
            }
            return StringBuilderFromXPathNavigator(_xpn);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_xpd"></param>
        /// <returns></returns>
        public static StringBuilder StringBuilderFromXPathDocument(XPathDocument _xpd)
        {
            StringBuilder returnVal = new StringBuilder();
            XPathNavigator _xpn;
            try
            {
                _xpn = _xpd.CreateNavigator();
                returnVal.AppendLine(_xpn.OuterXml.Trim());
            }
            catch (Exception ex)
            {
                returnVal = new StringBuilder()
                    .Append(ex.Message);
            }
            return returnVal;
        }
        ///
        public static StringBuilder StringBuilderFromXPathNavigator(XPathNavigator _xpn)
        {
            StringBuilder returnVal = new StringBuilder();
            try
            {
                returnVal.AppendLine(_xpn.OuterXml.Trim());
            }
            catch (Exception ex)
            {
                returnVal = new StringBuilder()
                    .Append(ex.Message);
            }
            return returnVal;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_xd"></param>
        /// <returns></returns>
        public static string StringFromXmlDocument(XmlDocument _xd)
        {
            XPathNavigator _xpn;
            try
            {
                _xpn = _xd.CreateNavigator();
            }
            catch (Exception ex)
            {
                _xd.LoadXml(ex.Message);
                _xpn = _xd.CreateNavigator();
            }
            return StringFromXPathNavigator(_xpn);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_xpn"></param>
        /// <returns></returns>
        public static string StringFromXPathNavigator(XPathNavigator _xpn)
        {
            string returnVal;
            try
            {
                returnVal = _xpn.OuterXml.Trim();
            }
            catch (Exception ex)
            {
                returnVal = ex.Message;
            }
            returnVal = _xpn.OuterXml.Trim();
            return returnVal;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_xpd"></param>
        /// <returns></returns>
        public static string StringFromXPathDocument(XPathDocument _xpd)
        {
            string returnVal;
            XPathNavigator _xpn;
            try
            {
                _xpn = _xpd.CreateNavigator();
                returnVal = _xpn.OuterXml.Trim();
            }
            catch (Exception ex)
            {
                returnVal = ex.Message;
            }
            return returnVal;
        }
    }
}
