using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_UnappliedScalers                       000185CCB898 ModelClassListType List`1<AdaptivePerformanceScaler> List`1<AdaptivePerformanceScaler> List<AdaptivePerformanceScaler> Pointer
    // 018 M_AppliedScalers                         000185CCB898 ModelClassListType List`1<AdaptivePerformanceScaler> List`1<AdaptivePerformanceScaler> List<AdaptivePerformanceScaler> Pointer
    // 020 M_DisabledScalers                        000185CCB898 ModelClassListType List`1<AdaptivePerformanceScaler> List`1<AdaptivePerformanceScaler> List<AdaptivePerformanceScaler> Pointer
    // 028 M_ThermalStateTracker                    000186659F50 ModelClassType ThermalStateTracker ThermalStateTracker ThermalStateTracker Pointer
    // 030 M_PerformanceStateTracker                000186734540 ModelClassType PerformanceStateTracker PerformanceStateTracker PerformanceStateTracker Pointer
    // 038 M_ScalerEfficiencyTracker                000186686FA0 ModelClassType AdaptivePerformanceScalerEfficiencyTracker AdaptivePerformanceScalerEfficiencyTracker AdaptivePerformanceScalerEfficiencyTracker Pointer
    // 040 M_Settings                               0001865E0E70 ModelClassType IAdaptivePerformanceSettings IAdaptivePerformanceSettings IAdaptivePerformanceSettings Pointer
    // 000 m_FeatureName                            string IL2CPP_TYPE_STRING
    // 048 TimeUntilNextAction                      0001866656B0 ModelPrimitiveType float float float Single
    // 04C ThermalAction                            000186581890 ModelEnumType StateAction StateAction StateAction Int32
    // 050 PerformanceAction                        000186581890 ModelEnumType StateAction StateAction StateAction Int32
    public partial class AdaptivePerformanceIndexer
    {
        public List<AdaptivePerformanceScaler>?         M_UnappliedScalers                      { get; set; }
        public List<AdaptivePerformanceScaler>?         M_AppliedScalers                        { get; set; }
        public List<AdaptivePerformanceScaler>?         M_DisabledScalers                       { get; set; }
        public ThermalStateTracker?                     M_ThermalStateTracker                   { get; set; }
        public PerformanceStateTracker?                 M_PerformanceStateTracker               { get; set; }
        public AdaptivePerformanceScalerEfficiencyTracker? M_ScalerEfficiencyTracker               { get; set; }
        public IAdaptivePerformanceSettings?            M_Settings                              { get; set; }
        public float                                    TimeUntilNextAction                     { get; set; }
        public StateAction                              ThermalAction                           { get; set; }
        public StateAction                              PerformanceAction                       { get; set; }

        public static AdaptivePerformanceIndexer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdaptivePerformanceIndexer();

            value.M_UnappliedScalers                        = GetObjectList<AdaptivePerformanceScaler>(new IntPtr(p + 0x010), ReversePrism.DataModels.AdaptivePerformanceScaler.FromPointer); // 0270DB659ED0 0x10 M_UnappliedScalers          ( 000185CCB898 ModelClassListType List`1<AdaptivePerformanceScaler> List`1<AdaptivePerformanceScaler> List<AdaptivePerformanceScaler> Pointer )
            value.M_AppliedScalers                          = GetObjectList<AdaptivePerformanceScaler>(new IntPtr(p + 0x018), ReversePrism.DataModels.AdaptivePerformanceScaler.FromPointer); // 0270DB659EF0 0x18 M_AppliedScalers            ( 000185CCB898 ModelClassListType List`1<AdaptivePerformanceScaler> List`1<AdaptivePerformanceScaler> List<AdaptivePerformanceScaler> Pointer )
            value.M_DisabledScalers                         = GetObjectList<AdaptivePerformanceScaler>(new IntPtr(p + 0x020), ReversePrism.DataModels.AdaptivePerformanceScaler.FromPointer); // 0270DB659F10 0x20 M_DisabledScalers           ( 000185CCB898 ModelClassListType List`1<AdaptivePerformanceScaler> List`1<AdaptivePerformanceScaler> List<AdaptivePerformanceScaler> Pointer )
            value.M_ThermalStateTracker                     = GetObject<ThermalStateTracker>(new IntPtr(p + 0x028), ReversePrism.DataModels.ThermalStateTracker.FromPointer); // 0270DB659F30 0x28 M_ThermalStateTracker       ( 000186659F50 ModelClassType ThermalStateTracker ThermalStateTracker ThermalStateTracker Pointer )
            value.M_PerformanceStateTracker                 = GetObject<PerformanceStateTracker>(new IntPtr(p + 0x030), ReversePrism.DataModels.PerformanceStateTracker.FromPointer); // 0270DB659F50 0x30 M_PerformanceStateTracker   ( 000186734540 ModelClassType PerformanceStateTracker PerformanceStateTracker PerformanceStateTracker Pointer )
            value.M_ScalerEfficiencyTracker                 = GetObject<AdaptivePerformanceScalerEfficiencyTracker>(new IntPtr(p + 0x038), ReversePrism.DataModels.AdaptivePerformanceScalerEfficiencyTracker.FromPointer); // 0270DB659F70 0x38 M_ScalerEfficiencyTracker   ( 000186686FA0 ModelClassType AdaptivePerformanceScalerEfficiencyTracker AdaptivePerformanceScalerEfficiencyTracker AdaptivePerformanceScalerEfficiencyTracker Pointer )
            value.M_Settings                                = GetObject<IAdaptivePerformanceSettings>(new IntPtr(p + 0x040), ReversePrism.DataModels.IAdaptivePerformanceSettings.FromPointer); // 0270DB659F90 0x40 M_Settings                  ( 0001865E0E70 ModelClassType IAdaptivePerformanceSettings IAdaptivePerformanceSettings IAdaptivePerformanceSettings Pointer )
            value.TimeUntilNextAction                       = GetSingle(new IntPtr(p + 0x048)); // 0270DB659FD0 0x48 TimeUntilNextAction         ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ThermalAction                             = (StateAction)GetInt32(new IntPtr(p + 0x04C)); // 0270DB659FF0 0x4C ThermalAction               ( 000186581890 ModelEnumType StateAction StateAction StateAction Int32 )
            value.PerformanceAction                         = (StateAction)GetInt32(new IntPtr(p + 0x050)); // 0270DB65A010 0x50 PerformanceAction           ( 000186581890 ModelEnumType StateAction StateAction StateAction Int32 )

            return value;
        }
    }
}
