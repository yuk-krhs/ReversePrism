using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_LensFlareData                          ModelClassType LensFlareDataSRP LensFlareDataSRP LensFlareDataSRP Pointer
    // 028 Intensity                                ModelPrimitiveType float float float Single
    // 02C MaxAttenuationDistance                   ModelPrimitiveType float float float Single
    // 030 MaxAttenuationScale                      ModelPrimitiveType float float float Single
    // 038 DistanceAttenuationCurve                 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 040 ScaleByDistanceCurve                     ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 048 AttenuationByLightShape                  ModelPrimitiveType bool bool bool Bool
    // 050 RadialScreenAttenuationCurve             ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 058 UseOcclusion                             ModelPrimitiveType bool bool bool Bool
    // 05C OcclusionRadius                          ModelPrimitiveType float float float Single
    // 060 UseBackgroundCloudOcclusion              ModelPrimitiveType bool bool bool Bool
    // 064 SampleCount                              ModelPrimitiveType uint uint uint UInt32
    // 068 OcclusionOffset                          ModelPrimitiveType float float float Single
    // 06C Scale                                    ModelPrimitiveType float float float Single
    // 070 AllowOffScreen                           ModelPrimitiveType bool bool bool Bool
    // 071 VolumetricCloudOcclusion                 ModelPrimitiveType bool bool bool Bool
    // 000 sCelestialAngularRadius                  float IL2CPP_TYPE_R4
    // 078 OcclusionRemapCurve                      ModelClassType TextureCurve TextureCurve TextureCurve Pointer
    public partial class LensFlareComponentSRP : DataModel
    {
        public LensFlareDataSRP?                        M_LensFlareData                         { get; set; }
        public float                                    Intensity                               { get; set; }
        public float                                    MaxAttenuationDistance                  { get; set; }
        public float                                    MaxAttenuationScale                     { get; set; }
        public AnimationCurve?                          DistanceAttenuationCurve                { get; set; }
        public AnimationCurve?                          ScaleByDistanceCurve                    { get; set; }
        public bool                                     AttenuationByLightShape                 { get; set; }
        public AnimationCurve?                          RadialScreenAttenuationCurve            { get; set; }
        public bool                                     UseOcclusion                            { get; set; }
        public float                                    OcclusionRadius                         { get; set; }
        public bool                                     UseBackgroundCloudOcclusion             { get; set; }
        public uint                                     SampleCount                             { get; set; }
        public float                                    OcclusionOffset                         { get; set; }
        public float                                    Scale                                   { get; set; }
        public bool                                     AllowOffScreen                          { get; set; }
        public bool                                     VolumetricCloudOcclusion                { get; set; }
        public TextureCurve?                            OcclusionRemapCurve                     { get; set; }

        public static LensFlareComponentSRP? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LensFlareComponentSRP() { Pointer= p0 };

            value.M_LensFlareData                           = GetObject<LensFlareDataSRP>(new IntPtr(p + 0x020), ReversePrism.DataModels.LensFlareDataSRP.FromPointer); // 0x20 M_LensFlareData             ( ModelClassType LensFlareDataSRP LensFlareDataSRP LensFlareDataSRP Pointer )
            value.Intensity                                 = GetSingle(new IntPtr(p + 0x028)); // 0x28 Intensity                   ( ModelPrimitiveType float float float Single )
            value.MaxAttenuationDistance                    = GetSingle(new IntPtr(p + 0x02C)); // 0x2C MaxAttenuationDistance      ( ModelPrimitiveType float float float Single )
            value.MaxAttenuationScale                       = GetSingle(new IntPtr(p + 0x030)); // 0x30 MaxAttenuationScale         ( ModelPrimitiveType float float float Single )
            value.DistanceAttenuationCurve                  = GetObject<AnimationCurve>(new IntPtr(p + 0x038), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x38 DistanceAttenuationCurve    ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.ScaleByDistanceCurve                      = GetObject<AnimationCurve>(new IntPtr(p + 0x040), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x40 ScaleByDistanceCurve        ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.AttenuationByLightShape                   = GetBool(new IntPtr(p + 0x048)); // 0x48 AttenuationByLightShape     ( ModelPrimitiveType bool bool bool Bool )
            value.RadialScreenAttenuationCurve              = GetObject<AnimationCurve>(new IntPtr(p + 0x050), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x50 RadialScreenAttenuationCurve ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.UseOcclusion                              = GetBool(new IntPtr(p + 0x058)); // 0x58 UseOcclusion                ( ModelPrimitiveType bool bool bool Bool )
            value.OcclusionRadius                           = GetSingle(new IntPtr(p + 0x05C)); // 0x5C OcclusionRadius             ( ModelPrimitiveType float float float Single )
            value.UseBackgroundCloudOcclusion               = GetBool(new IntPtr(p + 0x060)); // 0x60 UseBackgroundCloudOcclusion ( ModelPrimitiveType bool bool bool Bool )
            value.SampleCount                               = GetUInt32(new IntPtr(p + 0x064)); // 0x64 SampleCount                 ( ModelPrimitiveType uint uint uint UInt32 )
            value.OcclusionOffset                           = GetSingle(new IntPtr(p + 0x068)); // 0x68 OcclusionOffset             ( ModelPrimitiveType float float float Single )
            value.Scale                                     = GetSingle(new IntPtr(p + 0x06C)); // 0x6C Scale                       ( ModelPrimitiveType float float float Single )
            value.AllowOffScreen                            = GetBool(new IntPtr(p + 0x070)); // 0x70 AllowOffScreen              ( ModelPrimitiveType bool bool bool Bool )
            value.VolumetricCloudOcclusion                  = GetBool(new IntPtr(p + 0x071)); // 0x71 VolumetricCloudOcclusion    ( ModelPrimitiveType bool bool bool Bool )
            value.OcclusionRemapCurve                       = GetObject<TextureCurve>(new IntPtr(p + 0x078), ReversePrism.DataModels.TextureCurve.FromPointer); // 0x78 OcclusionRemapCurve         ( ModelClassType TextureCurve TextureCurve TextureCurve Pointer )

            return value;
        }
    }
}
