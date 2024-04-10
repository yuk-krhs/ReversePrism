using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_seed                                   uint IL2CPP_TYPE_U4
    // 010 V1                                       000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 014 V2                                       000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 018 V3                                       000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 01C V4                                       000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 020 Queue1                                   000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 024 Queue2                                   000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 028 Queue3                                   000186698B70 ModelPrimitiveType uint uint uint UInt32
    // 02C Length                                   000186698B70 ModelPrimitiveType uint uint uint UInt32
    public partial class HashCode : DataModel
    {
        public uint                                     V1                                      { get; set; }
        public uint                                     V2                                      { get; set; }
        public uint                                     V3                                      { get; set; }
        public uint                                     V4                                      { get; set; }
        public uint                                     Queue1                                  { get; set; }
        public uint                                     Queue2                                  { get; set; }
        public uint                                     Queue3                                  { get; set; }
        public uint                                     Length                                  { get; set; }

        public static HashCode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HashCode() { Pointer= p0 };

            value.V1                                        = GetUInt32(new IntPtr(p + 0x010)); // 0246630D0D38 0x10 V1                          ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.V2                                        = GetUInt32(new IntPtr(p + 0x014)); // 0246630D0D58 0x14 V2                          ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.V3                                        = GetUInt32(new IntPtr(p + 0x018)); // 0246630D0D78 0x18 V3                          ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.V4                                        = GetUInt32(new IntPtr(p + 0x01C)); // 0246630D0D98 0x1C V4                          ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.Queue1                                    = GetUInt32(new IntPtr(p + 0x020)); // 0246630D0DB8 0x20 Queue1                      ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.Queue2                                    = GetUInt32(new IntPtr(p + 0x024)); // 0246630D0DD8 0x24 Queue2                      ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.Queue3                                    = GetUInt32(new IntPtr(p + 0x028)); // 0246630D0DF8 0x28 Queue3                      ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )
            value.Length                                    = GetUInt32(new IntPtr(p + 0x02C)); // 0246630D0E18 0x2C Length                      ( 000186698B70 ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
