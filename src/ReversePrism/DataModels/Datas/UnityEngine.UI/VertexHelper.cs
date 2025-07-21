using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Positions                              ModelEnumListType List`1<Vector3> List`1<Vector3> List<Vector3> Pointer
    // 018 M_Colors                                 ModelEnumListType List`1<Color32> List`1<Color32> List<Color32> Pointer
    // 020 M_Uv0S                                   ModelEnumListType List`1<Vector4> List`1<Vector4> List<Vector4> Pointer
    // 028 M_Uv1S                                   ModelEnumListType List`1<Vector4> List`1<Vector4> List<Vector4> Pointer
    // 030 M_Uv2S                                   ModelEnumListType List`1<Vector4> List`1<Vector4> List<Vector4> Pointer
    // 038 M_Uv3S                                   ModelEnumListType List`1<Vector4> List`1<Vector4> List<Vector4> Pointer
    // 040 M_Normals                                ModelEnumListType List`1<Vector3> List`1<Vector3> List<Vector3> Pointer
    // 048 M_Tangents                               ModelEnumListType List`1<Vector4> List`1<Vector4> List<Vector4> Pointer
    // 050 M_Indices                                ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 000 s_DefaultTangent                         Vector4 IL2CPP_TYPE_VALUETYPE
    // 010 S_DefaultNormal                          ModelEnumType Vector3 Vector3 Vector3 Int32
    // 058 M_ListsInitalized                        ModelPrimitiveType bool bool bool Bool
    public partial class VertexHelper : DataModel
    {
        public List<Vector3>?                           M_Positions                             { get; set; }
        public List<Color32>?                           M_Colors                                { get; set; }
        public List<Vector4>?                           M_Uv0S                                  { get; set; }
        public List<Vector4>?                           M_Uv1S                                  { get; set; }
        public List<Vector4>?                           M_Uv2S                                  { get; set; }
        public List<Vector4>?                           M_Uv3S                                  { get; set; }
        public List<Vector3>?                           M_Normals                               { get; set; }
        public List<Vector4>?                           M_Tangents                              { get; set; }
        public List<int>?                               M_Indices                               { get; set; }
        public Vector3                                  S_DefaultNormal                         { get; set; }
        public bool                                     M_ListsInitalized                       { get; set; }

        public static VertexHelper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VertexHelper() { Pointer= p0 };

            value.M_Positions                               = GetEnumList<Vector3>(new IntPtr(p + 0x010)); // 0x10 M_Positions                 ( ModelEnumListType List`1<Vector3> List`1<Vector3> List<Vector3> Pointer )
            value.M_Colors                                  = GetEnumList<Color32>(new IntPtr(p + 0x018)); // 0x18 M_Colors                    ( ModelEnumListType List`1<Color32> List`1<Color32> List<Color32> Pointer )
            value.M_Uv0S                                    = GetEnumList<Vector4>(new IntPtr(p + 0x020)); // 0x20 M_Uv0S                      ( ModelEnumListType List`1<Vector4> List`1<Vector4> List<Vector4> Pointer )
            value.M_Uv1S                                    = GetEnumList<Vector4>(new IntPtr(p + 0x028)); // 0x28 M_Uv1S                      ( ModelEnumListType List`1<Vector4> List`1<Vector4> List<Vector4> Pointer )
            value.M_Uv2S                                    = GetEnumList<Vector4>(new IntPtr(p + 0x030)); // 0x30 M_Uv2S                      ( ModelEnumListType List`1<Vector4> List`1<Vector4> List<Vector4> Pointer )
            value.M_Uv3S                                    = GetEnumList<Vector4>(new IntPtr(p + 0x038)); // 0x38 M_Uv3S                      ( ModelEnumListType List`1<Vector4> List`1<Vector4> List<Vector4> Pointer )
            value.M_Normals                                 = GetEnumList<Vector3>(new IntPtr(p + 0x040)); // 0x40 M_Normals                   ( ModelEnumListType List`1<Vector3> List`1<Vector3> List<Vector3> Pointer )
            value.M_Tangents                                = GetEnumList<Vector4>(new IntPtr(p + 0x048)); // 0x48 M_Tangents                  ( ModelEnumListType List`1<Vector4> List`1<Vector4> List<Vector4> Pointer )
            value.M_Indices                                 = GetInt32List(new IntPtr(p + 0x050)); // 0x50 M_Indices                   ( ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.S_DefaultNormal                           = (Vector3)GetInt32(new IntPtr(p + 0x010)); // 0x10 S_DefaultNormal             ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_ListsInitalized                         = GetBool(new IntPtr(p + 0x058)); // 0x58 M_ListsInitalized           ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
