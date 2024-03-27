using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_countTokens                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 M_headTokens                             000186689090 ModelClassType TokenizerShortBlock TokenizerShortBlock TokenizerShortBlock Pointer
    // 020 M_lastTokens                             000186689090 ModelClassType TokenizerShortBlock TokenizerShortBlock TokenizerShortBlock Pointer
    // 028 M_currentTokens                          000186689090 ModelClassType TokenizerShortBlock TokenizerShortBlock TokenizerShortBlock Pointer
    // 030 M_indexTokens                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 M_headStrings                            000186689A60 ModelClassType TokenizerStringBlock TokenizerStringBlock TokenizerStringBlock Pointer
    // 040 M_currentStrings                         000186689A60 ModelClassType TokenizerStringBlock TokenizerStringBlock TokenizerStringBlock Pointer
    // 048 M_indexStrings                           0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class TokenizerStream
    {
        public int                                      M_countTokens                           { get; set; }
        public TokenizerShortBlock?                     M_headTokens                            { get; set; }
        public TokenizerShortBlock?                     M_lastTokens                            { get; set; }
        public TokenizerShortBlock?                     M_currentTokens                         { get; set; }
        public int                                      M_indexTokens                           { get; set; }
        public TokenizerStringBlock?                    M_headStrings                           { get; set; }
        public TokenizerStringBlock?                    M_currentStrings                        { get; set; }
        public int                                      M_indexStrings                          { get; set; }

        public static TokenizerStream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TokenizerStream();

            value.M_countTokens                             = GetInt32(new IntPtr(p + 0x010)); // 0270D6B6A800 0x10 M_countTokens               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_headTokens                              = GetObject<TokenizerShortBlock>(new IntPtr(p + 0x018), ReversePrism.DataModels.TokenizerShortBlock.FromPointer); // 0270D6B6A820 0x18 M_headTokens                ( 000186689090 ModelClassType TokenizerShortBlock TokenizerShortBlock TokenizerShortBlock Pointer )
            value.M_lastTokens                              = GetObject<TokenizerShortBlock>(new IntPtr(p + 0x020), ReversePrism.DataModels.TokenizerShortBlock.FromPointer); // 0270D6B6A840 0x20 M_lastTokens                ( 000186689090 ModelClassType TokenizerShortBlock TokenizerShortBlock TokenizerShortBlock Pointer )
            value.M_currentTokens                           = GetObject<TokenizerShortBlock>(new IntPtr(p + 0x028), ReversePrism.DataModels.TokenizerShortBlock.FromPointer); // 0270D6B6A860 0x28 M_currentTokens             ( 000186689090 ModelClassType TokenizerShortBlock TokenizerShortBlock TokenizerShortBlock Pointer )
            value.M_indexTokens                             = GetInt32(new IntPtr(p + 0x030)); // 0270D6B6A880 0x30 M_indexTokens               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_headStrings                             = GetObject<TokenizerStringBlock>(new IntPtr(p + 0x038), ReversePrism.DataModels.TokenizerStringBlock.FromPointer); // 0270D6B6A8A0 0x38 M_headStrings               ( 000186689A60 ModelClassType TokenizerStringBlock TokenizerStringBlock TokenizerStringBlock Pointer )
            value.M_currentStrings                          = GetObject<TokenizerStringBlock>(new IntPtr(p + 0x040), ReversePrism.DataModels.TokenizerStringBlock.FromPointer); // 0270D6B6A8C0 0x40 M_currentStrings            ( 000186689A60 ModelClassType TokenizerStringBlock TokenizerStringBlock TokenizerStringBlock Pointer )
            value.M_indexStrings                            = GetInt32(new IntPtr(p + 0x048)); // 0270D6B6A8E0 0x48 M_indexStrings              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
