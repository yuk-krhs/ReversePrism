using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Enable                                   000186595960 ModelPrimitiveType bool bool bool Bool
    // 014 LeftTopColor                             0001865AB0A0 ModelEnumType Color Color Color Int32
    // 024 RightTopColor                            0001865AB0A0 ModelEnumType Color Color Color Int32
    // 034 LeftBottomColor                          0001865AB0A0 ModelEnumType Color Color Color Int32
    // 044 RightBottomColor                         0001865AB0A0 ModelEnumType Color Color Color Int32
    // 054 BlendType                                0001866F13B0 ModelEnumType ScreenEdgeColorBlendType ScreenEdgeColorBlendType ScreenEdgeColorBlendType Int32
    public partial class ScreenEdgeColorBehaviour
    {
        public bool                                     Enable                                  { get; set; }
        public Color                                    LeftTopColor                            { get; set; }
        public Color                                    RightTopColor                           { get; set; }
        public Color                                    LeftBottomColor                         { get; set; }
        public Color                                    RightBottomColor                        { get; set; }
        public ScreenEdgeColorBlendType                 BlendType                               { get; set; }

        public static ScreenEdgeColorBehaviour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScreenEdgeColorBehaviour();

            value.Enable                                    = GetBool(new IntPtr(p + 0x010)); // 0270D5075D38 0x10 Enable                      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.LeftTopColor                              = (Color)GetInt32(new IntPtr(p + 0x014)); // 0270D5075D58 0x14 LeftTopColor                ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.RightTopColor                             = (Color)GetInt32(new IntPtr(p + 0x024)); // 0270D5075D78 0x24 RightTopColor               ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.LeftBottomColor                           = (Color)GetInt32(new IntPtr(p + 0x034)); // 0270D5075D98 0x34 LeftBottomColor             ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.RightBottomColor                          = (Color)GetInt32(new IntPtr(p + 0x044)); // 0270D5075DB8 0x44 RightBottomColor            ( 0001865AB0A0 ModelEnumType Color Color Color Int32 )
            value.BlendType                                 = (ScreenEdgeColorBlendType)GetInt32(new IntPtr(p + 0x054)); // 0270D5075DD8 0x54 BlendType                   ( 0001866F13B0 ModelEnumType ScreenEdgeColorBlendType ScreenEdgeColorBlendType ScreenEdgeColorBlendType Int32 )

            return value;
        }
    }
}
