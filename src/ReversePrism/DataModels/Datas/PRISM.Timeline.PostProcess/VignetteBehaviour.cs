using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Enable                                   ModelPrimitiveType bool bool bool Bool
    // 014 Color                                    ModelEnumType Color Color Color Int32
    // 024 Center                                   ModelEnumType Vector2 Vector2 Vector2 Int32
    // 02C Intensity                                ModelPrimitiveType float float float Single
    // 030 Smoothness                               ModelPrimitiveType float float float Single
    // 034 Roundness                                ModelPrimitiveType float float float Single
    // 038 Rounded                                  ModelPrimitiveType bool bool bool Bool
    public partial class VignetteBehaviour : DataModel
    {
        public bool                                     Enable                                  { get; set; }
        public Color                                    Color                                   { get; set; }
        public Vector2                                  Center                                  { get; set; }
        public float                                    Intensity                               { get; set; }
        public float                                    Smoothness                              { get; set; }
        public float                                    Roundness                               { get; set; }
        public bool                                     Rounded                                 { get; set; }

        public static VignetteBehaviour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VignetteBehaviour() { Pointer= p0 };

            value.Enable                                    = GetBool(new IntPtr(p + 0x010)); // 0x10 Enable                      ( ModelPrimitiveType bool bool bool Bool )
            value.Color                                     = (Color)GetInt32(new IntPtr(p + 0x014)); // 0x14 Color                       ( ModelEnumType Color Color Color Int32 )
            value.Center                                    = (Vector2)GetInt32(new IntPtr(p + 0x024)); // 0x24 Center                      ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.Intensity                                 = GetSingle(new IntPtr(p + 0x02C)); // 0x2C Intensity                   ( ModelPrimitiveType float float float Single )
            value.Smoothness                                = GetSingle(new IntPtr(p + 0x030)); // 0x30 Smoothness                  ( ModelPrimitiveType float float float Single )
            value.Roundness                                 = GetSingle(new IntPtr(p + 0x034)); // 0x34 Roundness                   ( ModelPrimitiveType float float float Single )
            value.Rounded                                   = GetBool(new IntPtr(p + 0x038)); // 0x38 Rounded                     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
