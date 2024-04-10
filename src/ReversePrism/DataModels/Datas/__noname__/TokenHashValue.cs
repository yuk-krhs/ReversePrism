using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TokenString                              000186671BA0 ModelPrimitiveType string string string String
    // 018 TokenType                                00018668DA40 ModelEnumType TokenType TokenType TokenType Int32
    // 01C TokenValue                               0001865F2F90 ModelPrimitiveType int int int Int32
    public partial class TokenHashValue : DataModel
    {
        public string                                   TokenString                             { get; set; }
        public TokenType                                TokenType                               { get; set; }
        public int                                      TokenValue                              { get; set; }

        public static TokenHashValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TokenHashValue() { Pointer= p0 };

            value.TokenString                               = GetString(new IntPtr(p + 0x010)); // 024662FD2568 0x10 TokenString                 ( 000186671BA0 ModelPrimitiveType string string string String )
            value.TokenType                                 = (TokenType)GetInt32(new IntPtr(p + 0x018)); // 024662FD2588 0x18 TokenType                   ( 00018668DA40 ModelEnumType TokenType TokenType TokenType Int32 )
            value.TokenValue                                = GetInt32(new IntPtr(p + 0x01C)); // 024662FD25A8 0x1C TokenValue                  ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
