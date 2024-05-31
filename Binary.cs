using System.IO;
using ProtoBuf;
using Serializers;

public class MyBinarySerializer : MySerializer
{
    public override void Write<T>(T obj, string path)
    {
        using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
        {
            Serializer.Serialize(fs, obj);
        }
    }
    public override T Read<T>(string path)
    {
        using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
        {
            return Serializer.Deserialize<T>(fs);
        }
    }
}