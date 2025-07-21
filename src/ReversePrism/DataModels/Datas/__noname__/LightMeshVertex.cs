using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Position                                 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 01C Color                                    ModelEnumType Color Color Color Int32
    // 02C Uv                                       ModelEnumType Vector2 Vector2 Vector2 Int32
    // 000 VertexLayout                             VertexAttributeDescriptor[] IL2CPP_TYPE_SZARRAY
    public partial class LightMeshVertex : DataModel
    {
        public Vector3                                  Position                                { get; set; }
        public Color                                    Color                                   { get; set; }
        public Vector2                                  Uv                                      { get; set; }

        public static LightMeshVertex? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LightMeshVertex() { Pointer= p0 };

            value.Position                                  = (Vector3)GetInt32(new IntPtr(p + 0x010)); // 0x10 Position                    ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Color                                     = (Color)GetInt32(new IntPtr(p + 0x01C)); // 0x1C Color                       ( ModelEnumType Color Color Color Int32 )
            value.Uv                                        = (Vector2)GetInt32(new IntPtr(p + 0x02C)); // 0x2C Uv                          ( ModelEnumType Vector2 Vector2 Vector2 Int32 )

            return value;
        }
    }
}
