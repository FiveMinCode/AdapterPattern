using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AdapterPatternWebAPI
{
    public class XMLToJsonAdapter:IXMLToJsonAdapter
    {
        public string Parse(string xmlFileName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlFileName);
            return JsonConvert.SerializeXmlNode(doc);
        } 
    }
}
