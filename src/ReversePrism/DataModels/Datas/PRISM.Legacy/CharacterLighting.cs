using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 RimColor                                 ModelEnumType Color Color Color Int32
    // 030 RimLightDirection                        ModelEnumType Vector3 Vector3 Vector3 Int32
    // 03C RimFeather                               ModelPrimitiveType float float float Single
    // 040 RimDiffuseRate                           ModelPrimitiveType float float float Single
    // 044 EnableDepthOffsetRimLight                ModelPrimitiveType bool bool bool Bool
    // 045 EnableToonRimLight                       ModelPrimitiveType bool bool bool Bool
    // 048 GlobalCubeMap                            ModelClassType Cubemap Cubemap Cubemap Pointer
    // 050 RimPower                                 ModelPrimitiveType float float float Single
    // 054 RimIntensity                             ModelPrimitiveType float float float Single
    // 058 RimWidth                                 ModelPrimitiveType float float float Single
    // 05C RimSpread                                ModelPrimitiveType float float float Single
    // 060 RimBorder                                ModelPrimitiveType float float float Single
    // 064 RimBlur                                  ModelPrimitiveType float float float Single
    // 068 RimAntiAlias                             ModelPrimitiveType float float float Single
    // 06C EnableSSS                                ModelPrimitiveType bool bool bool Bool
    // 070 SSSColor                                 ModelEnumType Color Color Color Int32
    // 000 CharacterLightingList                    List`1<CharacterLighting> IL2CPP_TYPE_GENERICINST
    // 008 DepthOffsetRimLightGlobalKeyword         GlobalKeyword IL2CPP_TYPE_VALUETYPE
    // 018 ToonRimLightGlobalKeyword                ModelEnumType GlobalKeyword GlobalKeyword GlobalKeyword Int32
    // 028 SssGlobalKeyword                         ModelEnumType GlobalKeyword GlobalKeyword GlobalKeyword Int32
    public partial class CharacterLighting : DataModel
    {
        public Color                                    RimColor                                { get; set; }
        public Vector3                                  RimLightDirection                       { get; set; }
        public float                                    RimFeather                              { get; set; }
        public float                                    RimDiffuseRate                          { get; set; }
        public bool                                     EnableDepthOffsetRimLight               { get; set; }
        public bool                                     EnableToonRimLight                      { get; set; }
        public Cubemap?                                 GlobalCubeMap                           { get; set; }
        public float                                    RimPower                                { get; set; }
        public float                                    RimIntensity                            { get; set; }
        public float                                    RimWidth                                { get; set; }
        public float                                    RimSpread                               { get; set; }
        public float                                    RimBorder                               { get; set; }
        public float                                    RimBlur                                 { get; set; }
        public float                                    RimAntiAlias                            { get; set; }
        public bool                                     EnableSSS                               { get; set; }
        public Color                                    SSSColor                                { get; set; }
        public GlobalKeyword                            ToonRimLightGlobalKeyword               { get; set; }
        public GlobalKeyword                            SssGlobalKeyword                        { get; set; }

        public static CharacterLighting? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CharacterLighting() { Pointer= p0 };

            value.RimColor                                  = (Color)GetInt32(new IntPtr(p + 0x020)); // 0x20 RimColor                    ( ModelEnumType Color Color Color Int32 )
            value.RimLightDirection                         = (Vector3)GetInt32(new IntPtr(p + 0x030)); // 0x30 RimLightDirection           ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.RimFeather                                = GetSingle(new IntPtr(p + 0x03C)); // 0x3C RimFeather                  ( ModelPrimitiveType float float float Single )
            value.RimDiffuseRate                            = GetSingle(new IntPtr(p + 0x040)); // 0x40 RimDiffuseRate              ( ModelPrimitiveType float float float Single )
            value.EnableDepthOffsetRimLight                 = GetBool(new IntPtr(p + 0x044)); // 0x44 EnableDepthOffsetRimLight   ( ModelPrimitiveType bool bool bool Bool )
            value.EnableToonRimLight                        = GetBool(new IntPtr(p + 0x045)); // 0x45 EnableToonRimLight          ( ModelPrimitiveType bool bool bool Bool )
            value.GlobalCubeMap                             = GetObject<Cubemap>(new IntPtr(p + 0x048), ReversePrism.DataModels.Cubemap.FromPointer); // 0x48 GlobalCubeMap               ( ModelClassType Cubemap Cubemap Cubemap Pointer )
            value.RimPower                                  = GetSingle(new IntPtr(p + 0x050)); // 0x50 RimPower                    ( ModelPrimitiveType float float float Single )
            value.RimIntensity                              = GetSingle(new IntPtr(p + 0x054)); // 0x54 RimIntensity                ( ModelPrimitiveType float float float Single )
            value.RimWidth                                  = GetSingle(new IntPtr(p + 0x058)); // 0x58 RimWidth                    ( ModelPrimitiveType float float float Single )
            value.RimSpread                                 = GetSingle(new IntPtr(p + 0x05C)); // 0x5C RimSpread                   ( ModelPrimitiveType float float float Single )
            value.RimBorder                                 = GetSingle(new IntPtr(p + 0x060)); // 0x60 RimBorder                   ( ModelPrimitiveType float float float Single )
            value.RimBlur                                   = GetSingle(new IntPtr(p + 0x064)); // 0x64 RimBlur                     ( ModelPrimitiveType float float float Single )
            value.RimAntiAlias                              = GetSingle(new IntPtr(p + 0x068)); // 0x68 RimAntiAlias                ( ModelPrimitiveType float float float Single )
            value.EnableSSS                                 = GetBool(new IntPtr(p + 0x06C)); // 0x6C EnableSSS                   ( ModelPrimitiveType bool bool bool Bool )
            value.SSSColor                                  = (Color)GetInt32(new IntPtr(p + 0x070)); // 0x70 SSSColor                    ( ModelEnumType Color Color Color Int32 )
            value.ToonRimLightGlobalKeyword                 = (GlobalKeyword)GetInt32(new IntPtr(p + 0x018)); // 0x18 ToonRimLightGlobalKeyword   ( ModelEnumType GlobalKeyword GlobalKeyword GlobalKeyword Int32 )
            value.SssGlobalKeyword                          = (GlobalKeyword)GetInt32(new IntPtr(p + 0x028)); // 0x28 SssGlobalKeyword            ( ModelEnumType GlobalKeyword GlobalKeyword GlobalKeyword Int32 )

            return value;
        }
    }
}
