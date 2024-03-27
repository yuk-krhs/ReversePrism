using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_block                                  000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 018 M_next                                   000186689D10 ModelClassType TokenizerStringBlock TokenizerStringBlock TokenizerStringBlock Pointer
    public partial class TokenizerStringBlock
    {
        public List<string>?                            M_block                                 { get; set; }
        public TokenizerStringBlock?                    M_next                                  { get; set; }

        public static TokenizerStringBlock? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TokenizerStringBlock();

            value.M_block                                   = GetStringList(new IntPtr(p + 0x010)); // 0270D6B6ACC0 0x10 M_block                     ( 000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.M_next                                    = GetObject<TokenizerStringBlock>(new IntPtr(p + 0x018), ReversePrism.DataModels.TokenizerStringBlock.FromPointer); // 0270D6B6ACE0 0x18 M_next                      ( 000186689D10 ModelClassType TokenizerStringBlock TokenizerStringBlock TokenizerStringBlock Pointer )

            return value;
        }
    }
}
