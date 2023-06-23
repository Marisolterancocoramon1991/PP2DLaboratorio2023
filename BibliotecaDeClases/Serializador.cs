
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BibliotecaDeClases
{
    public class Serializador<T>
    {
        public void SerializarXML(T entidad, string nombreArchivo)
        {
            using (StreamWriter streamWriter = new StreamWriter(nombreArchivo))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                xmlSerializer.Serialize(streamWriter, entidad);
            }
        }


        public T DeserializarXMl(string nombreArchivo)
        {
            T Objetodeserializado;

            using (StreamReader sr = new StreamReader(nombreArchivo))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                Objetodeserializado = (T?)xmlSerializer.Deserialize(sr);
            }
            return (T)Objetodeserializado;
        }


        public void SerializarJSON(T entidad, string nombreArchivo)
        {
            var options = new JsonSerializerOptions();
            options.WriteIndented = true;
            string jsonString = JsonSerializer.Serialize(entidad, options);
            File.WriteAllText(nombreArchivo, jsonString);
        }

        public T DeserializarJSON(string nombreArchivo)
        {
            T Objetodeserializado;
            string jsonString = File.ReadAllText(nombreArchivo);
            Objetodeserializado = JsonSerializer.Deserialize<T>(jsonString);
            return Objetodeserializado;
        }


    }
}
