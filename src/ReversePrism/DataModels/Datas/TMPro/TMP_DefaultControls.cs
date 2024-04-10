using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kWidth                                   float IL2CPP_TYPE_R4
    // 000 kThickHeight                             float IL2CPP_TYPE_R4
    // 000 kThinHeight                              float IL2CPP_TYPE_R4
    // 000 s_TextElementSize                        Vector2 IL2CPP_TYPE_VALUETYPE
    // 008 s_ThickElementSize                       Vector2 IL2CPP_TYPE_VALUETYPE
    // 010 S_ThinElementSize                        0001866A8990 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 018 S_DefaultSelectableColor                 0001865AB2F0 ModelEnumType Color Color Color Int32
    // 028 S_TextColor                              0001865AB2F0 ModelEnumType Color Color Color Int32
    public partial class TMP_DefaultControls : DataModel
    {
        public Vector2                                  S_ThinElementSize                       { get; set; }
        public Color                                    S_DefaultSelectableColor                { get; set; }
        public Color                                    S_TextColor                             { get; set; }

        public static TMP_DefaultControls? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TMP_DefaultControls() { Pointer= p0 };

            value.S_ThinElementSize                         = (Vector2)GetInt32(new IntPtr(p + 0x010)); // 02466A676278 0x10 S_ThinElementSize           ( 0001866A8990 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.S_DefaultSelectableColor                  = (Color)GetInt32(new IntPtr(p + 0x018)); // 02466A676298 0x18 S_DefaultSelectableColor    ( 0001865AB2F0 ModelEnumType Color Color Color Int32 )
            value.S_TextColor                               = (Color)GetInt32(new IntPtr(p + 0x028)); // 02466A6762B8 0x28 S_TextColor                 ( 0001865AB2F0 ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
