using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MethodName                               000186671910 ModelPrimitiveType string string string String
    // 018 Type                                     000186692850 ModelClassType Type Type Type Pointer
    public partial class KnownTypeAttribute
    {
        public string                                   MethodName                              { get; set; }
        public Type?                                    Type                                    { get; set; }

        public static KnownTypeAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new KnownTypeAttribute();

            value.MethodName                                = GetString(new IntPtr(p + 0x010)); // 027004CF55E0 0x10 MethodName                  ( 000186671910 ModelPrimitiveType string string string String )
            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x018), ReversePrism.DataModels.Type.FromPointer); // 027004CF5600 0x18 Type                        ( 000186692850 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
