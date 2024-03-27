using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ProbeOcclusionLightIndex                 0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 OcclusionMaskChannel                     0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 LightmapBakeType                         000186529F30 ModelEnumType LightmapBakeType LightmapBakeType LightmapBakeType Int32
    // 01C MixedLightingMode                        00018662B880 ModelEnumType MixedLightingMode MixedLightingMode MixedLightingMode Int32
    // 020 IsBaked                                  000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class LightBakingOutput
    {
        public int                                      ProbeOcclusionLightIndex                { get; set; }
        public int                                      OcclusionMaskChannel                    { get; set; }
        public LightmapBakeType                         LightmapBakeType                        { get; set; }
        public MixedLightingMode                        MixedLightingMode                       { get; set; }
        public bool                                     IsBaked                                 { get; set; }

        public static LightBakingOutput? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LightBakingOutput();

            value.ProbeOcclusionLightIndex                  = GetInt32(new IntPtr(p + 0x010)); // 0270068AC108 0x10 ProbeOcclusionLightIndex    ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.OcclusionMaskChannel                      = GetInt32(new IntPtr(p + 0x014)); // 0270068AC128 0x14 OcclusionMaskChannel        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.LightmapBakeType                          = (LightmapBakeType)GetInt32(new IntPtr(p + 0x018)); // 0270068AC148 0x18 LightmapBakeType            ( 000186529F30 ModelEnumType LightmapBakeType LightmapBakeType LightmapBakeType Int32 )
            value.MixedLightingMode                         = (MixedLightingMode)GetInt32(new IntPtr(p + 0x01C)); // 0270068AC168 0x1C MixedLightingMode           ( 00018662B880 ModelEnumType MixedLightingMode MixedLightingMode MixedLightingMode Int32 )
            value.IsBaked                                   = GetBool(new IntPtr(p + 0x020)); // 0270068AC188 0x20 IsBaked                     ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
