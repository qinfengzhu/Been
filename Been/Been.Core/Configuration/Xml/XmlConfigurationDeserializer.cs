using System;
using System.Text;
using System.Xml;


namespace Been.Core.Configuration.Xml
{
    public class XmlConfigurationDeserializer
    {
        public IConfiguration Deserialize(XmlNode node)
        {
            return GetDeserializedNode(node);
        }
        public static string GetConfigValue(string value)
        {
            if(value==string.Empty)
            {
                return null;
            }
            return value;
        }
        public static bool IsTextNode(XmlNode node)
        {
            return node.NodeType == XmlNodeType.Text || node.NodeType == XmlNodeType.CDATA;
        }
        public static IConfiguration GetDeserializedNode(XmlNode node)
        {
            var configChilds = new ConfigurationCollection();

            var configValue = new StringBuilder();
            if(node.HasChildNodes)
            {
                foreach(XmlNode child in node.ChildNodes)
                {
                    if(IsTextNode(child))
                    {
                        configValue.Append(child.Value);
                    }
                    else if(child.NodeType==XmlNodeType.Element)
                    {
                        configChilds.Add(GetDeserializedNode(child));
                    }
                }
            }

            var config = new MutableConfiguration(node.Name, GetConfigValue(configValue.ToString()));
            foreach(XmlAttribute attribute in node.Attributes)
            {
                config.Attributes.Add(attribute.Name, attribute.Value);
            }
            config.Children.AddRange(configChilds);
            return config;
        }
    }
}
