using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0E0 M_FontData                               0001865AE670 ModelClassType FontData FontData FontData Pointer
    // 0E8 M_Text                                   000186671E00 ModelPrimitiveType string string string String
    // 0F0 M_TextCache                              00018663C980 ModelClassType TextGenerator TextGenerator TextGenerator Pointer
    // 0F8 M_TextCacheForLayout                     00018663C980 ModelClassType TextGenerator TextGenerator TextGenerator Pointer
    // 000 s_DefaultText                            Material IL2CPP_TYPE_CLASS
    // 100 M_DisableFontTextureRebuiltCallback      000186597990 ModelPrimitiveType bool bool bool Bool
    // 108 M_TempVerts                              000185CAE938 ModelEnumListType UIVertex[] UIVertex[] List<UIVertex> Pointer
    public partial class Text : DataModel
    {
        public FontData?                                M_FontData                              { get; set; }
        public string                                   M_Text                                  { get; set; }
        public TextGenerator?                           M_TextCache                             { get; set; }
        public TextGenerator?                           M_TextCacheForLayout                    { get; set; }
        public bool                                     M_DisableFontTextureRebuiltCallback     { get; set; }
        public List<UIVertex>?                          M_TempVerts                             { get; set; }

        public static Text? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Text() { Pointer= p0 };

            value.M_FontData                                = GetObject<FontData>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.FontData.FromPointer); // 0245A68A37C0 0xE0 M_FontData                  ( 0001865AE670 ModelClassType FontData FontData FontData Pointer )
            value.M_Text                                    = GetString(new IntPtr(p + 0x0E8)); // 0245A68A37E0 0xE8 M_Text                      ( 000186671E00 ModelPrimitiveType string string string String )
            value.M_TextCache                               = GetObject<TextGenerator>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.TextGenerator.FromPointer); // 0245A68A3800 0xF0 M_TextCache                 ( 00018663C980 ModelClassType TextGenerator TextGenerator TextGenerator Pointer )
            value.M_TextCacheForLayout                      = GetObject<TextGenerator>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.TextGenerator.FromPointer); // 0245A68A3820 0xF8 M_TextCacheForLayout        ( 00018663C980 ModelClassType TextGenerator TextGenerator TextGenerator Pointer )
            value.M_DisableFontTextureRebuiltCallback       = GetBool(new IntPtr(p + 0x100)); // 0245A68A3860 0x100 M_DisableFontTextureRebuiltCallback ( 000186597990 ModelPrimitiveType bool bool bool Bool )
            value.M_TempVerts                               = GetEnumList<UIVertex>(new IntPtr(p + 0x108)); // 0245A68A3880 0x108 M_TempVerts                 ( 000185CAE938 ModelEnumListType UIVertex[] UIVertex[] List<UIVertex> Pointer )

            return value;
        }
    }
}
