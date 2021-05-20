using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace IHChan.Options
{
    public static class YamlController
    {   
        public static T DeserializerAsTag<T>(string path, string tag)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentNullException("path is blank.");
            
            if (string.IsNullOrEmpty(tag))
                throw new ArgumentNullException("tag is blank.");

            if (!File.Exists(path))
                throw new FileNotFoundException($"filePath : {path}\nFile not found.");

            var builder = new DeserializerBuilder().Build();

            using (var stream = File.Open(path, FileMode.Open, FileAccess.Read))
            using (var reader = new StreamReader(stream))
            {
                var obj = builder.Deserialize(reader) as Dictionary<object, object>;

                if (!obj.ContainsKey(tag))
                    throw new ArgumentException("The tag is not found in file");

                return CreateInstance<T>(obj[tag]);
            }
        }

        public static void Serializer<T>(string path, T value)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentNullException("path is blank.");

            if (value == null)
                throw new ArgumentNullException("value is null.");

            if (!File.Exists(path))
                throw new FileNotFoundException($"filePath : {path}\nFile not found.");

            var builder = new SerializerBuilder().Build();

            using (var stream = File.Open(path, FileMode.Create, FileAccess.Write))
            using (var reader = new StreamWriter(stream))
            {
                builder.Serialize(reader, value);
            }
        }

        private static T CreateInstance<T>(object data)
        {
            if (data is Dictionary<object, object> dics)
            {
                var type = typeof(T);
                var instance = Activator.CreateInstance(type);

                foreach(var kv in dics)
                {
                    type.GetProperty($"{kv.Key}", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(instance, kv.Value);
                }

                return (T)instance;
            }

            return default(T);
        }
    }
}
