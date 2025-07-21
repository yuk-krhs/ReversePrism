using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FaceColor                                ModelEnumType Color Color Color Int32
    // 020 OutlineColor                             ModelEnumType Color Color Color Int32
    // 030 OutlineWidth                             ModelPrimitiveType float float float Single
    // 034 UnderlayColor                            ModelEnumType Color Color Color Int32
    // 044 UnderlayOffset                           ModelEnumType Vector2 Vector2 Vector2 Int32
    // 04C UnderlaySoftness                         ModelPrimitiveType float float float Single
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

            value.FaceColor                                 = (Color)GetInt32(new IntPtr(p + 0x010)); // 0x10 FaceColor                   ( ModelEnumType Color Color Color Int32 )
            value.OutlineColor                              = (Color)GetInt32(new IntPtr(p + 0x020)); // 0x20 OutlineColor                ( ModelEnumType Color Color Color Int32 )
            value.OutlineWidth                              = GetSingle(new IntPtr(p + 0x030)); // 0x30 OutlineWidth                ( ModelPrimitiveType float float float Single )
            value.UnderlayColor                             = (Color)GetInt32(new IntPtr(p + 0x034)); // 0x34 UnderlayColor               ( ModelEnumType Color Color Color Int32 )
            value.UnderlayOffset                            = (Vector2)GetInt32(new IntPtr(p + 0x044)); // 0x44 UnderlayOffset              ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.UnderlaySoftness                          = GetSingle(new IntPtr(p + 0x04C)); // 0x4C UnderlaySoftness            ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
