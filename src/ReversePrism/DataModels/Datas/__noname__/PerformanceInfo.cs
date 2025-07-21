using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ServerProcessCount                       ModelPrimitiveType uint uint uint UInt32
    // 014 LastServerTime                           ModelPrimitiveType uint uint uint UInt32
    // 018 MaxServerTime                            ModelPrimitiveType uint uint uint UInt32
    // 01C AverageServerTime                        ModelPrimitiveType uint uint uint UInt32
    // 020 LastServerInterval                       ModelPrimitiveType uint uint uint UInt32
    // 024 MaxServerInterval                        ModelPrimitiveType uint uint uint UInt32
    // 028 AverageServerInterval                    ModelPrimitiveType uint uint uint UInt32
    public partial class PerformanceInfo : DataModel
    {
        public uint                                     ServerProcessCount                      { get; set; }
        public uint                                     LastServerTime                          { get; set; }
        public uint                                     MaxServerTime                           { get; set; }
        public uint                                     AverageServerTime                       { get; set; }
        public uint                                     LastServerInterval                      { get; set; }
        public uint                                     MaxServerInterval                       { get; set; }
        public uint                                     AverageServerInterval                   { get; set; }

        public static PerformanceInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PerformanceInfo() { Pointer= p0 };

            value.ServerProcessCount                        = GetUInt32(new IntPtr(p + 0x010)); // 0x10 ServerProcessCount          ( ModelPrimitiveType uint uint uint UInt32 )
            value.LastServerTime                            = GetUInt32(new IntPtr(p + 0x014)); // 0x14 LastServerTime              ( ModelPrimitiveType uint uint uint UInt32 )
            value.MaxServerTime                             = GetUInt32(new IntPtr(p + 0x018)); // 0x18 MaxServerTime               ( ModelPrimitiveType uint uint uint UInt32 )
            value.AverageServerTime                         = GetUInt32(new IntPtr(p + 0x01C)); // 0x1C AverageServerTime           ( ModelPrimitiveType uint uint uint UInt32 )
            value.LastServerInterval                        = GetUInt32(new IntPtr(p + 0x020)); // 0x20 LastServerInterval          ( ModelPrimitiveType uint uint uint UInt32 )
            value.MaxServerInterval                         = GetUInt32(new IntPtr(p + 0x024)); // 0x24 MaxServerInterval           ( ModelPrimitiveType uint uint uint UInt32 )
            value.AverageServerInterval                     = GetUInt32(new IntPtr(p + 0x028)); // 0x28 AverageServerInterval       ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
