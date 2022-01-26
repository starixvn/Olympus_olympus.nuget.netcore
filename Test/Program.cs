using Newtonsoft.Json;
using System.Collections.Generic;

namespace Test
{
    public class MyData
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, object>
            {
                { "id" , 1 },
                { "Name" , "Cob" }
            };

            var json = JsonConvert.SerializeObject(dictionary);
            var criteria = JsonConvert.DeserializeObject(json, typeof(MyData));
        }
    }
}
