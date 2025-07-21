using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_DoubleClickSelectsWord                 ModelPrimitiveType bool bool bool Bool
    // 011 M_TripleClickSelectsLine                 ModelPrimitiveType bool bool bool Bool
    // 014 M_CursorColor                            ModelEnumType Color Color Color Int32
    // 024 M_CursorFlashSpeed                       ModelPrimitiveType float float float Single
    // 028 M_SelectionColor                         ModelEnumType Color Color Color Int32
    public partial class GUISettings : DataModel
    {
        public bool                                     M_DoubleClickSelectsWord                { get; set; }
        public bool                                     M_TripleClickSelectsLine                { get; set; }
        public Color                                    M_CursorColor                           { get; set; }
        public float                                    M_CursorFlashSpeed                      { get; set; }
        public Color                                    M_SelectionColor                        { get; set; }

        public static GUISettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GUISettings() { Pointer= p0 };

            value.M_DoubleClickSelectsWord                  = GetBool(new IntPtr(p + 0x010)); // 0x10 M_DoubleClickSelectsWord    ( ModelPrimitiveType bool bool bool Bool )
            value.M_TripleClickSelectsLine                  = GetBool(new IntPtr(p + 0x011)); // 0x11 M_TripleClickSelectsLine    ( ModelPrimitiveType bool bool bool Bool )
            value.M_CursorColor                             = (Color)GetInt32(new IntPtr(p + 0x014)); // 0x14 M_CursorColor               ( ModelEnumType Color Color Color Int32 )
            value.M_CursorFlashSpeed                        = GetSingle(new IntPtr(p + 0x024)); // 0x24 M_CursorFlashSpeed          ( ModelPrimitiveType float float float Single )
            value.M_SelectionColor                          = (Color)GetInt32(new IntPtr(p + 0x028)); // 0x28 M_SelectionColor            ( ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
