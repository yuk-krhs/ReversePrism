using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Flag_Fixed                               sbyte IL2CPP_TYPE_U1
    // 000 Flag_Move                                sbyte IL2CPP_TYPE_U1
    // 000 Flag_InvalidMotion                       sbyte IL2CPP_TYPE_U1
    // 000 Flag_DisableCollision                    sbyte IL2CPP_TYPE_U1
    // 000 Flag_Triangle                            sbyte IL2CPP_TYPE_U1
    // 000 Invalid                                  VertexAttribute IL2CPP_TYPE_VALUETYPE
    // 001 Fixed                                    VertexAttribute IL2CPP_TYPE_VALUETYPE
    // 002 Move                                     VertexAttribute IL2CPP_TYPE_VALUETYPE
    // 003 DisableCollision                         VertexAttribute IL2CPP_TYPE_VALUETYPE
    // 010 Value                                    ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class VertexAttribute : DataModel
    {
        public sbyte                                    Value                                   { get; set; }

        public static VertexAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VertexAttribute() { Pointer= p0 };

            value.Value                                     = GetSByte(new IntPtr(p + 0x010)); // 0x10 Value                       ( ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
