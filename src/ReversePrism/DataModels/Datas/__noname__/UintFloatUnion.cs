using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UintValue                                ModelPrimitiveType uint uint uint UInt32
    // 010 FloatValue                               ModelPrimitiveType float float float Single
    public partial class UintFloatUnion : DataModel
    {
        public uint                                     UintValue                               { get; set; }
        public float                                    FloatValue                              { get; set; }

        public static UintFloatUnion? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UintFloatUnion() { Pointer= p0 };

            value.UintValue                                 = GetUInt32(new IntPtr(p + 0x010)); // 0x10 UintValue                   ( ModelPrimitiveType uint uint uint UInt32 )
            value.FloatValue                                = GetSingle(new IntPtr(p + 0x010)); // 0x10 FloatValue                  ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
