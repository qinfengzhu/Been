using System;
using System.Collections.Specialized;
using System.Runtime.Serialization;

namespace Been.Core.Configuration
{
    [Serializable]
    public class ConfigurationAttributeCollection:NameValueCollection
    {
        public ConfigurationAttributeCollection()
        {
        }
        protected ConfigurationAttributeCollection(SerializationInfo info,StreamingContext context)
            :base(info,context)
        { }
    }
}
