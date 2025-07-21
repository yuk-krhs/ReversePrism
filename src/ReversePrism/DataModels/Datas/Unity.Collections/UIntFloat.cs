using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FloatValue                               ModelPrimitiveType float float float Single
    // 010 IntValue                                 ModelPrimitiveType uint uint uint UInt32
    // 010 DoubleValue                              ModelPrimitiveType double double double Double
    // 010 LongValue                                ModelPrimitiveType ulong ulong ulong UInt64
    public partial class UIntFloat : DataModel
    {
        public float                                    FloatValue                              { get; set; }
        public uint                                     IntValue                                { get; set; }
        public double                                   DoubleValue                             { get; set; }
        public ulong                                    LongValue                               { get; set; }

        public static UIntFloat? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UIntFloat() { Pointer= p0 };

            value.FloatValue                                = GetSingle(new IntPtr(p + 0x010)); // 0x10 FloatValue                  ( ModelPrimitiveType float float float Single )
            value.IntValue                                  = GetUInt32(new IntPtr(p + 0x010)); // 0x10 IntValue                    ( ModelPrimitiveType uint uint uint UInt32 )
            value.DoubleValue                               = GetDouble(new IntPtr(p + 0x010)); // 0x10 DoubleValue                 ( ModelPrimitiveType double double double Double )
            value.LongValue                                 = GetUInt64(new IntPtr(p + 0x010)); // 0x10 LongValue                   ( ModelPrimitiveType ulong ulong ulong UInt64 )

            return value;
        }
    }
}
