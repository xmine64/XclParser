using System;

namespace XclParser.Reflection
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class XclFieldAttribute : Attribute
    {
        public string Name { get; set; }
    }
}
