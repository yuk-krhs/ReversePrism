using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FaceColor                                0001865AB0A0 ModelEnumType Color Color Color Int32
    // 020 OutlineColor                             0001865AB0A0 ModelEnumType Color Color Color Int32
    // 030 OutlineWidth                             000186666050 ModelPrimitiveType float float float Single
    // 034 UnderlayColor                            0001865AB0A0 ModelEnumType Color Color Color Int32
    // 044 UnderlayOffset                           0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 04C UnderlaySoftness                         000186666050 ModelPrimitiveType float float float Single
    public partial class TextCoreSettings : DataModel
    {
        public Color                                    FaceColor                               { get; set; }
        public Color                                    OutlineColor                            { get; set; }
        public float                                    OutlineWidth                            { get; set; }
        public Color                                    UnderlayColor                           { get; set; }
        public Vector2                                  UnderlayOffset                          { get; set; }
        public float                                    UnderlaySoftness                        { get; set; }

        public static TextCoreSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextCoreSettings() { Pointer= p0 };

            value.FaceColor                                 = (Color)GetInt32(new IntPtr(p + 0x010)); // 0245A682D7D8 0x10 FaceColor                   ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.OutlineColor                              = (Color)GetInt32(new IntPtr(p + 0x020)); // 0245A682D7F8 0x20 OutlineColor                ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.OutlineWidth                              = GetSingle(new IntPtr(p + 0x030)); // 0245A682D818 0x30 OutlineWidth                ( 000186666050 ModelPrimitiveType float float float Single )
            value.UnderlayColor                             = (Color)GetInt32(new IntPtr(p + 0x034)); // 0245A682D838 0x34 UnderlayColor               ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.UnderlayOffset                            = (Vector2)GetInt32(new IntPtr(p + 0x044)); // 0245A682D858 0x44 UnderlayOffset              ( 0001866A8740 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.UnderlaySoftness                          = GetSingle(new IntPtr(p + 0x04C)); // 0245A682D878 0x4C UnderlaySoftness            ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
