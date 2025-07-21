using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Position                                 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 018 Color                                    ModelEnumType Color32 Color32 Color32 Int32
    // 01C Uv                                       ModelEnumType Vector2 Vector2 Vector2 Int32
    public partial class VertexParameter : DataModel
    {
        public Vector2                                  Position                                { get; set; }
        public Color32                                  Color                                   { get; set; }
        public Vector2                                  Uv                                      { get; set; }

        public static VertexParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VertexParameter() { Pointer= p0 };

            value.Position                                  = (Vector2)GetInt32(new IntPtr(p + 0x010)); // 0x10 Position                    ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Color                                     = (Color32)GetInt32(new IntPtr(p + 0x018)); // 0x18 Color                       ( ModelEnumType Color32 Color32 Color32 Int32 )
            value.Uv                                        = (Vector2)GetInt32(new IntPtr(p + 0x01C)); // 0x1C Uv                          ( ModelEnumType Vector2 Vector2 Vector2 Int32 )

            return value;
        }
    }
}
