using Newtonsoft.Json;
using System.IO;

namespace LessonEight.Serialization
{
    public class SerializationClass
    {
        public string SerializeObject(object obj)
        {
            var json = JsonConvert.SerializeObject(obj);
            File.WriteAllText("converted.json", json);
            return json;
        }

        public object DeSerializeObject(string json)
        {
            return JsonConvert.DeserializeObject(json);
        }
    }
}
