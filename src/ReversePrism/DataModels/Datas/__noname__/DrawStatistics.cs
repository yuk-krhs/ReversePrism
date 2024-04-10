using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CurrentFrameIndex                        0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 TotalIndices                             0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 018 CommandCount                             0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 01C DrawCommandCount                         0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 020 MaterialSetCount                         0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 024 DrawRangeCount                           0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 028 DrawRangeCallCount                       0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 02C ImmediateDraws                           0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 030 StencilRefChanges                        0001866992B0 ModelPrimitiveType uint uint uint UInt32
    public partial class DrawStatistics : DataModel
    {
        public int                                      CurrentFrameIndex                       { get; set; }
        public uint                                     TotalIndices                            { get; set; }
        public uint                                     CommandCount                            { get; set; }
        public uint                                     DrawCommandCount                        { get; set; }
        public uint                                     MaterialSetCount                        { get; set; }
        public uint                                     DrawRangeCount                          { get; set; }
        public uint                                     DrawRangeCallCount                      { get; set; }
        public uint                                     ImmediateDraws                          { get; set; }
        public uint                                     StencilRefChanges                       { get; set; }

        public static DrawStatistics? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DrawStatistics() { Pointer= p0 };

            value.CurrentFrameIndex                         = GetInt32(new IntPtr(p + 0x010)); // 0245A6822800 0x10 CurrentFrameIndex           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.TotalIndices                              = GetUInt32(new IntPtr(p + 0x014)); // 0245A6822820 0x14 TotalIndices                ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.CommandCount                              = GetUInt32(new IntPtr(p + 0x018)); // 0245A6822840 0x18 CommandCount                ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.DrawCommandCount                          = GetUInt32(new IntPtr(p + 0x01C)); // 0245A6822860 0x1C DrawCommandCount            ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.MaterialSetCount                          = GetUInt32(new IntPtr(p + 0x020)); // 0245A6822880 0x20 MaterialSetCount            ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.DrawRangeCount                            = GetUInt32(new IntPtr(p + 0x024)); // 0245A68228A0 0x24 DrawRangeCount              ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.DrawRangeCallCount                        = GetUInt32(new IntPtr(p + 0x028)); // 0245A68228C0 0x28 DrawRangeCallCount          ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.ImmediateDraws                            = GetUInt32(new IntPtr(p + 0x02C)); // 0245A68228E0 0x2C ImmediateDraws              ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.StencilRefChanges                         = GetUInt32(new IntPtr(p + 0x030)); // 0245A6822900 0x30 StencilRefChanges           ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
