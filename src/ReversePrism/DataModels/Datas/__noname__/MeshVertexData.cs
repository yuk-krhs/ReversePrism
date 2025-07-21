using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Uv                                       ModelEnumType Vector2 Vector2 Vector2 Int32
    // 018 Vertex                                   ModelEnumType Vector3 Vector3 Vector3 Int32
    public partial class MeshVertexData : DataModel
    {
        public Vector2                                  Uv                                      { get; set; }
        public Vector3                                  Vertex                                  { get; set; }

        public static MeshVertexData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MeshVertexData() { Pointer= p0 };

            value.Uv                                        = (Vector2)GetInt32(new IntPtr(p + 0x010)); // 0x10 Uv                          ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Vertex                                    = (Vector3)GetInt32(new IntPtr(p + 0x018)); // 0x18 Vertex                      ( ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
