using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_DefaultColor                           Color32 IL2CPP_TYPE_VALUETYPE
    // 004 s_DefaultNormal                          Vector3 IL2CPP_TYPE_VALUETYPE
    // 010 S_DefaultTangent                         ModelEnumType Vector4 Vector4 Vector4 Int32
    // 020 S_DefaultBounds                          ModelEnumType Bounds Bounds Bounds Int32
    // 010 Mesh                                     ModelClassType Mesh Mesh Mesh Pointer
    // 018 VertexCount                              ModelPrimitiveType int int int Int32
    // 020 Vertices                                 ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    // 028 Normals                                  ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer
    // 030 Tangents                                 ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer
    // 038 Uvs0                                     ModelEnumListType Vector2[] Vector2[] List<Vector2> Pointer
    // 040 Uvs2                                     ModelEnumListType Vector2[] Vector2[] List<Vector2> Pointer
    // 048 Colors32                                 ModelEnumListType Color32[] Color32[] List<Color32> Pointer
    // 050 Triangles                                ModelPrimitiveListType int[] int[] List<int> Pointer
    // 058 Material                                 ModelClassType Material Material Material Pointer
    public partial class TMP_MeshInfo : DataModel
    {
        public Vector4                                  S_DefaultTangent                        { get; set; }
        public Bounds                                   S_DefaultBounds                         { get; set; }
        public Mesh?                                    Mesh                                    { get; set; }
        public int                                      VertexCount                             { get; set; }
        public List<Vector3>?                           Vertices                                { get; set; }
        public List<Vector3>?                           Normals                                 { get; set; }
        public List<Vector4>?                           Tangents                                { get; set; }
        public List<Vector2>?                           Uvs0                                    { get; set; }
        public List<Vector2>?                           Uvs2                                    { get; set; }
        public List<Color32>?                           Colors32                                { get; set; }
        public List<int>?                               Triangles                               { get; set; }
        public Material?                                Material                                { get; set; }

        public static TMP_MeshInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TMP_MeshInfo() { Pointer= p0 };

            value.S_DefaultTangent                          = (Vector4)GetInt32(new IntPtr(p + 0x010)); // 0x10 S_DefaultTangent            ( ModelEnumType Vector4 Vector4 Vector4 Int32 )
            value.S_DefaultBounds                           = (Bounds)GetInt32(new IntPtr(p + 0x020)); // 0x20 S_DefaultBounds             ( ModelEnumType Bounds Bounds Bounds Int32 )
            value.Mesh                                      = GetObject<Mesh>(new IntPtr(p + 0x010), ReversePrism.DataModels.Mesh.FromPointer); // 0x10 Mesh                        ( ModelClassType Mesh Mesh Mesh Pointer )
            value.VertexCount                               = GetInt32(new IntPtr(p + 0x018)); // 0x18 VertexCount                 ( ModelPrimitiveType int int int Int32 )
            value.Vertices                                  = GetEnumList<Vector3>(new IntPtr(p + 0x020)); // 0x20 Vertices                    ( ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )
            value.Normals                                   = GetEnumList<Vector3>(new IntPtr(p + 0x028)); // 0x28 Normals                     ( ModelEnumListType Vector3[] Vector3[] List<Vector3> Pointer )
            value.Tangents                                  = GetEnumList<Vector4>(new IntPtr(p + 0x030)); // 0x30 Tangents                    ( ModelEnumListType Vector4[] Vector4[] List<Vector4> Pointer )
            value.Uvs0                                      = GetEnumList<Vector2>(new IntPtr(p + 0x038)); // 0x38 Uvs0                        ( ModelEnumListType Vector2[] Vector2[] List<Vector2> Pointer )
            value.Uvs2                                      = GetEnumList<Vector2>(new IntPtr(p + 0x040)); // 0x40 Uvs2                        ( ModelEnumListType Vector2[] Vector2[] List<Vector2> Pointer )
            value.Colors32                                  = GetEnumList<Color32>(new IntPtr(p + 0x048)); // 0x48 Colors32                    ( ModelEnumListType Color32[] Color32[] List<Color32> Pointer )
            value.Triangles                                 = GetInt32List(new IntPtr(p + 0x050)); // 0x50 Triangles                   ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.Material                                  = GetObject<Material>(new IntPtr(p + 0x058), ReversePrism.DataModels.Material.FromPointer); // 0x58 Material                    ( ModelClassType Material Material Material Pointer )

            return value;
        }
    }
}
