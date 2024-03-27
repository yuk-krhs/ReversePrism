using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_Instance                               UnicodeLineBreakingRules IL2CPP_TYPE_CLASS
    // 010 M_UnicodeLineBreakingRules               000186634CA0 ModelClassType TextAsset TextAsset TextAsset Pointer
    // 018 M_LeadingCharacters                      000186634CA0 ModelClassType TextAsset TextAsset TextAsset Pointer
    // 020 M_FollowingCharacters                    000186634CA0 ModelClassType TextAsset TextAsset TextAsset Pointer
    // 028 M_UseModernHangulLineBreakingRules       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 008 s_LeadingCharactersLookup                HashSet`1<uint> IL2CPP_TYPE_GENERICINST
    // 010 s_FollowingCharactersLookup              HashSet`1<uint> IL2CPP_TYPE_GENERICINST
    public partial class UnicodeLineBreakingRules
    {
        public TextAsset?                               M_UnicodeLineBreakingRules              { get; set; }
        public TextAsset?                               M_LeadingCharacters                     { get; set; }
        public TextAsset?                               M_FollowingCharacters                   { get; set; }
        public bool                                     M_UseModernHangulLineBreakingRules      { get; set; }

        public static UnicodeLineBreakingRules? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UnicodeLineBreakingRules();

            value.M_UnicodeLineBreakingRules                = GetObject<TextAsset>(new IntPtr(p + 0x010), ReversePrism.DataModels.TextAsset.FromPointer); // 0270068FC6F8 0x10 M_UnicodeLineBreakingRules  ( 000186634CA0 ModelClassType TextAsset TextAsset TextAsset Pointer )
            value.M_LeadingCharacters                       = GetObject<TextAsset>(new IntPtr(p + 0x018), ReversePrism.DataModels.TextAsset.FromPointer); // 0270068FC718 0x18 M_LeadingCharacters         ( 000186634CA0 ModelClassType TextAsset TextAsset TextAsset Pointer )
            value.M_FollowingCharacters                     = GetObject<TextAsset>(new IntPtr(p + 0x020), ReversePrism.DataModels.TextAsset.FromPointer); // 0270068FC738 0x20 M_FollowingCharacters       ( 000186634CA0 ModelClassType TextAsset TextAsset TextAsset Pointer )
            value.M_UseModernHangulLineBreakingRules        = GetBool(new IntPtr(p + 0x028)); // 0270068FC758 0x28 M_UseModernHangulLineBreakingRules ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
