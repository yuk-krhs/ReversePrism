using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_AdaptiveFramerate                      ModelClassType AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase Pointer
    // 018 M_AdaptiveResolution                     ModelClassType AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase Pointer
    // 020 M_AdaptiveBatching                       ModelClassType AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase Pointer
    // 028 M_AdaptiveLOD                            ModelClassType AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase Pointer
    // 030 M_AdaptiveLut                            ModelClassType AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase Pointer
    // 038 M_AdaptiveMSAA                           ModelClassType AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase Pointer
    // 040 M_AdaptiveShadowCascade                  ModelClassType AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase Pointer
    // 000 obsoleteMsg                              string IL2CPP_TYPE_STRING
    // 048 M_AdaptiveShadowDistance                 ModelClassType AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase Pointer
    // 050 M_AdaptiveShadowmapResolution            ModelClassType AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase Pointer
    // 058 M_AdaptiveShadowQuality                  ModelClassType AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase Pointer
    // 060 M_AdaptiveSorting                        ModelClassType AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase Pointer
    // 068 M_AdaptiveTransparency                   ModelClassType AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase Pointer
    // 070 M_AdaptiveViewDistance                   ModelClassType AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase Pointer
    // 078 M_AdaptivePhysics                        ModelClassType AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase Pointer
    // 080 M_AdaptiveDecals                         ModelClassType AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase Pointer
    // 088 M_AdaptiveLayerCulling                   ModelClassType AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase Pointer
    public partial class AdaptivePerformanceScalerSettings : DataModel
    {
        public AdaptivePerformanceScalerSettingsBase?   M_AdaptiveFramerate                     { get; set; }
        public AdaptivePerformanceScalerSettingsBase?   M_AdaptiveResolution                    { get; set; }
        public AdaptivePerformanceScalerSettingsBase?   M_AdaptiveBatching                      { get; set; }
        public AdaptivePerformanceScalerSettingsBase?   M_AdaptiveLOD                           { get; set; }
        public AdaptivePerformanceScalerSettingsBase?   M_AdaptiveLut                           { get; set; }
        public AdaptivePerformanceScalerSettingsBase?   M_AdaptiveMSAA                          { get; set; }
        public AdaptivePerformanceScalerSettingsBase?   M_AdaptiveShadowCascade                 { get; set; }
        public AdaptivePerformanceScalerSettingsBase?   M_AdaptiveShadowDistance                { get; set; }
        public AdaptivePerformanceScalerSettingsBase?   M_AdaptiveShadowmapResolution           { get; set; }
        public AdaptivePerformanceScalerSettingsBase?   M_AdaptiveShadowQuality                 { get; set; }
        public AdaptivePerformanceScalerSettingsBase?   M_AdaptiveSorting                       { get; set; }
        public AdaptivePerformanceScalerSettingsBase?   M_AdaptiveTransparency                  { get; set; }
        public AdaptivePerformanceScalerSettingsBase?   M_AdaptiveViewDistance                  { get; set; }
        public AdaptivePerformanceScalerSettingsBase?   M_AdaptivePhysics                       { get; set; }
        public AdaptivePerformanceScalerSettingsBase?   M_AdaptiveDecals                        { get; set; }
        public AdaptivePerformanceScalerSettingsBase?   M_AdaptiveLayerCulling                  { get; set; }

        public static AdaptivePerformanceScalerSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdaptivePerformanceScalerSettings() { Pointer= p0 };

            value.M_AdaptiveFramerate                       = GetObject<AdaptivePerformanceScalerSettingsBase>(new IntPtr(p + 0x010), ReversePrism.DataModels.AdaptivePerformanceScalerSettingsBase.FromPointer); // 0x10 M_AdaptiveFramerate         ( ModelClassType AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase Pointer )
            value.M_AdaptiveResolution                      = GetObject<AdaptivePerformanceScalerSettingsBase>(new IntPtr(p + 0x018), ReversePrism.DataModels.AdaptivePerformanceScalerSettingsBase.FromPointer); // 0x18 M_AdaptiveResolution        ( ModelClassType AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase Pointer )
            value.M_AdaptiveBatching                        = GetObject<AdaptivePerformanceScalerSettingsBase>(new IntPtr(p + 0x020), ReversePrism.DataModels.AdaptivePerformanceScalerSettingsBase.FromPointer); // 0x20 M_AdaptiveBatching          ( ModelClassType AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase Pointer )
            value.M_AdaptiveLOD                             = GetObject<AdaptivePerformanceScalerSettingsBase>(new IntPtr(p + 0x028), ReversePrism.DataModels.AdaptivePerformanceScalerSettingsBase.FromPointer); // 0x28 M_AdaptiveLOD               ( ModelClassType AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase Pointer )
            value.M_AdaptiveLut                             = GetObject<AdaptivePerformanceScalerSettingsBase>(new IntPtr(p + 0x030), ReversePrism.DataModels.AdaptivePerformanceScalerSettingsBase.FromPointer); // 0x30 M_AdaptiveLut               ( ModelClassType AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase Pointer )
            value.M_AdaptiveMSAA                            = GetObject<AdaptivePerformanceScalerSettingsBase>(new IntPtr(p + 0x038), ReversePrism.DataModels.AdaptivePerformanceScalerSettingsBase.FromPointer); // 0x38 M_AdaptiveMSAA              ( ModelClassType AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase Pointer )
            value.M_AdaptiveShadowCascade                   = GetObject<AdaptivePerformanceScalerSettingsBase>(new IntPtr(p + 0x040), ReversePrism.DataModels.AdaptivePerformanceScalerSettingsBase.FromPointer); // 0x40 M_AdaptiveShadowCascade     ( ModelClassType AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase Pointer )
            value.M_AdaptiveShadowDistance                  = GetObject<AdaptivePerformanceScalerSettingsBase>(new IntPtr(p + 0x048), ReversePrism.DataModels.AdaptivePerformanceScalerSettingsBase.FromPointer); // 0x48 M_AdaptiveShadowDistance    ( ModelClassType AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase Pointer )
            value.M_AdaptiveShadowmapResolution             = GetObject<AdaptivePerformanceScalerSettingsBase>(new IntPtr(p + 0x050), ReversePrism.DataModels.AdaptivePerformanceScalerSettingsBase.FromPointer); // 0x50 M_AdaptiveShadowmapResolution ( ModelClassType AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase Pointer )
            value.M_AdaptiveShadowQuality                   = GetObject<AdaptivePerformanceScalerSettingsBase>(new IntPtr(p + 0x058), ReversePrism.DataModels.AdaptivePerformanceScalerSettingsBase.FromPointer); // 0x58 M_AdaptiveShadowQuality     ( ModelClassType AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase Pointer )
            value.M_AdaptiveSorting                         = GetObject<AdaptivePerformanceScalerSettingsBase>(new IntPtr(p + 0x060), ReversePrism.DataModels.AdaptivePerformanceScalerSettingsBase.FromPointer); // 0x60 M_AdaptiveSorting           ( ModelClassType AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase Pointer )
            value.M_AdaptiveTransparency                    = GetObject<AdaptivePerformanceScalerSettingsBase>(new IntPtr(p + 0x068), ReversePrism.DataModels.AdaptivePerformanceScalerSettingsBase.FromPointer); // 0x68 M_AdaptiveTransparency      ( ModelClassType AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase Pointer )
            value.M_AdaptiveViewDistance                    = GetObject<AdaptivePerformanceScalerSettingsBase>(new IntPtr(p + 0x070), ReversePrism.DataModels.AdaptivePerformanceScalerSettingsBase.FromPointer); // 0x70 M_AdaptiveViewDistance      ( ModelClassType AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase Pointer )
            value.M_AdaptivePhysics                         = GetObject<AdaptivePerformanceScalerSettingsBase>(new IntPtr(p + 0x078), ReversePrism.DataModels.AdaptivePerformanceScalerSettingsBase.FromPointer); // 0x78 M_AdaptivePhysics           ( ModelClassType AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase Pointer )
            value.M_AdaptiveDecals                          = GetObject<AdaptivePerformanceScalerSettingsBase>(new IntPtr(p + 0x080), ReversePrism.DataModels.AdaptivePerformanceScalerSettingsBase.FromPointer); // 0x80 M_AdaptiveDecals            ( ModelClassType AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase Pointer )
            value.M_AdaptiveLayerCulling                    = GetObject<AdaptivePerformanceScalerSettingsBase>(new IntPtr(p + 0x088), ReversePrism.DataModels.AdaptivePerformanceScalerSettingsBase.FromPointer); // 0x88 M_AdaptiveLayerCulling      ( ModelClassType AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase AdaptivePerformanceScalerSettingsBase Pointer )

            return value;
        }
    }
}
