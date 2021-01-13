using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace ConsoleApp1._2_Creational_Patterns.Prototype.DeepCopy
{
    public static class ExtensionMethods
    {
        public static T DeepCopy<T>(this T self) 
        {
            var stream = new MemoryStream();
            var formatter = new BinaryFormatter();
            
            formatter.Serialize(stream, self);
            stream.Seek(0, SeekOrigin.Begin);

            object copy = formatter.Deserialize(stream);
            stream.Close();
            return (T)copy;
        }
    }
}
