using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kDefaultNormalAnimName                   string IL2CPP_TYPE_STRING
    // 000 kDefaultHighlightedAnimName              string IL2CPP_TYPE_STRING
    // 000 kDefaultPressedAnimName                  string IL2CPP_TYPE_STRING
    // 000 kDefaultSelectedAnimName                 string IL2CPP_TYPE_STRING
    // 000 kDefaultDisabledAnimName                 string IL2CPP_TYPE_STRING
    // 010 M_NormalTrigger                          000186671910 ModelPrimitiveType string string string String
    // 018 M_HighlightedTrigger                     000186671910 ModelPrimitiveType string string string String
    // 020 M_PressedTrigger                         000186671910 ModelPrimitiveType string string string String
    // 028 M_SelectedTrigger                        000186671910 ModelPrimitiveType string string string String
    // 030 M_DisabledTrigger                        000186671910 ModelPrimitiveType string string string String
    public partial class AnimationTriggers : DataModel
    {
        public string                                   M_NormalTrigger                         { get; set; }
        public string                                   M_HighlightedTrigger                    { get; set; }
        public string                                   M_PressedTrigger                        { get; set; }
        public string                                   M_SelectedTrigger                       { get; set; }
        public string                                   M_DisabledTrigger                       { get; set; }

        public static AnimationTriggers? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AnimationTriggers() { Pointer= p0 };

            value.M_NormalTrigger                           = GetString(new IntPtr(p + 0x010)); // 024660A87E20 0x10 M_NormalTrigger             ( 000186671910 ModelPrimitiveType string string string String )
            value.M_HighlightedTrigger                      = GetString(new IntPtr(p + 0x018)); // 024660A87E40 0x18 M_HighlightedTrigger        ( 000186671910 ModelPrimitiveType string string string String )
            value.M_PressedTrigger                          = GetString(new IntPtr(p + 0x020)); // 024660A87E60 0x20 M_PressedTrigger            ( 000186671910 ModelPrimitiveType string string string String )
            value.M_SelectedTrigger                         = GetString(new IntPtr(p + 0x028)); // 024660A87E80 0x28 M_SelectedTrigger           ( 000186671910 ModelPrimitiveType string string string String )
            value.M_DisabledTrigger                         = GetString(new IntPtr(p + 0x030)); // 024660A87EA0 0x30 M_DisabledTrigger           ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
