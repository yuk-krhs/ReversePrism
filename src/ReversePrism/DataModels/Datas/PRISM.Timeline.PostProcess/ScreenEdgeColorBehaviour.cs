using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Enable                                   ModelPrimitiveType bool bool bool Bool
    // 014 LeftTopColor                             ModelEnumType Color Color Color Int32
    // 024 RightTopColor                            ModelEnumType Color Color Color Int32
    // 034 LeftBottomColor                          ModelEnumType Color Color Color Int32
    // 044 RightBottomColor                         ModelEnumType Color Color Color Int32
    // 054 BlendType                                ModelEnumType ScreenEdgeColorBlendType ScreenEdgeColorBlendType ScreenEdgeColorBlendType Int32
    public partial class ScreenEdgeColorBehaviour : DataModel
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
            var value   = new ScreenEdgeColorBehaviour() { Pointer= p0 };

            value.Enable                                    = GetBool(new IntPtr(p + 0x010)); // 0x10 Enable                      ( ModelPrimitiveType bool bool bool Bool )
            value.LeftTopColor                              = (Color)GetInt32(new IntPtr(p + 0x014)); // 0x14 LeftTopColor                ( ModelEnumType Color Color Color Int32 )
            value.RightTopColor                             = (Color)GetInt32(new IntPtr(p + 0x024)); // 0x24 RightTopColor               ( ModelEnumType Color Color Color Int32 )
            value.LeftBottomColor                           = (Color)GetInt32(new IntPtr(p + 0x034)); // 0x34 LeftBottomColor             ( ModelEnumType Color Color Color Int32 )
            value.RightBottomColor                          = (Color)GetInt32(new IntPtr(p + 0x044)); // 0x44 RightBottomColor            ( ModelEnumType Color Color Color Int32 )
            value.BlendType                                 = (ScreenEdgeColorBlendType)GetInt32(new IntPtr(p + 0x054)); // 0x54 BlendType                   ( ModelEnumType ScreenEdgeColorBlendType ScreenEdgeColorBlendType ScreenEdgeColorBlendType Int32 )

            return value;
        }
    }
}
