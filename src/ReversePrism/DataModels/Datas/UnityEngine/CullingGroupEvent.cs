using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Index                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 M_PrevState                              00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 015 M_ThisState                              00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte
    public partial class CullingGroupEvent : DataModel
    {
        public int                                      M_Index                                 { get; set; }
        public sbyte                                    M_PrevState                             { get; set; }
        public sbyte                                    M_ThisState                             { get; set; }

        public static CullingGroupEvent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CullingGroupEvent() { Pointer= p0 };

            value.M_Index                                   = GetInt32(new IntPtr(p + 0x010)); // 0245A686A228 0x10 M_Index                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_PrevState                               = GetSByte(new IntPtr(p + 0x014)); // 0245A686A248 0x14 M_PrevState                 ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.M_ThisState                               = GetSByte(new IntPtr(p + 0x015)); // 0245A686A268 0x15 M_ThisState                 ( 00018659CA20 ModelPrimitiveType sbyte sbyte sbyte SByte )

            return value;
        }
    }
}
