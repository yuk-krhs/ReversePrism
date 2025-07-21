using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 M_Indexer                                ModelClassType AdaptivePerformanceIndexer AdaptivePerformanceIndexer AdaptivePerformanceIndexer Pointer
    // 020 CurrentLevel                             ModelPrimitiveType int int int Int32
    // 024 GpuImpact                                ModelPrimitiveType int int int Int32
    // 028 CpuImpact                                ModelPrimitiveType int int int Int32
    // 02C M_OverrideLevel                          ModelPrimitiveType int int int Int32
    // 030 M_defaultSetting                         ModelClassType AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase Pointer
    // 038 M_Settings                               ModelClassType IAdaptivePerformanceSettings IAdaptivePerformanceSettings IAdaptivePerformanceSettings Pointer
    public partial class AdaptivePerformanceScaler : DataModel
    {
        public AdaptivePerformanceIndexer?              M_Indexer                               { get; set; }
        public int                                      CurrentLevel                            { get; set; }
        public int                                      GpuImpact                               { get; set; }
        public int                                      CpuImpact                               { get; set; }
        public int                                      M_OverrideLevel                         { get; set; }
        public AdaptivePerformanceScalerSettingsBase?   M_defaultSetting                        { get; set; }
        public IAdaptivePerformanceSettings?            M_Settings                              { get; set; }

        public static AdaptivePerformanceScaler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdaptivePerformanceScaler() { Pointer= p0 };

            value.M_Indexer                                 = GetObject<AdaptivePerformanceIndexer>(new IntPtr(p + 0x018), ReversePrism.DataModels.AdaptivePerformanceIndexer.FromPointer); // 0x18 M_Indexer                   ( ModelClassType AdaptivePerformanceIndexer AdaptivePerformanceIndexer AdaptivePerformanceIndexer Pointer )
            value.CurrentLevel                              = GetInt32(new IntPtr(p + 0x020)); // 0x20 CurrentLevel                ( ModelPrimitiveType int int int Int32 )
            value.GpuImpact                                 = GetInt32(new IntPtr(p + 0x024)); // 0x24 GpuImpact                   ( ModelPrimitiveType int int int Int32 )
            value.CpuImpact                                 = GetInt32(new IntPtr(p + 0x028)); // 0x28 CpuImpact                   ( ModelPrimitiveType int int int Int32 )
            value.M_OverrideLevel                           = GetInt32(new IntPtr(p + 0x02C)); // 0x2C M_OverrideLevel             ( ModelPrimitiveType int int int Int32 )
            value.M_defaultSetting                          = GetObject<AdaptivePerformanceScalerSettingsBase>(new IntPtr(p + 0x030), ReversePrism.DataModels.AdaptivePerformanceScalerSettingsBase.FromPointer); // 0x30 M_defaultSetting            ( ModelClassType AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase Pointer )
            value.M_Settings                                = GetObject<IAdaptivePerformanceSettings>(new IntPtr(p + 0x038), ReversePrism.DataModels.IAdaptivePerformanceSettings.FromPointer); // 0x38 M_Settings                  ( ModelClassType IAdaptivePerformanceSettings IAdaptivePerformanceSettings IAdaptivePerformanceSettings Pointer )

            return value;
        }
    }
}
