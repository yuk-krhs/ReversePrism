using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_UnicodeLineBreakingRules               ModelClassType TextAsset TextAsset TextAsset Pointer
    // 018 M_LeadingCharacters                      ModelClassType TextAsset TextAsset TextAsset Pointer
    // 020 M_FollowingCharacters                    ModelClassType TextAsset TextAsset TextAsset Pointer
    // 028 M_UseModernHangulLineBreakingRules       ModelPrimitiveType bool bool bool Bool
    // 030 m_LeadingCharactersLookup                HashSet`1<uint> IL2CPP_TYPE_GENERICINST
    // 038 m_FollowingCharactersLookup              HashSet`1<uint> IL2CPP_TYPE_GENERICINST
    public partial class UnicodeLineBreakingRules : DataModel
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
            var value   = new UnicodeLineBreakingRules() { Pointer= p0 };

            value.M_UnicodeLineBreakingRules                = GetObject<TextAsset>(new IntPtr(p + 0x010), ReversePrism.DataModels.TextAsset.FromPointer); // 0x10 M_UnicodeLineBreakingRules  ( ModelClassType TextAsset TextAsset TextAsset Pointer )
            value.M_LeadingCharacters                       = GetObject<TextAsset>(new IntPtr(p + 0x018), ReversePrism.DataModels.TextAsset.FromPointer); // 0x18 M_LeadingCharacters         ( ModelClassType TextAsset TextAsset TextAsset Pointer )
            value.M_FollowingCharacters                     = GetObject<TextAsset>(new IntPtr(p + 0x020), ReversePrism.DataModels.TextAsset.FromPointer); // 0x20 M_FollowingCharacters       ( ModelClassType TextAsset TextAsset TextAsset Pointer )
            value.M_UseModernHangulLineBreakingRules        = GetBool(new IntPtr(p + 0x028)); // 0x28 M_UseModernHangulLineBreakingRules ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
