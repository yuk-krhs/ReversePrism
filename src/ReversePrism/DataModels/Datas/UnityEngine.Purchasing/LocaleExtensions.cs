using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Labels                                   string[] IL2CPP_TYPE_SZARRAY
    // 008 GoogleLocales                            TranslationLocale[] IL2CPP_TYPE_SZARRAY
    // 010 AppleLocales                             ModelEnumListType TranslationLocale[] TranslationLocale[] List<TranslationLocale> Pointer
    // 018 LabelsWithSupportedPlatforms             ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class LocaleExtensions : DataModel
    {
        public List<TranslationLocale>?                 AppleLocales                            { get; set; }
        public List<string>?                            LabelsWithSupportedPlatforms            { get; set; }

        public static LocaleExtensions? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LocaleExtensions() { Pointer= p0 };

            value.AppleLocales                              = GetEnumList<TranslationLocale>(new IntPtr(p + 0x010)); // 0x10 AppleLocales                ( ModelEnumListType TranslationLocale[] TranslationLocale[] List<TranslationLocale> Pointer )
            value.LabelsWithSupportedPlatforms              = GetStringList(new IntPtr(p + 0x018)); // 0x18 LabelsWithSupportedPlatforms ( ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
