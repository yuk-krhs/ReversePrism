using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 M_Logging                                ModelPrimitiveType bool bool bool Bool
    // 019 M_AutomaticPerformanceModeEnabled        ModelPrimitiveType bool bool bool Bool
    // 01A M_EnableBoostOnStartup                   ModelPrimitiveType bool bool bool Bool
    // 01C M_StatsLoggingFrequencyInFrames          ModelPrimitiveType int int int Int32
    // 020 M_IndexerSettings                        ModelClassType AdaptivePerformanceIndexerSettings AdaptivePerformanceIndexerSettings AdaptivePerformanceIndexerSettings Pointer
    // 028 M_ScalerSettings                         ModelClassType AdaptivePerformanceScalerSettings AdaptivePerformanceScalerSettings AdaptivePerformanceScalerSettings Pointer
    // 030 M_scalerProfileList                      ModelClassListType AdaptivePerformanceScalerProfile[] AdaptivePerformanceScalerProfile[] List<AdaptivePerformanceScalerProfile> Pointer
    // 038 M_DefaultScalerProfilerIndex             ModelPrimitiveType int int int Int32
    public partial class IAdaptivePerformanceSettings : DataModel
    {
        public bool                                     M_Logging                               { get; set; }
        public bool                                     M_AutomaticPerformanceModeEnabled       { get; set; }
        public bool                                     M_EnableBoostOnStartup                  { get; set; }
        public int                                      M_StatsLoggingFrequencyInFrames         { get; set; }
        public AdaptivePerformanceIndexerSettings?      M_IndexerSettings                       { get; set; }
        public AdaptivePerformanceScalerSettings?       M_ScalerSettings                        { get; set; }
        public List<AdaptivePerformanceScalerProfile>?  M_scalerProfileList                     { get; set; }
        public int                                      M_DefaultScalerProfilerIndex            { get; set; }

        public static IAdaptivePerformanceSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IAdaptivePerformanceSettings() { Pointer= p0 };

            value.M_Logging                                 = GetBool(new IntPtr(p + 0x018)); // 0x18 M_Logging                   ( ModelPrimitiveType bool bool bool Bool )
            value.M_AutomaticPerformanceModeEnabled         = GetBool(new IntPtr(p + 0x019)); // 0x19 M_AutomaticPerformanceModeEnabled ( ModelPrimitiveType bool bool bool Bool )
            value.M_EnableBoostOnStartup                    = GetBool(new IntPtr(p + 0x01A)); // 0x1A M_EnableBoostOnStartup      ( ModelPrimitiveType bool bool bool Bool )
            value.M_StatsLoggingFrequencyInFrames           = GetInt32(new IntPtr(p + 0x01C)); // 0x1C M_StatsLoggingFrequencyInFrames ( ModelPrimitiveType int int int Int32 )
            value.M_IndexerSettings                         = GetObject<AdaptivePerformanceIndexerSettings>(new IntPtr(p + 0x020), ReversePrism.DataModels.AdaptivePerformanceIndexerSettings.FromPointer); // 0x20 M_IndexerSettings           ( ModelClassType AdaptivePerformanceIndexerSettings AdaptivePerformanceIndexerSettings AdaptivePerformanceIndexerSettings Pointer )
            value.M_ScalerSettings                          = GetObject<AdaptivePerformanceScalerSettings>(new IntPtr(p + 0x028), ReversePrism.DataModels.AdaptivePerformanceScalerSettings.FromPointer); // 0x28 M_ScalerSettings            ( ModelClassType AdaptivePerformanceScalerSettings AdaptivePerformanceScalerSettings AdaptivePerformanceScalerSettings Pointer )
            value.M_scalerProfileList                       = GetObjectList<AdaptivePerformanceScalerProfile>(new IntPtr(p + 0x030), ReversePrism.DataModels.AdaptivePerformanceScalerProfile.FromPointer); // 0x30 M_scalerProfileList         ( ModelClassListType AdaptivePerformanceScalerProfile[] AdaptivePerformanceScalerProfile[] List<AdaptivePerformanceScalerProfile> Pointer )
            value.M_DefaultScalerProfilerIndex              = GetInt32(new IntPtr(p + 0x038)); // 0x38 M_DefaultScalerProfilerIndex ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
