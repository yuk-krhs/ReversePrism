using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_block                                  000185B8D710 ModelPrimitiveListType short[] short[] List<short> Pointer
    // 018 M_next                                   0001866893C0 ModelClassType TokenizerShortBlock TokenizerShortBlock TokenizerShortBlock Pointer
    public partial class TokenizerShortBlock
    {
        public List<short>?                             M_block                                 { get; set; }
        public TokenizerShortBlock?                     M_next                                  { get; set; }

        public static TokenizerShortBlock? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TokenizerShortBlock();

            value.M_block                                   = GetInt16List(new IntPtr(p + 0x010)); // 0270D6B6AC20 0x10 M_block                     ( 000185B8D710 ModelPrimitiveListType short[] short[] List<short> Pointer )
            value.M_next                                    = GetObject<TokenizerShortBlock>(new IntPtr(p + 0x018), ReversePrism.DataModels.TokenizerShortBlock.FromPointer); // 0270D6B6AC40 0x18 M_next                      ( 0001866893C0 ModelClassType TokenizerShortBlock TokenizerShortBlock TokenizerShortBlock Pointer )

            return value;
        }
    }
}
