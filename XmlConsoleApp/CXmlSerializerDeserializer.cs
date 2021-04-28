using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace XmlConsoleApp
{
    public static class CXmlSerializerDeserializer<T>
    {
        internal static readonly XmlSerializer _serializer = null;
        #region Static Constructor
        /// <summary>
        /// Static constructor that initialises the serializer for this type
        /// </summary>
        static CXmlSerializerDeserializer()
        {
            _serializer = new XmlSerializer(typeof(T));
        }
        #endregion
        #region Public Methods
        /// <summary>
        /// Deserialisiert ein XML in ein Objekt
        /// </summary>
        /// <param name="xml"></param>
        /// <returns></returns>
        public static T ToObject(string xml)
        {
            return (T)_serializer.Deserialize(new StringReader(xml));
        }
        /// <summary>
        /// Serialisiert ein Object in ein XML
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToXml(T obj)
        {
            using (var memoryStream = new MemoryStream())
            {
                _serializer.Serialize(memoryStream, obj);
                return Encoding.UTF8.GetString(memoryStream.ToArray());
            }
        }
        #endregion
    }
}