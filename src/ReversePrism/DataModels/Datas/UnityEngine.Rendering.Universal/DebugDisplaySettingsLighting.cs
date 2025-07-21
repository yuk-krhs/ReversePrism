using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 LightingDebugMode                        ModelEnumType DebugLightingMode DebugLightingMode DebugLightingMode Int32
    // 014 LightingFeatureFlags                     ModelEnumType DebugLightingFeatureFlags DebugLightingFeatureFlags DebugLightingFeatureFlags Int32
    // 018 HdrDebugMode                             ModelEnumType HDRDebugMode HDRDebugMode HDRDebugMode Int32
    public partial class DebugDisplaySettingsLighting : DataModel
    {
        public DebugLightingMode                        LightingDebugMode                       { get; set; }
        public DebugLightingFeatureFlags                LightingFeatureFlags                    { get; set; }
        public HDRDebugMode                             HdrDebugMode                            { get; set; }

        public static DebugDisplaySettingsLighting? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugDisplaySettingsLighting() { Pointer= p0 };

            value.LightingDebugMode                         = (DebugLightingMode)GetInt32(new IntPtr(p + 0x010)); // 0x10 LightingDebugMode           ( ModelEnumType DebugLightingMode DebugLightingMode DebugLightingMode Int32 )
            value.LightingFeatureFlags                      = (DebugLightingFeatureFlags)GetInt32(new IntPtr(p + 0x014)); // 0x14 LightingFeatureFlags        ( ModelEnumType DebugLightingFeatureFlags DebugLightingFeatureFlags DebugLightingFeatureFlags Int32 )
            value.HdrDebugMode                              = (HDRDebugMode)GetInt32(new IntPtr(p + 0x018)); // 0x18 HdrDebugMode                ( ModelEnumType HDRDebugMode HDRDebugMode HDRDebugMode Int32 )

            return value;
        }
    }
}
