using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Offset                                   ModelEnumType Vector2 Vector2 Vector2 Int32
    // 018 BlurRadius                               ModelPrimitiveType float float float Single
    // 01C Color                                    ModelEnumType Color Color Color Int32
    public partial class TextShadow : DataModel
    {
        public Vector2                                  Offset                                  { get; set; }
        public float                                    BlurRadius                              { get; set; }
        public Color                                    Color                                   { get; set; }

        public static TextShadow? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextShadow() { Pointer= p0 };

            value.Offset                                    = (Vector2)GetInt32(new IntPtr(p + 0x010)); // 0x10 Offset                      ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.BlurRadius                                = GetSingle(new IntPtr(p + 0x018)); // 0x18 BlurRadius                  ( ModelPrimitiveType float float float Single )
            value.Color                                     = (Color)GetInt32(new IntPtr(p + 0x01C)); // 0x1C Color                       ( ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
