using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MainLightIndex                           ModelPrimitiveType int int int Int32
    // 014 AdditionalLightsCount                    ModelPrimitiveType int int int Int32
    // 018 MaxPerObjectAdditionalLightsCount        ModelPrimitiveType int int int Int32
    // 020 visibleLights                            NativeArray`1<VisibleLight> IL2CPP_TYPE_GENERICINST
    // 030 ShadeAdditionalLightsPerVertex           ModelPrimitiveType bool bool bool Bool
    // 031 SupportsMixedLighting                    ModelPrimitiveType bool bool bool Bool
    // 032 ReflectionProbeBoxProjection             ModelPrimitiveType bool bool bool Bool
    // 033 ReflectionProbeBlending                  ModelPrimitiveType bool bool bool Bool
    // 034 SupportsLightLayers                      ModelPrimitiveType bool bool bool Bool
    // 035 SupportsAdditionalLights                 ModelPrimitiveType bool bool bool Bool
    public partial class LightData : DataModel
    {
        public int                                      MainLightIndex                          { get; set; }
        public int                                      AdditionalLightsCount                   { get; set; }
        public int                                      MaxPerObjectAdditionalLightsCount       { get; set; }
        public bool                                     ShadeAdditionalLightsPerVertex          { get; set; }
        public bool                                     SupportsMixedLighting                   { get; set; }
        public bool                                     ReflectionProbeBoxProjection            { get; set; }
        public bool                                     ReflectionProbeBlending                 { get; set; }
        public bool                                     SupportsLightLayers                     { get; set; }
        public bool                                     SupportsAdditionalLights                { get; set; }

        public static LightData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LightData() { Pointer= p0 };

            value.MainLightIndex                            = GetInt32(new IntPtr(p + 0x010)); // 0x10 MainLightIndex              ( ModelPrimitiveType int int int Int32 )
            value.AdditionalLightsCount                     = GetInt32(new IntPtr(p + 0x014)); // 0x14 AdditionalLightsCount       ( ModelPrimitiveType int int int Int32 )
            value.MaxPerObjectAdditionalLightsCount         = GetInt32(new IntPtr(p + 0x018)); // 0x18 MaxPerObjectAdditionalLightsCount ( ModelPrimitiveType int int int Int32 )
            value.ShadeAdditionalLightsPerVertex            = GetBool(new IntPtr(p + 0x030)); // 0x30 ShadeAdditionalLightsPerVertex ( ModelPrimitiveType bool bool bool Bool )
            value.SupportsMixedLighting                     = GetBool(new IntPtr(p + 0x031)); // 0x31 SupportsMixedLighting       ( ModelPrimitiveType bool bool bool Bool )
            value.ReflectionProbeBoxProjection              = GetBool(new IntPtr(p + 0x032)); // 0x32 ReflectionProbeBoxProjection ( ModelPrimitiveType bool bool bool Bool )
            value.ReflectionProbeBlending                   = GetBool(new IntPtr(p + 0x033)); // 0x33 ReflectionProbeBlending     ( ModelPrimitiveType bool bool bool Bool )
            value.SupportsLightLayers                       = GetBool(new IntPtr(p + 0x034)); // 0x34 SupportsLightLayers         ( ModelPrimitiveType bool bool bool Bool )
            value.SupportsAdditionalLights                  = GetBool(new IntPtr(p + 0x035)); // 0x35 SupportsAdditionalLights    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
