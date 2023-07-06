
using CsvHelper;
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
        /// <summary>
        /// Serializa un objeto en formato XML y lo guarda en un archivo.
        /// </summary>
        /// <param name="entidad">El objeto a serializar.</param>
        /// <param name="nombreArchivo">El nombre del archivo donde se guardará el XML.</param>
        public void SerializarXML(T entidad, string nombreArchivo)
        {
            using (StreamWriter streamWriter = new StreamWriter(nombreArchivo))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                xmlSerializer.Serialize(streamWriter, entidad);
            }
        }

        /// <summary>
        /// Deserializa un objeto desde un archivo XML.
        /// </summary>
        /// <param name="nombreArchivo">El nombre del archivo XML.</param>
        /// <returns>El objeto deserializado.</returns>

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

        /// <summary>
        /// Serializa un objeto en formato JSON y lo guarda en un archivo.
        /// </summary>
        /// <param name="entidad">El objeto a serializar.</param>
        /// <param name="nombreArchivo">El nombre del archivo donde se guardará el JSON.</param>
        public void SerializarJSON(T entidad, string nombreArchivo)
        {
            var options = new JsonSerializerOptions();
            options.WriteIndented = true;
            string jsonString = JsonSerializer.Serialize(entidad, options);
            File.WriteAllText(nombreArchivo, jsonString);
        }

        /// <summary>
        /// Deserializa un objeto desde un archivo JSON.
        /// </summary>
        /// <param name="nombreArchivo">El nombre del archivo que contiene el JSON.</param>
        /// <returns>El objeto deserializado.</returns>

        public T DeserializarJSON(string nombreArchivo)
        {
            T Objetodeserializado;
            string jsonString = File.ReadAllText(nombreArchivo);
            Objetodeserializado = JsonSerializer.Deserialize<T>(jsonString);
            return Objetodeserializado;
        }
        /// <summary>
        /// Serializa una colección de objetos en formato CSV.
        /// </summary>
        /// <typeparam name="T">El tipo de los objetos en la colección.</typeparam>
        /// <param name="entidad">La colección de objetos a serializar.</param>
        /// <param name="nombreArchivo">El nombre del archivo de salida.</param>
        public void SerializarCSV<T>(IEnumerable<T> entidad, string nombreArhcivo)
        {
            StreamWriter streamWriter = new StreamWriter(nombreArhcivo);
            using (var csv = new CsvWriter(streamWriter, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(entidad);
            }
            streamWriter.Close();
        }
        /// <summary>
        /// Deserializa un archivo CSV en una lista de objetos del tipo especificado.
        /// </summary>
        /// <typeparam name="T">El tipo de los objetos en la lista.</typeparam>
        /// <param name="nombreArchivo">El nombre del archivo CSV.</param>
        /// <returns>Una lista de objetos deserializados.</returns>
        public List<T> DeserializarCSV<T>(string nombreArchivo)
        {
            List<T> Objetodeserializado;
            StreamReader streamReader = new StreamReader(nombreArchivo);
            using (var csv = new CsvReader(streamReader, CultureInfo.InvariantCulture))
            {
                Objetodeserializado = csv.GetRecords<T>().ToList();
            }
            streamReader.Close();
            return Objetodeserializado;
        }
    }
}
