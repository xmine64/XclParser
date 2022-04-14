using System;
using System.Collections.Generic;
using System.Text;
using XclParser.Parser;
using XclParser.Reflection;

namespace XclParser.Primitives
{
    public class XclStringType : XclType
    {
        public static XclStringType Instance { get; } = new();

        private XclStringType() : base("string")
        {
        }
    }
}
