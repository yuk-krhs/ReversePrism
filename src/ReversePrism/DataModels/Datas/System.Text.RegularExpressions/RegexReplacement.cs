using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Specials                                 int IL2CPP_TYPE_I4
    // 000 LeftPortion                              int IL2CPP_TYPE_I4
    // 000 RightPortion                             int IL2CPP_TYPE_I4
    // 000 LastGroup                                int IL2CPP_TYPE_I4
    // 000 WholeString                              int IL2CPP_TYPE_I4
    // 010 Strings                                  000185D0D798 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 018 Rules                                    000185CED1B8 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 020 Pattern                                  000186672F10 ModelPrimitiveType string string string String
    public partial class RegexReplacement : DataModel
    {
        public List<string>?                            Strings                                 { get; set; }
        public List<int>?                               Rules                                   { get; set; }
        public string                                   Pattern                                 { get; set; }

        public static RegexReplacement? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RegexReplacement() { Pointer= p0 };

            value.Strings                                   = GetStringList(new IntPtr(p + 0x010)); // 0245A34948F0 0x10 Strings                     ( 000185D0D798 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.Rules                                     = GetInt32List(new IntPtr(p + 0x018)); // 0245A3494910 0x18 Rules                       ( 000185CED1B8 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.Pattern                                   = GetString(new IntPtr(p + 0x020)); // 0245A3494930 0x20 Pattern                     ( 000186672F10 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
