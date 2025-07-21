using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _MainLightPosition                       int IL2CPP_TYPE_I4
    // 004 _MainLightColor                          int IL2CPP_TYPE_I4
    // 008 _MainLightOcclusionProbesChannel         int IL2CPP_TYPE_I4
    // 00C _MainLightLayerMask                      int IL2CPP_TYPE_I4
    // 010 AdditionalLightsCount                    ModelPrimitiveType int int int Int32
    // 014 AdditionalLightsPosition                 ModelPrimitiveType int int int Int32
    // 018 AdditionalLightsColor                    ModelPrimitiveType int int int Int32
    // 01C AdditionalLightsAttenuation              ModelPrimitiveType int int int Int32
    // 020 AdditionalLightsSpotDir                  ModelPrimitiveType int int int Int32
    // 024 AdditionalLightOcclusionProbeChannel     ModelPrimitiveType int int int Int32
    // 028 AdditionalLightsLayerMasks               ModelPrimitiveType int int int Int32
    public partial class LightConstantBuffer : DataModel
    {
        public int                                      AdditionalLightsCount                   { get; set; }
        public int                                      AdditionalLightsPosition                { get; set; }
        public int                                      AdditionalLightsColor                   { get; set; }
        public int                                      AdditionalLightsAttenuation             { get; set; }
        public int                                      AdditionalLightsSpotDir                 { get; set; }
        public int                                      AdditionalLightOcclusionProbeChannel    { get; set; }
        public int                                      AdditionalLightsLayerMasks              { get; set; }

        public static LightConstantBuffer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LightConstantBuffer() { Pointer= p0 };

            value.AdditionalLightsCount                     = GetInt32(new IntPtr(p + 0x010)); // 0x10 AdditionalLightsCount       ( ModelPrimitiveType int int int Int32 )
            value.AdditionalLightsPosition                  = GetInt32(new IntPtr(p + 0x014)); // 0x14 AdditionalLightsPosition    ( ModelPrimitiveType int int int Int32 )
            value.AdditionalLightsColor                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 AdditionalLightsColor       ( ModelPrimitiveType int int int Int32 )
            value.AdditionalLightsAttenuation               = GetInt32(new IntPtr(p + 0x01C)); // 0x1C AdditionalLightsAttenuation ( ModelPrimitiveType int int int Int32 )
            value.AdditionalLightsSpotDir                   = GetInt32(new IntPtr(p + 0x020)); // 0x20 AdditionalLightsSpotDir     ( ModelPrimitiveType int int int Int32 )
            value.AdditionalLightOcclusionProbeChannel      = GetInt32(new IntPtr(p + 0x024)); // 0x24 AdditionalLightOcclusionProbeChannel ( ModelPrimitiveType int int int Int32 )
            value.AdditionalLightsLayerMasks                = GetInt32(new IntPtr(p + 0x028)); // 0x28 AdditionalLightsLayerMasks  ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
