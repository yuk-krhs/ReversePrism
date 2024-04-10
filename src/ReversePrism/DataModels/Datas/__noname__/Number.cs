using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_posCurrencyFormats                     string[] IL2CPP_TYPE_SZARRAY
    // 008 s_negCurrencyFormats                     string[] IL2CPP_TYPE_SZARRAY
    // 010 S_posPercentFormats                      000185B81AC0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 018 S_negPercentFormats                      000185B81AC0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 020 S_negNumberFormats                       000185B81AC0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 028 S_posNumberFormat                        000186672530 ModelPrimitiveType string string string String
    public partial class Number : DataModel
    {
        public List<string>?                            S_posPercentFormats                     { get; set; }
        public List<string>?                            S_negPercentFormats                     { get; set; }
        public List<string>?                            S_negNumberFormats                      { get; set; }
        public string                                   S_posNumberFormat                       { get; set; }

        public static Number? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Number() { Pointer= p0 };

            value.S_posPercentFormats                       = GetStringList(new IntPtr(p + 0x010)); // 02466BC22AF8 0x10 S_posPercentFormats         ( 000185B81AC0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.S_negPercentFormats                       = GetStringList(new IntPtr(p + 0x018)); // 02466BC22B18 0x18 S_negPercentFormats         ( 000185B81AC0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.S_negNumberFormats                        = GetStringList(new IntPtr(p + 0x020)); // 02466BC22B38 0x20 S_negNumberFormats          ( 000185B81AC0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.S_posNumberFormat                         = GetString(new IntPtr(p + 0x028)); // 02466BC22B58 0x28 S_posNumberFormat           ( 000186672530 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
