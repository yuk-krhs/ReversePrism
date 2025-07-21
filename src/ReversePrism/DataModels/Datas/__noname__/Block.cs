using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Range                                    ModelEnumType Range Range Range Int32
    // 020 BytesPerItem                             ModelPrimitiveType int int int Int32
    // 024 AllocatedItems                           ModelPrimitiveType int int int Int32
    // 028 Log2Alignment                            ModelPrimitiveType sbyte sbyte sbyte SByte
    // 029 Padding0                                 ModelPrimitiveType sbyte sbyte sbyte SByte
    // 02A Padding1                                 ModelPrimitiveType ushort ushort ushort UInt16
    // 02C Padding2                                 ModelPrimitiveType uint uint uint UInt32
    public partial class Block : DataModel
    {
        public Range                                    Range                                   { get; set; }
        public int                                      BytesPerItem                            { get; set; }
        public int                                      AllocatedItems                          { get; set; }
        public sbyte                                    Log2Alignment                           { get; set; }
        public sbyte                                    Padding0                                { get; set; }
        public ushort                                   Padding1                                { get; set; }
        public uint                                     Padding2                                { get; set; }

        public static Block? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Block() { Pointer= p0 };

            value.Range                                     = (Range)GetInt32(new IntPtr(p + 0x010)); // 0x10 Range                       ( ModelEnumType Range Range Range Int32 )
            value.BytesPerItem                              = GetInt32(new IntPtr(p + 0x020)); // 0x20 BytesPerItem                ( ModelPrimitiveType int int int Int32 )
            value.AllocatedItems                            = GetInt32(new IntPtr(p + 0x024)); // 0x24 AllocatedItems              ( ModelPrimitiveType int int int Int32 )
            value.Log2Alignment                             = GetSByte(new IntPtr(p + 0x028)); // 0x28 Log2Alignment               ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Padding0                                  = GetSByte(new IntPtr(p + 0x029)); // 0x29 Padding0                    ( ModelPrimitiveType sbyte sbyte sbyte SByte )
            value.Padding1                                  = GetUInt16(new IntPtr(p + 0x02A)); // 0x2A Padding1                    ( ModelPrimitiveType ushort ushort ushort UInt16 )
            value.Padding2                                  = GetUInt32(new IntPtr(p + 0x02C)); // 0x2C Padding2                    ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
