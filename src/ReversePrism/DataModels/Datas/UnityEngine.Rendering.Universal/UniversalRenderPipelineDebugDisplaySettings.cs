using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 CommonSettings                           ModelClassType DebugDisplaySettingsCommon DebugDisplaySettingsCommon DebugDisplaySettingsCommon Pointer
    // 020 MaterialSettings                         ModelClassType DebugDisplaySettingsMaterial DebugDisplaySettingsMaterial DebugDisplaySettingsMaterial Pointer
    // 028 RenderingSettings                        ModelClassType DebugDisplaySettingsRendering DebugDisplaySettingsRendering DebugDisplaySettingsRendering Pointer
    // 030 LightingSettings                         ModelClassType DebugDisplaySettingsLighting DebugDisplaySettingsLighting DebugDisplaySettingsLighting Pointer
    // 038 VolumeSettings                           ModelClassType DebugDisplaySettingsVolume DebugDisplaySettingsVolume DebugDisplaySettingsVolume Pointer
    // 040 DisplayStats                             ModelClassType DebugDisplayStats DebugDisplayStats DebugDisplayStats Pointer
    public partial class UniversalRenderPipelineDebugDisplaySettings : DataModel
    {
        public DebugDisplaySettingsCommon?              CommonSettings                          { get; set; }
        public DebugDisplaySettingsMaterial?            MaterialSettings                        { get; set; }
        public DebugDisplaySettingsRendering?           RenderingSettings                       { get; set; }
        public DebugDisplaySettingsLighting?            LightingSettings                        { get; set; }
        public DebugDisplaySettingsVolume?              VolumeSettings                          { get; set; }
        public DebugDisplayStats?                       DisplayStats                            { get; set; }

        public static UniversalRenderPipelineDebugDisplaySettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UniversalRenderPipelineDebugDisplaySettings() { Pointer= p0 };

            value.CommonSettings                            = GetObject<DebugDisplaySettingsCommon>(new IntPtr(p + 0x018), ReversePrism.DataModels.DebugDisplaySettingsCommon.FromPointer); // 0x18 CommonSettings              ( ModelClassType DebugDisplaySettingsCommon DebugDisplaySettingsCommon DebugDisplaySettingsCommon Pointer )
            value.MaterialSettings                          = GetObject<DebugDisplaySettingsMaterial>(new IntPtr(p + 0x020), ReversePrism.DataModels.DebugDisplaySettingsMaterial.FromPointer); // 0x20 MaterialSettings            ( ModelClassType DebugDisplaySettingsMaterial DebugDisplaySettingsMaterial DebugDisplaySettingsMaterial Pointer )
            value.RenderingSettings                         = GetObject<DebugDisplaySettingsRendering>(new IntPtr(p + 0x028), ReversePrism.DataModels.DebugDisplaySettingsRendering.FromPointer); // 0x28 RenderingSettings           ( ModelClassType DebugDisplaySettingsRendering DebugDisplaySettingsRendering DebugDisplaySettingsRendering Pointer )
            value.LightingSettings                          = GetObject<DebugDisplaySettingsLighting>(new IntPtr(p + 0x030), ReversePrism.DataModels.DebugDisplaySettingsLighting.FromPointer); // 0x30 LightingSettings            ( ModelClassType DebugDisplaySettingsLighting DebugDisplaySettingsLighting DebugDisplaySettingsLighting Pointer )
            value.VolumeSettings                            = GetObject<DebugDisplaySettingsVolume>(new IntPtr(p + 0x038), ReversePrism.DataModels.DebugDisplaySettingsVolume.FromPointer); // 0x38 VolumeSettings              ( ModelClassType DebugDisplaySettingsVolume DebugDisplaySettingsVolume DebugDisplaySettingsVolume Pointer )
            value.DisplayStats                              = GetObject<DebugDisplayStats>(new IntPtr(p + 0x040), ReversePrism.DataModels.DebugDisplayStats.FromPointer); // 0x40 DisplayStats                ( ModelClassType DebugDisplayStats DebugDisplayStats DebugDisplayStats Pointer )

            return value;
        }
    }
}
