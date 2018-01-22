using System;
using System.Collections.Generic;

namespace Been.Core.Configuration
{
    /// <summary>
    /// 配置对象集合
    /// </summary>
    [Serializable]
    public class ConfigurationCollection:List<IConfiguration>
    {
        public ConfigurationCollection()
        { }
        public ConfigurationCollection(IEnumerable<IConfiguration> value)
            : base(value)
        {
            //just base
        }
        public IConfiguration this[String name]
        {
            get
            {
                foreach(IConfiguration config in this)
                {
                    if(name.Equals(config.Name))
                    {
                        return config;
                    }
                }
                return null;
            }
        }
    }
}
