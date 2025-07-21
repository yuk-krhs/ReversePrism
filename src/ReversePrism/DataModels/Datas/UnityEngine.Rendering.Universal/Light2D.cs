using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_CurrentComponentVersion                ComponentVersions IL2CPP_TYPE_VALUETYPE
    // 020 M_ComponentVersion                       ModelEnumType ComponentVersions ComponentVersions ComponentVersions Int32
    // 024 M_LightType                              ModelEnumType LightType LightType LightType Int32
    // 028 M_BlendStyleIndex                        ModelPrimitiveType int int int Int32
    // 02C M_FalloffIntensity                       ModelPrimitiveType float float float Single
    // 030 M_Color                                  ModelEnumType Color Color Color Int32
    // 040 M_Intensity                              ModelPrimitiveType float float float Single
    // 044 M_LightVolumeIntensity                   ModelPrimitiveType float float float Single
    // 048 M_LightVolumeIntensityEnabled            ModelPrimitiveType bool bool bool Bool
    // 050 M_ApplyToSortingLayers                   ModelPrimitiveListType int[] int[] List<int> Pointer
    // 058 M_LightCookieSprite                      ModelClassType Sprite Sprite Sprite Pointer
    // 060 M_DeprecatedPointLightCookieSprite       ModelClassType Sprite Sprite Sprite Pointer
    // 068 M_LightOrder                             ModelPrimitiveType int int int Int32
    // 06C M_AlphaBlendOnOverlap                    ModelPrimitiveType bool bool bool Bool
    // 070 M_OverlapOperation                       ModelEnumType OverlapOperation OverlapOperation OverlapOperation Int32
    // 074 M_NormalMapDistance                      ModelPrimitiveType float float float Single
    // 078 M_NormalMapQuality                       ModelEnumType NormalMapQuality NormalMapQuality NormalMapQuality Int32
    // 07C M_UseNormalMap                           ModelPrimitiveType bool bool bool Bool
    // 07D M_ShadowIntensityEnabled                 ModelPrimitiveType bool bool bool Bool
    // 080 M_ShadowIntensity                        ModelPrimitiveType float float float Single
    // 084 M_ShadowVolumeIntensityEnabled           ModelPrimitiveType bool bool bool Bool
    // 088 M_ShadowVolumeIntensity                  ModelPrimitiveType float float float Single
    // 090 M_Mesh                                   ModelClassType Mesh Mesh Mesh Pointer
    // 098 M_Vertices                               ModelEnumListType LightMeshVertex[] LightMeshVertex[] List<LightMeshVertex> Pointer
    // 0A0 M_Triangles                              ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer
    // 0A8 M_PreviousLightCookieSprite              ModelPrimitiveType int int int Int32
    // 0AC M_CachedPosition                         ModelEnumType Vector3 Vector3 Vector3 Int32
    // 0B8 M_LocalBounds                            ModelEnumType Bounds Bounds Bounds Int32
    // 0D0 BoundingSphere                           ModelEnumType BoundingSphere BoundingSphere BoundingSphere Int32
    // 0E0 ForceUpdate                              ModelPrimitiveType bool bool bool Bool
    // 0E4 M_PointLightInnerAngle                   ModelPrimitiveType float float float Single
    // 0E8 M_PointLightOuterAngle                   ModelPrimitiveType float float float Single
    // 0EC M_PointLightInnerRadius                  ModelPrimitiveType float float float Single
    // 0F0 M_PointLightOuterRadius                  ModelPrimitiveType float float float Single
    // 0F4 M_ShapeLightParametricSides              ModelPrimitiveType int int int Int32
    // 0F8 M_ShapeLightParametricAngleOffset        ModelPrimitiveType float float float Single
    // 0FC M_ShapeLightParametricRadius             ModelPrimitiveType float float float Single
    // 100 M_ShapeLightFalloffSize                  ModelPrimitiveType float float float Single
    // 104 M_ShapeLightFalloffOffset                ModelEnumType Vector2 Vector2 Vector2 Int32
    // 110 M_ShapePath                              ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    // 118 M_PreviousShapeLightFalloffSize          ModelPrimitiveType float float float Single
    // 11C M_PreviousShapeLightParametricSides      ModelPrimitiveType int int int Int32
    // 120 M_PreviousShapeLightParametricAngleOffset ModelPrimitiveType float float float Single
    // 124 M_PreviousShapeLightParametricRadius     ModelPrimitiveType float float float Single
    // 128 M_PreviousShapePathHash                  ModelPrimitiveType int int int Int32
    // 12C M_PreviousLightType                      ModelEnumType LightType LightType LightType Int32
    public partial class Light2D : DataModel
    {
        public ComponentVersions                        M_ComponentVersion                      { get; set; }
        public LightType                                M_LightType                             { get; set; }
        public int                                      M_BlendStyleIndex                       { get; set; }
        public float                                    M_FalloffIntensity                      { get; set; }
        public Color                                    M_Color                                 { get; set; }
        public float                                    M_Intensity                             { get; set; }
        public float                                    M_LightVolumeIntensity                  { get; set; }
        public bool                                     M_LightVolumeIntensityEnabled           { get; set; }
        public List<int>?                               M_ApplyToSortingLayers                  { get; set; }
        public Sprite?                                  M_LightCookieSprite                     { get; set; }
        public Sprite?                                  M_DeprecatedPointLightCookieSprite      { get; set; }
        public int                                      M_LightOrder                            { get; set; }
        public bool                                     M_AlphaBlendOnOverlap                   { get; set; }
        public OverlapOperation                         M_OverlapOperation                      { get; set; }
        public float                                    M_NormalMapDistance                     { get; set; }
        public NormalMapQuality                         M_NormalMapQuality                      { get; set; }
        public bool                                     M_UseNormalMap                          { get; set; }
        public bool                                     M_ShadowIntensityEnabled                { get; set; }
        public float                                    M_ShadowIntensity                       { get; set; }
        public bool                                     M_ShadowVolumeIntensityEnabled          { get; set; }
        public float                                    M_ShadowVolumeIntensity                 { get; set; }
        public Mesh?                                    M_Mesh                                  { get; set; }
        public List<LightMeshVertex>?                   M_Vertices                              { get; set; }
        public List<ushort>?                            M_Triangles                             { get; set; }
        public int                                      M_PreviousLightCookieSprite             { get; set; }
        public Vector3                                  M_CachedPosition                        { get; set; }
        public Bounds                                   M_LocalBounds                           { get; set; }
        public BoundingSphere                           BoundingSphere                          { get; set; }
        public bool                                     ForceUpdate                             { get; set; }
        public float                                    M_PointLightInnerAngle                  { get; set; }
        public float                                    M_PointLightOuterAngle                  { get; set; }
        public float                                    M_PointLightInnerRadius                 { get; set; }
        public float                                    M_PointLightOuterRadius                 { get; set; }
        public int                                      M_ShapeLightParametricSides             { get; set; }
        public float                                    M_ShapeLightParametricAngleOffset       { get; set; }
        public float                                    M_ShapeLightParametricRadius            { get; set; }
        public float                                    M_ShapeLightFalloffSize                 { get; set; }
        public Vector2                                  M_ShapeLightFalloffOffset               { get; set; }
        public List<Vector3>?                           M_ShapePath                             { get; set; }
        public float                                    M_PreviousShapeLightFalloffSize         { get; set; }
        public int                                      M_PreviousShapeLightParametricSides     { get; set; }
        public float                                    M_PreviousShapeLightParametricAngleOffset { get; set; }
        public float                                    M_PreviousShapeLightParametricRadius    { get; set; }
        public int                                      M_PreviousShapePathHash                 { get; set; }
        public LightType                                M_PreviousLightType                     { get; set; }

        public static Light2D? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Light2D() { Pointer= p0 };

            value.M_ComponentVersion                        = (ComponentVersions)GetInt32(new IntPtr(p + 0x020)); // 0x20 M_ComponentVersion          ( ModelEnumType ComponentVersions ComponentVersions ComponentVersions Int32 )
            value.M_LightType                               = (LightType)GetInt32(new IntPtr(p + 0x024)); // 0x24 M_LightType                 ( ModelEnumType LightType LightType LightType Int32 )
            value.M_BlendStyleIndex                         = GetInt32(new IntPtr(p + 0x028)); // 0x28 M_BlendStyleIndex           ( ModelPrimitiveType int int int Int32 )
            value.M_FalloffIntensity                        = GetSingle(new IntPtr(p + 0x02C)); // 0x2C M_FalloffIntensity          ( ModelPrimitiveType float float float Single )
            value.M_Color                                   = (Color)GetInt32(new IntPtr(p + 0x030)); // 0x30 M_Color                     ( ModelEnumType Color Color Color Int32 )
            value.M_Intensity                               = GetSingle(new IntPtr(p + 0x040)); // 0x40 M_Intensity                 ( ModelPrimitiveType float float float Single )
            value.M_LightVolumeIntensity                    = GetSingle(new IntPtr(p + 0x044)); // 0x44 M_LightVolumeIntensity      ( ModelPrimitiveType float float float Single )
            value.M_LightVolumeIntensityEnabled             = GetBool(new IntPtr(p + 0x048)); // 0x48 M_LightVolumeIntensityEnabled ( ModelPrimitiveType bool bool bool Bool )
            value.M_ApplyToSortingLayers                    = GetInt32List(new IntPtr(p + 0x050)); // 0x50 M_ApplyToSortingLayers      ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.M_LightCookieSprite                       = GetObject<Sprite>(new IntPtr(p + 0x058), ReversePrism.DataModels.Sprite.FromPointer); // 0x58 M_LightCookieSprite         ( ModelClassType Sprite Sprite Sprite Pointer )
            value.M_DeprecatedPointLightCookieSprite        = GetObject<Sprite>(new IntPtr(p + 0x060), ReversePrism.DataModels.Sprite.FromPointer); // 0x60 M_DeprecatedPointLightCookieSprite ( ModelClassType Sprite Sprite Sprite Pointer )
            value.M_LightOrder                              = GetInt32(new IntPtr(p + 0x068)); // 0x68 M_LightOrder                ( ModelPrimitiveType int int int Int32 )
            value.M_AlphaBlendOnOverlap                     = GetBool(new IntPtr(p + 0x06C)); // 0x6C M_AlphaBlendOnOverlap       ( ModelPrimitiveType bool bool bool Bool )
            value.M_OverlapOperation                        = (OverlapOperation)GetInt32(new IntPtr(p + 0x070)); // 0x70 M_OverlapOperation          ( ModelEnumType OverlapOperation OverlapOperation OverlapOperation Int32 )
            value.M_NormalMapDistance                       = GetSingle(new IntPtr(p + 0x074)); // 0x74 M_NormalMapDistance         ( ModelPrimitiveType float float float Single )
            value.M_NormalMapQuality                        = (NormalMapQuality)GetInt32(new IntPtr(p + 0x078)); // 0x78 M_NormalMapQuality          ( ModelEnumType NormalMapQuality NormalMapQuality NormalMapQuality Int32 )
            value.M_UseNormalMap                            = GetBool(new IntPtr(p + 0x07C)); // 0x7C M_UseNormalMap              ( ModelPrimitiveType bool bool bool Bool )
            value.M_ShadowIntensityEnabled                  = GetBool(new IntPtr(p + 0x07D)); // 0x7D M_ShadowIntensityEnabled    ( ModelPrimitiveType bool bool bool Bool )
            value.M_ShadowIntensity                         = GetSingle(new IntPtr(p + 0x080)); // 0x80 M_ShadowIntensity           ( ModelPrimitiveType float float float Single )
            value.M_ShadowVolumeIntensityEnabled            = GetBool(new IntPtr(p + 0x084)); // 0x84 M_ShadowVolumeIntensityEnabled ( ModelPrimitiveType bool bool bool Bool )
            value.M_ShadowVolumeIntensity                   = GetSingle(new IntPtr(p + 0x088)); // 0x88 M_ShadowVolumeIntensity     ( ModelPrimitiveType float float float Single )
            value.M_Mesh                                    = GetObject<Mesh>(new IntPtr(p + 0x090), ReversePrism.DataModels.Mesh.FromPointer); // 0x90 M_Mesh                      ( ModelClassType Mesh Mesh Mesh Pointer )
            value.M_Vertices                                = GetEnumList<LightMeshVertex>(new IntPtr(p + 0x098)); // 0x98 M_Vertices                  ( ModelEnumListType LightMeshVertex[] LightMeshVertex[] List<LightMeshVertex> Pointer )
            value.M_Triangles                               = GetUInt16List(new IntPtr(p + 0x0A0)); // 0xA0 M_Triangles                 ( ModelPrimitiveListType ushort[] ushort[] List<ushort> Pointer )
            value.M_PreviousLightCookieSprite               = GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 M_PreviousLightCookieSprite ( ModelPrimitiveType int int int Int32 )
            value.M_CachedPosition                          = (Vector3)GetInt32(new IntPtr(p + 0x0AC)); // 0xAC M_CachedPosition            ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_LocalBounds                             = (Bounds)GetInt32(new IntPtr(p + 0x0B8)); // 0xB8 M_LocalBounds               ( ModelEnumType Bounds Bounds Bounds Int32 )
            value.BoundingSphere                            = (BoundingSphere)GetInt32(new IntPtr(p + 0x0D0)); // 0xD0 BoundingSphere              ( ModelEnumType BoundingSphere BoundingSphere BoundingSphere Int32 )
            value.ForceUpdate                               = GetBool(new IntPtr(p + 0x0E0)); // 0xE0 ForceUpdate                 ( ModelPrimitiveType bool bool bool Bool )
            value.M_PointLightInnerAngle                    = GetSingle(new IntPtr(p + 0x0E4)); // 0xE4 M_PointLightInnerAngle      ( ModelPrimitiveType float float float Single )
            value.M_PointLightOuterAngle                    = GetSingle(new IntPtr(p + 0x0E8)); // 0xE8 M_PointLightOuterAngle      ( ModelPrimitiveType float float float Single )
            value.M_PointLightInnerRadius                   = GetSingle(new IntPtr(p + 0x0EC)); // 0xEC M_PointLightInnerRadius     ( ModelPrimitiveType float float float Single )
            value.M_PointLightOuterRadius                   = GetSingle(new IntPtr(p + 0x0F0)); // 0xF0 M_PointLightOuterRadius     ( ModelPrimitiveType float float float Single )
            value.M_ShapeLightParametricSides               = GetInt32(new IntPtr(p + 0x0F4)); // 0xF4 M_ShapeLightParametricSides ( ModelPrimitiveType int int int Int32 )
            value.M_ShapeLightParametricAngleOffset         = GetSingle(new IntPtr(p + 0x0F8)); // 0xF8 M_ShapeLightParametricAngleOffset ( ModelPrimitiveType float float float Single )
            value.M_ShapeLightParametricRadius              = GetSingle(new IntPtr(p + 0x0FC)); // 0xFC M_ShapeLightParametricRadius ( ModelPrimitiveType float float float Single )
            value.M_ShapeLightFalloffSize                   = GetSingle(new IntPtr(p + 0x100)); // 0x100 M_ShapeLightFalloffSize     ( ModelPrimitiveType float float float Single )
            value.M_ShapeLightFalloffOffset                 = (Vector2)GetInt32(new IntPtr(p + 0x104)); // 0x104 M_ShapeLightFalloffOffset   ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_ShapePath                               = GetEnumList<Vector3>(new IntPtr(p + 0x110)); // 0x110 M_ShapePath                 ( ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )
            value.M_PreviousShapeLightFalloffSize           = GetSingle(new IntPtr(p + 0x118)); // 0x118 M_PreviousShapeLightFalloffSize ( ModelPrimitiveType float float float Single )
            value.M_PreviousShapeLightParametricSides       = GetInt32(new IntPtr(p + 0x11C)); // 0x11C M_PreviousShapeLightParametricSides ( ModelPrimitiveType int int int Int32 )
            value.M_PreviousShapeLightParametricAngleOffset = GetSingle(new IntPtr(p + 0x120)); // 0x120 M_PreviousShapeLightParametricAngleOffset ( ModelPrimitiveType float float float Single )
            value.M_PreviousShapeLightParametricRadius      = GetSingle(new IntPtr(p + 0x124)); // 0x124 M_PreviousShapeLightParametricRadius ( ModelPrimitiveType float float float Single )
            value.M_PreviousShapePathHash                   = GetInt32(new IntPtr(p + 0x128)); // 0x128 M_PreviousShapePathHash     ( ModelPrimitiveType int int int Int32 )
            value.M_PreviousLightType                       = (LightType)GetInt32(new IntPtr(p + 0x12C)); // 0x12C M_PreviousLightType         ( ModelEnumType LightType LightType LightType Int32 )

            return value;
        }
    }
}
