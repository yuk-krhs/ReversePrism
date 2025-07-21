using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_AdditionalLightsBufferId               ModelPrimitiveType int int int Int32
    // 014 M_AdditionalLightsIndicesId              ModelPrimitiveType int int int Int32
    // 000 k_SetupLightConstants                    string IL2CPP_TYPE_STRING
    // 000 m_ProfilingSampler                       ProfilingSampler IL2CPP_TYPE_CLASS
    // 008 m_ProfilingSamplerFPSetup                ProfilingSampler IL2CPP_TYPE_CLASS
    // 010 M_ProfilingSamplerFPComplete             ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 018 M_ProfilingSamplerFPUpload               ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer
    // 018 M_MixedLightingSetup                     ModelEnumType MixedLightingSetup MixedLightingSetup MixedLightingSetup Int32
    // 020 M_AdditionalLightPositions               ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer
    // 028 M_AdditionalLightColors                  ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer
    // 030 M_AdditionalLightAttenuations            ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer
    // 038 M_AdditionalLightSpotDirections          ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer
    // 040 M_AdditionalLightOcclusionProbeChannels  ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer
    // 048 M_AdditionalLightsLayerMasks             ModelPrimitiveListType float[] float[] List<float> Pointer
    // 050 M_UseStructuredBuffer                    ModelPrimitiveType bool bool bool Bool
    // 051 M_UseForwardPlus                         ModelPrimitiveType bool bool bool Bool
    // 054 M_DirectionalLightCount                  ModelPrimitiveType int int int Int32
    // 058 M_ActualTileWidth                        ModelPrimitiveType int int int Int32
    // 05C M_TileResolution                         ModelEnumType int2 int2 int2 Int32
    // 068 M_CullingHandle                          ModelEnumType JobHandle JobHandle JobHandle Int32
    // 078 m_ZBins                                  NativeArray`1<uint> IL2CPP_TYPE_GENERICINST
    // 088 M_ZBinsBuffer                            ModelClassType GraphicsBuffer GraphicsBuffer GraphicsBuffer Pointer
    // 090 m_TileMasks                              NativeArray`1<uint> IL2CPP_TYPE_GENERICINST
    // 0A0 M_TileMasksBuffer                        ModelClassType GraphicsBuffer GraphicsBuffer GraphicsBuffer Pointer
    // 0A8 M_LightCookieManager                     ModelClassType LightCookieManager LightCookieManager LightCookieManager Pointer
    // 0B0 M_ReflectionProbeManager                 ModelEnumType ReflectionProbeManager ReflectionProbeManager ReflectionProbeManager Int32
    // 130 M_WordsPerTile                           ModelPrimitiveType int int int Int32
    // 134 M_ZBinScale                              ModelPrimitiveType float float float Single
    // 138 M_ZBinOffset                             ModelPrimitiveType float float float Single
    // 13C M_LightCount                             ModelPrimitiveType int int int Int32
    // 140 M_BinCount                               ModelPrimitiveType int int int Int32
    public partial class ForwardLights : DataModel
    {
        public int                                      M_AdditionalLightsBufferId              { get; set; }
        public int                                      M_AdditionalLightsIndicesId             { get; set; }
        public ProfilingSampler?                        M_ProfilingSamplerFPComplete            { get; set; }
        public ProfilingSampler?                        M_ProfilingSamplerFPUpload              { get; set; }
        public MixedLightingSetup                       M_MixedLightingSetup                    { get; set; }
        public List<Vector4>?                           M_AdditionalLightPositions              { get; set; }
        public List<Vector4>?                           M_AdditionalLightColors                 { get; set; }
        public List<Vector4>?                           M_AdditionalLightAttenuations           { get; set; }
        public List<Vector4>?                           M_AdditionalLightSpotDirections         { get; set; }
        public List<Vector4>?                           M_AdditionalLightOcclusionProbeChannels { get; set; }
        public List<float>?                             M_AdditionalLightsLayerMasks            { get; set; }
        public bool                                     M_UseStructuredBuffer                   { get; set; }
        public bool                                     M_UseForwardPlus                        { get; set; }
        public int                                      M_DirectionalLightCount                 { get; set; }
        public int                                      M_ActualTileWidth                       { get; set; }
        public int2                                     M_TileResolution                        { get; set; }
        public JobHandle                                M_CullingHandle                         { get; set; }
        public GraphicsBuffer?                          M_ZBinsBuffer                           { get; set; }
        public GraphicsBuffer?                          M_TileMasksBuffer                       { get; set; }
        public LightCookieManager?                      M_LightCookieManager                    { get; set; }
        public ReflectionProbeManager                   M_ReflectionProbeManager                { get; set; }
        public int                                      M_WordsPerTile                          { get; set; }
        public float                                    M_ZBinScale                             { get; set; }
        public float                                    M_ZBinOffset                            { get; set; }
        public int                                      M_LightCount                            { get; set; }
        public int                                      M_BinCount                              { get; set; }

        public static ForwardLights? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ForwardLights() { Pointer= p0 };

            value.M_AdditionalLightsBufferId                = GetInt32(new IntPtr(p + 0x010)); // 0x10 M_AdditionalLightsBufferId  ( ModelPrimitiveType int int int Int32 )
            value.M_AdditionalLightsIndicesId               = GetInt32(new IntPtr(p + 0x014)); // 0x14 M_AdditionalLightsIndicesId ( ModelPrimitiveType int int int Int32 )
            value.M_ProfilingSamplerFPComplete              = GetObject<ProfilingSampler>(new IntPtr(p + 0x010), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0x10 M_ProfilingSamplerFPComplete ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.M_ProfilingSamplerFPUpload                = GetObject<ProfilingSampler>(new IntPtr(p + 0x018), ReversePrism.DataModels.ProfilingSampler.FromPointer); // 0x18 M_ProfilingSamplerFPUpload  ( ModelClassType ProfilingSampler ProfilingSampler ProfilingSampler Pointer )
            value.M_MixedLightingSetup                      = (MixedLightingSetup)GetInt32(new IntPtr(p + 0x018)); // 0x18 M_MixedLightingSetup        ( ModelEnumType MixedLightingSetup MixedLightingSetup MixedLightingSetup Int32 )
            value.M_AdditionalLightPositions                = GetEnumList<Vector4>(new IntPtr(p + 0x020)); // 0x20 M_AdditionalLightPositions  ( ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer )
            value.M_AdditionalLightColors                   = GetEnumList<Vector4>(new IntPtr(p + 0x028)); // 0x28 M_AdditionalLightColors     ( ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer )
            value.M_AdditionalLightAttenuations             = GetEnumList<Vector4>(new IntPtr(p + 0x030)); // 0x30 M_AdditionalLightAttenuations ( ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer )
            value.M_AdditionalLightSpotDirections           = GetEnumList<Vector4>(new IntPtr(p + 0x038)); // 0x38 M_AdditionalLightSpotDirections ( ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer )
            value.M_AdditionalLightOcclusionProbeChannels   = GetEnumList<Vector4>(new IntPtr(p + 0x040)); // 0x40 M_AdditionalLightOcclusionProbeChannels ( ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer )
            value.M_AdditionalLightsLayerMasks              = GetSingleList(new IntPtr(p + 0x048)); // 0x48 M_AdditionalLightsLayerMasks ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.M_UseStructuredBuffer                     = GetBool(new IntPtr(p + 0x050)); // 0x50 M_UseStructuredBuffer       ( ModelPrimitiveType bool bool bool Bool )
            value.M_UseForwardPlus                          = GetBool(new IntPtr(p + 0x051)); // 0x51 M_UseForwardPlus            ( ModelPrimitiveType bool bool bool Bool )
            value.M_DirectionalLightCount                   = GetInt32(new IntPtr(p + 0x054)); // 0x54 M_DirectionalLightCount     ( ModelPrimitiveType int int int Int32 )
            value.M_ActualTileWidth                         = GetInt32(new IntPtr(p + 0x058)); // 0x58 M_ActualTileWidth           ( ModelPrimitiveType int int int Int32 )
            value.M_TileResolution                          = (int2)GetInt32(new IntPtr(p + 0x05C)); // 0x5C M_TileResolution            ( ModelEnumType int2 int2 int2 Int32 )
            value.M_CullingHandle                           = (JobHandle)GetInt32(new IntPtr(p + 0x068)); // 0x68 M_CullingHandle             ( ModelEnumType JobHandle JobHandle JobHandle Int32 )
            value.M_ZBinsBuffer                             = GetObject<GraphicsBuffer>(new IntPtr(p + 0x088), ReversePrism.DataModels.GraphicsBuffer.FromPointer); // 0x88 M_ZBinsBuffer               ( ModelClassType GraphicsBuffer GraphicsBuffer GraphicsBuffer Pointer )
            value.M_TileMasksBuffer                         = GetObject<GraphicsBuffer>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.GraphicsBuffer.FromPointer); // 0xA0 M_TileMasksBuffer           ( ModelClassType GraphicsBuffer GraphicsBuffer GraphicsBuffer Pointer )
            value.M_LightCookieManager                      = GetObject<LightCookieManager>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.LightCookieManager.FromPointer); // 0xA8 M_LightCookieManager        ( ModelClassType LightCookieManager LightCookieManager LightCookieManager Pointer )
            value.M_ReflectionProbeManager                  = (ReflectionProbeManager)GetInt32(new IntPtr(p + 0x0B0)); // 0xB0 M_ReflectionProbeManager    ( ModelEnumType ReflectionProbeManager ReflectionProbeManager ReflectionProbeManager Int32 )
            value.M_WordsPerTile                            = GetInt32(new IntPtr(p + 0x130)); // 0x130 M_WordsPerTile              ( ModelPrimitiveType int int int Int32 )
            value.M_ZBinScale                               = GetSingle(new IntPtr(p + 0x134)); // 0x134 M_ZBinScale                 ( ModelPrimitiveType float float float Single )
            value.M_ZBinOffset                              = GetSingle(new IntPtr(p + 0x138)); // 0x138 M_ZBinOffset                ( ModelPrimitiveType float float float Single )
            value.M_LightCount                              = GetInt32(new IntPtr(p + 0x13C)); // 0x13C M_LightCount                ( ModelPrimitiveType int int int Int32 )
            value.M_BinCount                                = GetInt32(new IntPtr(p + 0x140)); // 0x140 M_BinCount                  ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
