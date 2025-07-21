using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Position                                 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 01C Uv                                       ModelEnumType Vector2 Vector2 Vector2 Int32
    // 024 Uv2                                      ModelEnumType Vector2 Vector2 Vector2 Int32
    // 02C Uv4                                      ModelEnumType Vector2 Vector2 Vector2 Int32
    // 034 Color                                    ModelEnumType Color32 Color32 Color32 Int32
    // 000 k_Zero                                   TMP_Vertex IL2CPP_TYPE_VALUETYPE
    public partial class TMP_Vertex : DataModel
    {
        public Vector3                                  Position                                { get; set; }
        public Vector2                                  Uv                                      { get; set; }
        public Vector2                                  Uv2                                     { get; set; }
        public Vector2                                  Uv4                                     { get; set; }
        public Color32                                  Color                                   { get; set; }

        public static TMP_Vertex? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TMP_Vertex() { Pointer= p0 };

            value.Position                                  = (Vector3)GetInt32(new IntPtr(p + 0x010)); // 0x10 Position                    ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.Uv                                        = (Vector2)GetInt32(new IntPtr(p + 0x01C)); // 0x1C Uv                          ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Uv2                                       = (Vector2)GetInt32(new IntPtr(p + 0x024)); // 0x24 Uv2                         ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Uv4                                       = (Vector2)GetInt32(new IntPtr(p + 0x02C)); // 0x2C Uv4                         ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Color                                     = (Color32)GetInt32(new IntPtr(p + 0x034)); // 0x34 Color                       ( ModelEnumType Color32 Color32 Color32 Int32 )

            return value;
        }
    }
}
