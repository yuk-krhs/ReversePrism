using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TileID                                   ModelPrimitiveType uint uint uint UInt32
    // 014 ListBitMask                              ModelPrimitiveType uint uint uint UInt32
    // 018 RelLightOffset                           ModelPrimitiveType uint uint uint UInt32
    // 01C Unused                                   ModelPrimitiveType uint uint uint UInt32
    public partial class TileData : DataModel
    {
        public uint                                     TileID                                  { get; set; }
        public uint                                     ListBitMask                             { get; set; }
        public uint                                     RelLightOffset                          { get; set; }
        public uint                                     Unused                                  { get; set; }

        public static TileData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TileData() { Pointer= p0 };

            value.TileID                                    = GetUInt32(new IntPtr(p + 0x010)); // 0x10 TileID                      ( ModelPrimitiveType uint uint uint UInt32 )
            value.ListBitMask                               = GetUInt32(new IntPtr(p + 0x014)); // 0x14 ListBitMask                 ( ModelPrimitiveType uint uint uint UInt32 )
            value.RelLightOffset                            = GetUInt32(new IntPtr(p + 0x018)); // 0x18 RelLightOffset              ( ModelPrimitiveType uint uint uint UInt32 )
            value.Unused                                    = GetUInt32(new IntPtr(p + 0x01C)); // 0x1C Unused                      ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
