using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_SettingsKey                            string IL2CPP_TYPE_STRING
    // 008 s_RuntimeSettingsInstance                AdaptivePerformanceGeneralSettings IL2CPP_TYPE_CLASS
    // 018 M_LoaderManagerInstance                  ModelClassType AdaptivePerformanceManagerSettings AdaptivePerformanceManagerSettings AdaptivePerformanceManagerSettings Pointer
    // 020 M_InitManagerOnStart                     ModelPrimitiveType bool bool bool Bool
    // 028 M_AdaptivePerformanceManager             ModelClassType AdaptivePerformanceManagerSettings AdaptivePerformanceManagerSettings AdaptivePerformanceManagerSettings Pointer
    // 030 M_ProviderIntialized                     ModelPrimitiveType bool bool bool Bool
    // 031 M_ProviderStarted                        ModelPrimitiveType bool bool bool Bool
    public partial class AdaptivePerformanceGeneralSettings : DataModel
    {
        public AdaptivePerformanceManagerSettings?      M_LoaderManagerInstance                 { get; set; }
        public bool                                     M_InitManagerOnStart                    { get; set; }
        public AdaptivePerformanceManagerSettings?      M_AdaptivePerformanceManager            { get; set; }
        public bool                                     M_ProviderIntialized                    { get; set; }
        public bool                                     M_ProviderStarted                       { get; set; }

        public static AdaptivePerformanceGeneralSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdaptivePerformanceGeneralSettings() { Pointer= p0 };

            value.M_LoaderManagerInstance                   = GetObject<AdaptivePerformanceManagerSettings>(new IntPtr(p + 0x018), ReversePrism.DataModels.AdaptivePerformanceManagerSettings.FromPointer); // 0x18 M_LoaderManagerInstance     ( ModelClassType AdaptivePerformanceManagerSettings AdaptivePerformanceManagerSettings AdaptivePerformanceManagerSettings Pointer )
            value.M_InitManagerOnStart                      = GetBool(new IntPtr(p + 0x020)); // 0x20 M_InitManagerOnStart        ( ModelPrimitiveType bool bool bool Bool )
            value.M_AdaptivePerformanceManager              = GetObject<AdaptivePerformanceManagerSettings>(new IntPtr(p + 0x028), ReversePrism.DataModels.AdaptivePerformanceManagerSettings.FromPointer); // 0x28 M_AdaptivePerformanceManager ( ModelClassType AdaptivePerformanceManagerSettings AdaptivePerformanceManagerSettings AdaptivePerformanceManagerSettings Pointer )
            value.M_ProviderIntialized                      = GetBool(new IntPtr(p + 0x030)); // 0x30 M_ProviderIntialized        ( ModelPrimitiveType bool bool bool Bool )
            value.M_ProviderStarted                         = GetBool(new IntPtr(p + 0x031)); // 0x31 M_ProviderStarted           ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
