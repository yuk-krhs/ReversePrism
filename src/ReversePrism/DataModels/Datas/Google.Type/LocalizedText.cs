using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<LocalizedText> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 TextFieldNumber                          int IL2CPP_TYPE_I4
    // 018 Text                                     000186671910 ModelPrimitiveType string string string String
    // 000 LanguageCodeFieldNumber                  int IL2CPP_TYPE_I4
    // 020 LanguageCode                             000186671910 ModelPrimitiveType string string string String
    public partial class LocalizedText : DataModel
    {
        public string                                   Text                                    { get; set; }
        public string                                   LanguageCode                            { get; set; }

        public static LocalizedText? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LocalizedText() { Pointer= p0 };

            value.Text                                      = GetString(new IntPtr(p + 0x018)); // 02466A7026B0 0x18 Text                        ( 000186671910 ModelPrimitiveType string string string String )
            value.LanguageCode                              = GetString(new IntPtr(p + 0x020)); // 02466A7026F0 0x20 LanguageCode                ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
