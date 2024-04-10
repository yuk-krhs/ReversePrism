using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ServerProcessCount                       0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 014 LastServerTime                           0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 018 MaxServerTime                            0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 01C AverageServerTime                        0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 020 LastServerInterval                       0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 024 MaxServerInterval                        0001866992B0 ModelPrimitiveType uint uint uint UInt32
    // 028 AverageServerInterval                    0001866992B0 ModelPrimitiveType uint uint uint UInt32
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

            value.ServerProcessCount                        = GetUInt32(new IntPtr(p + 0x010)); // 02466ACD49A0 0x10 ServerProcessCount          ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.LastServerTime                            = GetUInt32(new IntPtr(p + 0x014)); // 02466ACD49C0 0x14 LastServerTime              ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.MaxServerTime                             = GetUInt32(new IntPtr(p + 0x018)); // 02466ACD49E0 0x18 MaxServerTime               ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.AverageServerTime                         = GetUInt32(new IntPtr(p + 0x01C)); // 02466ACD4A00 0x1C AverageServerTime           ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.LastServerInterval                        = GetUInt32(new IntPtr(p + 0x020)); // 02466ACD4A20 0x20 LastServerInterval          ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.MaxServerInterval                         = GetUInt32(new IntPtr(p + 0x024)); // 02466ACD4A40 0x24 MaxServerInterval           ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )
            value.AverageServerInterval                     = GetUInt32(new IntPtr(p + 0x028)); // 02466ACD4A60 0x28 AverageServerInterval       ( 0001866992B0 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
