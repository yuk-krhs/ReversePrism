using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_CurrentComponentVersion                ComponentVersions IL2CPP_TYPE_VALUETYPE
    // 030 M_ComponentVersion                       ModelEnumType ComponentVersions ComponentVersions ComponentVersions Int32
    // 034 M_HasRenderer                            ModelPrimitiveType bool bool bool Bool
    // 035 M_UseRendererSilhouette                  ModelPrimitiveType bool bool bool Bool
    // 036 M_CastsShadows                           ModelPrimitiveType bool bool bool Bool
    // 037 M_SelfShadows                            ModelPrimitiveType bool bool bool Bool
    // 038 M_ApplyToSortingLayers                   ModelPrimitiveListType int[] int[] List<int> Pointer
    // 040 M_ShapePath                              ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    // 048 M_ShapePathHash                          ModelPrimitiveType int int int Int32
    // 050 M_Mesh                                   ModelClassType Mesh Mesh Mesh Pointer
    // 058 M_InstanceId                             ModelPrimitiveType int int int Int32
    // 060 M_ShadowCasterGroup                      ModelClassType ShadowCasterGroup2D ShadowCasterGroup2D ShadowCasterGroup2D Pointer
    // 068 M_PreviousShadowCasterGroup              ModelClassType ShadowCasterGroup2D ShadowCasterGroup2D ShadowCasterGroup2D Pointer
    // 070 M_LocalBounds                            ModelEnumType Bounds Bounds Bounds Int32
    // 088 M_BoundingSphere                         ModelEnumType BoundingSphere BoundingSphere BoundingSphere Int32
    // 098 M_PreviousShadowGroup                    ModelPrimitiveType int int int Int32
    // 09C M_PreviousCastsShadows                   ModelPrimitiveType bool bool bool Bool
    // 0A0 M_PreviousPathHash                       ModelPrimitiveType int int int Int32
    // 0A4 M_CachedPosition                         ModelEnumType Vector3 Vector3 Vector3 Int32
    // 0B0 M_CachedLossyScale                       ModelEnumType Vector3 Vector3 Vector3 Int32
    // 0BC M_CachedRotation                         ModelEnumType Quaternion Quaternion Quaternion Int32
    // 0CC M_CachedShadowMatrix                     ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 10C M_CachedInverseShadowMatrix              ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 14C M_CachedLocalToWorldMatrix               ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    public partial class ShadowCaster2D : DataModel
    {
        public ComponentVersions                        M_ComponentVersion                      { get; set; }
        public bool                                     M_HasRenderer                           { get; set; }
        public bool                                     M_UseRendererSilhouette                 { get; set; }
        public bool                                     M_CastsShadows                          { get; set; }
        public bool                                     M_SelfShadows                           { get; set; }
        public List<int>?                               M_ApplyToSortingLayers                  { get; set; }
        public List<Vector3>?                           M_ShapePath                             { get; set; }
        public int                                      M_ShapePathHash                         { get; set; }
        public Mesh?                                    M_Mesh                                  { get; set; }
        public int                                      M_InstanceId                            { get; set; }
        public ShadowCasterGroup2D?                     M_ShadowCasterGroup                     { get; set; }
        public ShadowCasterGroup2D?                     M_PreviousShadowCasterGroup             { get; set; }
        public Bounds                                   M_LocalBounds                           { get; set; }
        public BoundingSphere                           M_BoundingSphere                        { get; set; }
        public int                                      M_PreviousShadowGroup                   { get; set; }
        public bool                                     M_PreviousCastsShadows                  { get; set; }
        public int                                      M_PreviousPathHash                      { get; set; }
        public Vector3                                  M_CachedPosition                        { get; set; }
        public Vector3                                  M_CachedLossyScale                      { get; set; }
        public Quaternion                               M_CachedRotation                        { get; set; }
        public Matrix4x4                                M_CachedShadowMatrix                    { get; set; }
        public Matrix4x4                                M_CachedInverseShadowMatrix             { get; set; }
        public Matrix4x4                                M_CachedLocalToWorldMatrix              { get; set; }

        public static ShadowCaster2D? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShadowCaster2D() { Pointer= p0 };

            value.M_ComponentVersion                        = (ComponentVersions)GetInt32(new IntPtr(p + 0x030)); // 0x30 M_ComponentVersion          ( ModelEnumType ComponentVersions ComponentVersions ComponentVersions Int32 )
            value.M_HasRenderer                             = GetBool(new IntPtr(p + 0x034)); // 0x34 M_HasRenderer               ( ModelPrimitiveType bool bool bool Bool )
            value.M_UseRendererSilhouette                   = GetBool(new IntPtr(p + 0x035)); // 0x35 M_UseRendererSilhouette     ( ModelPrimitiveType bool bool bool Bool )
            value.M_CastsShadows                            = GetBool(new IntPtr(p + 0x036)); // 0x36 M_CastsShadows              ( ModelPrimitiveType bool bool bool Bool )
            value.M_SelfShadows                             = GetBool(new IntPtr(p + 0x037)); // 0x37 M_SelfShadows               ( ModelPrimitiveType bool bool bool Bool )
            value.M_ApplyToSortingLayers                    = GetInt32List(new IntPtr(p + 0x038)); // 0x38 M_ApplyToSortingLayers      ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.M_ShapePath                               = GetEnumList<Vector3>(new IntPtr(p + 0x040)); // 0x40 M_ShapePath                 ( ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )
            value.M_ShapePathHash                           = GetInt32(new IntPtr(p + 0x048)); // 0x48 M_ShapePathHash             ( ModelPrimitiveType int int int Int32 )
            value.M_Mesh                                    = GetObject<Mesh>(new IntPtr(p + 0x050), ReversePrism.DataModels.Mesh.FromPointer); // 0x50 M_Mesh                      ( ModelClassType Mesh Mesh Mesh Pointer )
            value.M_InstanceId                              = GetInt32(new IntPtr(p + 0x058)); // 0x58 M_InstanceId                ( ModelPrimitiveType int int int Int32 )
            value.M_ShadowCasterGroup                       = GetObject<ShadowCasterGroup2D>(new IntPtr(p + 0x060), ReversePrism.DataModels.ShadowCasterGroup2D.FromPointer); // 0x60 M_ShadowCasterGroup         ( ModelClassType ShadowCasterGroup2D ShadowCasterGroup2D ShadowCasterGroup2D Pointer )
            value.M_PreviousShadowCasterGroup               = GetObject<ShadowCasterGroup2D>(new IntPtr(p + 0x068), ReversePrism.DataModels.ShadowCasterGroup2D.FromPointer); // 0x68 M_PreviousShadowCasterGroup ( ModelClassType ShadowCasterGroup2D ShadowCasterGroup2D ShadowCasterGroup2D Pointer )
            value.M_LocalBounds                             = (Bounds)GetInt32(new IntPtr(p + 0x070)); // 0x70 M_LocalBounds               ( ModelEnumType Bounds Bounds Bounds Int32 )
            value.M_BoundingSphere                          = (BoundingSphere)GetInt32(new IntPtr(p + 0x088)); // 0x88 M_BoundingSphere            ( ModelEnumType BoundingSphere BoundingSphere BoundingSphere Int32 )
            value.M_PreviousShadowGroup                     = GetInt32(new IntPtr(p + 0x098)); // 0x98 M_PreviousShadowGroup       ( ModelPrimitiveType int int int Int32 )
            value.M_PreviousCastsShadows                    = GetBool(new IntPtr(p + 0x09C)); // 0x9C M_PreviousCastsShadows      ( ModelPrimitiveType bool bool bool Bool )
            value.M_PreviousPathHash                        = GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 M_PreviousPathHash          ( ModelPrimitiveType int int int Int32 )
            value.M_CachedPosition                          = (Vector3)GetInt32(new IntPtr(p + 0x0A4)); // 0xA4 M_CachedPosition            ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_CachedLossyScale                        = (Vector3)GetInt32(new IntPtr(p + 0x0B0)); // 0xB0 M_CachedLossyScale          ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_CachedRotation                          = (Quaternion)GetInt32(new IntPtr(p + 0x0BC)); // 0xBC M_CachedRotation            ( ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.M_CachedShadowMatrix                      = (Matrix4x4)GetInt32(new IntPtr(p + 0x0CC)); // 0xCC M_CachedShadowMatrix        ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.M_CachedInverseShadowMatrix               = (Matrix4x4)GetInt32(new IntPtr(p + 0x10C)); // 0x10C M_CachedInverseShadowMatrix ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.M_CachedLocalToWorldMatrix                = (Matrix4x4)GetInt32(new IntPtr(p + 0x14C)); // 0x14C M_CachedLocalToWorldMatrix  ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )

            return value;
        }
    }
}
