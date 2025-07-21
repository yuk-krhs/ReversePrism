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
    // 010 AddDefaultSchemaMethodName               ModelPrimitiveType string string string String
    public partial class XmlSerializableServices : DataModel
    {
        public string                                   AddDefaultSchemaMethodName              { get; set; }

        public static XmlSerializableServices? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSerializableServices() { Pointer= p0 };

            value.AddDefaultSchemaMethodName                = GetString(new IntPtr(p + 0x010)); // 0x10 AddDefaultSchemaMethodName  ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
