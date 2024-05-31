using System.IO;
using System.Xml.Serialization;
public class MyXmlSerializer : MySerializer
{
    public override void Write<T>(T obj, string path)
    {
        using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
        {
            new XmlSerializer(typeof(T)).Serialize(fs, obj);
        }
    }
    public override T Read<T>(string path)
    {
        using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
        {
            return (T)new XmlSerializer(typeof(T)).Deserialize(fs);
        }
    }
}