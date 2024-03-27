using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PrimitiveTypeEnum                        0001865FCE10 ModelEnumType InternalPrimitiveTypeE InternalPrimitiveTypeE InternalPrimitiveTypeE Int32
    // 018 value                                    <object> IL2CPP_TYPE_OBJECT
    public partial class MemberPrimitiveTyped
    {
        public InternalPrimitiveTypeE                   PrimitiveTypeEnum                       { get; set; }

        public static MemberPrimitiveTyped? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MemberPrimitiveTyped();

            value.PrimitiveTypeEnum                         = (InternalPrimitiveTypeE)GetInt32(new IntPtr(p + 0x010)); // 0270D6C32158 0x10 PrimitiveTypeEnum           ( 0001865FCE10 ModelEnumType InternalPrimitiveTypeE InternalPrimitiveTypeE InternalPrimitiveTypeE Int32 )

            return value;
        }
    }
}
