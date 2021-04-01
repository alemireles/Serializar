using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Deserializar
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer mySerializer = new XmlSerializer(typeof(Object));
            byte[] byteArray = Encoding.UTF8.GetBytes("String");
            MemoryStream stream = new MemoryStream(byteArray);
            Object comprobante = (Object)mySerializer.Deserialize(stream);


            XmlSerializer mySerializer2 = new XmlSerializer(typeof(Object));
            byte[] byteArray2 = Encoding.UTF8.GetBytes("String");
            FileStream filestram = File.Open("", FileMode.Open);
            Object comprobante2 = (Object)mySerializer.Deserialize(filestram);
            //Subir comentarip

        }
    }
}
