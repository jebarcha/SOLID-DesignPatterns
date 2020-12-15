using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1._3_Structural_Patterns.Adapter
{
    public class JsonConverter
    {
        private IEnumerable<Product> _productData;
        public JsonConverter(IEnumerable<Product> productData)
        {
            _productData = productData;
        }

        public void ConvertToJson() 
        {
            var result = JsonConvert.SerializeObject(_productData);
            Console.WriteLine(result);
        }
    }
}
