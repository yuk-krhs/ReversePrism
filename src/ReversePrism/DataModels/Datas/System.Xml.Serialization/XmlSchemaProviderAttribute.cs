using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MethodName                               ModelPrimitiveType string string string String
    // 018 IsAny                                    ModelPrimitiveType bool bool bool Bool
    public partial class XmlSchemaProviderAttribute : DataModel
    {
        public string                                   MethodName                              { get; set; }
        public bool                                     IsAny                                   { get; set; }

        public static XmlSchemaProviderAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaProviderAttribute() { Pointer= p0 };

            value.MethodName                                = GetString(new IntPtr(p + 0x010)); // 0x10 MethodName                  ( ModelPrimitiveType string string string String )
            value.IsAny                                     = GetBool(new IntPtr(p + 0x018)); // 0x18 IsAny                       ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
