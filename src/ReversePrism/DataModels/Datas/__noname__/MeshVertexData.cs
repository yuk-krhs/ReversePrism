using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Uv                                       0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 018 Vertex                                   0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32
    public partial class MeshVertexData
    {
        public Vector2                                  Uv                                      { get; set; }
        public Vector3                                  Vertex                                  { get; set; }

        public static MeshVertexData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MeshVertexData();

            value.Uv                                        = (Vector2)GetInt32(new IntPtr(p + 0x010)); // 0270035B92D0 0x10 Uv                          ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Vertex                                    = (Vector3)GetInt32(new IntPtr(p + 0x018)); // 0270035B92F0 0x18 Vertex                      ( 0001866ABF40 ModelEnumType Vector3 Vector3 Vector3 Int32 )

            return value;
        }
    }
}
