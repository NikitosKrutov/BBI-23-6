
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Text.Json;
using System;
using System.IO;
using System.Xml.Serialization;

namespace Serializers
{
    public abstract class MySerializer
    {
        public abstract T Read<T>(string path);
        public abstract void Write<T>(T obj, string path);
    }

    public class MyJsonSerializer : MySerializer
    {
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true
        };
        public override void Write<T>(T obj, string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize(fs, obj, options);
            }
        }
        public override T Read<T>(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                return JsonSerializer.Deserialize<T>(fs);
            }
    }
    }
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
}