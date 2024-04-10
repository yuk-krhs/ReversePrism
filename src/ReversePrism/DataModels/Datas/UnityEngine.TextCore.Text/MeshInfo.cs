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
    // 010 K_DefaultTangent                         0001866AF510 ModelEnumType Vector4 Vector4 Vector4 Int32
    // 010 VertexCount                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 Vertices                                 000185CB0ED8 ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    // 020 Normals                                  000185CB0ED8 ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    // 028 Tangents                                 000185CB1558 ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer
    // 030 Uvs0                                     000185CB1558 ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer
    // 038 Uvs2                                     000185CB0738 ModelEnumListType Vector2[] Vector2[] List<Vector2> Pointer
    // 040 Colors32                                 000185B75EB0 ModelEnumListType Color32[] Color32[] List<Color32> Pointer
    // 048 Triangles                                000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 050 Material                                 00018660C4B0 ModelClassType Material Material Material Pointer
    // 058 GlyphRenderMode                          000186682B30 ModelEnumType GlyphRenderMode GlyphRenderMode GlyphRenderMode Int32
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

            value.K_DefaultTangent                          = (Vector4)GetInt32(new IntPtr(p + 0x010)); // 0245A68AD028 0x10 K_DefaultTangent            ( 0001866AF510 ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.VertexCount                               = GetInt32(new IntPtr(p + 0x010)); // 0245A68AD048 0x10 VertexCount                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Vertices                                  = GetEnumList<Vector3>(new IntPtr(p + 0x018)); // 0245A68AD068 0x18 Vertices                    ( 000185CB0ED8 ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )
            value.Normals                                   = GetEnumList<Vector3>(new IntPtr(p + 0x020)); // 0245A68AD088 0x20 Normals                     ( 000185CB0ED8 ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )
            value.Tangents                                  = GetEnumList<Vector4>(new IntPtr(p + 0x028)); // 0245A68AD0A8 0x28 Tangents                    ( 000185CB1558 ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer )
            value.Uvs0                                      = GetEnumList<Vector4>(new IntPtr(p + 0x030)); // 0245A68AD0C8 0x30 Uvs0                        ( 000185CB1558 ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer )
            value.Uvs2                                      = GetEnumList<Vector2>(new IntPtr(p + 0x038)); // 0245A68AD0E8 0x38 Uvs2                        ( 000185CB0738 ModelEnumListType Vector2[] Vector2[] List<Vector2> Pointer )
            value.Colors32                                  = GetEnumList<Color32>(new IntPtr(p + 0x040)); // 0245A68AD108 0x40 Colors32                    ( 000185B75EB0 ModelEnumListType Color32[] Color32[] List<Color32> Pointer )
            value.Triangles                                 = GetInt32List(new IntPtr(p + 0x048)); // 0245A68AD128 0x48 Triangles                   ( 000185B7D5E0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.Material                                  = GetObject<Material>(new IntPtr(p + 0x050), ReversePrism.DataModels.Material.FromPointer); // 0245A68AD148 0x50 Material                    ( 00018660C4B0 ModelClassType Material Material Material Pointer )
            value.GlyphRenderMode                           = (GlyphRenderMode)GetInt32(new IntPtr(p + 0x058)); // 0245A68AD168 0x58 GlyphRenderMode             ( 000186682B30 ModelEnumType GlyphRenderMode GlyphRenderMode GlyphRenderMode Int32 )

            return value;
        }
    }
}
