using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_DefaultColor                           Color32 IL2CPP_TYPE_VALUETYPE
    // 004 k_DefaultNormal                          Vector3 IL2CPP_TYPE_VALUETYPE
    // 010 K_DefaultTangent                         ModelEnumType Vector4 Vector4 Vector4 Int32
    // 010 VertexCount                              ModelPrimitiveType int int int Int32
    // 018 Vertices                                 ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    // 020 Normals                                  ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    // 028 Tangents                                 ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer
    // 030 Uvs0                                     ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer
    // 038 Uvs2                                     ModelEnumListType Vector2[] Vector2[] List<Vector2> Pointer
    // 040 Colors32                                 ModelEnumListType Color32[] Color32[] List<Color32> Pointer
    // 048 Triangles                                ModelPrimitiveListType int[] int[] List<int> Pointer
    // 050 Material                                 ModelClassType Material Material Material Pointer
    // 058 GlyphRenderMode                          ModelEnumType GlyphRenderMode GlyphRenderMode GlyphRenderMode Int32
    public partial class MeshInfo : DataModel
    {
        public Vector4                                  K_DefaultTangent                        { get; set; }
        public int                                      VertexCount                             { get; set; }
        public List<Vector3>?                           Vertices                                { get; set; }
        public List<Vector3>?                           Normals                                 { get; set; }
        public List<Vector4>?                           Tangents                                { get; set; }
        public List<Vector4>?                           Uvs0                                    { get; set; }
        public List<Vector2>?                           Uvs2                                    { get; set; }
        public List<Color32>?                           Colors32                                { get; set; }
        public List<int>?                               Triangles                               { get; set; }
        public Material?                                Material                                { get; set; }
        public GlyphRenderMode                          GlyphRenderMode                         { get; set; }

        public static MeshInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MeshInfo() { Pointer= p0 };

            value.K_DefaultTangent                          = (Vector4)GetInt32(new IntPtr(p + 0x010)); // 0x10 K_DefaultTangent            ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.VertexCount                               = GetInt32(new IntPtr(p + 0x010)); // 0x10 VertexCount                 ( ModelPrimitiveType int int int Int32 )
            value.Vertices                                  = GetEnumList<Vector3>(new IntPtr(p + 0x018)); // 0x18 Vertices                    ( ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )
            value.Normals                                   = GetEnumList<Vector3>(new IntPtr(p + 0x020)); // 0x20 Normals                     ( ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )
            value.Tangents                                  = GetEnumList<Vector4>(new IntPtr(p + 0x028)); // 0x28 Tangents                    ( ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer )
            value.Uvs0                                      = GetEnumList<Vector4>(new IntPtr(p + 0x030)); // 0x30 Uvs0                        ( ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer )
            value.Uvs2                                      = GetEnumList<Vector2>(new IntPtr(p + 0x038)); // 0x38 Uvs2                        ( ModelEnumListType Vector2[] Vector2[] List<Vector2> Pointer )
            value.Colors32                                  = GetEnumList<Color32>(new IntPtr(p + 0x040)); // 0x40 Colors32                    ( ModelEnumListType Color32[] Color32[] List<Color32> Pointer )
            value.Triangles                                 = GetInt32List(new IntPtr(p + 0x048)); // 0x48 Triangles                   ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.Material                                  = GetObject<Material>(new IntPtr(p + 0x050), ReversePrism.DataModels.Material.FromPointer); // 0x50 Material                    ( ModelClassType Material Material Material Pointer )
            value.GlyphRenderMode                           = (GlyphRenderMode)GetInt32(new IntPtr(p + 0x058)); // 0x58 GlyphRenderMode             ( ModelEnumType GlyphRenderMode GlyphRenderMode GlyphRenderMode Int32 )

            return value;
        }
    }
}
