using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Pos                                      0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 018 LeftDown                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 019 RightDown                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 01A MiddleDown                               000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ShaderDebugPrintInput : DataModel
    {
        public Vector2                                  Pos                                     { get; set; }
        public bool                                     LeftDown                                { get; set; }
        public bool                                     RightDown                               { get; set; }
        public bool                                     MiddleDown                              { get; set; }

        public static ShaderDebugPrintInput? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ShaderDebugPrintInput() { Pointer= p0 };

            value.Pos                                       = (Vector2)GetInt32(new IntPtr(p + 0x010)); // 0246692048B0 0x10 Pos                         ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.LeftDown                                  = GetBool(new IntPtr(p + 0x018)); // 0246692048D0 0x18 LeftDown                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.RightDown                                 = GetBool(new IntPtr(p + 0x019)); // 0246692048F0 0x19 RightDown                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.MiddleDown                                = GetBool(new IntPtr(p + 0x01A)); // 024669204910 0x1A MiddleDown                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
