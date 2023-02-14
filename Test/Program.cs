using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Test
{
    using Olympus.Xml;

    [Serializable]
    [XmlName("Row")]
    public class MyData
    {
        public int Id { get; set; }

        [XmlName("Jacob")]
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<MyData>
            {
                new MyData { Id = 1, Name = "A" }
            };

            var text = XmlConverter.Serialize(list);
        }
    }
}
