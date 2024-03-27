using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MeshFilter                               000186601410 ModelClassType MeshFilter MeshFilter MeshFilter Pointer
    // 028 Mesh                                     0001866104D0 ModelClassType Mesh Mesh Mesh Pointer
    // 030 Vertices                                 000185D1AEA8 ModelEnumListType List`1<Vector3> List`1<Vector3> List<Vector3> Pointer
    // 038 Uv                                       000185D1AEA8 ModelEnumListType List`1<Vector3> List`1<Vector3> List<Vector3> Pointer
    // 040 Colors                                   000185CD3408 ModelEnumListType List`1<Color> List`1<Color> List<Color> Pointer
    // 048 Triangles                                000185CED1B8 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    public partial class NoteLine
    {
        public MeshFilter?                              MeshFilter                              { get; set; }
        public Mesh?                                    Mesh                                    { get; set; }
        public List<Vector3>?                           Vertices                                { get; set; }
        public List<Vector3>?                           Uv                                      { get; set; }
        public List<Color>?                             Colors                                  { get; set; }
        public List<int>?                               Triangles                               { get; set; }

        public static NoteLine? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NoteLine();

            value.MeshFilter                                = GetObject<MeshFilter>(new IntPtr(p + 0x020), ReversePrism.DataModels.MeshFilter.FromPointer); // 0270D4FAFA40 0x20 MeshFilter                  ( 000186601410 ModelClassType MeshFilter MeshFilter MeshFilter Pointer )
            value.Mesh                                      = GetObject<Mesh>(new IntPtr(p + 0x028), ReversePrism.DataModels.Mesh.FromPointer); // 0270D4FAFA60 0x28 Mesh                        ( 0001866104D0 ModelClassType Mesh Mesh Mesh Pointer )
            value.Vertices                                  = GetEnumList<Vector3>(new IntPtr(p + 0x030)); // 0270D4FAFA80 0x30 Vertices                    ( 000185D1AEA8 ModelEnumListType List`1<Vector3> List`1<Vector3> List<Vector3> Pointer )
            value.Uv                                        = GetEnumList<Vector3>(new IntPtr(p + 0x038)); // 0270D4FAFAA0 0x38 Uv                          ( 000185D1AEA8 ModelEnumListType List`1<Vector3> List`1<Vector3> List<Vector3> Pointer )
            value.Colors                                    = GetEnumList<Color>(new IntPtr(p + 0x040)); // 0270D4FAFAC0 0x40 Colors                      ( 000185CD3408 ModelEnumListType List`1<Color> List`1<Color> List<Color> Pointer )
            value.Triangles                                 = GetInt32List(new IntPtr(p + 0x048)); // 0270D4FAFAE0 0x48 Triangles                   ( 000185CED1B8 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )

            return value;
        }
    }
}
