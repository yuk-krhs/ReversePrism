using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ReadNodesMethodName                      string IL2CPP_TYPE_STRING
    // 008 WriteNodesMethodName                     string IL2CPP_TYPE_STRING
    // 010 AddDefaultSchemaMethodName               0001866727E0 ModelPrimitiveType string string string String
    public partial class XmlSerializableServices
    {
        public string                                   AddDefaultSchemaMethodName              { get; set; }

        public static XmlSerializableServices? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSerializableServices();

            value.AddDefaultSchemaMethodName                = GetString(new IntPtr(p + 0x010)); // 0270D7D73C88 0x10 AddDefaultSchemaMethodName  ( 0001866727E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
