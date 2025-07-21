using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     ModelClassType Type Type Type Pointer
    // 018 TypeCode                                 ModelEnumType PrimitiveTypeCode PrimitiveTypeCode PrimitiveTypeCode Int32
    public partial class TypeInformation : DataModel
    {
        public Type?                                    Type                                    { get; set; }
        public PrimitiveTypeCode                        TypeCode                                { get; set; }

        public static TypeInformation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TypeInformation() { Pointer= p0 };

            value.Type                                      = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0x10 Type                        ( ModelClassType Type Type Type Pointer )
            value.TypeCode                                  = (PrimitiveTypeCode)GetInt32(new IntPtr(p + 0x018)); // 0x18 TypeCode                    ( ModelEnumType PrimitiveTypeCode PrimitiveTypeCode PrimitiveTypeCode Int32 )

            return value;
        }
    }
}
