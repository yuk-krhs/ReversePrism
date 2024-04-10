using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Visible                                  000186595960 ModelPrimitiveType bool bool bool Bool
    // 014 Position                                 000186666050 ModelPrimitiveType float float float Single
    // 018 PositionOffset                           0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 020 AngularOffset                            000186666050 ModelPrimitiveType float float float Single
    // 024 TranslationScale                         0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 02C M_LocalIntensity                         0001866656B0 ModelPrimitiveType float float float Single
    // 030 LensFlareTexture                         00018664D720 ModelClassType Texture Texture Texture Pointer
    // 038 UniformScale                             000186666050 ModelPrimitiveType float float float Single
    // 03C SizeXY                                   0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 044 AllowMultipleElement                     000186595960 ModelPrimitiveType bool bool bool Bool
    // 048 M_Count                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 04C PreserveAspectRatio                      000186595960 ModelPrimitiveType bool bool bool Bool
    // 050 Rotation                                 000186666050 ModelPrimitiveType float float float Single
    // 054 Tint                                     0001865AB0A0 ModelEnumType Color Color Color Int32
    // 064 BlendMode                                0001866B4FB0 ModelEnumType SRPLensFlareBlendMode SRPLensFlareBlendMode SRPLensFlareBlendMode Int32
    // 068 AutoRotate                               000186595960 ModelPrimitiveType bool bool bool Bool
    // 06C FlareType                                0001866B5E50 ModelEnumType SRPLensFlareType SRPLensFlareType SRPLensFlareType Int32
    // 070 ModulateByLightColor                     000186595960 ModelPrimitiveType bool bool bool Bool
    // 071 IsFoldOpened                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 074 Distribution                             0001866B5700 ModelEnumType SRPLensFlareDistribution SRPLensFlareDistribution SRPLensFlareDistribution Int32
    // 078 LengthSpread                             000186666050 ModelPrimitiveType float float float Single
    // 080 PositionCurve                            000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 088 ScaleCurve                               000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 090 Seed                                     0001865F36C0 ModelPrimitiveType int int int Int32
    // 098 ColorGradient                            0001865DB1F0 ModelClassType Gradient Gradient Gradient Pointer
    // 0A0 M_IntensityVariation                     0001866656B0 ModelPrimitiveType float float float Single
    // 0A4 PositionVariation                        0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 0AC ScaleVariation                           000186666050 ModelPrimitiveType float float float Single
    // 0B0 RotationVariation                        000186666050 ModelPrimitiveType float float float Single
    // 0B4 EnableRadialDistortion                   000186595960 ModelPrimitiveType bool bool bool Bool
    // 0B8 TargetSizeDistortion                     0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 0C0 DistortionCurve                          000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
    // 0C8 DistortionRelativeToCenter               000186595960 ModelPrimitiveType bool bool bool Bool
    // 0CC M_FallOff                                0001866656B0 ModelPrimitiveType float float float Single
    // 0D0 M_EdgeOffset                             0001866656B0 ModelPrimitiveType float float float Single
    // 0D4 M_SideCount                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0D8 M_SdfRoundness                           0001866656B0 ModelPrimitiveType float float float Single
    // 0DC InverseSDF                               000186595960 ModelPrimitiveType bool bool bool Bool
    // 0E0 UniformAngle                             000186666050 ModelPrimitiveType float float float Single
    // 0E8 UniformAngleCurve                        000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer
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

            value.Visible                                   = GetBool(new IntPtr(p + 0x010)); // 0246692B7688 0x10 Visible                     ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Position                                  = GetSingle(new IntPtr(p + 0x014)); // 0246692B76A8 0x14 Position                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.PositionOffset                            = (Vector2)GetInt32(new IntPtr(p + 0x018)); // 0246692B76C8 0x18 PositionOffset              ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.AngularOffset                             = GetSingle(new IntPtr(p + 0x020)); // 0246692B76E8 0x20 AngularOffset               ( 000186666050 ModelPrimitiveType float float float Single )
            value.TranslationScale                          = (Vector2)GetInt32(new IntPtr(p + 0x024)); // 0246692B7708 0x24 TranslationScale            ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_LocalIntensity                          = GetSingle(new IntPtr(p + 0x02C)); // 0246692B7728 0x2C M_LocalIntensity            ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.LensFlareTexture                          = GetObject<Texture>(new IntPtr(p + 0x030), ReversePrism.DataModels.Texture.FromPointer); // 0246692B7748 0x30 LensFlareTexture            ( 00018664D720 ModelClassType Texture Texture Texture Pointer )
            value.UniformScale                              = GetSingle(new IntPtr(p + 0x038)); // 0246692B7768 0x38 UniformScale                ( 000186666050 ModelPrimitiveType float float float Single )
            value.SizeXY                                    = (Vector2)GetInt32(new IntPtr(p + 0x03C)); // 0246692B7788 0x3C SizeXY                      ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.AllowMultipleElement                      = GetBool(new IntPtr(p + 0x044)); // 0246692B77A8 0x44 AllowMultipleElement        ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.M_Count                                   = GetInt32(new IntPtr(p + 0x048)); // 0246692B77C8 0x48 M_Count                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PreserveAspectRatio                       = GetBool(new IntPtr(p + 0x04C)); // 0246692B77E8 0x4C PreserveAspectRatio         ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Rotation                                  = GetSingle(new IntPtr(p + 0x050)); // 0246692B7808 0x50 Rotation                    ( 000186666050 ModelPrimitiveType float float float Single )
            value.Tint                                      = (Color)GetInt32(new IntPtr(p + 0x054)); // 0246692B7828 0x54 Tint                        ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.BlendMode                                 = (SRPLensFlareBlendMode)GetInt32(new IntPtr(p + 0x064)); // 0246692B7848 0x64 BlendMode                   ( 0001866B4FB0 ModelEnumType SRPLensFlareBlendMode SRPLensFlareBlendMode SRPLensFlareBlendMode Int32 )
            value.AutoRotate                                = GetBool(new IntPtr(p + 0x068)); // 0246692B7868 0x68 AutoRotate                  ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.FlareType                                 = (SRPLensFlareType)GetInt32(new IntPtr(p + 0x06C)); // 0246692B7888 0x6C FlareType                   ( 0001866B5E50 ModelEnumType SRPLensFlareType SRPLensFlareType SRPLensFlareType Int32 )
            value.ModulateByLightColor                      = GetBool(new IntPtr(p + 0x070)); // 0246692B78A8 0x70 ModulateByLightColor        ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.IsFoldOpened                              = GetBool(new IntPtr(p + 0x071)); // 0246692B78C8 0x71 IsFoldOpened                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Distribution                              = (SRPLensFlareDistribution)GetInt32(new IntPtr(p + 0x074)); // 0246692B78E8 0x74 Distribution                ( 0001866B5700 ModelEnumType SRPLensFlareDistribution SRPLensFlareDistribution SRPLensFlareDistribution Int32 )
            value.LengthSpread                              = GetSingle(new IntPtr(p + 0x078)); // 0246692B7908 0x78 LengthSpread                ( 000186666050 ModelPrimitiveType float float float Single )
            value.PositionCurve                             = GetObject<AnimationCurve>(new IntPtr(p + 0x080), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0246692B7928 0x80 PositionCurve               ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.ScaleCurve                                = GetObject<AnimationCurve>(new IntPtr(p + 0x088), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0246692B7948 0x88 ScaleCurve                  ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.Seed                                      = GetInt32(new IntPtr(p + 0x090)); // 0246692B7968 0x90 Seed                        ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ColorGradient                             = GetObject<Gradient>(new IntPtr(p + 0x098), ReversePrism.DataModels.Gradient.FromPointer); // 0246692B7988 0x98 ColorGradient               ( 0001865DB1F0 ModelClassType Gradient Gradient Gradient Pointer )
            value.M_IntensityVariation                      = GetSingle(new IntPtr(p + 0x0A0)); // 0246692B79A8 0xA0 M_IntensityVariation        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.PositionVariation                         = (Vector2)GetInt32(new IntPtr(p + 0x0A4)); // 0246692B79C8 0xA4 PositionVariation           ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.ScaleVariation                            = GetSingle(new IntPtr(p + 0x0AC)); // 0246692B79E8 0xAC ScaleVariation              ( 000186666050 ModelPrimitiveType float float float Single )
            value.RotationVariation                         = GetSingle(new IntPtr(p + 0x0B0)); // 0246692B7A08 0xB0 RotationVariation           ( 000186666050 ModelPrimitiveType float float float Single )
            value.EnableRadialDistortion                    = GetBool(new IntPtr(p + 0x0B4)); // 0246692B7A28 0xB4 EnableRadialDistortion      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.TargetSizeDistortion                      = (Vector2)GetInt32(new IntPtr(p + 0x0B8)); // 0246692B7A48 0xB8 TargetSizeDistortion        ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.DistortionCurve                           = GetObject<AnimationCurve>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0246692B7A68 0xC0 DistortionCurve             ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )
            value.DistortionRelativeToCenter                = GetBool(new IntPtr(p + 0x0C8)); // 0246692B7A88 0xC8 DistortionRelativeToCenter  ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.M_FallOff                                 = GetSingle(new IntPtr(p + 0x0CC)); // 0246692B7AA8 0xCC M_FallOff                   ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_EdgeOffset                              = GetSingle(new IntPtr(p + 0x0D0)); // 0246692B7AC8 0xD0 M_EdgeOffset                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_SideCount                               = GetInt32(new IntPtr(p + 0x0D4)); // 0246692B7AE8 0xD4 M_SideCount                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_SdfRoundness                            = GetSingle(new IntPtr(p + 0x0D8)); // 0246692B7B08 0xD8 M_SdfRoundness              ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.InverseSDF                                = GetBool(new IntPtr(p + 0x0DC)); // 0246692B7B28 0xDC InverseSDF                  ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.UniformAngle                              = GetSingle(new IntPtr(p + 0x0E0)); // 0246692B7B48 0xE0 UniformAngle                ( 000186666050 ModelPrimitiveType float float float Single )
            value.UniformAngleCurve                         = GetObject<AnimationCurve>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.AnimationCurve.FromPointer); // 0246692B7B68 0xE8 UniformAngleCurve           ( 000186586F10 ModelClassType AnimationCurve AnimationCurve AnimationCurve Pointer )

            return value;
        }
    }
}
