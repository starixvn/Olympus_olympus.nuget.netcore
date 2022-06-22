using System;

namespace Olympus.InfoSiteClient.Extensions.XMLExtensions
{


    [AttributeUsage(AttributeTargets.All)]
    public sealed class XMLName : Attribute
    {
        private readonly string name;

        public XMLName(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }
    }
}