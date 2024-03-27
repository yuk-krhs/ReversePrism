using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 m_CurrentFactory                         IFactoryControls IL2CPP_TYPE_CLASS
    // 000 kWidth                                   float IL2CPP_TYPE_R4
    // 000 kThickHeight                             float IL2CPP_TYPE_R4
    // 000 kThinHeight                              float IL2CPP_TYPE_R4
    // 008 s_ThickElementSize                       Vector2 IL2CPP_TYPE_VALUETYPE
    // 010 S_ThinElementSize                        0001866A8990 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 018 S_ImageElementSize                       0001866A8990 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 020 S_DefaultSelectableColor                 0001865AB2F0 ModelEnumType Color Color Color Int32
    // 030 S_PanelColor                             0001865AB2F0 ModelEnumType Color Color Color Int32
    // 040 S_TextColor                              0001865AB2F0 ModelEnumType Color Color Color Int32
    public partial class DefaultControls
    {
        public Vector2                                  S_ThinElementSize                       { get; set; }
        public Vector2                                  S_ImageElementSize                      { get; set; }
        public Color                                    S_DefaultSelectableColor                { get; set; }
        public Color                                    S_PanelColor                            { get; set; }
        public Color                                    S_TextColor                             { get; set; }

        public static DefaultControls? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DefaultControls();

            value.S_ThinElementSize                         = (Vector2)GetInt32(new IntPtr(p + 0x010)); // 0270068D9BA8 0x10 S_ThinElementSize           ( 0001866A8990 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.S_ImageElementSize                        = (Vector2)GetInt32(new IntPtr(p + 0x018)); // 0270068D9BC8 0x18 S_ImageElementSize          ( 0001866A8990 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.S_DefaultSelectableColor                  = (Color)GetInt32(new IntPtr(p + 0x020)); // 0270068D9BE8 0x20 S_DefaultSelectableColor    ( 0001865AB2F0 ModelEnumType Color Color Color Int32 )
            value.S_PanelColor                              = (Color)GetInt32(new IntPtr(p + 0x030)); // 0270068D9C08 0x30 S_PanelColor                ( 0001865AB2F0 ModelEnumType Color Color Color Int32 )
            value.S_TextColor                               = (Color)GetInt32(new IntPtr(p + 0x040)); // 0270068D9C28 0x40 S_TextColor                 ( 0001865AB2F0 ModelEnumType Color Color Color Int32 )

            return value;
        }
    }
}
