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
    public partial class LocalizedProductDescription
    {
        public TranslationLocale                        GoogleLocale                            { get; set; }
        public string                                   Title                                   { get; set; }
        public string                                   Description                             { get; set; }

        public static LocalizedProductDescription? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LocalizedProductDescription();

            value.GoogleLocale                              = (TranslationLocale)GetInt32(new IntPtr(p + 0x010)); // 02700691A368 0x10 GoogleLocale                ( 0001866AE1F0 ModelEnumType TranslationLocale TranslationLocale TranslationLocale Int32 )
            value.Title                                     = GetString(new IntPtr(p + 0x018)); // 02700691A388 0x18 Title                       ( 000186671910 ModelPrimitiveType string string string String )
            value.Description                               = GetString(new IntPtr(p + 0x020)); // 02700691A3A8 0x20 Description                 ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
