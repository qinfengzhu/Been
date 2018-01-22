using System;
using System.Collections;
namespace Been.Core.Configuration
{
    /// <summary>
    /// 用于封装配置节点的接口
    /// 检索配置值
    /// </summary>
    public interface IConfiguration
    {
        /// <summary>
        /// 节点名称
        /// </summary>
        String Name { get; }
        /// <summary>
        /// 节点的值
        /// </summary>
        String Value { get; }
        /// <summary>
        /// 子节点集合
        /// </summary>
        ConfigurationCollection Children { get; }
        /// <summary>
        /// 配置属性集合
        /// </summary>
        ConfigurationAttributeCollection Attributes { get; }
        /// <summary>
        /// 获取节点的值，并且转换为指定类型
        /// </summary>
        /// <param name="type">指定类型</param>
        /// <param name="defaultValue">当转换失败的时候，返回默认值</param>
        /// <returns>转换指定类型的值</returns>
        object GetValue(Type type, object defaultValue);
    }
}
