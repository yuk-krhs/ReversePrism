using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 7D8 RubyScale                                0001866656B0 ModelPrimitiveType float float float Single
    // 7E0 RubyVerticalOffset                       000186671910 ModelPrimitiveType string string string String
    // 7E8 RubyShowType                             0001865F9D30 ModelEnumType RubyShowType RubyShowType RubyShowType Int32
    // 7EC AllVCompensationRuby                     000186594D10 ModelPrimitiveType bool bool bool Bool
    // 7F0 AllVCompensationRubyLineHeight           000186671910 ModelPrimitiveType string string string String
    // 000 RubyRegex                                Regex IL2CPP_TYPE_CLASS
    public partial class TextMeshProUguiBase
    {
        public float                                    RubyScale                               { get; set; }
        public string                                   RubyVerticalOffset                      { get; set; }
        public RubyShowType                             RubyShowType                            { get; set; }
        public bool                                     AllVCompensationRuby                    { get; set; }
        public string                                   AllVCompensationRubyLineHeight          { get; set; }

        public static TextMeshProUguiBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextMeshProUguiBase();

            value.RubyScale                                 = GetSingle(new IntPtr(p + 0x7D8)); // 0270D4EEF408 0x7D8 RubyScale                   ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.RubyVerticalOffset                        = GetString(new IntPtr(p + 0x7E0)); // 0270D4EEF428 0x7E0 RubyVerticalOffset          ( 000186671910 ModelPrimitiveType string string string String )
            value.RubyShowType                              = (RubyShowType)GetInt32(new IntPtr(p + 0x7E8)); // 0270D4EEF448 0x7E8 RubyShowType                ( 0001865F9D30 ModelEnumType RubyShowType RubyShowType RubyShowType Int32 )
            value.AllVCompensationRuby                      = GetBool(new IntPtr(p + 0x7EC)); // 0270D4EEF468 0x7EC AllVCompensationRuby        ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.AllVCompensationRubyLineHeight            = GetString(new IntPtr(p + 0x7F0)); // 0270D4EEF488 0x7F0 AllVCompensationRubyLineHeight ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
