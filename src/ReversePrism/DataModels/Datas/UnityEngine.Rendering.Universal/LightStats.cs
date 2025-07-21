using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TotalLights                              ModelPrimitiveType int int int Int32
    // 014 TotalNormalMapUsage                      ModelPrimitiveType int int int Int32
    // 018 TotalVolumetricUsage                     ModelPrimitiveType int int int Int32
    // 01C BlendStylesUsed                          ModelPrimitiveType uint uint uint UInt32
    // 020 BlendStylesWithLights                    ModelPrimitiveType uint uint uint UInt32
    public partial class LightStats : DataModel
    {
        public int                                      TotalLights                             { get; set; }
        public int                                      TotalNormalMapUsage                     { get; set; }
        public int                                      TotalVolumetricUsage                    { get; set; }
        public uint                                     BlendStylesUsed                         { get; set; }
        public uint                                     BlendStylesWithLights                   { get; set; }

        public static LightStats? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LightStats() { Pointer= p0 };

            value.TotalLights                               = GetInt32(new IntPtr(p + 0x010)); // 0x10 TotalLights                 ( ModelPrimitiveType int int int Int32 )
            value.TotalNormalMapUsage                       = GetInt32(new IntPtr(p + 0x014)); // 0x14 TotalNormalMapUsage         ( ModelPrimitiveType int int int Int32 )
            value.TotalVolumetricUsage                      = GetInt32(new IntPtr(p + 0x018)); // 0x18 TotalVolumetricUsage        ( ModelPrimitiveType int int int Int32 )
            value.BlendStylesUsed                           = GetUInt32(new IntPtr(p + 0x01C)); // 0x1C BlendStylesUsed             ( ModelPrimitiveType uint uint uint UInt32 )
            value.BlendStylesWithLights                     = GetUInt32(new IntPtr(p + 0x020)); // 0x20 BlendStylesWithLights       ( ModelPrimitiveType uint uint uint UInt32 )

            return value;
        }
    }
}
