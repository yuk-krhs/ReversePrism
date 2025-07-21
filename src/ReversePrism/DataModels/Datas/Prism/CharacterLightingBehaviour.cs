using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RimColor                                 ModelEnumType Color Color Color Int32
    // 020 RimLightDirection                        ModelEnumType Vector3 Vector3 Vector3 Int32
    // 02C RimFeather                               ModelPrimitiveType float float float Single
    // 030 RimDiffuseRate                           ModelPrimitiveType float float float Single
    // 034 EnableDepthOffsetRimLight                ModelPrimitiveType bool bool bool Bool
    // 035 EnableToonRimLight                       ModelPrimitiveType bool bool bool Bool
    // 038 RimPower                                 ModelPrimitiveType float float float Single
    // 03C RimIntensity                             ModelPrimitiveType float float float Single
    // 040 RimWidth                                 ModelPrimitiveType float float float Single
    // 044 RimSpread                                ModelPrimitiveType float float float Single
    // 048 RimBorder                                ModelPrimitiveType float float float Single
    // 04C RimBlur                                  ModelPrimitiveType float float float Single
    // 050 RimAntiAlias                             ModelPrimitiveType float float float Single
    // 054 EnableSSS                                ModelPrimitiveType bool bool bool Bool
    // 058 SSSColor                                 ModelEnumType Color Color Color Int32
    public partial class CharacterLightingBehaviour : DataModel
    {
        public Color                                    RimColor                                { get; set; }
        public Vector3                                  RimLightDirection                       { get; set; }
        public float                                    RimFeather                              { get; set; }
        public float                                    RimDiffuseRate                          { get; set; }
        public bool                                     EnableDepthOffsetRimLight               { get; set; }
        public bool                                     EnableToonRimLight                      { get; set; }
        public float                                    RimPower                                { get; set; }
        public float                                    RimIntensity                            { get; set; }
        public float                                    RimWidth                                { get; set; }
        public float                                    RimSpread                               { get; set; }
        public float                                    RimBorder                               { get; set; }
        public float                                    RimBlur                                 { get; set; }
        public float                                    RimAntiAlias                            { get; set; }
        public bool                                     EnableSSS                               { get; set; }
        public Color                                    SSSColor                                { get; set; }

        public static CharacterLightingBehaviour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterLightingBehaviour() { Pointer= p0 };

            value.RimColor                                  = (Color)GetInt32(new IntPtr(p + 0x010)); // 0x10 RimColor                    ( ModelEnumType Color Color Color Int32 )
            value.RimLightDirection                         = (Vector3)GetInt32(new IntPtr(p + 0x020)); // 0x20 RimLightDirection           ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.RimFeather                                = GetSingle(new IntPtr(p + 0x02C)); // 0x2C RimFeather                  ( ModelPrimitiveType float float float Single )
            value.RimDiffuseRate                            = GetSingle(new IntPtr(p + 0x030)); // 0x30 RimDiffuseRate              ( ModelPrimitiveType float float float Single )
            value.EnableDepthOffsetRimLight                 = GetBool(new IntPtr(p + 0x034)); // 0x34 EnableDepthOffsetRimLight   ( ModelPrimitiveType bool bool bool Bool )
            value.EnableToonRimLight                        = GetBool(new IntPtr(p + 0x035)); // 0x35 EnableToonRimLight          ( ModelPrimitiveType bool bool bool Bool )
            value.RimPower                                  = GetSingle(new IntPtr(p + 0x038)); // 0x38 RimPower                    ( ModelPrimitiveType float float float Single )
            value.RimIntensity                              = GetSingle(new IntPtr(p + 0x03C)); // 0x3C RimIntensity                ( ModelPrimitiveType float float float Single )
            value.RimWidth                                  = GetSingle(new IntPtr(p + 0x040)); // 0x40 RimWidth                    ( ModelPrimitiveType float float float Single )
            value.RimSpread                                 = GetSingle(new IntPtr(p + 0x044)); // 0x44 RimSpread                   ( ModelPrimitiveType float float float Single )
            value.RimBorder                                 = GetSingle(new IntPtr(p + 0x048)); // 0x48 RimBorder                   ( ModelPrimitiveType float float float Single )
            value.RimBlur                                   = GetSingle(new IntPtr(p + 0x04C)); // 0x4C RimBlur                     ( ModelPrimitiveType float float float Single )
            value.RimAntiAlias                              = GetSingle(new IntPtr(p + 0x050)); // 0x50 RimAntiAlias                ( ModelPrimitiveType float float float Single )
            value.EnableSSS                                 = GetBool(new IntPtr(p + 0x054)); // 0x54 EnableSSS                   ( ModelPrimitiveType bool bool bool Bool )
            value.SSSColor                                  = (Color)GetInt32(new IntPtr(p + 0x058)); // 0x58 SSSColor                    ( ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
