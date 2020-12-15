using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace ConsoleApp1._3_Structural_Patterns.Adapter
{
    public class XmlConverter
    {
        public XDocument GetXml() 
        {
            var xDocument = new XDocument();
            var xElement = new XElement("Productos");
            var xAttributes = ProductDataProvider.GetData()
                .Select(m => new XElement("Producto",
                                new XAttribute("Nombre", m.Name),
                                new XAttribute("Precio", m.Price)));
            xElement.Add(xAttributes);
            xDocument.Add(xElement);

            return xDocument;
        }
    }
}
