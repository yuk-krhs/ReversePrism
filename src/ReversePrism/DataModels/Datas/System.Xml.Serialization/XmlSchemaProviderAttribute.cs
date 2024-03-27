using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MethodName                               000186671910 ModelPrimitiveType string string string String
    // 018 IsAny                                    000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class XmlSchemaProviderAttribute
    {
        public string                                   MethodName                              { get; set; }
        public bool                                     IsAny                                   { get; set; }

        public static XmlSchemaProviderAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlSchemaProviderAttribute();

            value.MethodName                                = GetString(new IntPtr(p + 0x010)); // 0270D74C8568 0x10 MethodName                  ( 000186671910 ModelPrimitiveType string string string String )
            value.IsAny                                     = GetBool(new IntPtr(p + 0x018)); // 0270D74C8588 0x18 IsAny                       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
