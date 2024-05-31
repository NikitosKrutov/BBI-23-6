public abstract class MySerializer
{
    public abstract void Write<T>(T obj, string path);
    public abstract T Read<T>(string path);
}