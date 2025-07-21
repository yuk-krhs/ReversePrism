using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Visible                                  ModelPrimitiveType bool bool bool Bool
    // 014 Position                                 ModelPrimitiveType float float float Single
    // 018 PositionOffset                           ModelEnumType Vector2 Vector2 Vector2 Int32
    // 020 AngularOffset                            ModelPrimitiveType float float float Single
    // 024 TranslationScale                         ModelEnumType Vector2 Vector2 Vector2 Int32
    // 02C M_LocalIntensity                         ModelPrimitiveType float float float Single
    // 030 LensFlareTexture                         ModelClassType Texture Texture Texture Pointer
    // 038 UniformScale                             ModelPrimitiveType float float float Single
    // 03C SizeXY                                   ModelEnumType Vector2 Vector2 Vector2 Int32
    // 044 AllowMultipleElement                     ModelPrimitiveType bool bool bool Bool
    // 048 M_Count                                  ModelPrimitiveType int int int Int32
    // 04C PreserveAspectRatio                      ModelPrimitiveType bool bool bool Bool
    // 050 Rotation                                 ModelPrimitiveType float float float Single
    // 054 Tint                                     ModelEnumType Color Color Color Int32
    // 064 BlendMode                                ModelEnumType SRPLensFlareBlendMode SRPLensFlareBlendMode SRPLensFlareBlendMode Int32
    // 068 AutoRotate                               ModelPrimitiveType bool bool bool Bool
    // 06C FlareType                                ModelEnumType SRPLensFlareType SRPLensFlareType SRPLensFlareType Int32
    // 070 ModulateByLightColor                     ModelPrimitiveType bool bool bool Bool
    // 071 IsFoldOpened                             ModelPrimitiveType bool bool bool Bool
    // 074 Distribution                             ModelEnumType SRPLensFlareDistribution SRPLensFlareDistribution SRPLensFlareDistribution Int32
    // 078 LengthSpread                             ModelPrimitiveType float float float Single
    // 080 PositionCurve                            ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 088 ScaleCurve                               ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 090 Seed                                     ModelPrimitiveType int int int Int32
    // 098 ColorGradient                            ModelClassType Gradient Gradient Gradient Pointer
    // 0A0 M_IntensityVariation                     ModelPrimitiveType float float float Single
    // 0A4 PositionVariation                        ModelEnumType Vector2 Vector2 Vector2 Int32
    // 0AC ScaleVariation                           ModelPrimitiveType float float float Single
    // 0B0 RotationVariation                        ModelPrimitiveType float float float Single
    // 0B4 EnableRadialDistortion                   ModelPrimitiveType bool bool bool Bool
    // 0B8 TargetSizeDistortion                     ModelEnumType Vector2 Vector2 Vector2 Int32
    // 0C0 DistortionCurve                          ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 0C8 DistortionRelativeToCenter               ModelPrimitiveType bool bool bool Bool
    // 0CC M_FallOff                                ModelPrimitiveType float float float Single
    // 0D0 M_EdgeOffset                             ModelPrimitiveType float float float Single
    // 0D4 M_SideCount                              ModelPrimitiveType int int int Int32
    // 0D8 M_SdfRoundness                           ModelPrimitiveType float float float Single
    // 0DC InverseSDF                               ModelPrimitiveType bool bool bool Bool
    // 0E0 UniformAngle                             ModelPrimitiveType float float float Single
    // 0E8 UniformAngleCurve                        ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    public partial class LensFlareDataElementSRP : DataModel
    {
        public bool                                     Visible                                 { get; set; }
        public float                                    Position                                { get; set; }
        public Vector2                                  PositionOffset                          { get; set; }
        public float                                    AngularOffset                           { get; set; }
        public Vector2                                  TranslationScale                        { get; set; }
        public float                                    M_LocalIntensity                        { get; set; }
        public Texture?                                 LensFlareTexture                        { get; set; }
        public float                                    UniformScale                            { get; set; }
        public Vector2                                  SizeXY                                  { get; set; }
        public bool                                     AllowMultipleElement                    { get; set; }
        public int                                      M_Count                                 { get; set; }
        public bool                                     PreserveAspectRatio                     { get; set; }
        public float                                    Rotation                                { get; set; }
        public Color                                    Tint                                    { get; set; }
        public SRPLensFlareBlendMode                    BlendMode                               { get; set; }
        public bool                                     AutoRotate                              { get; set; }
        public SRPLensFlareType                         FlareType                               { get; set; }
        public bool                                     ModulateByLightColor                    { get; set; }
        public bool                                     IsFoldOpened                            { get; set; }
        public SRPLensFlareDistribution                 Distribution                            { get; set; }
        public float                                    LengthSpread                            { get; set; }
        public AnimationCurve?                          PositionCurve                           { get; set; }
        public AnimationCurve?                          ScaleCurve                              { get; set; }
        public int                                      Seed                                    { get; set; }
        public Gradient?                                ColorGradient                           { get; set; }
        public float                                    M_IntensityVariation                    { get; set; }
        public Vector2                                  PositionVariation                       { get; set; }
        public float                                    ScaleVariation                          { get; set; }
        public float                                    RotationVariation                       { get; set; }
        public bool                                     EnableRadialDistortion                  { get; set; }
        public Vector2                                  TargetSizeDistortion                    { get; set; }
        public AnimationCurve?                          DistortionCurve                         { get; set; }
        public bool                                     DistortionRelativeToCenter              { get; set; }
        public float                                    M_FallOff                               { get; set; }
        public float                                    M_EdgeOffset                            { get; set; }
        public int                                      M_SideCount                             { get; set; }
        public float                                    M_SdfRoundness                          { get; set; }
        public bool                                     InverseSDF                              { get; set; }
        public float                                    UniformAngle                            { get; set; }
        public AnimationCurve?                          UniformAngleCurve                       { get; set; }

        public static LensFlareDataElementSRP? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LensFlareDataElementSRP() { Pointer= p0 };

            value.Visible                                   = GetBool(new IntPtr(p + 0x010)); // 0x10 Visible                     ( ModelPrimitiveType bool bool bool Bool )
            value.Position                                  = GetSingle(new IntPtr(p + 0x014)); // 0x14 Position                    ( ModelPrimitiveType float float float Single )
            value.PositionOffset                            = (Vector2)GetInt32(new IntPtr(p + 0x018)); // 0x18 PositionOffset              ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.AngularOffset                             = GetSingle(new IntPtr(p + 0x020)); // 0x20 AngularOffset               ( ModelPrimitiveType float float float Single )
            value.TranslationScale                          = (Vector2)GetInt32(new IntPtr(p + 0x024)); // 0x24 TranslationScale            ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_LocalIntensity                          = GetSingle(new IntPtr(p + 0x02C)); // 0x2C M_LocalIntensity            ( ModelPrimitiveType float float float Single )
            value.LensFlareTexture                          = GetObject<Texture>(new IntPtr(p + 0x030), ReversePrism.DataModels.Texture.FromPointer); // 0x30 LensFlareTexture            ( ModelClassType Texture Texture Texture Pointer )
            value.UniformScale                              = GetSingle(new IntPtr(p + 0x038)); // 0x38 UniformScale                ( ModelPrimitiveType float float float Single )
            value.SizeXY                                    = (Vector2)GetInt32(new IntPtr(p + 0x03C)); // 0x3C SizeXY                      ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.AllowMultipleElement                      = GetBool(new IntPtr(p + 0x044)); // 0x44 AllowMultipleElement        ( ModelPrimitiveType bool bool bool Bool )
            value.M_Count                                   = GetInt32(new IntPtr(p + 0x048)); // 0x48 M_Count                     ( ModelPrimitiveType int int int Int32 )
            value.PreserveAspectRatio                       = GetBool(new IntPtr(p + 0x04C)); // 0x4C PreserveAspectRatio         ( ModelPrimitiveType bool bool bool Bool )
            value.Rotation                                  = GetSingle(new IntPtr(p + 0x050)); // 0x50 Rotation                    ( ModelPrimitiveType float float float Single )
            value.Tint                                      = (Color)GetInt32(new IntPtr(p + 0x054)); // 0x54 Tint                        ( ModelEnumType Color Color Color Int32 )
            value.BlendMode                                 = (SRPLensFlareBlendMode)GetInt32(new IntPtr(p + 0x064)); // 0x64 BlendMode                   ( ModelEnumType SRPLensFlareBlendMode SRPLensFlareBlendMode SRPLensFlareBlendMode Int32 )
            value.AutoRotate                                = GetBool(new IntPtr(p + 0x068)); // 0x68 AutoRotate                  ( ModelPrimitiveType bool bool bool Bool )
            value.FlareType                                 = (SRPLensFlareType)GetInt32(new IntPtr(p + 0x06C)); // 0x6C FlareType                   ( ModelEnumType SRPLensFlareType SRPLensFlareType SRPLensFlareType Int32 )
            value.ModulateByLightColor                      = GetBool(new IntPtr(p + 0x070)); // 0x70 ModulateByLightColor        ( ModelPrimitiveType bool bool bool Bool )
            value.IsFoldOpened                              = GetBool(new IntPtr(p + 0x071)); // 0x71 IsFoldOpened                ( ModelPrimitiveType bool bool bool Bool )
            value.Distribution                              = (SRPLensFlareDistribution)GetInt32(new IntPtr(p + 0x074)); // 0x74 Distribution                ( ModelEnumType SRPLensFlareDistribution SRPLensFlareDistribution SRPLensFlareDistribution Int32 )
            value.LengthSpread                              = GetSingle(new IntPtr(p + 0x078)); // 0x78 LengthSpread                ( ModelPrimitiveType float float float Single )
            value.PositionCurve                             = GetObject<AnimationCurve>(new IntPtr(p + 0x080), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x80 PositionCurve               ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.ScaleCurve                                = GetObject<AnimationCurve>(new IntPtr(p + 0x088), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0x88 ScaleCurve                  ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.Seed                                      = GetInt32(new IntPtr(p + 0x090)); // 0x90 Seed                        ( ModelPrimitiveType int int int Int32 )
            value.ColorGradient                             = GetObject<Gradient>(new IntPtr(p + 0x098), ReversePrism.DataModels.Gradient.FromPointer); // 0x98 ColorGradient               ( ModelClassType Gradient Gradient Gradient Pointer )
            value.M_IntensityVariation                      = GetSingle(new IntPtr(p + 0x0A0)); // 0xA0 M_IntensityVariation        ( ModelPrimitiveType float float float Single )
            value.PositionVariation                         = (Vector2)GetInt32(new IntPtr(p + 0x0A4)); // 0xA4 PositionVariation           ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.ScaleVariation                            = GetSingle(new IntPtr(p + 0x0AC)); // 0xAC ScaleVariation              ( ModelPrimitiveType float float float Single )
            value.RotationVariation                         = GetSingle(new IntPtr(p + 0x0B0)); // 0xB0 RotationVariation           ( ModelPrimitiveType float float float Single )
            value.EnableRadialDistortion                    = GetBool(new IntPtr(p + 0x0B4)); // 0xB4 EnableRadialDistortion      ( ModelPrimitiveType bool bool bool Bool )
            value.TargetSizeDistortion                      = (Vector2)GetInt32(new IntPtr(p + 0x0B8)); // 0xB8 TargetSizeDistortion        ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.DistortionCurve                           = GetObject<AnimationCurve>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0xC0 DistortionCurve             ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.DistortionRelativeToCenter                = GetBool(new IntPtr(p + 0x0C8)); // 0xC8 DistortionRelativeToCenter  ( ModelPrimitiveType bool bool bool Bool )
            value.M_FallOff                                 = GetSingle(new IntPtr(p + 0x0CC)); // 0xCC M_FallOff                   ( ModelPrimitiveType float float float Single )
            value.M_EdgeOffset                              = GetSingle(new IntPtr(p + 0x0D0)); // 0xD0 M_EdgeOffset                ( ModelPrimitiveType float float float Single )
            value.M_SideCount                               = GetInt32(new IntPtr(p + 0x0D4)); // 0xD4 M_SideCount                 ( ModelPrimitiveType int int int Int32 )
            value.M_SdfRoundness                            = GetSingle(new IntPtr(p + 0x0D8)); // 0xD8 M_SdfRoundness              ( ModelPrimitiveType float float float Single )
            value.InverseSDF                                = GetBool(new IntPtr(p + 0x0DC)); // 0xDC InverseSDF                  ( ModelPrimitiveType bool bool bool Bool )
            value.UniformAngle                              = GetSingle(new IntPtr(p + 0x0E0)); // 0xE0 UniformAngle                ( ModelPrimitiveType float float float Single )
            value.UniformAngleCurve                         = GetObject<AnimationCurve>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0xE8 UniformAngleCurve           ( ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )

            return value;
        }
    }
}
