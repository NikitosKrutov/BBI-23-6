using System.Text.Json;
using System.Text.Json.Serialization;
abstract class Task
{
    protected string text = "No text";
    public string Text
    {
        get => text;
        protected set => text = value;
    }
    [JsonConstructor]
    public Task()
    {
    }
}
class Task1 : Task
{
    [JsonConstructor]
    public Task1(string text) { this.text = text; }
    public override string ToString()
    {
        int counter = 0;
        bool numberStarted = false;
        int startIndex = 0;
        for (int i = 0; i < text.Length; i++)
        {
           if (numberStarted)
            {
                if (text[i] == '.' | char.IsDigit(text[i])) { }
                else { numberStarted = false; counter++; }
            }
           else
           {
                if (char.IsDigit(text[i]))
                {
                    numberStarted = true;
                }
           }
        }
        double[] result = new double[counter];
        counter = 0;
        numberStarted = false;
        bool isNegative = false;
        startIndex = 0;
        for (int i = 0; i < text.Length; i++)
        {
            if (numberStarted)
            {
                if (text[i] == '.' | char.IsDigit(text[i])) { }
                else 
                {
                    numberStarted = false;
                    double t = 0;
                    int g = 0;
                    for (int j = i - 1; j > startIndex; j--)
                    {
                        if (text[j] == '.')
                        {
                            t /= Math.Pow(10, g);
                            g = 0;
                        }
                        else
                        {
                            t += int.Parse(text[j].ToString()) * Math.Pow(10, g);
                            g++;
                        }
                    }
                    result[counter] = t;
                    if (isNegative) { result[counter] *= -1; }
                    counter++;
                    isNegative = false;
                }
            }
            else
            {
                if (char.IsDigit(text[i]))
                {
                    if (text[i - 1] == '-') { isNegative = true; }
                    startIndex = i - 1;
                    numberStarted = true;
                }
            }
        }
        return string.Join("\n", result);
    }
}
class Task2 : Task
{
    [JsonConstructor]
    public Task2(string text) { this.text = text; }
    public override string ToString()
    {
        char[] a = { 'ё', 'й', 'ц', 'у', 'к', 'е', 'н', 'г', 'ш', 'щ', 'з', 'х', 'ъ', 'ф', 'ы', 'в', 'а', 'п', 'р', 'о', 'л', 'д', 'ж', 'э', 'я', 'ч', 'с', 'м', 'и', 'т', 'ь', 'б', 'ю' };
        int[] b = new int[33];
        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsLetter(text[i]))
            {
                for (int j = 0; j < 33; j++)
                {
                    if (a[j] == char.ToLower(text[i])) { b[j]++; }
                }
            }
        }
        int max = 0;
        int index = 0;
        for (int i = 0; i < 33; i++)
        {
            if (b[i] > max) { max = b[i]; index = i; }
        }
            return a[index].ToString();
    }
}
class JsonIO
{
    public static void Write<T>(T obj, string filePath)
    {
        using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
        {
            JsonSerializer.Serialize(fs, obj);
        }
    }
    public static T Read<T>(string filePath)
    {
        using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
        {
            return JsonSerializer.Deserialize<T>(fs);
        }
        return default(T);
    }
}

    class Control2
    {
        static void Main()
        {
            string text = "Hello Students ;)";
            Task[] tasks = { new Task1(text), new Task2(text)
        };
            Console.WriteLine(tasks[0]);

            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string folderName = "Control Work";
            path = Path.Combine(path, folderName);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string fileName1 = "cw2_1.json";
            string fileName2 = "cw2_2.json";

            fileName1 = Path.Combine(path, fileName1);
            fileName2 = Path.Combine(path, fileName2);

            if (!File.Exists(fileName2))
            {
                JsonIO.Write<Task1>(tasks[0] as Task1, fileName1);
                JsonIO.Write<Task2>(tasks[1] as Task2, fileName2);
            }
            else
            {
                var t1 = JsonIO.Read<Task1>(fileName1);
                var t2 = JsonIO.Read<Task2>(fileName2);
                Console.WriteLine(t1);
                Console.WriteLine(t2);
            }
        }
    }
