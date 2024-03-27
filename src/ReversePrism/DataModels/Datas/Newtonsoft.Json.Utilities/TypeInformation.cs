using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     0001866936B0 ModelClassType Type Type Type Pointer
    // 018 TypeCode                                 000186644220 ModelEnumType PrimitiveTypeCode PrimitiveTypeCode PrimitiveTypeCode Int32
    public partial class TypeInformation
    {
        public Type?                                    Type                                    { get; set; }
        public PrimitiveTypeCode                        TypeCode                                { get; set; }

        public static TypeInformation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TypeInformation();

            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 027005FF0128 0x10 Type                        ( 0001866936B0 ModelClassType Type Type Type Pointer )
            value.TypeCode                                  = (PrimitiveTypeCode)GetInt32(new IntPtr(p + 0x018)); // 027005FF0148 0x18 TypeCode                    ( 000186644220 ModelEnumType PrimitiveTypeCode PrimitiveTypeCode PrimitiveTypeCode Int32 )

            return value;
        }
    }
}
