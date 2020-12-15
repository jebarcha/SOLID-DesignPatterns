using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1._3_Structural_Patterns.Adapter
{
    public class XmlToJsonAdapter : IXMLToJson
    {
        private XmlConverter _xmlConverter;
        public XmlToJsonAdapter(XmlConverter xmlConverter)
        {
            _xmlConverter = xmlConverter;
        }

        public void ConvertXmlToJson()
        {
            var products = _xmlConverter.GetXml()
                   .Element("Productos")
                   .Elements("Producto")
                   .Select(m => new Product
                   {
                        Name = m.Attribute("Nombre").Value,
                        Price = int.Parse(m.Attribute("Precio").Value)
                   });

            new JsonConverter(products).ConvertToJson(); //.GetJson();
        }
    }
}
