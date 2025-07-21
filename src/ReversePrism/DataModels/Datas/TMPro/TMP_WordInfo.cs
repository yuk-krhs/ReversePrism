using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TextComponent                            ModelClassType TMP_Text TMP_Text TMP_Text Pointer
    // 018 FirstCharacterIndex                      ModelPrimitiveType int int int Int32
    // 01C LastCharacterIndex                       ModelPrimitiveType int int int Int32
    // 020 CharacterCount                           ModelPrimitiveType int int int Int32
    public partial class TMP_WordInfo : DataModel
    {
        public TMP_Text?                                TextComponent                           { get; set; }
        public int                                      FirstCharacterIndex                     { get; set; }
        public int                                      LastCharacterIndex                      { get; set; }
        public int                                      CharacterCount                          { get; set; }

        public static TMP_WordInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TMP_WordInfo() { Pointer= p0 };

            value.TextComponent                             = GetObject<TMP_Text>(new IntPtr(p + 0x010), ReversePrism.DataModels.TMP_Text.FromPointer); // 0x10 TextComponent               ( ModelClassType TMP_Text TMP_Text TMP_Text Pointer )
            value.FirstCharacterIndex                       = GetInt32(new IntPtr(p + 0x018)); // 0x18 FirstCharacterIndex         ( ModelPrimitiveType int int int Int32 )
            value.LastCharacterIndex                        = GetInt32(new IntPtr(p + 0x01C)); // 0x1C LastCharacterIndex          ( ModelPrimitiveType int int int Int32 )
            value.CharacterCount                            = GetInt32(new IntPtr(p + 0x020)); // 0x20 CharacterCount              ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
