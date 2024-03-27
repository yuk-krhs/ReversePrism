using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 M_Indexer                                000186683E60 ModelClassType AdaptivePerformanceIndexer AdaptivePerformanceIndexer AdaptivePerformanceIndexer Pointer
    // 020 CurrentLevel                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 GpuImpact                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 CpuImpact                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C M_OverrideLevel                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 M_defaultSetting                         000186687970 ModelClassType AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase Pointer
    // 038 M_Settings                               0001865E10B0 ModelClassType IAdaptivePerformanceSettings IAdaptivePerformanceSettings IAdaptivePerformanceSettings Pointer
    public partial class AdaptivePerformanceScaler
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
            var value   = new AdaptivePerformanceScaler();

            value.M_Indexer                                 = GetObject<AdaptivePerformanceIndexer>(new IntPtr(p + 0x018), ReversePrism.DataModels.AdaptivePerformanceIndexer.FromPointer); // 0270DB65E980 0x18 M_Indexer                   ( 000186683E60 ModelClassType AdaptivePerformanceIndexer AdaptivePerformanceIndexer AdaptivePerformanceIndexer Pointer )
            value.CurrentLevel                              = GetInt32(new IntPtr(p + 0x020)); // 0270DB65E9A0 0x20 CurrentLevel                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.GpuImpact                                 = GetInt32(new IntPtr(p + 0x024)); // 0270DB65E9C0 0x24 GpuImpact                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CpuImpact                                 = GetInt32(new IntPtr(p + 0x028)); // 0270DB65E9E0 0x28 CpuImpact                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_OverrideLevel                           = GetInt32(new IntPtr(p + 0x02C)); // 0270DB65EA00 0x2C M_OverrideLevel             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_defaultSetting                          = GetObject<AdaptivePerformanceScalerSettingsBase>(new IntPtr(p + 0x030), ReversePrism.DataModels.AdaptivePerformanceScalerSettingsBase.FromPointer); // 0270DB65EA20 0x30 M_defaultSetting            ( 000186687970 ModelClassType AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase Pointer )
            value.M_Settings                                = GetObject<IAdaptivePerformanceSettings>(new IntPtr(p + 0x038), ReversePrism.DataModels.IAdaptivePerformanceSettings.FromPointer); // 0270DB65EA40 0x38 M_Settings                  ( 0001865E10B0 ModelClassType IAdaptivePerformanceSettings IAdaptivePerformanceSettings IAdaptivePerformanceSettings Pointer )

            return value;
        }
    }
}
