using System;
namespace Been.Core.Configuration
{
    [Serializable]
    public class MutableConfiguration:AbstractConfiguration
    {
        public MutableConfiguration(String name) : this(name, null)
        {

        }
        public MutableConfiguration(String name,String value)
        {
            Name = name;
            Value = value;
        }
        public new string Value
        {
            get { return base.Value; }
            set { base.Value = value; }
        }
        public static MutableConfiguration Create(string name)
        {
            return new MutableConfiguration(name);
        }
        public MutableConfiguration Attribute(string name,string value)
        {
            Attributes[name] = value;
            return this;
        }
        public MutableConfiguration CreateChild(string name)
        {
            MutableConfiguration child = new MutableConfiguration(name);
            Children.Add(child);
            return child;
        }
        public MutableConfiguration CreateChild(string name,string value)
        {
            MutableConfiguration child = new MutableConfiguration(name, value);
            Children.Add(child);
            return child;
        }
    }
}
