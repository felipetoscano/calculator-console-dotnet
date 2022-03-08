using System.Xml.Serialization;

namespace Calculator.Adapters
{
    /*
     * Classe responsável por adaptar recursos para a manipulação dentro do padrão do sistema.
     * Todas essas adaptações ficam dentro de um adapter.
     */
    public class XmlAdapter
    {
        public string GenerateXml(object o)
        {
            var serializer = new XmlSerializer(o.GetType());
            var writer = new StringWriter();
            serializer.Serialize(writer, o);
            return writer.ToString();
        }
    }
}
