using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 GoogleLocale                             0001866AE1F0 ModelEnumType TranslationLocale TranslationLocale TranslationLocale Int32
    // 018 Title                                    000186671910 ModelPrimitiveType string string string String
    // 020 Description                              000186671910 ModelPrimitiveType string string string String
    public partial class LocalizedProductDescription : DataModel
    {
        public TranslationLocale                        GoogleLocale                            { get; set; }
        public string                                   Title                                   { get; set; }
        public string                                   Description                             { get; set; }

        public static LocalizedProductDescription? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LocalizedProductDescription() { Pointer= p0 };

            value.GoogleLocale                              = (TranslationLocale)GetInt32(new IntPtr(p + 0x010)); // 0245A68DD230 0x10 GoogleLocale                ( 0001866AE1F0 ModelEnumType TranslationLocale TranslationLocale TranslationLocale Int32 )
            value.Title                                     = GetString(new IntPtr(p + 0x018)); // 0245A68DD250 0x18 Title                       ( 000186671910 ModelPrimitiveType string string string String )
            value.Description                               = GetString(new IntPtr(p + 0x020)); // 0245A68DD270 0x20 Description                 ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
