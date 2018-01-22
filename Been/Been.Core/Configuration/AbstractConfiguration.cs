using System;
using System.Globalization;

namespace Been.Core.Configuration
{
    [Serializable]
    public abstract class AbstractConfiguration:IConfiguration
    {
        private readonly ConfigurationAttributeCollection attributes = new ConfigurationAttributeCollection();
        private readonly ConfigurationCollection children = new ConfigurationCollection();

        /// <summary>
        /// 节点的所有属性
        /// </summary>
        public virtual ConfigurationAttributeCollection Attributes
        {
            get { return attributes; }
        }
        /// <summary>
        /// 所有子节点
        /// </summary>
        public virtual ConfigurationCollection Children
        {
            get { return children; }
        }
        /// <summary>
        /// 配置的名称
        /// </summary>
        public string Name { get; protected set; }
        /// <summary>
        /// 配置的值
        /// </summary>
        public string Value { get; protected set; }
        public virtual object GetValue(Type type,object defaultValue)
        {
            if(type==null)
            {
                throw new ArgumentNullException("type");
            }
            try
            {
                return Convert.ChangeType(Value, type, CultureInfo.CurrentCulture);
            }
            catch(InvalidCastException)
            {
                return defaultValue;
            }
        }
    }
}
