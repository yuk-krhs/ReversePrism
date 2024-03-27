using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 TypeCode                                 000186643F90 ModelEnumType PrimitiveTypeCode PrimitiveTypeCode PrimitiveTypeCode Int32
    // 000 ReadTypeMap                              Dictionary`2<Type, ReadType> IL2CPP_TYPE_GENERICINST
    public partial class JsonPrimitiveContract
    {
        public PrimitiveTypeCode                        TypeCode                                { get; set; }

        public static JsonPrimitiveContract? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonPrimitiveContract();

            value.TypeCode                                  = (PrimitiveTypeCode)GetInt32(new IntPtr(p + 0x090)); // 0270060C69C0 0x90 TypeCode                    ( 000186643F90 ModelEnumType PrimitiveTypeCode PrimitiveTypeCode PrimitiveTypeCode Int32 )

            return value;
        }
    }
}
